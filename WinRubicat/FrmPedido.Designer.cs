
namespace WinRubicat
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.btnAplicarDescuento = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.rbPorcentaje = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVerDesc = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDatosLocalidad = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFechaDePedido = new System.Windows.Forms.Label();
            this.dtpFechaDePedido = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.lblDatosIVA = new System.Windows.Forms.Label();
            this.lblDatosCondicion = new System.Windows.Forms.Label();
            this.lblDatosCUIT = new System.Windows.Forms.Label();
            this.lblDatosDomicilio = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDatosTelefono = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumeroDeRemito = new System.Windows.Forms.Label();
            this.txtNumeroDeRemito = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvPedidoParcial = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.btnParcialPedido = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.lblDatosProductoCosto = new System.Windows.Forms.Label();
            this.lblDatosProducto = new System.Windows.Forms.Label();
            this.lblDatosTransporteHorario = new System.Windows.Forms.Label();
            this.lblDatosTransporteTelefono = new System.Windows.Forms.Label();
            this.lblDatosTransporte = new System.Windows.Forms.Label();
            this.lblFechaDeEntrega = new System.Windows.Forms.Label();
            this.dtpFechaDeEntrega = new System.Windows.Forms.DateTimePicker();
            this.cboTransporte = new System.Windows.Forms.ComboBox();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.lblDireccionTransporte = new System.Windows.Forms.Label();
            this.lblTelefonoTransporte = new System.Windows.Forms.Label();
            this.lblCantidadDeProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblNombreDeProducto = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lblHorarioTransporte = new System.Windows.Forms.Label();
            this.lblDatosCantidadMinima = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAplicarDescuento
            // 
            this.btnAplicarDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicarDescuento.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAplicarDescuento.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAplicarDescuento.FlatAppearance.BorderSize = 2;
            this.btnAplicarDescuento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAplicarDescuento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAplicarDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarDescuento.Location = new System.Drawing.Point(104, 45);
            this.btnAplicarDescuento.Name = "btnAplicarDescuento";
            this.btnAplicarDescuento.Size = new System.Drawing.Size(116, 36);
            this.btnAplicarDescuento.TabIndex = 0;
            this.btnAplicarDescuento.Text = "Aplicar";
            this.btnAplicarDescuento.UseVisualStyleBackColor = true;
            // 
            // cboCliente
            // 
            this.cboCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(182, 37);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(120, 29);
            this.cboCliente.TabIndex = 5;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            this.cboCliente.TextChanged += new System.EventHandler(this.cboCliente_TextChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescuento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDescuento.Location = new System.Drawing.Point(3, 51);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(95, 23);
            this.txtDescuento.TabIndex = 9;
            this.txtDescuento.Text = "0";
            // 
            // rbPorcentaje
            // 
            this.rbPorcentaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbPorcentaje.AutoSize = true;
            this.rbPorcentaje.Location = new System.Drawing.Point(3, 10);
            this.rbPorcentaje.Name = "rbPorcentaje";
            this.rbPorcentaje.Size = new System.Drawing.Size(95, 21);
            this.rbPorcentaje.TabIndex = 11;
            this.rbPorcentaje.TabStop = true;
            this.rbPorcentaje.Text = "Porcentaje";
            this.rbPorcentaje.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(123, 10);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(78, 21);
            this.rbEfectivo.TabIndex = 12;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(743, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(743, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(743, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "$";
            // 
            // txtVerDesc
            // 
            this.txtVerDesc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtVerDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerDesc.Location = new System.Drawing.Point(768, 367);
            this.txtVerDesc.Name = "txtVerDesc";
            this.txtVerDesc.ReadOnly = true;
            this.txtVerDesc.Size = new System.Drawing.Size(100, 27);
            this.txtVerDesc.TabIndex = 38;
            this.txtVerDesc.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(768, 404);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 27);
            this.txtTotal.TabIndex = 39;
            this.txtTotal.Text = "0";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSubTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(768, 334);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 27);
            this.txtSubTotal.TabIndex = 37;
            this.txtSubTotal.Text = "0";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(639, 372);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(101, 21);
            this.lblDescuento.TabIndex = 36;
            this.lblDescuento.Text = "Descuentos";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(662, 337);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(77, 21);
            this.lblSubTotal.TabIndex = 35;
            this.lblSubTotal.Text = "Subtotal";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(677, 404);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 21);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.01639F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.98361F));
            this.tableLayoutPanel4.Controls.Add(this.lblDatosLocalidad, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.lblFechaDePedido, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtpFechaDePedido, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cboCliente, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblDatosCliente, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblDatosIVA, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblDatosCondicion, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblDatosCUIT, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.lblDatosDomicilio, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.lblTelefono, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.lblLocalidad, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.lblDatosTelefono, 1, 8);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 49);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(305, 312);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // lblDatosLocalidad
            // 
            this.lblDatosLocalidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosLocalidad.AutoSize = true;
            this.lblDatosLocalidad.Location = new System.Drawing.Point(182, 244);
            this.lblDatosLocalidad.Name = "lblDatosLocalidad";
            this.lblDatosLocalidad.Size = new System.Drawing.Size(66, 21);
            this.lblDatosLocalidad.TabIndex = 77;
            this.lblDatosLocalidad.Text = "Cliente";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "I.V.A::";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Condición de venta:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "C.U.I.T.:";
            // 
            // lblFechaDePedido
            // 
            this.lblFechaDePedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFechaDePedido.AutoSize = true;
            this.lblFechaDePedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDePedido.Location = new System.Drawing.Point(3, 6);
            this.lblFechaDePedido.Name = "lblFechaDePedido";
            this.lblFechaDePedido.Size = new System.Drawing.Size(146, 21);
            this.lblFechaDePedido.TabIndex = 51;
            this.lblFechaDePedido.Text = "Fecha de Pedido:";
            // 
            // dtpFechaDePedido
            // 
            this.dtpFechaDePedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaDePedido.Location = new System.Drawing.Point(182, 3);
            this.dtpFechaDePedido.Name = "dtpFechaDePedido";
            this.dtpFechaDePedido.Size = new System.Drawing.Size(120, 27);
            this.dtpFechaDePedido.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Domicilio:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cod. Cliente";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Cliente";
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Location = new System.Drawing.Point(182, 74);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(66, 21);
            this.lblDatosCliente.TabIndex = 2;
            this.lblDatosCliente.Text = "Cliente";
            // 
            // lblDatosIVA
            // 
            this.lblDatosIVA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosIVA.AutoSize = true;
            this.lblDatosIVA.Location = new System.Drawing.Point(182, 108);
            this.lblDatosIVA.Name = "lblDatosIVA";
            this.lblDatosIVA.Size = new System.Drawing.Size(66, 21);
            this.lblDatosIVA.TabIndex = 53;
            this.lblDatosIVA.Text = "Cliente";
            // 
            // lblDatosCondicion
            // 
            this.lblDatosCondicion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosCondicion.AutoSize = true;
            this.lblDatosCondicion.Location = new System.Drawing.Point(182, 142);
            this.lblDatosCondicion.Name = "lblDatosCondicion";
            this.lblDatosCondicion.Size = new System.Drawing.Size(66, 21);
            this.lblDatosCondicion.TabIndex = 54;
            this.lblDatosCondicion.Text = "Cliente";
            // 
            // lblDatosCUIT
            // 
            this.lblDatosCUIT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosCUIT.AutoSize = true;
            this.lblDatosCUIT.Location = new System.Drawing.Point(182, 176);
            this.lblDatosCUIT.Name = "lblDatosCUIT";
            this.lblDatosCUIT.Size = new System.Drawing.Size(66, 21);
            this.lblDatosCUIT.TabIndex = 55;
            this.lblDatosCUIT.Text = "Cliente";
            // 
            // lblDatosDomicilio
            // 
            this.lblDatosDomicilio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosDomicilio.AutoSize = true;
            this.lblDatosDomicilio.Location = new System.Drawing.Point(182, 210);
            this.lblDatosDomicilio.Name = "lblDatosDomicilio";
            this.lblDatosDomicilio.Size = new System.Drawing.Size(66, 21);
            this.lblDatosDomicilio.TabIndex = 56;
            this.lblDatosDomicilio.Text = "Cliente";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(3, 281);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(76, 21);
            this.lblTelefono.TabIndex = 58;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(3, 244);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(95, 21);
            this.lblLocalidad.TabIndex = 59;
            this.lblLocalidad.Text = "Localidad: ";
            // 
            // lblDatosTelefono
            // 
            this.lblDatosTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosTelefono.AutoSize = true;
            this.lblDatosTelefono.Location = new System.Drawing.Point(182, 281);
            this.lblDatosTelefono.Name = "lblDatosTelefono";
            this.lblDatosTelefono.Size = new System.Drawing.Size(66, 21);
            this.lblDatosTelefono.TabIndex = 57;
            this.lblDatosTelefono.Text = "Cliente";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.66929F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.33071F));
            this.tableLayoutPanel2.Controls.Add(this.btnAplicarDescuento, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDescuento, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.rbEfectivo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbPorcentaje, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(645, 101);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(223, 84);
            this.tableLayoutPanel2.TabIndex = 47;
            // 
            // lblNumeroDeRemito
            // 
            this.lblNumeroDeRemito.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumeroDeRemito.AutoSize = true;
            this.lblNumeroDeRemito.Location = new System.Drawing.Point(3, 2);
            this.lblNumeroDeRemito.Name = "lblNumeroDeRemito";
            this.lblNumeroDeRemito.Size = new System.Drawing.Size(76, 42);
            this.lblNumeroDeRemito.TabIndex = 53;
            this.lblNumeroDeRemito.Text = "Núm. de Remito:";
            // 
            // txtNumeroDeRemito
            // 
            this.txtNumeroDeRemito.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumeroDeRemito.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNumeroDeRemito.Location = new System.Drawing.Point(87, 9);
            this.txtNumeroDeRemito.Name = "txtNumeroDeRemito";
            this.txtNumeroDeRemito.Size = new System.Drawing.Size(133, 27);
            this.txtNumeroDeRemito.TabIndex = 54;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.90476F));
            this.tableLayoutPanel1.Controls.Add(this.lblNumeroDeRemito, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumeroDeRemito, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(645, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(223, 46);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(414, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 23);
            this.lblTitulo.TabIndex = 49;
            this.lblTitulo.Text = "titulo";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(556, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 23);
            this.lblId.TabIndex = 50;
            this.lblId.Text = "Id";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(590, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 23);
            this.lblCodigo.TabIndex = 51;
            this.lblCodigo.Text = "Codigo";
            // 
            // dgvPedidoParcial
            // 
            this.dgvPedidoParcial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedidoParcial.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPedidoParcial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPedidoParcial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedidoParcial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidoParcial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidoParcial.ColumnHeadersHeight = 45;
            this.dgvPedidoParcial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidoParcial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidoParcial.EnableHeadersVisualStyles = false;
            this.dgvPedidoParcial.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPedidoParcial.Location = new System.Drawing.Point(18, 384);
            this.dgvPedidoParcial.Name = "dgvPedidoParcial";
            this.dgvPedidoParcial.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPedidoParcial.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidoParcial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidoParcial.Size = new System.Drawing.Size(621, 41);
            this.dgvPedidoParcial.TabIndex = 70;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(523, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 53);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarPedido.FlatAppearance.BorderSize = 2;
            this.btnAgregarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPedido.Image")));
            this.btnAgregarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregarPedido.Location = new System.Drawing.Point(225, 437);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(98, 53);
            this.btnAgregarPedido.TabIndex = 73;
            this.btnAgregarPedido.Text = "Pedido";
            this.btnAgregarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            // 
            // btnParcialPedido
            // 
            this.btnParcialPedido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnParcialPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParcialPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnParcialPedido.FlatAppearance.BorderSize = 2;
            this.btnParcialPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnParcialPedido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnParcialPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParcialPedido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParcialPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnParcialPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnParcialPedido.Image")));
            this.btnParcialPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnParcialPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnParcialPedido.Location = new System.Drawing.Point(710, 191);
            this.btnParcialPedido.Name = "btnParcialPedido";
            this.btnParcialPedido.Size = new System.Drawing.Size(82, 45);
            this.btnParcialPedido.TabIndex = 74;
            this.btnParcialPedido.Text = "Pedido Parcial";
            this.btnParcialPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParcialPedido.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.83764F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.16236F));
            this.tableLayoutPanel3.Controls.Add(this.txtCantidadProducto, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.lblDatosProductoCosto, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblDatosProducto, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblDatosTransporteHorario, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblDatosTransporteTelefono, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblDatosTransporte, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblFechaDeEntrega, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpFechaDeEntrega, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboTransporte, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblTransporte, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDireccionTransporte, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblTelefonoTransporte, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblCantidadDeProducto, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.lblPrecioProducto, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblNombreDeProducto, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblProducto, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.cboProducto, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblHorarioTransporte, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblDatosCantidadMinima, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 9);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(350, 49);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(271, 329);
            this.tableLayoutPanel3.TabIndex = 76;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCantidadProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCantidadProducto.Location = new System.Drawing.Point(176, 279);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(92, 20);
            this.txtCantidadProducto.TabIndex = 77;
            // 
            // lblDatosProductoCosto
            // 
            this.lblDatosProductoCosto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosProductoCosto.AutoSize = true;
            this.lblDatosProductoCosto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDatosProductoCosto.Location = new System.Drawing.Point(176, 244);
            this.lblDatosProductoCosto.Name = "lblDatosProductoCosto";
            this.lblDatosProductoCosto.Size = new System.Drawing.Size(66, 21);
            this.lblDatosProductoCosto.TabIndex = 72;
            this.lblDatosProductoCosto.Text = "Cliente";
            // 
            // lblDatosProducto
            // 
            this.lblDatosProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosProducto.AutoSize = true;
            this.lblDatosProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDatosProducto.Location = new System.Drawing.Point(176, 210);
            this.lblDatosProducto.Name = "lblDatosProducto";
            this.lblDatosProducto.Size = new System.Drawing.Size(82, 21);
            this.lblDatosProducto.TabIndex = 71;
            this.lblDatosProducto.Text = "Producto";
            // 
            // lblDatosTransporteHorario
            // 
            this.lblDatosTransporteHorario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosTransporteHorario.AutoSize = true;
            this.lblDatosTransporteHorario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDatosTransporteHorario.Location = new System.Drawing.Point(176, 136);
            this.lblDatosTransporteHorario.Name = "lblDatosTransporteHorario";
            this.lblDatosTransporteHorario.Size = new System.Drawing.Size(83, 34);
            this.lblDatosTransporteHorario.TabIndex = 70;
            this.lblDatosTransporteHorario.Text = "Transporte";
            // 
            // lblDatosTransporteTelefono
            // 
            this.lblDatosTransporteTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosTransporteTelefono.AutoSize = true;
            this.lblDatosTransporteTelefono.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDatosTransporteTelefono.Location = new System.Drawing.Point(176, 102);
            this.lblDatosTransporteTelefono.Name = "lblDatosTransporteTelefono";
            this.lblDatosTransporteTelefono.Size = new System.Drawing.Size(83, 34);
            this.lblDatosTransporteTelefono.TabIndex = 69;
            this.lblDatosTransporteTelefono.Text = "Trasnporte";
            // 
            // lblDatosTransporte
            // 
            this.lblDatosTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosTransporte.AutoSize = true;
            this.lblDatosTransporte.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDatosTransporte.Location = new System.Drawing.Point(176, 68);
            this.lblDatosTransporte.Name = "lblDatosTransporte";
            this.lblDatosTransporte.Size = new System.Drawing.Size(83, 34);
            this.lblDatosTransporte.TabIndex = 68;
            this.lblDatosTransporte.Text = "Transporte";
            // 
            // lblFechaDeEntrega
            // 
            this.lblFechaDeEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFechaDeEntrega.AutoSize = true;
            this.lblFechaDeEntrega.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeEntrega.Location = new System.Drawing.Point(3, 6);
            this.lblFechaDeEntrega.Name = "lblFechaDeEntrega";
            this.lblFechaDeEntrega.Size = new System.Drawing.Size(155, 21);
            this.lblFechaDeEntrega.TabIndex = 52;
            this.lblFechaDeEntrega.Text = "Fecha de Entrega:";
            // 
            // dtpFechaDeEntrega
            // 
            this.dtpFechaDeEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaDeEntrega.Location = new System.Drawing.Point(176, 7);
            this.dtpFechaDeEntrega.Name = "dtpFechaDeEntrega";
            this.dtpFechaDeEntrega.Size = new System.Drawing.Size(92, 20);
            this.dtpFechaDeEntrega.TabIndex = 53;
            // 
            // cboTransporte
            // 
            this.cboTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboTransporte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboTransporte.FormattingEnabled = true;
            this.cboTransporte.Location = new System.Drawing.Point(176, 40);
            this.cboTransporte.Name = "cboTransporte";
            this.cboTransporte.Size = new System.Drawing.Size(92, 21);
            this.cboTransporte.TabIndex = 54;
            this.cboTransporte.SelectedIndexChanged += new System.EventHandler(this.cboTransporte_SelectedIndexChanged);
            this.cboTransporte.TextChanged += new System.EventHandler(this.cboTransporte_TextChanged);
            // 
            // lblTransporte
            // 
            this.lblTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransporte.Location = new System.Drawing.Point(3, 40);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(97, 21);
            this.lblTransporte.TabIndex = 55;
            this.lblTransporte.Text = "Transporte:";
            // 
            // lblDireccionTransporte
            // 
            this.lblDireccionTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDireccionTransporte.AutoSize = true;
            this.lblDireccionTransporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionTransporte.Location = new System.Drawing.Point(3, 74);
            this.lblDireccionTransporte.Name = "lblDireccionTransporte";
            this.lblDireccionTransporte.Size = new System.Drawing.Size(87, 21);
            this.lblDireccionTransporte.TabIndex = 65;
            this.lblDireccionTransporte.Text = "Dirección;";
            // 
            // lblTelefonoTransporte
            // 
            this.lblTelefonoTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTelefonoTransporte.AutoSize = true;
            this.lblTelefonoTransporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoTransporte.Location = new System.Drawing.Point(3, 108);
            this.lblTelefonoTransporte.Name = "lblTelefonoTransporte";
            this.lblTelefonoTransporte.Size = new System.Drawing.Size(80, 21);
            this.lblTelefonoTransporte.TabIndex = 66;
            this.lblTelefonoTransporte.Text = "Teléfono:";
            // 
            // lblCantidadDeProducto
            // 
            this.lblCantidadDeProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCantidadDeProducto.AutoSize = true;
            this.lblCantidadDeProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeProducto.Location = new System.Drawing.Point(3, 279);
            this.lblCantidadDeProducto.Name = "lblCantidadDeProducto";
            this.lblCantidadDeProducto.Size = new System.Drawing.Size(91, 21);
            this.lblCantidadDeProducto.TabIndex = 64;
            this.lblCantidadDeProducto.Text = "Cantidad:";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProducto.Location = new System.Drawing.Point(3, 244);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(60, 21);
            this.lblPrecioProducto.TabIndex = 61;
            this.lblPrecioProducto.Text = "Costo:";
            // 
            // lblNombreDeProducto
            // 
            this.lblNombreDeProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombreDeProducto.AutoSize = true;
            this.lblNombreDeProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeProducto.Location = new System.Drawing.Point(3, 210);
            this.lblNombreDeProducto.Name = "lblNombreDeProducto";
            this.lblNombreDeProducto.Size = new System.Drawing.Size(86, 21);
            this.lblNombreDeProducto.TabIndex = 59;
            this.lblNombreDeProducto.Text = "Producto:";
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(3, 176);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(149, 21);
            this.lblProducto.TabIndex = 58;
            this.lblProducto.Text = "Cod. de Producto";
            // 
            // cboProducto
            // 
            this.cboProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(176, 176);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(92, 21);
            this.cboProducto.TabIndex = 57;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            this.cboProducto.TextChanged += new System.EventHandler(this.cboProducto_TextChanged);
            // 
            // lblHorarioTransporte
            // 
            this.lblHorarioTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHorarioTransporte.AutoSize = true;
            this.lblHorarioTransporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioTransporte.Location = new System.Drawing.Point(3, 142);
            this.lblHorarioTransporte.Name = "lblHorarioTransporte";
            this.lblHorarioTransporte.Size = new System.Drawing.Size(69, 21);
            this.lblHorarioTransporte.TabIndex = 67;
            this.lblHorarioTransporte.Text = "Horario:";
            // 
            // lblDatosCantidadMinima
            // 
            this.lblDatosCantidadMinima.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatosCantidadMinima.AutoSize = true;
            this.lblDatosCantidadMinima.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDatosCantidadMinima.Location = new System.Drawing.Point(176, 307);
            this.lblDatosCantidadMinima.Name = "lblDatosCantidadMinima";
            this.lblDatosCantidadMinima.Size = new System.Drawing.Size(66, 21);
            this.lblDatosCantidadMinima.TabIndex = 79;
            this.lblDatosCantidadMinima.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 78;
            this.label4.Text = "Prod. en Stock";
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 496);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnParcialPedido);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvPedidoParcial);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVerDesc);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPedido";
            this.Text = "Pedido";
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAplicarDescuento;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.RadioButton rbPorcentaje;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVerDesc;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtpFechaDePedido;
        private System.Windows.Forms.Label lblFechaDePedido;
        private System.Windows.Forms.Label lblNumeroDeRemito;
        private System.Windows.Forms.TextBox txtNumeroDeRemito;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvPedidoParcial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button btnParcialPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblFechaDeEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaDeEntrega;
        private System.Windows.Forms.ComboBox cboTransporte;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblNombreDeProducto;
        private System.Windows.Forms.Label lblCantidadDeProducto;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.Label lblDireccionTransporte;
        private System.Windows.Forms.Label lblTelefonoTransporte;
        private System.Windows.Forms.Label lblHorarioTransporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatosTelefono;
        private System.Windows.Forms.Label lblDatosCondicion;
        private System.Windows.Forms.Label lblDatosCUIT;
        private System.Windows.Forms.Label lblDatosDomicilio;
        private System.Windows.Forms.Label lblDatosIVA;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Label lblDatosProductoCosto;
        private System.Windows.Forms.Label lblDatosProducto;
        private System.Windows.Forms.Label lblDatosTransporteHorario;
        private System.Windows.Forms.Label lblDatosTransporteTelefono;
        private System.Windows.Forms.Label lblDatosTransporte;
        private System.Windows.Forms.Label lblDatosLocalidad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblDatosCantidadMinima;
        private System.Windows.Forms.Label label4;
    }
}