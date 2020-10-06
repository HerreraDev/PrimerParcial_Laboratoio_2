namespace GestionComercio
{
    partial class FormCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtIdVendedor = new System.Windows.Forms.TextBox();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.lbl_Empleados = new System.Windows.Forms.Label();
            this.lbl_Clientes = new System.Windows.Forms.Label();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.lblProductos = new System.Windows.Forms.Label();
            this.btnAñadirCarro = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgCarrito = new System.Windows.Forms.DataGridView();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.AyudaOpcion = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoComprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarrito)).BeginInit();
            this.AyudaOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(15, 285);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(121, 36);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 328);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 36);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(15, 216);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Cursor = System.Windows.Forms.Cursors.No;
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(15, 162);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(121, 20);
            this.txtIdProducto.TabIndex = 3;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDniCliente.Enabled = false;
            this.txtDniCliente.Location = new System.Drawing.Point(15, 112);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.ReadOnly = true;
            this.txtDniCliente.Size = new System.Drawing.Size(121, 20);
            this.txtDniCliente.TabIndex = 4;
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.Cursor = System.Windows.Forms.Cursors.No;
            this.txtIdVendedor.Enabled = false;
            this.txtIdVendedor.Location = new System.Drawing.Point(15, 55);
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.ReadOnly = true;
            this.txtIdVendedor.Size = new System.Drawing.Size(121, 20);
            this.txtIdVendedor.TabIndex = 5;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblNombreVendedor.Location = new System.Drawing.Point(12, 36);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(174, 16);
            this.lblNombreVendedor.TabIndex = 6;
            this.lblNombreVendedor.Text = "Id del vendedor elegido";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 93);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(164, 16);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Dni del cliente elegido";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblProducto.Location = new System.Drawing.Point(12, 143);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(111, 16);
            this.lblProducto.TabIndex = 8;
            this.lblProducto.Text = "ID de Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCantidad.Location = new System.Drawing.Point(12, 197);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 16);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.AllowUserToResizeColumns = false;
            this.dtgClientes.AllowUserToResizeRows = false;
            this.dtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgClientes.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgClientes.EnableHeadersVisualStyles = false;
            this.dtgClientes.Location = new System.Drawing.Point(651, 163);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(627, 86);
            this.dtgClientes.TabIndex = 10;
            this.dtgClientes.DoubleClick += new System.EventHandler(this.dtgClientes_DoubleClick);
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.AllowUserToAddRows = false;
            this.dtgEmpleados.AllowUserToDeleteRows = false;
            this.dtgEmpleados.AllowUserToResizeColumns = false;
            this.dtgEmpleados.AllowUserToResizeRows = false;
            this.dtgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEmpleados.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEmpleados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgEmpleados.EnableHeadersVisualStyles = false;
            this.dtgEmpleados.Location = new System.Drawing.Point(651, 55);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.ReadOnly = true;
            this.dtgEmpleados.RowHeadersVisible = false;
            this.dtgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmpleados.Size = new System.Drawing.Size(627, 86);
            this.dtgEmpleados.TabIndex = 11;
            this.dtgEmpleados.DoubleClick += new System.EventHandler(this.dtgEmpleados_DoubleClick);
            // 
            // lbl_Empleados
            // 
            this.lbl_Empleados.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Empleados.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Empleados.Location = new System.Drawing.Point(648, 27);
            this.lbl_Empleados.Name = "lbl_Empleados";
            this.lbl_Empleados.Size = new System.Drawing.Size(630, 16);
            this.lbl_Empleados.TabIndex = 12;
            this.lbl_Empleados.Text = "Empelados";
            this.lbl_Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Clientes
            // 
            this.lbl_Clientes.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clientes.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Clientes.Location = new System.Drawing.Point(651, 144);
            this.lbl_Clientes.Name = "lbl_Clientes";
            this.lbl_Clientes.Size = new System.Drawing.Size(627, 16);
            this.lbl_Clientes.TabIndex = 13;
            this.lbl_Clientes.Text = "Clientes";
            this.lbl_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgProductos
            // 
            this.dtgProductos.AllowUserToAddRows = false;
            this.dtgProductos.AllowUserToDeleteRows = false;
            this.dtgProductos.AllowUserToResizeColumns = false;
            this.dtgProductos.AllowUserToResizeRows = false;
            this.dtgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductos.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgProductos.EnableHeadersVisualStyles = false;
            this.dtgProductos.Location = new System.Drawing.Point(651, 278);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.ReadOnly = true;
            this.dtgProductos.RowHeadersVisible = false;
            this.dtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductos.Size = new System.Drawing.Size(627, 86);
            this.dtgProductos.TabIndex = 14;
            this.dtgProductos.DoubleClick += new System.EventHandler(this.dtgProductos_DoubleClick);
            // 
            // lblProductos
            // 
            this.lblProductos.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblProductos.Location = new System.Drawing.Point(651, 252);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(627, 16);
            this.lblProductos.TabIndex = 15;
            this.lblProductos.Text = "Productos";
            this.lblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAñadirCarro
            // 
            this.btnAñadirCarro.Location = new System.Drawing.Point(15, 242);
            this.btnAñadirCarro.Name = "btnAñadirCarro";
            this.btnAñadirCarro.Size = new System.Drawing.Size(121, 36);
            this.btnAñadirCarro.TabIndex = 16;
            this.btnAñadirCarro.Text = "Agregar producto al carro";
            this.btnAñadirCarro.UseVisualStyleBackColor = true;
            this.btnAñadirCarro.Click += new System.EventHandler(this.btnAñadirCarro_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTotal.Location = new System.Drawing.Point(271, 354);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 16);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(205, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total: $";
            // 
            // dtgCarrito
            // 
            this.dtgCarrito.AllowUserToAddRows = false;
            this.dtgCarrito.AllowUserToDeleteRows = false;
            this.dtgCarrito.AllowUserToResizeColumns = false;
            this.dtgCarrito.AllowUserToResizeRows = false;
            this.dtgCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCarrito.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCarrito.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgCarrito.EnableHeadersVisualStyles = false;
            this.dtgCarrito.Location = new System.Drawing.Point(208, 55);
            this.dtgCarrito.MultiSelect = false;
            this.dtgCarrito.Name = "dtgCarrito";
            this.dtgCarrito.ReadOnly = true;
            this.dtgCarrito.RowHeadersVisible = false;
            this.dtgCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCarrito.Size = new System.Drawing.Size(423, 292);
            this.dtgCarrito.TabIndex = 19;
            this.dtgCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCarrito_CellContentClick);
            this.dtgCarrito.DoubleClick += new System.EventHandler(this.dtgCarrito_DoubleClick);
            // 
            // lblCarrito
            // 
            this.lblCarrito.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCarrito.Location = new System.Drawing.Point(208, 27);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(423, 16);
            this.lblCarrito.TabIndex = 20;
            this.lblCarrito.Text = "Carrito";
            this.lblCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AyudaOpcion
            // 
            this.AyudaOpcion.BackColor = System.Drawing.Color.Moccasin;
            this.AyudaOpcion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.agregarClienteNuevoToolStripMenuItem});
            this.AyudaOpcion.Location = new System.Drawing.Point(0, 0);
            this.AyudaOpcion.Name = "AyudaOpcion";
            this.AyudaOpcion.Size = new System.Drawing.Size(1290, 24);
            this.AyudaOpcion.TabIndex = 21;
            this.AyudaOpcion.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoComprarToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // comoComprarToolStripMenuItem
            // 
            this.comoComprarToolStripMenuItem.Name = "comoComprarToolStripMenuItem";
            this.comoComprarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.comoComprarToolStripMenuItem.Text = "Como comprar";
            this.comoComprarToolStripMenuItem.Click += new System.EventHandler(this.comoComprarToolStripMenuItem_Click);
            // 
            // agregarClienteNuevoToolStripMenuItem
            // 
            this.agregarClienteNuevoToolStripMenuItem.Name = "agregarClienteNuevoToolStripMenuItem";
            this.agregarClienteNuevoToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.agregarClienteNuevoToolStripMenuItem.Text = "Agregar cliente nuevo";
            this.agregarClienteNuevoToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteNuevoToolStripMenuItem_Click);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1290, 372);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.dtgCarrito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAñadirCarro);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.lbl_Clientes);
            this.Controls.Add(this.lbl_Empleados);
            this.Controls.Add(this.dtgEmpleados);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblNombreVendedor);
            this.Controls.Add(this.txtIdVendedor);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.AyudaOpcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.AyudaOpcion;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar compra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarrito)).EndInit();
            this.AyudaOpcion.ResumeLayout(false);
            this.AyudaOpcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtIdVendedor;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.Label lbl_Empleados;
        private System.Windows.Forms.Label lbl_Clientes;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Button btnAñadirCarro;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgCarrito;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.MenuStrip AyudaOpcion;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoComprarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteNuevoToolStripMenuItem;
    }
}