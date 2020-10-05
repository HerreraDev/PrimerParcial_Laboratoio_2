using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        Empleado empleado;
        Cliente cliente;
        List<Producto> productosElegidos;
        float precioFinal;

        #region Constructores
        /// <summary>
        /// Constructor sin parametros, siempre que se genere una compra, se va a tener una lista de productos.
        /// </summary>
        private Compra()
        {
            productosElegidos = new List<Producto>();
        }

        /// <summary>
        /// Constructor de la compra que va a llamar al constructor por defecto
        /// </summary>
        /// <param name="empleado"></param>
        /// <param name="cliente"></param>
        /// <param name="productosElegidos"></param>
        /// <param name="precioFinal"></param>
        public Compra(Empleado empleado, Cliente cliente, List<Producto> productosElegidos, float precioFinal) : this()
        {
            this.empleado = empleado;
            this.cliente = cliente;
            this.productosElegidos = productosElegidos;
            this.precioFinal = precioFinal;
        }
        #endregion

        #region Propiedades
        public string Empleado
        {
            get { return NombreYApellidoClienteYEmpleado(this.empleado.Nombre, this.empleado.Apellido); }
        }
        public string Cliente
        {
            get { return NombreYApellidoClienteYEmpleado(this.cliente.Nombre,this.cliente.Apellido); }
        }
        public string ProductosElegidos
        {
            get { return NombresProductos(this.productosElegidos); }
        }
        public string PrecioFinal
        {
            get { return Precio(this.precioFinal); }
        }
        #endregion

        /// <summary>
        /// Metodo que paramatriza el como se va a mostar el producto elegido y el precio de la lista de productos que elegio el comprador
        /// </summary>
        /// <param name="auxLista"></param>
        /// <returns></returns>
        public string NombresProductos(List<Producto> auxLista)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < auxLista.Count; i++)
            {
                //               Nombre:Precio, Nombre:Precio
                sb.AppendFormat("{0}: ${1}", auxLista[i].NombreProducto,auxLista[i].Precio);
                sb.Append(", ");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Metodo para mostrar el precio con un buen formato
        /// </summary>
        /// <param name="precioAux"></param>
        /// <returns></returns>
        public static string Precio(float precioAux)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("${0:0.##}", precioAux);
            return sb.ToString();
        }

        /// <summary>
        /// Genera un StringBuilder poniendo nombre, apellido del cliente o del empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <returns></returns>
        public string NombreYApellidoClienteYEmpleado(string nombre, string apellido)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}, {1}", nombre, apellido);

            return sb.ToString();

        }

        /// <summary>
        /// Override del ToString() utilizado para generar el ticket de compra
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("===========================");
            sb.AppendLine("DATOS DEL CLIENTE: ");
            sb.AppendLine(this.cliente.ToString());
            sb.AppendLine("===========================");
            sb.AppendLine("DATOS DEL EMPLEADO: ");
            sb.AppendLine(this.empleado.ToString());
            sb.AppendLine("===========================");
            sb.AppendLine("PRODUCTOS: ");
            sb.AppendLine(this.ProductosElegidos);
            sb.AppendLine("===========================");
            sb.AppendLine("TOTAL:    " + this.PrecioFinal);
            sb.AppendLine("===========================");

            return sb.ToString();

        }


    }

    
}
