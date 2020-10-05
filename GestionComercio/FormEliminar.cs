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
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int auxIndex = Validaciones.Enteros(this.txtIdEliminar.Text);
            auxIndex = Stock.BuscarProductoPorID(auxIndex);
            if( auxIndex != -1)
            {
                Stock.EliminarProducto(auxIndex);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error, no existe un producto con ese ID");
            }
            
        }
    }
}
