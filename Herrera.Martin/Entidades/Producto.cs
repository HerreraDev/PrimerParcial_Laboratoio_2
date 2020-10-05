using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        int idProducto;
        string nombreProducto;
        float precio;
        int cantidad;

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Producto()
        {
            this.idProducto = -1;
            this.nombreProducto = "Sin asignar";
            this.precio = -1;
            this.cantidad = -1;
        }

        /// <summary>
        /// Constructor que llama al por defecto
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="nombreProducto"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public Producto(int idProducto, string nombreProducto, float precio, int cantidad):this()
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        #endregion

        #region Propiedades
        public int IdProducto
        {
            get { return this.idProducto; }
        }
        public string NombreProducto
        {
            get { return this.nombreProducto; }
        }
        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }

        }
        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }

        }
        #endregion


        /// <summary>
        /// Sobrecarga del ==
        /// </summary>
        /// <param name="prodcuto"></param>
        /// <param name="listaAux"></param>
        /// <returns>devuelve el indice del producto en la lista o -1 si no lo encontro</returns>
        public static int operator ==(Producto prodcuto, List<Producto> listaAux)
        {
            int indice = -1;
            for (int i = 0; i < listaAux.Count; i++)
            {
                if (prodcuto.NombreProducto == listaAux[i].NombreProducto)
                {
                     indice = i;
                     break;
                }
            }

            return indice;
        }

        /// <summary>
        /// Sobrecarga del !=
        /// </summary>
        /// <param name="prodcuto"></param>
        /// <param name="listaAux"></param>
        /// <returns>Si el == devuelve -1, este devuelve -1 O el indice que devolvio el ==</returns>
        public static int operator !=(Producto prodcuto, List<Producto> listaAux)
        {
            if ((prodcuto == listaAux) == -1)
            {
                return -1;
            }
            else
            {
                return (prodcuto == listaAux);
            }
        }


    }
}
