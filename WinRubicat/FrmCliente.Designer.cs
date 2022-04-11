namespace WinRubicat
{
    partial class FrmCliente
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
            System.Windows.Forms.Label lblMail;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRazSocial = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblIngBrutos = new System.Windows.Forms.Label();
            this.lblTipoIngB = new System.Windows.Forms.Label();
            this.lblDomFiscal = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRazSocial = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtIngBrutos = new System.Windows.Forms.TextBox();
            this.txtTipoIngB = new System.Windows.Forms.TextBox();
            this.txtDomFiscal = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cboZona = new System.Windows.Forms.ComboBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCondicionDeVenta = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblCondicionDeVenta = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTransporte = new System.Windows.Forms.ComboBox();
            this.txtHorarioDeAtencion = new System.Windows.Forms.TextBox();
            this.lblHorarioDeAtencion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            lblMail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMail.Location = new System.Drawing.Point(63, 403);
            lblMail.Name = "lblMail";
            lblMail.Size = new System.Drawing.Size(42, 21);
            lblMail.TabIndex = 23;
            lblMail.Text = "Mail";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(56, 84);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(136, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(56, 133);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRazSocial
            // 
            this.lblRazSocial.AutoSize = true;
            this.lblRazSocial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazSocial.Location = new System.Drawing.Point(56, 166);
            this.lblRazSocial.Name = "lblRazSocial";
            this.lblRazSocial.Size = new System.Drawing.Size(107, 21);
            this.lblRazSocial.TabIndex = 2;
            this.lblRazSocial.Text = "Razón Social";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(58, 199);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(47, 21);
            this.lblCuit.TabIndex = 3;
            this.lblCuit.Text = "CUIT";
            // 
            // lblIngBrutos
            // 
            this.lblIngBrutos.AutoSize = true;
            this.lblIngBrutos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngBrutos.Location = new System.Drawing.Point(56, 232);
            this.lblIngBrutos.Name = "lblIngBrutos";
            this.lblIngBrutos.Size = new System.Drawing.Size(124, 21);
            this.lblIngBrutos.TabIndex = 4;
            this.lblIngBrutos.Text = "Ingresos Brutos";
            // 
            // lblTipoIngB
            // 
            this.lblTipoIngB.AutoSize = true;
            this.lblTipoIngB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoIngB.Location = new System.Drawing.Point(58, 269);
            this.lblTipoIngB.Name = "lblTipoIngB";
            this.lblTipoIngB.Size = new System.Drawing.Size(185, 21);
            this.lblTipoIngB.TabIndex = 5;
            this.lblTipoIngB.Text = "Tipo de Ingresos Brutos";
            // 
            // lblDomFiscal
            // 
            this.lblDomFiscal.AutoSize = true;
            this.lblDomFiscal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomFiscal.Location = new System.Drawing.Point(58, 298);
            this.lblDomFiscal.Name = "lblDomFiscal";
            this.lblDomFiscal.Size = new System.Drawing.Size(124, 21);
            this.lblDomFiscal.TabIndex = 6;
            this.lblDomFiscal.Text = "Domicilio Fiscal";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(58, 370);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(76, 21);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZona.Location = new System.Drawing.Point(65, 570);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(49, 21);
            this.lblZona.TabIndex = 8;
            this.lblZona.Text = "Zona";
            // 
            // cboVendedor
            // 
            this.cboVendedor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(257, 534);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(288, 28);
            this.cboVendedor.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(257, 131);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(288, 27);
            this.txtNombre.TabIndex = 10;
            // 
            // txtRazSocial
            // 
            this.txtRazSocial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRazSocial.Location = new System.Drawing.Point(257, 164);
            this.txtRazSocial.Name = "txtRazSocial";
            this.txtRazSocial.Size = new System.Drawing.Size(288, 27);
            this.txtRazSocial.TabIndex = 11;
            // 
            // txtCuit
            // 
            this.txtCuit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCuit.Location = new System.Drawing.Point(257, 197);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(288, 27);
            this.txtCuit.TabIndex = 12;
            // 
            // txtIngBrutos
            // 
            this.txtIngBrutos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtIngBrutos.Location = new System.Drawing.Point(257, 230);
            this.txtIngBrutos.Name = "txtIngBrutos";
            this.txtIngBrutos.Size = new System.Drawing.Size(288, 27);
            this.txtIngBrutos.TabIndex = 13;
            // 
            // txtTipoIngB
            // 
            this.txtTipoIngB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTipoIngB.Location = new System.Drawing.Point(257, 263);
            this.txtTipoIngB.Name = "txtTipoIngB";
            this.txtTipoIngB.Size = new System.Drawing.Size(288, 27);
            this.txtTipoIngB.TabIndex = 14;
            // 
            // txtDomFiscal
            // 
            this.txtDomFiscal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDomFiscal.Location = new System.Drawing.Point(257, 296);
            this.txtDomFiscal.Name = "txtDomFiscal";
            this.txtDomFiscal.Size = new System.Drawing.Size(288, 27);
            this.txtDomFiscal.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTelefono.Location = new System.Drawing.Point(257, 368);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(288, 27);
            this.txtTelefono.TabIndex = 16;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(63, 536);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(88, 21);
            this.lblVendedor.TabIndex = 18;
            this.lblVendedor.Text = "Vendedor";
            // 
            // cboZona
            // 
            this.cboZona.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboZona.FormattingEnabled = true;
            this.cboZona.Location = new System.Drawing.Point(257, 568);
            this.cboZona.Name = "cboZona";
            this.cboZona.Size = new System.Drawing.Size(288, 28);
            this.cboZona.TabIndex = 21;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(383, 84);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(44, 21);
            this.lblCod.TabIndex = 22;
            this.lblCod.Text = "Cod";
            // 
            // txtCondicionDeVenta
            // 
            this.txtCondicionDeVenta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCondicionDeVenta.Location = new System.Drawing.Point(257, 434);
            this.txtCondicionDeVenta.Name = "txtCondicionDeVenta";
            this.txtCondicionDeVenta.Size = new System.Drawing.Size(288, 27);
            this.txtCondicionDeVenta.TabIndex = 28;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtLocalidad.Location = new System.Drawing.Point(257, 329);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(288, 27);
            this.txtLocalidad.TabIndex = 27;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtMail.Location = new System.Drawing.Point(257, 401);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(288, 27);
            this.txtMail.TabIndex = 26;
            // 
            // lblCondicionDeVenta
            // 
            this.lblCondicionDeVenta.AutoSize = true;
            this.lblCondicionDeVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionDeVenta.Location = new System.Drawing.Point(63, 436);
            this.lblCondicionDeVenta.Name = "lblCondicionDeVenta";
            this.lblCondicionDeVenta.Size = new System.Drawing.Size(167, 21);
            this.lblCondicionDeVenta.TabIndex = 25;
            this.lblCondicionDeVenta.Text = "Condición de venta";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(58, 331);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(87, 21);
            this.lblLocalidad.TabIndex = 24;
            this.lblLocalidad.Text = "Localidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Transporte";
            // 
            // cboTransporte
            // 
            this.cboTransporte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboTransporte.FormattingEnabled = true;
            this.cboTransporte.Location = new System.Drawing.Point(257, 500);
            this.cboTransporte.Name = "cboTransporte";
            this.cboTransporte.Size = new System.Drawing.Size(288, 28);
            this.cboTransporte.TabIndex = 29;
            // 
            // txtHorarioDeAtencion
            // 
            this.txtHorarioDeAtencion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtHorarioDeAtencion.Location = new System.Drawing.Point(257, 467);
            this.txtHorarioDeAtencion.Name = "txtHorarioDeAtencion";
            this.txtHorarioDeAtencion.Size = new System.Drawing.Size(288, 27);
            this.txtHorarioDeAtencion.TabIndex = 32;
            // 
            // lblHorarioDeAtencion
            // 
            this.lblHorarioDeAtencion.AutoSize = true;
            this.lblHorarioDeAtencion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioDeAtencion.Location = new System.Drawing.Point(65, 469);
            this.lblHorarioDeAtencion.Name = "lblHorarioDeAtencion";
            this.lblHorarioDeAtencion.Size = new System.Drawing.Size(165, 21);
            this.lblHorarioDeAtencion.TabIndex = 31;
            this.lblHorarioDeAtencion.Text = "Horario de atención";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(189, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.btnCancelar.Location = new System.Drawing.Point(303, 602);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 63);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.btnAgregar.Location = new System.Drawing.Point(122, 602);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 63);
            this.btnAgregar.TabIndex = 52;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(597, 669);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtHorarioDeAtencion);
            this.Controls.Add(this.lblHorarioDeAtencion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTransporte);
            this.Controls.Add(this.txtCondicionDeVenta);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblCondicionDeVenta);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(lblMail);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.cboZona);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDomFiscal);
            this.Controls.Add(this.txtTipoIngB);
            this.Controls.Add(this.txtIngBrutos);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtRazSocial);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboVendedor);
            this.Controls.Add(this.lblZona);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDomFiscal);
            this.Controls.Add(this.lblTipoIngB);
            this.Controls.Add(this.lblIngBrutos);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblRazSocial);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRazSocial;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblIngBrutos;
        private System.Windows.Forms.Label lblTipoIngB;
        private System.Windows.Forms.Label lblDomFiscal;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRazSocial;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtIngBrutos;
        private System.Windows.Forms.TextBox txtTipoIngB;
        private System.Windows.Forms.TextBox txtDomFiscal;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cboZona;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtCondicionDeVenta;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblCondicionDeVenta;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTransporte;
        private System.Windows.Forms.TextBox txtHorarioDeAtencion;
        private System.Windows.Forms.Label lblHorarioDeAtencion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
    }
}