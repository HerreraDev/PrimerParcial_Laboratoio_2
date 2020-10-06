using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComercio
{
    public partial class FormCompra : Form
    {
        float precioFinal;
        List<Producto> listAuxProductos;
        string auxDireccionSinido = System.AppDomain.CurrentDomain.BaseDirectory + "hahaNelson.wav";
        List<Carrito> carritoAux;


        public FormCompra()
        {
            InitializeComponent();
            listAuxProductos = new List<Producto>();
            precioFinal = 0;
            carritoAux = new List<Carrito>();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {


            //creo auxiliares para validar el dni del cliente y el id del empleado
            int dniClienteAux = Validaciones.Enteros(this.txtDniCliente.Text);
            int idEmpleadoAux = Validaciones.Enteros(this.txtIdVendedor.Text);

            //genero un empleado y un cliente vacios
            Cliente auxCliente = new Cliente(-1, "", "", dniClienteAux);
            Empleado auxEmpleado = new Empleado(idEmpleadoAux, "", "", "");

            //mando el cliente por referencia y espero que me lo cargue con los datos correctos si existe
            Stock.buscarYCargarCliente(ref auxCliente);

            //mando el empleado por referencia y espero que me lo cargue con los datos correctos si existe
            Stock.buscarYCargarEmpleado(ref auxEmpleado);


            if (dniClienteAux > 0 && idEmpleadoAux > 0 && listAuxProductos.Count > 0)
            {
                if (!(auxEmpleado is null) && !(auxCliente is null))
                {
                    if (Stock.EsFamiliaSimpson(auxCliente))
                    {
                        MessageBox.Show("¡¡Como el cliente es de la familia Simpson recibe un 13% de descuento!!");
                        //aplico descuento Simpson
                        precioFinal -= (precioFinal * 0.13f);

                        //creo la compra
                        Stock.ListaCompras.Add(new Compra(auxEmpleado, auxCliente, listAuxProductos, precioFinal));

                        //sonido de compra
                        ReproducirSonido();


                        //genero un ticket
                        GenerarTicket();

                        MessageBox.Show("¡Se ha generado un ticket.txt, alojado en la carpeta del proyecto!");

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        //aca entra si no es Simpson
                        Stock.ListaCompras.Add(new Compra(auxEmpleado, auxCliente, listAuxProductos, precioFinal));

                        //sonido de compra
                        ReproducirSonido();

                        //genero un ticket
                        GenerarTicket();

                        MessageBox.Show("Se ha generado un ticket.txt, alojado en la carpeta del proyecto");

                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, el empleado no existe o el cliente no existe.");
                }

            }
            else
            {
                MessageBox.Show("Debe elegir un empleado y un cliente para continuar." + Environment.NewLine +
                    "Y recuerde que no puede no comprar nada.");
            }
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            Stock.CargarListadoPersonas();
            this.dtgClientes.DataSource = Stock.ListadoFiltradoPorClientes();
            this.dtgEmpleados.DataSource = Stock.ListadoFiltradoPorEmpleados();
            this.dtgProductos.DataSource = Stock.ListaProductos;
        }

        private void dtgProductos_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdProducto.Text = dtgProductos.CurrentRow.Cells["IdProducto"].Value.ToString();
        }

        private void btnAñadirCarro_Click(object sender, EventArgs e)
        {
            int auxValidarCantidad = Validaciones.Negativos(this.txtCantidad.Text);
            int auxValidarId = Validaciones.Negativos(this.txtIdProducto.Text);

            //genero un producto auxiliar vacio
            Producto auxProducto = new Producto(0, "", 0, 0);

            //mando por referencia el producto auxiliar y espero que me traiga el 
            //producto con toda su informacion.
            Stock.LoadProductoPorId(auxValidarId, ref auxProducto);

            if (auxValidarId < 1)
            {
                MessageBox.Show("Error, el id del producto debe ser correcto y existir en la lista de productos desplegada a la derecha de la pantalla");
            }
            else
            {
                if (auxProducto is null)
                {
                    MessageBox.Show("Error, ese producto no existe");
                }
                else
                {
                    if (auxValidarCantidad < 1)
                    {
                        MessageBox.Show("Letras, numero negativos o ceros no son validos en la cantidad. Reingrese la cantidad");
                        this.txtCantidad.Text = string.Empty;
                    }
                    else
                    {
                        if (auxProducto.Cantidad >= auxValidarCantidad)
                        {
                            //cargo el producto a la lista para hacer las cuentas
                            listAuxProductos.Add(auxProducto);

                            //se lo mando por referencia al carrito
                            AgregarCarrito(ref auxProducto, ref auxValidarCantidad);

                            //voy calculando el precio final
                            precioFinal += auxProducto.Precio * auxValidarCantidad;

                            //voy actualizando el precio
                            lblTotal.Text = precioFinal.ToString();
                            MessageBox.Show("Agregado al carrito");


                            //le saco la cantidad al producto
                            auxProducto.Cantidad -= auxValidarCantidad;
                            //lo vuelvo a agregar con la funcion agregar que lo va a reemplazar en la lista porque ya existe dicho producto
                            Stock.AgregarProducto(auxProducto.IdProducto, auxProducto.NombreProducto, auxProducto.Precio, auxProducto.Cantidad);

                            //actualizo lista productos
                            ActualizarDtgProductos();


                            //vacio los txt
                            this.txtCantidad.Text = string.Empty;
                            this.txtIdProducto.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Error, la cantidad de productos elegida debe ser menos a la cantidad de productos en el stock");
                        }

                    }
                }

            }

        }

        private void dtgEmpleados_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdVendedor.Text = dtgEmpleados.CurrentRow.Cells["Id"].Value.ToString();

            Empleado auxEmpleado = new Empleado((int)dtgEmpleados.CurrentRow.Cells["Id"].Value, "", "", "");

            Stock.buscarYCargarEmpleado(ref auxEmpleado);

            if (!(auxEmpleado is null))
            {
                MessageBox.Show(auxEmpleado.Saludar());
            }



        }

        private void dtgClientes_DoubleClick(object sender, EventArgs e)
        {
            this.txtDniCliente.Text = dtgClientes.CurrentRow.Cells["Dni"].Value.ToString();


            Cliente auxCliente = new Cliente(-1, "", "", (int)dtgClientes.CurrentRow.Cells["Dni"].Value);

            Stock.buscarYCargarCliente(ref auxCliente);

            if (!(auxCliente is null))
            {
                MessageBox.Show(auxCliente.Saludar());
            }
        }

        /// <summary>
        /// Actualiza el datagridview carrito
        /// </summary>
        private void ActualizarCarrito()
        {
            this.dtgCarrito.DataSource = null;
            if (carritoAux.Count > 0)
            {
                this.dtgCarrito.DataSource = carritoAux;
            }
        }

        private void ActualizarDtgProductos()
        {
            this.dtgProductos.DataSource = null;
            this.dtgProductos.DataSource = Stock.ListaProductos;
        }

        private void ActualizarDtgClientes()
        {
            this.dtgClientes.DataSource = null;
            this.dtgClientes.DataSource = Stock.ListadoFiltradoPorClientes();
        }

        private void ReproducirSonido()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(auxDireccionSinido);
            player.Play();
        }

        private void GenerarTicket()
        {
            //string directorioDebug = Directory.GetCurrentDirectory();
            //string directorioBin = Directory.GetParent(directorioDebug).Parent.FullName;
            //string directirioDelProjecto = Directory.GetParent(directorioDebug).Parent.Parent.FullName;

            string aux = DateTime.Now.ToLongDateString() + " " + "Horario= " + DateTime.Now.ToString("hh, mm, ss") + ".txt";
            string fileName = aux;

            FileStream ticket = new FileStream(fileName, FileMode.OpenOrCreate);

            using (StreamWriter writer = new StreamWriter(ticket, Encoding.UTF8))
            {
                writer.WriteLine(Stock.ListaCompras[Stock.ListaCompras.Count - 1].ToString());
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="auxProducto"></param>
        /// <param name="cantidad"></param>
        private void AgregarCarrito(ref Producto auxProducto, ref int cantidad)
        {
            carritoAux.Add(new Carrito(auxProducto, cantidad));
            ActualizarCarrito();
        }



        private void comoComprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para realizar la compra debera seleccionar con doble click el empleado y el cliente que deasea." + Environment.NewLine +
                "Lo mismo con el producto, luego seleccione la cantidad y agregla al carrito" + Environment.NewLine +
                "Por ultimo seleccione comprar y listo." + Environment.NewLine +
                "Para eliminar un producto toque doble click en el elemento del carrito que desea eliminar");
        }

        private void dtgCarrito_DoubleClick(object sender, EventArgs e)
        {
            if (carritoAux.Count > 0)
            {


                string nombreProducto = "";
                nombreProducto = (string)dtgCarrito.CurrentRow.Cells["Producto"].Value.ToString();

                Producto auxProducto = new Producto(-1, nombreProducto, -1, 1);

                int indiceDelProductoEnLaListaDelStock = (auxProducto == Stock.ListaProductos);

                //recorro y elimino del carrito el producto, resto del precio, el precio del producto eliminado y 
                //devuelvo la cantidad al stock original
                for (int i = 0; i < carritoAux.Count; i++)
                {
                    if (carritoAux[i].Producto == nombreProducto)
                    {
                        precioFinal -= carritoAux[i].Precio * carritoAux[i].Cantidad;
                        Stock.ListaProductos[indiceDelProductoEnLaListaDelStock].Cantidad += carritoAux[i].Cantidad;
                        carritoAux.Remove(carritoAux[i]);
                        break;
                    }
                }
                this.lblTotal.Text = Validaciones.AyudaPrecioFinal(precioFinal.ToString()).ToString();
                ActualizarCarrito();

                //elimino el producto que se fue del carrito de la lista que se va a cargar en la nueva compra
                for (int i = 0; i < listAuxProductos.Count; i++)
                {
                    if (listAuxProductos[i].NombreProducto == nombreProducto)
                    {
                        listAuxProductos.Remove(listAuxProductos[i]);
                        break;
                    }
                }
                ActualizarDtgProductos();
            }
            else
            {
                MessageBox.Show("Esta vacio");
            }

        }

        private void agregarClienteNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarCliente formAgregarCliente = new FormAgregarCliente();

            if (formAgregarCliente.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("¡Nuevo cliente registrado con exito!");
                ActualizarDtgClientes();
            }
            else
            {
                MessageBox.Show("Registro cancelado");
            }

        }

        private void dtgCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
