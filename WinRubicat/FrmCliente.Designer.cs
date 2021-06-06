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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboZona = new System.Windows.Forms.ComboBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(44, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(113, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(44, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRazSocial
            // 
            this.lblRazSocial.AutoSize = true;
            this.lblRazSocial.Location = new System.Drawing.Point(44, 117);
            this.lblRazSocial.Name = "lblRazSocial";
            this.lblRazSocial.Size = new System.Drawing.Size(94, 20);
            this.lblRazSocial.TabIndex = 2;
            this.lblRazSocial.Text = "Razón Social";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(44, 162);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(40, 20);
            this.lblCuit.TabIndex = 3;
            this.lblCuit.Text = "CUIT";
            // 
            // lblIngBrutos
            // 
            this.lblIngBrutos.AutoSize = true;
            this.lblIngBrutos.Location = new System.Drawing.Point(44, 204);
            this.lblIngBrutos.Name = "lblIngBrutos";
            this.lblIngBrutos.Size = new System.Drawing.Size(110, 20);
            this.lblIngBrutos.TabIndex = 4;
            this.lblIngBrutos.Text = "Ingresos Brutos";
            // 
            // lblTipoIngB
            // 
            this.lblTipoIngB.AutoSize = true;
            this.lblTipoIngB.Location = new System.Drawing.Point(44, 259);
            this.lblTipoIngB.Name = "lblTipoIngB";
            this.lblTipoIngB.Size = new System.Drawing.Size(165, 20);
            this.lblTipoIngB.TabIndex = 5;
            this.lblTipoIngB.Text = "Tipo de Ingresos Brutos";
            // 
            // lblDomFiscal
            // 
            this.lblDomFiscal.AutoSize = true;
            this.lblDomFiscal.Location = new System.Drawing.Point(44, 307);
            this.lblDomFiscal.Name = "lblDomFiscal";
            this.lblDomFiscal.Size = new System.Drawing.Size(114, 20);
            this.lblDomFiscal.TabIndex = 6;
            this.lblDomFiscal.Text = "Domicilio Fiscal";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(44, 359);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 20);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(44, 464);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(43, 20);
            this.lblZona.TabIndex = 8;
            this.lblZona.Text = "Zona";
            // 
            // cboVendedor
            // 
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(245, 409);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(288, 28);
            this.cboVendedor.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(245, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(288, 27);
            this.txtNombre.TabIndex = 10;
            // 
            // txtRazSocial
            // 
            this.txtRazSocial.Location = new System.Drawing.Point(245, 114);
            this.txtRazSocial.Name = "txtRazSocial";
            this.txtRazSocial.Size = new System.Drawing.Size(288, 27);
            this.txtRazSocial.TabIndex = 11;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(245, 159);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(288, 27);
            this.txtCuit.TabIndex = 12;
            // 
            // txtIngBrutos
            // 
            this.txtIngBrutos.Location = new System.Drawing.Point(245, 201);
            this.txtIngBrutos.Name = "txtIngBrutos";
            this.txtIngBrutos.Size = new System.Drawing.Size(288, 27);
            this.txtIngBrutos.TabIndex = 13;
            // 
            // txtTipoIngB
            // 
            this.txtTipoIngB.Location = new System.Drawing.Point(245, 256);
            this.txtTipoIngB.Name = "txtTipoIngB";
            this.txtTipoIngB.Size = new System.Drawing.Size(288, 27);
            this.txtTipoIngB.TabIndex = 14;
            // 
            // txtDomFiscal
            // 
            this.txtDomFiscal.Location = new System.Drawing.Point(245, 304);
            this.txtDomFiscal.Name = "txtDomFiscal";
            this.txtDomFiscal.Size = new System.Drawing.Size(288, 27);
            this.txtDomFiscal.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(245, 356);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(288, 27);
            this.txtTelefono.TabIndex = 16;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(44, 412);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(73, 20);
            this.lblVendedor.TabIndex = 18;
            this.lblVendedor.Text = "Vendedor";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(168, 508);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 35);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(401, 508);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cboZona
            // 
            this.cboZona.FormattingEnabled = true;
            this.cboZona.Location = new System.Drawing.Point(245, 461);
            this.cboZona.Name = "cboZona";
            this.cboZona.Size = new System.Drawing.Size(288, 28);
            this.cboZona.TabIndex = 21;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(283, 25);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(36, 20);
            this.lblCod.TabIndex = 22;
            this.lblCod.Text = "Cod";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 559);
            this.ControlBox = false;
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.cboZona);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboZona;
        private System.Windows.Forms.Label lblCod;
    }
}