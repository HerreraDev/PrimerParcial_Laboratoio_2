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
    public partial class FormAgregarCliente : Form
    {
        public FormAgregarCliente()
        {
            InitializeComponent();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            //sender es el objeto que envia el evento
            //Trim saca los espacios que sobran adelante y los que sobran despues de la cadena
            if (this.txtNombre.Text != string.Empty)
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();

                //Esto levanta la primera letra a mayus
                if (((TextBox)sender).Text[0] != ' ')
                {
                    ((TextBox)sender).Text = Char.ToUpper(((TextBox)sender).Text[0]) +
                    ((TextBox)sender).Text.Substring(1);
                }


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

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            int auxValidarDni;
            auxValidarDni = Validaciones.Enteros(this.txtDni.Text);

            //creo un cliente auxiliar solo con el dni para ver si ya existe en la lista
            Cliente auxCliente = new Cliente(-1, "", "", auxValidarDni);

            List<Cliente> auxListaClientes = Stock.ListadoFiltradoPorClientes();

            int existe = (auxCliente == auxListaClientes);

            if (!(Validaciones.EstaVacio(this.txtNombre.Text)) && !(Validaciones.EstaVacio(this.txtApellido.Text)))
            {
                if (existe == -1)
                {
                    if (auxValidarDni > 0)
                    {
                        Stock.PersonasDeLaTienda.Add(new Cliente(Stock.ObtenerUltimaIdListaClientes() + 1, this.txtNombre.Text, this.txtApellido.Text, auxValidarDni));
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("El DNI no puede ser negativo");

                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un cliente con ese DNI");
                }
            }
            else
            {
                MessageBox.Show("Por favor, no  dejar el nombre y el apellido vacios");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (this.txtApellido.Text != string.Empty)
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();

                //Esto levanta la primera letra a mayus
                if (((TextBox)sender).Text[0] != ' ')
                {
                    ((TextBox)sender).Text = Char.ToUpper(((TextBox)sender).Text[0]) +
                    ((TextBox)sender).Text.Substring(1);
                }


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
