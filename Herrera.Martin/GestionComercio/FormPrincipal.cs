using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace GestionComercio
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                CambiarScreen();
            }
            else
            {
                this.Close();
            }
        }

        private void CambiarScreen()
        {
            lblLoginOff.Visible = false;
            btn_Login.Visible = false;
            btnHacerCompra.Visible = true;
            btnRevisarStock.Visible = true;
            btnCerrar.Visible = true;
            btnVentas.Visible = true;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btnHacerCompra.Visible = false;
            btnRevisarStock.Visible = false;
            btnCerrar.Visible = false;
            btnVentas.Visible = false;

            Stock.CargarListadoPersonas();
            Stock.CargarListaProductos();
            Stock.CargarListadoCompras();
        }

        private void btnRevisarStock_Click(object sender, EventArgs e)
        {
            FormStock frmStock = new FormStock();
            if(frmStock.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show("Gracias por revisar el stock");
            }

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHacerCompra_Click(object sender, EventArgs e)
        {
            FormCompra frmCompra = new FormCompra();
            if (frmCompra.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Gracias!!  Vuelva prontosss");
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVenta frmVenta = new FormVenta();

            if(frmVenta.ShowDialog() ==  DialogResult.OK)
            {
                MessageBox.Show("Gracias por ver las ventas");
            }
        }
    }
}
