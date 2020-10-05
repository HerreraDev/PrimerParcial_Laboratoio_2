using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected int id;
        protected string nombre;
        protected string apellido;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Persona()
        {
            this.id = -1;
            this.nombre = "Sin cargar";
            this.apellido = "Sin cargar";
        }

        /// <summary>
        /// Constructor con parametros que llama al por defecto
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Persona(int id, string nombre, string apellido):this()
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #region Propiedades

        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        #endregion



        public abstract string Saludar();



        /// <summary>
        /// Override del metodo ToString() de Persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID: {this.Id}");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");

            return sb.ToString();
        }


    }
}
