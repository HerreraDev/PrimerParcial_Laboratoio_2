using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComercio
{
    public partial class FormVenta : Form
    {
        List<Compra> auxListraCompra;

        public FormVenta()
        {
            InitializeComponent();
            auxListraCompra = new List<Compra>();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.dtgVentas.DataSource = Stock.ListaCompras;
            this.dtgEmpleados.DataSource = Stock.ListadoFiltradoPorEmpleados();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dtgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //capturo el nombre y apellido
            string nombreAuxEmpleado = (string)dtgEmpleados.CurrentRow.Cells["Nombre"].Value + ", " + (string)dtgEmpleados.CurrentRow.Cells["Apellido"].Value;

            //genero la lista auxiliar filtrada
            for (int i = 0; i < Stock.ListaCompras.Count; i++)
            {
                    if (Stock.ListaCompras[i].Empleado == nombreAuxEmpleado)
                    {
                        auxListraCompra.Add(Stock.ListaCompras[i]);
                    }
            }

            //actualizo la lista de ventas
            this.dtgVentas.DataSource = null;
            this.dtgVentas.DataSource = auxListraCompra;

            //deshabilito el datagridview de empleados 
            ///para que no generen la misma listra filtrada una y otra vez
            this.dtgEmpleados.Enabled = false;

            
            }

        private void btnListaOriginal_Click(object sender, EventArgs e)
        {
            this.dtgVentas.DataSource = null;
            this.dtgVentas.DataSource = Stock.ListaCompras;
            this.dtgEmpleados.Enabled = true;

            auxListraCompra.Clear();
        }
    }
}
