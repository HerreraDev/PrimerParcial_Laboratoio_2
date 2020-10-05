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
    public partial class FormLogin : Form
    {
        Dictionary<string, string> usuarios;
        public FormLogin()
        {
            InitializeComponent();
            usuarios = new Dictionary<string, string>();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            usuarios.Add("Apu", "apu123");
            usuarios.Add("Perez", "perez123");
            usuarios.Add("1", "1");

        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtAceptar_Click(object sender, EventArgs e)
        {
            if (usuarios.TryGetValue(this.txtUsuario.Text, out string auxContraseña))
            {
                if(auxContraseña == this.txtContraseña.Text)
                {
                    MessageBox.Show("Login succes");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario inexistente");
            }

            
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

        }
    }
}
