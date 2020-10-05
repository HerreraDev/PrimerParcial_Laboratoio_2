using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        int dni;

        /// <summary>
        /// Constructor del Cliente que llama al base
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Cliente(int id, string nombre, string apellido, int dni): base(id,nombre, apellido)
        {
            this.dni = dni;
        }

        /// <summary>
        /// getter del dni
        /// </summary>
        public int Dni
        {
            get { return this.dni; }
        }

        public override string Saludar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Hola soy: {0} {1} tu proximo cliente", this.Nombre, this.Apellido);

            return sb.ToString();
        }

        /// <summary>
        /// Override del ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"DNI: {this.dni.ToString()}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del ==
        /// </summary>
        /// <param name="auxCliente"></param>
        /// <param name="auxListaClientes"></param>
        /// <returns>devuelve el indice si encontro o -1 si no encontro</returns>
        public static int operator ==(Cliente auxCliente, List<Cliente> auxListaClientes)
        {
            int indice = -1;

            for (int i = 0; i < auxListaClientes.Count; i++)
            {
                if (auxListaClientes[i].Dni == auxCliente.dni)
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
        /// <param name="auxCliente"></param>
        /// <param name="auxListaClientes"></param>
        /// <returns>Lo contraio al ==</returns>
        public static int operator !=(Cliente auxCliente, List<Cliente> auxListaClientes)
        {
            if ((auxCliente == auxListaClientes) == -1)
            {
                return -1;
            }
            else
            {
                return (auxCliente == auxListaClientes);
            }
        }



    }
}
