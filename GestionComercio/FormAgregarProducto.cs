using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComercio
{
    public partial class FormAgregarProducto : Form
    {
        public FormAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            float auxValidarPrecio = Validaciones.Flotantes(this.txtPrecio.Text);
            int auxValidarCantidad = Validaciones.Enteros(this.txtCantidad.Text);
            if (!(Validaciones.EstaVacio(this.txtNombre.Text)))
            {
                if(auxValidarCantidad > 0 && auxValidarCantidad > 0)
                {
                    if (Stock.AgregarProducto(Stock.ObtenerUltimaIdListaProductos() + 1, this.txtNombre.Text, auxValidarPrecio, auxValidarCantidad))
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Agregado");
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Como el producto ya existia en la lista, se le ha actualizado el precio y la cantidad");
                    }
                }
                else
                {
                    MessageBox.Show("El precio y la cantidad solo deben contener numeros y que no sean negativos");
                }
            }
            else
            {
                MessageBox.Show("Error al agregar, no deje el nombre vacio");
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            //sender es el objeto que envia el evento
            //Trim saca los espacios que sobran adelante y los que sobran despues de la cadena
            if(this.txtNombre.Text != string.Empty)
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();


                //Esto levanta la primera letra a mayus
                ((TextBox)sender).Text = Char.ToUpper(((TextBox)sender).Text[0]) +
                ((TextBox)sender).Text.Substring(1);

                //Despues de cada espacio levanta mayus
                int posicion = 1;
                while (((TextBox)sender).Text.IndexOf(' ', posicion) > 0)
                {

                    posicion = ((TextBox)sender).Text.IndexOf(' ', posicion);
                    ((TextBox)sender).Text = String.Concat(
                        ((TextBox)sender).Text.Substring(0, posicion + 1),
                        Char.ToUpper(((TextBox)sender).Text[posicion + 1]),
                        ((TextBox)sender).Text.Substring(posicion + 2));

                    posicion++;
                }
            }

        }
    }
}
