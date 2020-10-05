using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        string nacionalidad;

        /// <summary>
        /// Constructor con parametros que llama al base
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="idEmpleado"></param>
        public Empleado(int id, string nombre, string apellido, string nacionalidadEmpleado):base(id,nombre,apellido)
        {
            this.nacionalidad = nacionalidadEmpleado;
        }


        /// <summary>
        /// Solo lectura nacionalidad
        /// </summary>
        public string Nacionalidad
        {
            get { return this.nacionalidad; }
        }

        public override string Saludar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Hola soy el empleado: {0} {1} y te voy a atender", this.Nombre, this.Apellido);

            return sb.ToString();
        }


        /// <summary>
        /// Override del ToString() de empleado
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Nacionalidad: {this.nacionalidad.ToString()}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del ==
        /// </summary>
        /// <param name="auxEmpleado"></param>
        /// <param name="auxListaEmpleados"></param>
        /// <returns>devuelve indice donde esta el empleado en la lista</returns>
        public static int operator ==(Empleado auxEmpleado, List<Empleado> auxListaEmpleados)
        {
            int indice = -1;

            for (int i = 0; i < auxListaEmpleados.Count; i++)
            {
                if (auxListaEmpleados[i].Id == auxEmpleado.Id)
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
        /// <param name="auxEmpleado"></param>
        /// <param name="auxListaEmpleados"></param>
        /// <returns>Devuelve -1 si el == dio -1 O lo que dio el == </returns>
        public static int operator !=(Empleado auxEmpleado, List<Empleado> auxListaEmpleados)
        {
            if ((auxEmpleado == auxListaEmpleados) == -1)
            {
                return -1;
            }
            else
            {
                return (auxEmpleado == auxListaEmpleados);
            }
        }
    }
}
