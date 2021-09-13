namespace WinRubicat
{
    partial class FrmVenta
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
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.tlpDatos = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnNuevoVendedor = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarVta = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtVerDesc = new System.Windows.Forms.TextBox();
            this.lblTitProductos = new System.Windows.Forms.Label();
            this.tlpProductos = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitDatos = new System.Windows.Forms.Label();
            this.lblTitDescuentos = new System.Windows.Forms.Label();
            this.tlpDescuentos = new System.Windows.Forms.TableLayoutPanel();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.btnDescuento = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.rbPorcentaje = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tlpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tlpProductos.SuspendLayout();
            this.tlpDescuentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregarProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.Location = new System.Drawing.Point(394, 59);
            this.btnAgregarProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(120, 32);
            this.btnAgregarProd.TabIndex = 7;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(181, 525);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(94, 90);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(208, 27);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.Value = new System.DateTime(2021, 4, 26, 0, 0, 0, 0);
            // 
            // cboVendedor
            // 
            this.cboVendedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Items.AddRange(new object[] {
            "Jorge",
            "Andres"});
            this.cboVendedor.Location = new System.Drawing.Point(94, 51);
            this.cboVendedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(208, 28);
            this.cboVendedor.TabIndex = 2;
            this.cboVendedor.Text = "Elegir";
            // 
            // cboCliente
            // 
            this.cboCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Items.AddRange(new object[] {
            "Agra",
            "Oh my Dog",
            "Tiendas del Sur",
            "Marynor"});
            this.cboCliente.Location = new System.Drawing.Point(94, 10);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(208, 28);
            this.cboCliente.TabIndex = 1;
            this.cboCliente.Text = "Elegir";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCantidad.Location = new System.Drawing.Point(394, 10);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(118, 29);
            this.txtCantidad.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(4, 93);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 20);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // lblVendedor
            // 
            this.lblVendedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(4, 51);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(73, 20);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "Vendedor";
            // 
            // cboProducto
            // 
            this.cboProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Items.AddRange(new object[] {
            "Rubicat Classic",
            "Rubicat Premium",
            "Rubicat Super Premium"});
            this.cboProducto.Location = new System.Drawing.Point(94, 14);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(209, 29);
            this.cboProducto.TabIndex = 4;
            this.cboProducto.Text = "Elegir";
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(4, 10);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 20);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(314, 14);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 21);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(4, 14);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 21);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // tlpDatos
            // 
            this.tlpDatos.ColumnCount = 3;
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.25581F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.81395F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.67183F));
            this.tlpDatos.Controls.Add(this.btnNuevoCliente, 2, 0);
            this.tlpDatos.Controls.Add(this.cboCliente, 1, 0);
            this.tlpDatos.Controls.Add(this.lblCliente, 0, 0);
            this.tlpDatos.Controls.Add(this.lblVendedor, 0, 1);
            this.tlpDatos.Controls.Add(this.cboVendedor, 1, 1);
            this.tlpDatos.Controls.Add(this.btnNuevoVendedor, 2, 1);
            this.tlpDatos.Controls.Add(this.lblFecha, 0, 2);
            this.tlpDatos.Controls.Add(this.dtpFecha, 1, 2);
            this.tlpDatos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpDatos.Location = new System.Drawing.Point(13, 35);
            this.tlpDatos.Margin = new System.Windows.Forms.Padding(4, 5, 0, 5);
            this.tlpDatos.Name = "tlpDatos";
            this.tlpDatos.RowCount = 3;
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDatos.Size = new System.Drawing.Size(387, 125);
            this.tlpDatos.TabIndex = 0;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(310, 11);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(25, 25);
            this.btnNuevoCliente.TabIndex = 26;
            this.btnNuevoCliente.Text = "+";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // btnNuevoVendedor
            // 
            this.btnNuevoVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoVendedor.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoVendedor.Location = new System.Drawing.Point(310, 52);
            this.btnNuevoVendedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevoVendedor.Name = "btnNuevoVendedor";
            this.btnNuevoVendedor.Size = new System.Drawing.Size(25, 25);
            this.btnNuevoVendedor.TabIndex = 27;
            this.btnNuevoVendedor.Text = "+";
            this.btnNuevoVendedor.UseVisualStyleBackColor = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(4, 64);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 21);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrecio.Location = new System.Drawing.Point(94, 60);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(209, 29);
            this.txtPrecio.TabIndex = 6;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(13, 331);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(894, 184);
            this.dgvProductos.TabIndex = 12;
            // 
            // btnAgregarVta
            // 
            this.btnAgregarVta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVta.Location = new System.Drawing.Point(13, 525);
            this.btnAgregarVta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarVta.Name = "btnAgregarVta";
            this.btnAgregarVta.Size = new System.Drawing.Size(135, 40);
            this.btnAgregarVta.TabIndex = 10;
            this.btnAgregarVta.Text = "Agregar Pedido";
            this.btnAgregarVta.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(671, 604);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 21);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(671, 534);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(68, 21);
            this.lblSubTotal.TabIndex = 15;
            this.lblSubTotal.Text = "Subtotal";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(671, 569);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(90, 21);
            this.lblDescuento.TabIndex = 16;
            this.lblDescuento.Text = "Descuentos";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(809, 531);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 29);
            this.txtSubTotal.TabIndex = 28;
            this.txtSubTotal.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(809, 601);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 29);
            this.txtTotal.TabIndex = 30;
            this.txtTotal.Text = "0";
            // 
            // txtVerDesc
            // 
            this.txtVerDesc.Location = new System.Drawing.Point(809, 566);
            this.txtVerDesc.Name = "txtVerDesc";
            this.txtVerDesc.ReadOnly = true;
            this.txtVerDesc.Size = new System.Drawing.Size(100, 29);
            this.txtVerDesc.TabIndex = 29;
            this.txtVerDesc.Text = "0";
            // 
            // lblTitProductos
            // 
            this.lblTitProductos.AutoSize = true;
            this.lblTitProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitProductos.Location = new System.Drawing.Point(17, 171);
            this.lblTitProductos.Name = "lblTitProductos";
            this.lblTitProductos.Size = new System.Drawing.Size(87, 21);
            this.lblTitProductos.TabIndex = 20;
            this.lblTitProductos.Text = "Productos";
            // 
            // tlpProductos
            // 
            this.tlpProductos.ColumnCount = 4;
            this.tlpProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17557F));
            this.tlpProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.60305F));
            this.tlpProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.69767F));
            this.tlpProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.19685F));
            this.tlpProductos.Controls.Add(this.lblProducto, 0, 0);
            this.tlpProductos.Controls.Add(this.cboProducto, 1, 0);
            this.tlpProductos.Controls.Add(this.txtPrecio, 1, 1);
            this.tlpProductos.Controls.Add(this.lblCantidad, 2, 0);
            this.tlpProductos.Controls.Add(this.txtCantidad, 3, 0);
            this.tlpProductos.Controls.Add(this.btnAgregarProd, 3, 1);
            this.tlpProductos.Controls.Add(this.lblPrecio, 0, 1);
            this.tlpProductos.Location = new System.Drawing.Point(13, 197);
            this.tlpProductos.Name = "tlpProductos";
            this.tlpProductos.RowCount = 2;
            this.tlpProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProductos.Size = new System.Drawing.Size(524, 100);
            this.tlpProductos.TabIndex = 1;
            // 
            // lblTitDatos
            // 
            this.lblTitDatos.AutoSize = true;
            this.lblTitDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitDatos.Location = new System.Drawing.Point(11, 9);
            this.lblTitDatos.Name = "lblTitDatos";
            this.lblTitDatos.Size = new System.Drawing.Size(54, 21);
            this.lblTitDatos.TabIndex = 22;
            this.lblTitDatos.Text = "Datos";
            // 
            // lblTitDescuentos
            // 
            this.lblTitDescuentos.AutoSize = true;
            this.lblTitDescuentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitDescuentos.Location = new System.Drawing.Point(576, 171);
            this.lblTitDescuentos.Name = "lblTitDescuentos";
            this.lblTitDescuentos.Size = new System.Drawing.Size(98, 21);
            this.lblTitDescuentos.TabIndex = 23;
            this.lblTitDescuentos.Text = "Descuentos";
            // 
            // tlpDescuentos
            // 
            this.tlpDescuentos.ColumnCount = 2;
            this.tlpDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.23664F));
            this.tlpDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.76336F));
            this.tlpDescuentos.Controls.Add(this.rbEfectivo, 1, 0);
            this.tlpDescuentos.Controls.Add(this.btnDescuento, 1, 1);
            this.tlpDescuentos.Controls.Add(this.txtDescuento, 0, 1);
            this.tlpDescuentos.Controls.Add(this.rbPorcentaje, 0, 0);
            this.tlpDescuentos.Location = new System.Drawing.Point(580, 197);
            this.tlpDescuentos.Name = "tlpDescuentos";
            this.tlpDescuentos.RowCount = 2;
            this.tlpDescuentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDescuentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDescuentos.Size = new System.Drawing.Size(262, 100);
            this.tlpDescuentos.TabIndex = 2;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(154, 12);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(82, 25);
            this.rbEfectivo.TabIndex = 11;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnDescuento
            // 
            this.btnDescuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDescuento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescuento.Location = new System.Drawing.Point(135, 60);
            this.btnDescuento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Size = new System.Drawing.Size(120, 30);
            this.btnDescuento.TabIndex = 9;
            this.btnDescuento.Text = "Aplicar";
            this.btnDescuento.UseVisualStyleBackColor = true;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescuento.Location = new System.Drawing.Point(3, 60);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(120, 29);
            this.txtDescuento.TabIndex = 8;
            this.txtDescuento.Text = "0";
            // 
            // rbPorcentaje
            // 
            this.rbPorcentaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbPorcentaje.AutoSize = true;
            this.rbPorcentaje.Location = new System.Drawing.Point(14, 12);
            this.rbPorcentaje.Name = "rbPorcentaje";
            this.rbPorcentaje.Size = new System.Drawing.Size(100, 25);
            this.rbPorcentaje.TabIndex = 10;
            this.rbPorcentaje.TabStop = true;
            this.rbPorcentaje.Text = "Porcentaje";
            this.rbPorcentaje.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(784, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(784, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "$";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 646);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlpDescuentos);
            this.Controls.Add(this.lblTitDescuentos);
            this.Controls.Add(this.lblTitDatos);
            this.Controls.Add(this.tlpProductos);
            this.Controls.Add(this.lblTitProductos);
            this.Controls.Add(this.txtVerDesc);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAgregarVta);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tlpDatos);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVenta";
            this.Text = "NUEVO PEDIDO";
            this.tlpDatos.ResumeLayout(false);
            this.tlpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tlpProductos.ResumeLayout(false);
            this.tlpProductos.PerformLayout();
            this.tlpDescuentos.ResumeLayout(false);
            this.tlpDescuentos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TableLayoutPanel tlpDatos;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnNuevoVendedor;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregarVta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtVerDesc;
        private System.Windows.Forms.Label lblTitProductos;
        private System.Windows.Forms.TableLayoutPanel tlpProductos;
        private System.Windows.Forms.Label lblTitDatos;
        private System.Windows.Forms.Label lblTitDescuentos;
        private System.Windows.Forms.TableLayoutPanel tlpDescuentos;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Button btnDescuento;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbPorcentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}