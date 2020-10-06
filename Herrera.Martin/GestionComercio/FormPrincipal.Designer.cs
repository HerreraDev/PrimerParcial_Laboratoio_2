namespace GestionComercio
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lblLoginOff = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btnHacerCompra = new System.Windows.Forms.Button();
            this.btnRevisarStock = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginOff
            // 
            this.lblLoginOff.AutoSize = true;
            this.lblLoginOff.BackColor = System.Drawing.Color.Peru;
            this.lblLoginOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginOff.Location = new System.Drawing.Point(308, 231);
            this.lblLoginOff.Name = "lblLoginOff";
            this.lblLoginOff.Size = new System.Drawing.Size(200, 29);
            this.lblLoginOff.TabIndex = 0;
            this.lblLoginOff.Text = "Debe loguearse";
            this.lblLoginOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(420, 263);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(88, 22);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btnHacerCompra
            // 
            this.btnHacerCompra.Location = new System.Drawing.Point(12, 211);
            this.btnHacerCompra.Name = "btnHacerCompra";
            this.btnHacerCompra.Size = new System.Drawing.Size(253, 21);
            this.btnHacerCompra.TabIndex = 1;
            this.btnHacerCompra.Text = "Realizar Compra";
            this.btnHacerCompra.UseVisualStyleBackColor = true;
            this.btnHacerCompra.Click += new System.EventHandler(this.btnHacerCompra_Click);
            // 
            // btnRevisarStock
            // 
            this.btnRevisarStock.Location = new System.Drawing.Point(12, 238);
            this.btnRevisarStock.Name = "btnRevisarStock";
            this.btnRevisarStock.Size = new System.Drawing.Size(253, 22);
            this.btnRevisarStock.TabIndex = 2;
            this.btnRevisarStock.Text = "Control stock";
            this.btnRevisarStock.UseVisualStyleBackColor = true;
            this.btnRevisarStock.Click += new System.EventHandler(this.btnRevisarStock_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 266);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(253, 19);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(12, 184);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(253, 21);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "Ventas realizadas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(520, 297);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRevisarStock);
            this.Controls.Add(this.btnHacerCompra);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lblLoginOff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kwek E Mart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginOff;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btnHacerCompra;
        private System.Windows.Forms.Button btnRevisarStock;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVentas;
    }
}