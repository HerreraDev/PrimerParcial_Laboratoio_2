using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        Producto producto;
        int cantidad;

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        public Carrito(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Getter del id del producto que tiene el carrito
        /// </summary>
        public int IdProducto
        {
            get
            {
                return producto.IdProducto;
            }
        }
        /// <summary>
        /// Getter del nombre del producto que tiene el carrito
        /// </summary>
        public string Producto
        {
            get
            {
                return this.producto.NombreProducto;
            }
        }

        /// <summary>
        /// getter cantidad
        /// </summary>
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        /// <summary>
        /// getter del precio
        /// </summary>
        public float Precio
        {
            get
            {
                return producto.Precio;
            }
        }




    }
}
