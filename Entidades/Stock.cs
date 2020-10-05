using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Stock
    {
        static List<Producto> listaProductos;
        static List<Producto> listaProductosMenorA10Unidades;
        static List<Persona> personasDeLaTienda;
        static List<Compra> listaCompras;

        /// <summary>
        /// Constructor estatico
        /// </summary>
        static Stock()
        {
            listaProductos = new List<Producto>();
            listaProductosMenorA10Unidades = new List<Producto>();
            personasDeLaTienda = new List<Persona>();
            listaCompras = new List<Compra>();
        }

        #region Propiedades
        public static List<Producto> ListaProductos 
        { 
            get { return listaProductos; }
            set { listaProductos = value; }
        }

        public static List<Producto> ListaProductosMenorA10Unidades
        {
            get { return listaProductosMenorA10Unidades; }
            set { listaProductosMenorA10Unidades = value; }
        }
        public static List<Persona> PersonasDeLaTienda
        {
            get { return personasDeLaTienda; }
            set { personasDeLaTienda = value; }
        }
        public static List<Compra> ListaCompras
        {
            get { return listaCompras; }
            set { listaCompras = value; }
        }
        #endregion

        #region Metodos De Hardcodeo
        /// <summary>
        /// 
        /// </summary>
        public static void CargarListaProductos()
        {
            if(listaProductos.Count == 0)
            {
                ListaProductos.Add(new Producto(1, "Galletita", 160, 20));
                ListaProductos.Add(new Producto(2, "Pan", 60.2f, 22));
                ListaProductos.Add(new Producto(3, "Azucar", 20.4f, 62));
                ListaProductos.Add(new Producto(4, "Agua", 100, 71));
                ListaProductos.Add(new Producto(5, "Rosquillas", 10, 20));
                ListaProductos.Add(new Producto(6, "Helado", 260.2f, 120));
                ListaProductos.Add(new Producto(7, "Chicle", 14, 38));
                ListaProductos.Add(new Producto(8, "Caramelo", 6, 22));
                ListaProductos.Add(new Producto(9, "Queso", 21, 23));
                ListaProductos.Add(new Producto(10, "Aceite", 44.2f, 22));
                ListaProductos.Add(new Producto(11, "Sal", 62.4f, 16));
                ListaProductos.Add(new Producto(12, "Manguito", 1260, 71));
                ListaProductos.Add(new Producto(13, "Fernet", 6, 25));
                ListaProductos.Add(new Producto(14, "Coca-Cola", 262, 64));
                ListaProductos.Add(new Producto(15, "Sprite", 202, 71));

                ListaProductos.Add(new Producto(16, "Coca-Zero", 223, 8));
                ListaProductos.Add(new Producto(17, "Fanta", 424.2f, 12));
                ListaProductos.Add(new Producto(18, "Limones", 20.4f, 7));
                ListaProductos.Add(new Producto(19, "Raspados", 123, 13));
                ListaProductos.Add(new Producto(20, "Tomate", 42, 6));
                ListaProductos.Add(new Producto(21, "Lechuga", 63.2f, 15));
                ListaProductos.Add(new Producto(22, "Papa", 73, 38));
                ListaProductos.Add(new Producto(23, "Jugo de Naranja", 62, 1));
                ListaProductos.Add(new Producto(24, "Queso mdp", 23, 8));
                ListaProductos.Add(new Producto(25, "Pinceles", 21.2f, 4));
                ListaProductos.Add(new Producto(26, "Sal marina", 17.4f, 2));
                ListaProductos.Add(new Producto(27, "Frutilla", 321, 1));
                ListaProductos.Add(new Producto(28, "Uva", 51, 110));
                ListaProductos.Add(new Producto(29, "Pera", 61, 20));
                ListaProductos.Add(new Producto(30, "Naranju", 72, 9));
            }
            

        }
        public static void CargarListadoPersonas()
        {
            if (personasDeLaTienda.Count == 0)
            {
                personasDeLaTienda.Add(new Empleado(1,"Apu", "Nahasapeemapetilon ", "India"));
                personasDeLaTienda.Add(new Empleado(2,"Sanjay", "Nahasapeemapetilon ", "India"));
                personasDeLaTienda.Add(new Cliente(1,"Homero", "Simpson", 54134249));
                personasDeLaTienda.Add(new Cliente(2,"Marge", "Simpson", 12548484));
                personasDeLaTienda.Add(new Cliente(3, "Barney", "Gomez", 34234234));
                personasDeLaTienda.Add(new Cliente(4, "Bart", "Simpson", 54134246));
                personasDeLaTienda.Add(new Cliente(5, "Lisa", "Simpson", 12548484));
                personasDeLaTienda.Add(new Cliente(6, "Montgomery", "Burns", 44135345));
                personasDeLaTienda.Add(new Cliente(7, "Bob", "Sideshow", 45179448));
                personasDeLaTienda.Add(new Cliente(8, "Ned", "Flanders", 15477789));
                personasDeLaTienda.Add(new Cliente(9, "Waylon", "Smithers", 14795129));
                personasDeLaTienda.Add(new Cliente(10, "Seymour", "Skinner", 14795129));

            }

        }

        public static void CargarListadoCompras()
        {
            CargarListadoPersonas();
            CargarListaProductos();

            List<Empleado> auxEmpleadosCompras = new List<Empleado>();
            List<Cliente> auxClientesCompras = new List<Cliente>();

            List<Producto> auxListadoCompra = new List<Producto>();

            auxEmpleadosCompras = ListadoFiltradoPorEmpleados();
            auxClientesCompras = ListadoFiltradoPorClientes();


            auxListadoCompra.Add(listaProductos[0]);
            auxListadoCompra.Add(listaProductos[1]);
            auxListadoCompra.Add(listaProductos[4]);
            auxListadoCompra.Add(listaProductos[6]);



            listaCompras.Add(new Compra(auxEmpleadosCompras[0], auxClientesCompras[0], auxListadoCompra, 1000));
            listaCompras.Add(new Compra(auxEmpleadosCompras[1], auxClientesCompras[1], auxListadoCompra, 2222));
            listaCompras.Add(new Compra(auxEmpleadosCompras[0], auxClientesCompras[2], auxListadoCompra, 3434));
            listaCompras.Add(new Compra(auxEmpleadosCompras[1], auxClientesCompras[3], auxListadoCompra, 3445));
            listaCompras.Add(new Compra(auxEmpleadosCompras[1], auxClientesCompras[8], auxListadoCompra, 3445));

            listaCompras.Add(new Compra(auxEmpleadosCompras[0], auxClientesCompras[2], auxListadoCompra, 8498));
            listaCompras.Add(new Compra(auxEmpleadosCompras[0], auxClientesCompras[6], auxListadoCompra, 4568));
            listaCompras.Add(new Compra(auxEmpleadosCompras[1], auxClientesCompras[8], auxListadoCompra, 4789));
            listaCompras.Add(new Compra(auxEmpleadosCompras[0], auxClientesCompras[1], auxListadoCompra, 4512));
            listaCompras.Add(new Compra(auxEmpleadosCompras[1], auxClientesCompras[7], auxListadoCompra, 1579));

            listaCompras.Add(new Compra(auxEmpleadosCompras[0], auxClientesCompras[2], auxListadoCompra, 8498));
            listaCompras.Add(new Compra(auxEmpleadosCompras[0], auxClientesCompras[6], auxListadoCompra, 4568));
            listaCompras.Add(new Compra(auxEmpleadosCompras[1], auxClientesCompras[8], auxListadoCompra, 4789));
            listaCompras.Add(new Compra(auxEmpleadosCompras[0], auxClientesCompras[1], auxListadoCompra, 4512));
            listaCompras.Add(new Compra(auxEmpleadosCompras[1], auxClientesCompras[7], auxListadoCompra, 1579));

        }

        #endregion


        #region Metodos relacionados a los productos

        /// <summary>
        /// Agrega un producto a la lista de productos validando sus datos.
        /// Si el producto ya existe sobreescribe la cantidad y el precio del mismo
        /// Si no existe lo agrega
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public static bool AgregarProducto(int id, string nombre, float precio, int cantidad)
        {
            bool exito = true;
            int auxIndice = 0;
            Producto productoAux = new Producto(id, nombre, precio, cantidad);

            auxIndice = (productoAux == Stock.ListaProductos);
            if (auxIndice != -1)
            {
                Stock.ListaProductos[auxIndice].Cantidad = cantidad;
                Stock.ListaProductos[auxIndice].Precio = precio;

                exito = false;
            }
            else
            {
                Stock.ListaProductos.Add(productoAux);
                exito = true;
            }
            return exito;
        }

        /// <summary>
        /// Deja en 0 lacantidad del producto a eliminar
        /// </summary>
        /// <param name="index"></param>
        public static void EliminarProducto(int index)
        {
            Stock.ListaProductos[index].Cantidad = 0;

        }

        /// <summary>
        /// Busca el producto por id y devuelve el indice
        /// </summary>
        /// <param name="idAux"></param>
        /// <returns>-1 si no existe el producto o el indice del producto</returns>
        public static int BuscarProductoPorID(int idAux)
        {
            int auxIndex = -1;
            for (int i = 0; i < Stock.ListaProductos.Count; i++)
            {
                if (idAux == Stock.ListaProductos[i].IdProducto)
                {
                    return auxIndex = i;
                }
            }
            return auxIndex;
        }

        /// <summary>
        /// Hace un recuento del total del stock que se suman entre los productos
        /// </summary>
        /// <returns></returns>
        public static int ObtenerCantidadTotalStock()
        {
            int total = 0;
            for (int i = 0; i < listaProductos.Count; i++)
            {
                total += listaProductos[i].Cantidad;
            }
            return total;
        }


        /// <summary>
        /// Genera una lista con los productos que tengan menos de 10 de cantidad
        /// </summary>
        /// <returns></returns>
        public static bool GenerarListadoPocoStock()
        {
            bool exito = false;
            listaProductosMenorA10Unidades.Clear();
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].Cantidad < 10)
                {
                    listaProductosMenorA10Unidades.Add(listaProductos[i]);
                    exito = true;
                }
            }
            return exito;
        }


        /// <summary>
        /// Le llega un id  y un objeto tipo producto
        /// va a buscar en la lista de productos cual tiene el ID que le llega por parametro
        /// Si lo encuentra lo carga sino lo pone en null
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="producto"></param>
        public static void LoadProductoPorId(int idProducto, ref Producto producto)
        {
            for (int i = 0; i < Stock.ListaProductos.Count; i++)
            {
                if (Stock.ListaProductos[i].IdProducto == idProducto)
                {
                    producto = Stock.ListaProductos[i];
                    break;
                }
                else
                {
                    producto = null;
                }
            }
        }

        /// <summary>
        /// Obtiene la ultima ID del listado de productos
        /// </summary>
        /// <returns></returns>
        public static int ObtenerUltimaIdListaProductos()
        {
            int auxLargo = listaProductos.Count - 1;
            int auxIndice = -1;

            if (auxLargo == -1)
            {
                auxIndice = 0;
            }
            else
            {
                auxIndice = listaProductos[auxLargo].IdProducto;

            }
            return auxIndice;
        }
        #endregion


        #region Metodos relacionados a los clientes/empleados
        /// <summary>
        /// Le llega un DNI y un objeto tipo Cliente
        /// Genera una lista de filtrada por clientes a partir de la lista de personas
        /// Y usa la sobrecarga del == de cliente para saber si existe
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="auxPersona"></param>
        public static void buscarYCargarCliente(ref Cliente auxCliente)
        {
            List<Cliente> auxList = new List<Cliente>();
            auxList = Stock.ListadoFiltradoPorClientes();
            int indice = (auxCliente == auxList);

            if(indice < 0)
            {
                auxCliente = null;
            }
            else
            {
                auxCliente = auxList[indice];
            }
        }

        /// <summary>
        /// Le llega un DNI y un objeto tipo Empleado
        /// Genera una lista de filtrada por empleados a partir de la lista de personas
        /// Y carga al Empleado que le llega por parametro con los datos del que esta en la lista y coincide el ID
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="auxPersona"></param>
        public static void buscarYCargarEmpleado(ref Empleado auxEmpleado)
        {
            List<Empleado> auxList = new List<Empleado>();
            auxList = Stock.ListadoFiltradoPorEmpleados();
            int indice = (auxEmpleado == auxList);

            if (indice < 0)
            {
                auxEmpleado = null;
            }
            else
            {
                auxEmpleado = auxList[indice];
            }

        }

        public static bool EsFamiliaSimpson(Cliente auxCliente)
        {
            bool exito = false;
            if(auxCliente.Nombre == "Homero" || auxCliente.Nombre == "Marge" || auxCliente.Nombre == "Lisa" 
                || auxCliente.Nombre == "Bart" || auxCliente.Nombre == "Maggie")
            {
                if (auxCliente.Apellido == "Simpson")
                {
                    exito = true;
                }
            }
            return exito;
        }


        /// <summary>
        /// Metodo para filtrar la lista de empleados por Empleados
        /// </summary>
        /// <returns>lista con Empleados</returns>
        public static List<Empleado> ListadoFiltradoPorEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            foreach (Persona auxPersona in personasDeLaTienda)
            {
                if (auxPersona is Empleado)
                {
                    empleados.Add((Empleado)auxPersona);
                }
            }
            return empleados;
        }

        /// <summary>
        /// Metodo para filtrar la lista de empleados por Clientes
        /// </summary>
        /// <returns>lista con Clientes</returns>
        public static List<Cliente> ListadoFiltradoPorClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            foreach (Persona auxPersona in personasDeLaTienda)
            {
                if (auxPersona is Cliente)
                {
                    clientes.Add((Cliente)auxPersona);
                }
            }
            return clientes;
        }

        /// <summary>
        /// Devuelve el ulitmo id de la lista de clientes
        /// </summary>
        /// <returns>int 0 si no hay nada en la lista O el id</returns>
        public static int ObtenerUltimaIdListaClientes()
        {
            List<Cliente> auxLista = Stock.ListadoFiltradoPorClientes();

            int auxLargo = auxLista.Count - 1;
            int auxIndice = -1;

            if (auxLargo == -1)
            {
                auxIndice = 0;
            }
            else
            {
                auxIndice = auxLista[auxLargo].Id;

            }
            return auxIndice;
        }
        #endregion  










    }
}
