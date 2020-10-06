namespace GestionComercio
{
    partial class FormVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.btnListaOriginal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVentas
            // 
            this.dtgVentas.AllowUserToAddRows = false;
            this.dtgVentas.AllowUserToDeleteRows = false;
            this.dtgVentas.AllowUserToResizeColumns = false;
            this.dtgVentas.AllowUserToResizeRows = false;
            this.dtgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVentas.BackgroundColor = System.Drawing.Color.Coral;
            this.dtgVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgVentas.EnableHeadersVisualStyles = false;
            this.dtgVentas.Location = new System.Drawing.Point(18, 47);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.ReadOnly = true;
            this.dtgVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgVentas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVentas.Size = new System.Drawing.Size(916, 170);
            this.dtgVentas.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(209, 381);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(725, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.AllowUserToAddRows = false;
            this.dtgEmpleados.AllowUserToDeleteRows = false;
            this.dtgEmpleados.AllowUserToResizeColumns = false;
            this.dtgEmpleados.AllowUserToResizeRows = false;
            this.dtgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEmpleados.BackgroundColor = System.Drawing.Color.Coral;
            this.dtgEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEmpleados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgEmpleados.EnableHeadersVisualStyles = false;
            this.dtgEmpleados.Location = new System.Drawing.Point(18, 297);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.ReadOnly = true;
            this.dtgEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgEmpleados.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dtgEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmpleados.Size = new System.Drawing.Size(916, 79);
            this.dtgEmpleados.TabIndex = 2;
            this.dtgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpleados_CellContentClick);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.BackColor = System.Drawing.Color.Black;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.Color.White;
            this.lblEmpleados.Location = new System.Drawing.Point(18, 244);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(916, 50);
            this.lblEmpleados.TabIndex = 3;
            this.lblEmpleados.Text = resources.GetString("lblEmpleados.Text");
            this.lblEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVentas
            // 
            this.lblVentas.BackColor = System.Drawing.Color.Black;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.White;
            this.lblVentas.Location = new System.Drawing.Point(18, 10);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(916, 23);
            this.lblVentas.TabIndex = 4;
            this.lblVentas.Text = "Ventas realizadas";
            this.lblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListaOriginal
            // 
            this.btnListaOriginal.Location = new System.Drawing.Point(18, 381);
            this.btnListaOriginal.Name = "btnListaOriginal";
            this.btnListaOriginal.Size = new System.Drawing.Size(185, 23);
            this.btnListaOriginal.TabIndex = 0;
            this.btnListaOriginal.Text = "Ver lista de ventas original";
            this.btnListaOriginal.UseVisualStyleBackColor = true;
            this.btnListaOriginal.Click += new System.EventHandler(this.btnListaOriginal_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(953, 414);
            this.Controls.Add(this.btnListaOriginal);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.dtgEmpleados);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtgVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVentas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Button btnListaOriginal;
    }
}