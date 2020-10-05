using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComercio
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();

        }

        private void lblStockShow_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            Stock.CargarListaProductos();
            this.dtgStock.DataSource = Stock.ListaProductos;

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormAgregarProducto frmAgregarProducto = new FormAgregarProducto();
           if( frmAgregarProducto.ShowDialog()==DialogResult.OK)
            {
                ActualizarStock();
            }
        }

        public void ActualizarStock()
        {
            this.dtgStock.DataSource = null;
            this.dtgStock.DataSource = Stock.ListaProductos;
        }

        private void btnActualizarStock_Click(object sender, EventArgs e)
        {
            ActualizarStock();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormEliminar eliminar = new FormEliminar();
            if(eliminar.ShowDialog() == DialogResult.OK)
            {
                ActualizarStock();
            }
        }

        private void btnListaMenosA10Unidades_Click(object sender, EventArgs e)
        {
            this.dtgStock.DataSource = null;
            Stock.GenerarListadoPocoStock();
            this.dtgStock.DataSource = Stock.ListaProductosMenorA10Unidades;
        }

        private void btnCantidadTotalStock_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(Stock.ObtenerCantidadTotalStock()));
        }

    }
}
