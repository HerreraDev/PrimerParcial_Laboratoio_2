namespace GestionComercio
{
    partial class FormStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.lblStockShow = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtgStock = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnActualizarStock = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListaMenosA10Unidades = new System.Windows.Forms.Button();
            this.btnCantidadTotalStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStockShow
            // 
            this.lblStockShow.BackColor = System.Drawing.Color.Transparent;
            this.lblStockShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStockShow.Location = new System.Drawing.Point(604, 22);
            this.lblStockShow.Name = "lblStockShow";
            this.lblStockShow.Size = new System.Drawing.Size(548, 25);
            this.lblStockShow.TabIndex = 1;
            this.lblStockShow.Text = "STOCK";
            this.lblStockShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStockShow.Click += new System.EventHandler(this.lblStockShow_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(35, 612);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(1117, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtgStock
            // 
            this.dtgStock.AllowUserToAddRows = false;
            this.dtgStock.AllowUserToDeleteRows = false;
            this.dtgStock.AllowUserToResizeColumns = false;
            this.dtgStock.AllowUserToResizeRows = false;
            this.dtgStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgStock.BackgroundColor = System.Drawing.Color.Peru;
            this.dtgStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgStock.ColumnHeadersHeight = 30;
            this.dtgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgStock.EnableHeadersVisualStyles = false;
            this.dtgStock.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgStock.Location = new System.Drawing.Point(604, 50);
            this.dtgStock.Name = "dtgStock";
            this.dtgStock.ReadOnly = true;
            this.dtgStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgStock.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgStock.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgStock.Size = new System.Drawing.Size(548, 556);
            this.dtgStock.TabIndex = 3;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(35, 41);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(151, 39);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnActualizarStock
            // 
            this.btnActualizarStock.Location = new System.Drawing.Point(35, 565);
            this.btnActualizarStock.Name = "btnActualizarStock";
            this.btnActualizarStock.Size = new System.Drawing.Size(151, 39);
            this.btnActualizarStock.TabIndex = 5;
            this.btnActualizarStock.Text = "Mostar lista sin filtrar";
            this.btnActualizarStock.UseVisualStyleBackColor = true;
            this.btnActualizarStock.Click += new System.EventHandler(this.btnActualizarStock_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(35, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 39);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnListaMenosA10Unidades
            // 
            this.btnListaMenosA10Unidades.Location = new System.Drawing.Point(35, 293);
            this.btnListaMenosA10Unidades.Name = "btnListaMenosA10Unidades";
            this.btnListaMenosA10Unidades.Size = new System.Drawing.Size(151, 49);
            this.btnListaMenosA10Unidades.TabIndex = 7;
            this.btnListaMenosA10Unidades.Text = "Generar listado con los productos que tengan menos de 10 unidades";
            this.btnListaMenosA10Unidades.UseVisualStyleBackColor = true;
            this.btnListaMenosA10Unidades.Click += new System.EventHandler(this.btnListaMenosA10Unidades_Click);
            // 
            // btnCantidadTotalStock
            // 
            this.btnCantidadTotalStock.Location = new System.Drawing.Point(35, 429);
            this.btnCantidadTotalStock.Name = "btnCantidadTotalStock";
            this.btnCantidadTotalStock.Size = new System.Drawing.Size(151, 49);
            this.btnCantidadTotalStock.TabIndex = 8;
            this.btnCantidadTotalStock.Text = "Ver la cantidad total de stock";
            this.btnCantidadTotalStock.UseVisualStyleBackColor = true;
            this.btnCantidadTotalStock.Click += new System.EventHandler(this.btnCantidadTotalStock_Click);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1164, 647);
            this.Controls.Add(this.btnCantidadTotalStock);
            this.Controls.Add(this.btnListaMenosA10Unidades);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizarStock);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dtgStock);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblStockShow);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock del negocio";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblStockShow;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dtgStock;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnActualizarStock;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListaMenosA10Unidades;
        private System.Windows.Forms.Button btnCantidadTotalStock;
    }
}