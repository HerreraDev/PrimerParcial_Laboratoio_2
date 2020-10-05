using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        /// <summary>
        /// Valida que no sea negativo
        /// </summary>
        /// <param name="auxNumero"></param>
        /// <returns></returns>
        public static int Negativos(string auxNumero)
        {
            int exito = -1;
            if(int.TryParse(auxNumero, out int parseado))
            {
                exito = parseado;
            }
            return exito;
        }

        /// <summary>
        /// Valida que sea entero
        /// </summary>
        /// <param name="auxNumero"></param>
        /// <returns></returns>
        public static int Enteros(string auxNumero)
        {
            int exito = -1;
            if (int.TryParse(auxNumero, out int parseado))
            {
                exito = parseado;
            }
            else if (auxNumero == String.Empty)
            {
                exito = 0;
            }
            return exito;
        }

        /// <summary>
        /// Valida que sea flotante
        /// </summary>
        /// <param name="auxNumero"></param>
        /// <returns></returns>
        public static float Flotantes(string auxNumero)
        {
            float exito = -1;
            if (float.TryParse(auxNumero, out float parseado))
            {
                exito = parseado;
            }
            return exito;
        }

        public static bool EstaVacio(string auxString)
        {
            bool vacio = false;
            if(auxString == string.Empty)
            {
                vacio = true;
            }
            return vacio;
        }
    }
}
