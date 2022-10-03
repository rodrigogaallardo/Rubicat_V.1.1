namespace WinRubicat
{
    partial class FrmIngresosStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresosStock));
            this.lblFechaDeIngreso = new System.Windows.Forms.Label();
            this.dtpFechaDeIngresoStock = new System.Windows.Forms.DateTimePicker();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.cmbSectorIngresos = new System.Windows.Forms.ComboBox();
            this.lblAromas = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblNombreDeposito = new System.Windows.Forms.Label();
            this.txtNombreDeposito = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCantidadMinima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaDeIngreso
            // 
            this.lblFechaDeIngreso.AutoSize = true;
            this.lblFechaDeIngreso.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFechaDeIngreso.Location = new System.Drawing.Point(24, 115);
            this.lblFechaDeIngreso.Name = "lblFechaDeIngreso";
            this.lblFechaDeIngreso.Size = new System.Drawing.Size(145, 21);
            this.lblFechaDeIngreso.TabIndex = 22;
            this.lblFechaDeIngreso.Text = "Fecha de Ingreso";
            // 
            // dtpFechaDeIngresoStock
            // 
            this.dtpFechaDeIngresoStock.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFechaDeIngresoStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFechaDeIngresoStock.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeIngresoStock.Location = new System.Drawing.Point(193, 109);
            this.dtpFechaDeIngresoStock.Name = "dtpFechaDeIngresoStock";
            this.dtpFechaDeIngresoStock.Size = new System.Drawing.Size(142, 29);
            this.dtpFechaDeIngresoStock.TabIndex = 23;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblIngresos.Location = new System.Drawing.Point(24, 321);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(146, 21);
            this.lblIngresos.TabIndex = 26;
            this.lblIngresos.Text = "Sector de Ingreso";
            // 
            // cmbSectorIngresos
            // 
            this.cmbSectorIngresos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbSectorIngresos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbSectorIngresos.FormattingEnabled = true;
            this.cmbSectorIngresos.Location = new System.Drawing.Point(193, 318);
            this.cmbSectorIngresos.Name = "cmbSectorIngresos";
            this.cmbSectorIngresos.Size = new System.Drawing.Size(142, 29);
            this.cmbSectorIngresos.TabIndex = 28;
            this.cmbSectorIngresos.SelectedIndexChanged += new System.EventHandler(this.cmbSectorIngresos_SelectedIndexChanged);
            this.cmbSectorIngresos.TextChanged += new System.EventHandler(this.cmbSectorIngresos_TextChanged);
            // 
            // lblAromas
            // 
            this.lblAromas.AutoSize = true;
            this.lblAromas.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblAromas.Location = new System.Drawing.Point(24, 147);
            this.lblAromas.Name = "lblAromas";
            this.lblAromas.Size = new System.Drawing.Size(108, 21);
            this.lblAromas.TabIndex = 29;
            this.lblAromas.Text = "Responsable";
            // 
            // txtResponsable
            // 
            this.txtResponsable.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtResponsable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtResponsable.Location = new System.Drawing.Point(193, 144);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(142, 29);
            this.txtResponsable.TabIndex = 30;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(193, 248);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(142, 29);
            this.txtCantidad.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(24, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 47;
            this.label7.Text = "Cantidad";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblCodigoProducto.Location = new System.Drawing.Point(24, 178);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(149, 21);
            this.lblCodigoProducto.TabIndex = 46;
            this.lblCodigoProducto.Text = "Cod. de Producto";
            // 
            // cboProducto
            // 
            this.cboProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(193, 178);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(142, 29);
            this.cboProducto.TabIndex = 45;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            this.cboProducto.TextChanged += new System.EventHandler(this.cboProducto_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblProducto.Location = new System.Drawing.Point(24, 216);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(82, 21);
            this.lblProducto.TabIndex = 49;
            this.lblProducto.Text = "Producto";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCodigoProducto.Location = new System.Drawing.Point(193, 213);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(142, 29);
            this.txtCodigoProducto.TabIndex = 50;
            // 
            // lblNombreDeposito
            // 
            this.lblNombreDeposito.AutoSize = true;
            this.lblNombreDeposito.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNombreDeposito.Location = new System.Drawing.Point(24, 356);
            this.lblNombreDeposito.Name = "lblNombreDeposito";
            this.lblNombreDeposito.Size = new System.Drawing.Size(171, 21);
            this.lblNombreDeposito.TabIndex = 51;
            this.lblNombreDeposito.Text = "Nombre de Deposito";
            // 
            // txtNombreDeposito
            // 
            this.txtNombreDeposito.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNombreDeposito.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombreDeposito.Location = new System.Drawing.Point(193, 353);
            this.txtNombreDeposito.Name = "txtNombreDeposito";
            this.txtNombreDeposito.Size = new System.Drawing.Size(142, 29);
            this.txtNombreDeposito.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(92, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(190, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 53);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregar.Location = new System.Drawing.Point(27, 393);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 57);
            this.btnAgregar.TabIndex = 56;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(117, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(141, 19);
            this.lblTitulo.TabIndex = 58;
            this.lblTitulo.Text = "Ingresos de Stock";
            // 
            // txtCantidadMinima
            // 
            this.txtCantidadMinima.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCantidadMinima.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCantidadMinima.Location = new System.Drawing.Point(193, 283);
            this.txtCantidadMinima.Name = "txtCantidadMinima";
            this.txtCantidadMinima.Size = new System.Drawing.Size(142, 29);
            this.txtCantidadMinima.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(24, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 53;
            this.label1.Text = "Cantidad Minima";
            // 
            // FrmIngresosStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 509);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCantidadMinima);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreDeposito);
            this.Controls.Add(this.lblNombreDeposito);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.lblAromas);
            this.Controls.Add(this.cmbSectorIngresos);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.dtpFechaDeIngresoStock);
            this.Controls.Add(this.lblFechaDeIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIngresosStock";
            this.Text = "Ingresos de Stock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblFechaDeIngreso;
    private System.Windows.Forms.DateTimePicker dtpFechaDeIngresoStock;
    private System.Windows.Forms.Label lblIngresos;
    private System.Windows.Forms.ComboBox cmbSectorIngresos;
    private System.Windows.Forms.Label lblAromas;
    private System.Windows.Forms.TextBox txtResponsable;
    private System.Windows.Forms.TextBox txtCantidad;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label lblCodigoProducto;
    private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblNombreDeposito;
        private System.Windows.Forms.TextBox txtNombreDeposito;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCantidadMinima;
        private System.Windows.Forms.Label label1;
    }
}