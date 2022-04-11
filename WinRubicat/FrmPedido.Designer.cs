
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
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtHorarioTransporte = new System.Windows.Forms.TextBox();
            this.txtTelefonoTransporte = new System.Windows.Forms.TextBox();
            this.txtDireccionTransporte = new System.Windows.Forms.TextBox();
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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFechaDePedido = new System.Windows.Forms.Label();
            this.dtpFechaDePedido = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblFechaDeEntrega = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTransporte = new System.Windows.Forms.ComboBox();
            this.dtpFechaDeEntrega = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumeroDeRemito = new System.Windows.Forms.Label();
            this.txtNumeroDeRemito = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvPedidoParcial = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.btnParcialPedido = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnAplicarDescuento.Location = new System.Drawing.Point(96, 45);
            this.btnAplicarDescuento.Name = "btnAplicarDescuento";
            this.btnAplicarDescuento.Size = new System.Drawing.Size(106, 36);
            this.btnAplicarDescuento.TabIndex = 0;
            this.btnAplicarDescuento.Text = "Aplicar";
            this.btnAplicarDescuento.UseVisualStyleBackColor = true;
            // 
            // txtCondicion
            // 
            this.txtCondicion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCondicion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCondicion.Location = new System.Drawing.Point(182, 166);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(120, 27);
            this.txtCondicion.TabIndex = 9;
            // 
            // txtIva
            // 
            this.txtIva.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIva.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtIva.Location = new System.Drawing.Point(182, 126);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(120, 27);
            this.txtIva.TabIndex = 8;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLocalidad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtLocalidad.Location = new System.Drawing.Point(182, 86);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(120, 27);
            this.txtLocalidad.TabIndex = 7;
            // 
            // cboCliente
            // 
            this.cboCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(182, 49);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(120, 29);
            this.cboCliente.TabIndex = 5;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            this.cboCliente.TextChanged += new System.EventHandler(this.cboCliente_TextChanged);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDomicilio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDomicilio.Location = new System.Drawing.Point(182, 246);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(120, 27);
            this.txtDomicilio.TabIndex = 6;
            // 
            // txtCuit
            // 
            this.txtCuit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCuit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCuit.Location = new System.Drawing.Point(182, 206);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(120, 27);
            this.txtCuit.TabIndex = 11;
            // 
            // txtHorarioTransporte
            // 
            this.txtHorarioTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHorarioTransporte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtHorarioTransporte.Location = new System.Drawing.Point(164, 116);
            this.txtHorarioTransporte.Name = "txtHorarioTransporte";
            this.txtHorarioTransporte.Size = new System.Drawing.Size(143, 27);
            this.txtHorarioTransporte.TabIndex = 8;
            // 
            // txtTelefonoTransporte
            // 
            this.txtTelefonoTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTelefonoTransporte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTelefonoTransporte.Location = new System.Drawing.Point(164, 79);
            this.txtTelefonoTransporte.Name = "txtTelefonoTransporte";
            this.txtTelefonoTransporte.Size = new System.Drawing.Size(143, 27);
            this.txtTelefonoTransporte.TabIndex = 7;
            // 
            // txtDireccionTransporte
            // 
            this.txtDireccionTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDireccionTransporte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDireccionTransporte.Location = new System.Drawing.Point(164, 153);
            this.txtDireccionTransporte.Name = "txtDireccionTransporte";
            this.txtDireccionTransporte.Size = new System.Drawing.Size(143, 27);
            this.txtDireccionTransporte.TabIndex = 6;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescuento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDescuento.Location = new System.Drawing.Point(3, 51);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(87, 23);
            this.txtDescuento.TabIndex = 9;
            this.txtDescuento.Text = "0";
            // 
            // rbPorcentaje
            // 
            this.rbPorcentaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbPorcentaje.AutoSize = true;
            this.rbPorcentaje.Location = new System.Drawing.Point(3, 10);
            this.rbPorcentaje.Name = "rbPorcentaje";
            this.rbPorcentaje.Size = new System.Drawing.Size(87, 21);
            this.rbPorcentaje.TabIndex = 11;
            this.rbPorcentaje.TabStop = true;
            this.rbPorcentaje.Text = "Porcentaje";
            this.rbPorcentaje.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(110, 10);
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
            this.label3.Location = new System.Drawing.Point(782, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(782, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(782, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "$";
            // 
            // txtVerDesc
            // 
            this.txtVerDesc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtVerDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerDesc.Location = new System.Drawing.Point(807, 359);
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
            this.txtTotal.Location = new System.Drawing.Point(807, 396);
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
            this.txtSubTotal.Location = new System.Drawing.Point(807, 326);
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
            this.lblDescuento.Location = new System.Drawing.Point(678, 364);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(101, 21);
            this.lblDescuento.TabIndex = 36;
            this.lblDescuento.Text = "Descuentos";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(701, 329);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(77, 21);
            this.lblSubTotal.TabIndex = 35;
            this.lblSubTotal.Text = "Subtotal";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(716, 396);
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
            this.tableLayoutPanel4.Controls.Add(this.txtCondicion, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtIva, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtLocalidad, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtCuit, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.lblFechaDePedido, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtpFechaDePedido, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtDomicilio, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.cboCliente, 1, 1);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 49);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(305, 279);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Localidad:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "I.V.A::";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Condición de venta:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 209);
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
            this.lblFechaDePedido.Location = new System.Drawing.Point(3, 9);
            this.lblFechaDePedido.Name = "lblFechaDePedido";
            this.lblFechaDePedido.Size = new System.Drawing.Size(146, 21);
            this.lblFechaDePedido.TabIndex = 51;
            this.lblFechaDePedido.Text = "Fecha de Pedido:";
            // 
            // dtpFechaDePedido
            // 
            this.dtpFechaDePedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaDePedido.Location = new System.Drawing.Point(182, 6);
            this.dtpFechaDePedido.Name = "dtpFechaDePedido";
            this.dtpFechaDePedido.Size = new System.Drawing.Size(120, 27);
            this.dtpFechaDePedido.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Domicilio:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Señor/es:";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.25806F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.74194F));
            this.tableLayoutPanel5.Controls.Add(this.txtHorarioTransporte, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.txtTelefonoTransporte, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblFechaDeEntrega, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtDireccionTransporte, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.cboTransporte, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.dtpFechaDeEntrega, 1, 0);
            this.tableLayoutPanel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(353, 49);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(310, 185);
            this.tableLayoutPanel5.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Teléfono:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 21);
            this.label16.TabIndex = 3;
            this.label16.Text = "Horario:";
            // 
            // lblFechaDeEntrega
            // 
            this.lblFechaDeEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFechaDeEntrega.AutoSize = true;
            this.lblFechaDeEntrega.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeEntrega.Location = new System.Drawing.Point(3, 8);
            this.lblFechaDeEntrega.Name = "lblFechaDeEntrega";
            this.lblFechaDeEntrega.Size = new System.Drawing.Size(155, 21);
            this.lblFechaDeEntrega.TabIndex = 52;
            this.lblFechaDeEntrega.Text = "Fecha de Entrega:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transporte:";
            // 
            // cboTransporte
            // 
            this.cboTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboTransporte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboTransporte.FormattingEnabled = true;
            this.cboTransporte.Location = new System.Drawing.Point(164, 41);
            this.cboTransporte.Name = "cboTransporte";
            this.cboTransporte.Size = new System.Drawing.Size(143, 29);
            this.cboTransporte.TabIndex = 48;
            this.cboTransporte.SelectedIndexChanged += new System.EventHandler(this.cboTransporte_SelectedIndexChanged);
            this.cboTransporte.TextChanged += new System.EventHandler(this.cboTransporte_TextChanged);
            // 
            // dtpFechaDeEntrega
            // 
            this.dtpFechaDeEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaDeEntrega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaDeEntrega.Location = new System.Drawing.Point(164, 5);
            this.dtpFechaDeEntrega.Name = "dtpFechaDeEntrega";
            this.dtpFechaDeEntrega.Size = new System.Drawing.Size(143, 27);
            this.dtpFechaDeEntrega.TabIndex = 50;
            this.dtpFechaDeEntrega.Value = new System.DateTime(2022, 2, 19, 0, 0, 0, 0);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.66929F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.33071F));
            this.tableLayoutPanel2.Controls.Add(this.btnAplicarDescuento, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDescuento, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.rbPorcentaje, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbEfectivo, 1, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(719, 218);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(205, 84);
            this.tableLayoutPanel2.TabIndex = 47;
            // 
            // lblNumeroDeRemito
            // 
            this.lblNumeroDeRemito.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumeroDeRemito.AutoSize = true;
            this.lblNumeroDeRemito.Location = new System.Drawing.Point(3, 0);
            this.lblNumeroDeRemito.Name = "lblNumeroDeRemito";
            this.lblNumeroDeRemito.Size = new System.Drawing.Size(80, 31);
            this.lblNumeroDeRemito.TabIndex = 53;
            this.lblNumeroDeRemito.Text = "Núm. de Remito:";
            // 
            // txtNumeroDeRemito
            // 
            this.txtNumeroDeRemito.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumeroDeRemito.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNumeroDeRemito.Location = new System.Drawing.Point(107, 3);
            this.txtNumeroDeRemito.Name = "txtNumeroDeRemito";
            this.txtNumeroDeRemito.Size = new System.Drawing.Size(162, 27);
            this.txtNumeroDeRemito.TabIndex = 54;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCantidadProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCantidadProducto.Location = new System.Drawing.Point(107, 96);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(162, 27);
            this.txtCantidadProducto.TabIndex = 6;
            // 
            // cboProducto
            // 
            this.cboProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(107, 34);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(162, 29);
            this.cboProducto.TabIndex = 5;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            this.cboProducto.TextChanged += new System.EventHandler(this.cboProducto_TextChanged);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 21);
            this.label19.TabIndex = 2;
            this.label19.Text = "Precio:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 21);
            this.label18.TabIndex = 1;
            this.label18.Text = "Cantidad:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "Producto:";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrecioProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPrecioProducto.Location = new System.Drawing.Point(107, 65);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(162, 27);
            this.txtPrecioProducto.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.90476F));
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNumeroDeRemito, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumeroDeRemito, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCantidadProducto, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboProducto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPrecioProducto, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(681, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 146);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(366, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 23);
            this.lblTitulo.TabIndex = 49;
            this.lblTitulo.Text = "titulo";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(467, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 23);
            this.lblId.TabIndex = 50;
            this.lblId.Text = "Id";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(575, 9);
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
            this.dgvPedidoParcial.Location = new System.Drawing.Point(18, 334);
            this.dgvPedidoParcial.Name = "dgvPedidoParcial";
            this.dgvPedidoParcial.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPedidoParcial.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidoParcial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidoParcial.Size = new System.Drawing.Size(638, 110);
            this.dgvPedidoParcial.TabIndex = 70;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnActualizar.FlatAppearance.BorderSize = 2;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnActualizar.Location = new System.Drawing.Point(360, 246);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 45);
            this.btnActualizar.TabIndex = 71;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(518, 461);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 63);
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
            this.btnAgregarPedido.Location = new System.Drawing.Point(237, 461);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(98, 63);
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
            this.btnParcialPedido.Location = new System.Drawing.Point(561, 246);
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
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnParcialPedido);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvPedidoParcial);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel5);
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
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAplicarDescuento;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtHorarioTransporte;
        private System.Windows.Forms.TextBox txtTelefonoTransporte;
        private System.Windows.Forms.TextBox txtDireccionTransporte;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cboTransporte;
        private System.Windows.Forms.DateTimePicker dtpFechaDePedido;
        private System.Windows.Forms.DateTimePicker dtpFechaDeEntrega;
        private System.Windows.Forms.Label lblFechaDePedido;
        private System.Windows.Forms.Label lblFechaDeEntrega;
        private System.Windows.Forms.Label lblNumeroDeRemito;
        private System.Windows.Forms.TextBox txtNumeroDeRemito;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvPedidoParcial;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button btnParcialPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}