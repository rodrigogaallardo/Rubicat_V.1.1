namespace WinRubicat
{
    partial class FrmTransporte
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
            this.txtDireccionTransporte = new System.Windows.Forms.TextBox();
            this.txtNombreTransporte = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCaracterTransporte = new System.Windows.Forms.Label();
            this.lblDireccionTrasnporte = new System.Windows.Forms.Label();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.cmbCaracterTransporte = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIdTransporte = new System.Windows.Forms.Label();
            this.lblIdT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDireccionTransporte
            // 
            this.txtDireccionTransporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDireccionTransporte.Location = new System.Drawing.Point(200, 142);
            this.txtDireccionTransporte.Name = "txtDireccionTransporte";
            this.txtDireccionTransporte.Size = new System.Drawing.Size(142, 29);
            this.txtDireccionTransporte.TabIndex = 36;
            // 
            // txtNombreTransporte
            // 
            this.txtNombreTransporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombreTransporte.Location = new System.Drawing.Point(200, 88);
            this.txtNombreTransporte.Name = "txtNombreTransporte";
            this.txtNombreTransporte.Size = new System.Drawing.Size(142, 29);
            this.txtNombreTransporte.TabIndex = 35;
            this.txtNombreTransporte.TextChanged += new System.EventHandler(this.txtNombreDeposito_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(200, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 40);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(48, 289);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 40);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblCaracterTransporte
            // 
            this.lblCaracterTransporte.AutoSize = true;
            this.lblCaracterTransporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCaracterTransporte.Location = new System.Drawing.Point(106, 201);
            this.lblCaracterTransporte.Name = "lblCaracterTransporte";
            this.lblCaracterTransporte.Size = new System.Drawing.Size(68, 21);
            this.lblCaracterTransporte.TabIndex = 32;
            this.lblCaracterTransporte.Text = "Caracter";
            // 
            // lblDireccionTrasnporte
            // 
            this.lblDireccionTrasnporte.AutoSize = true;
            this.lblDireccionTrasnporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDireccionTrasnporte.Location = new System.Drawing.Point(14, 145);
            this.lblDireccionTrasnporte.Name = "lblDireccionTrasnporte";
            this.lblDireccionTrasnporte.Size = new System.Drawing.Size(160, 21);
            this.lblDireccionTrasnporte.TabIndex = 31;
            this.lblDireccionTrasnporte.Text = "Direccion de locacion:";
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTransporte.Location = new System.Drawing.Point(14, 91);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(170, 21);
            this.lblTransporte.TabIndex = 30;
            this.lblTransporte.Text = "Nombre de Transporte:";
            this.lblTransporte.Click += new System.EventHandler(this.lblDeposito_Click);
            // 
            // cmbCaracterTransporte
            // 
            this.cmbCaracterTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCaracterTransporte.FormattingEnabled = true;
            this.cmbCaracterTransporte.Items.AddRange(new object[] {
            "Local",
            "Externo"});
            this.cmbCaracterTransporte.Location = new System.Drawing.Point(200, 201);
            this.cmbCaracterTransporte.Name = "cmbCaracterTransporte";
            this.cmbCaracterTransporte.Size = new System.Drawing.Size(142, 28);
            this.cmbCaracterTransporte.TabIndex = 38;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTitulo.Location = new System.Drawing.Point(117, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 21);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "Nombre de Transporte";
            // 
            // lblIdTransporte
            // 
            this.lblIdTransporte.AutoSize = true;
            this.lblIdTransporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblIdTransporte.Location = new System.Drawing.Point(56, 45);
            this.lblIdTransporte.Name = "lblIdTransporte";
            this.lblIdTransporte.Size = new System.Drawing.Size(125, 21);
            this.lblIdTransporte.TabIndex = 40;
            this.lblIdTransporte.Text = "Id de Transporte:";
            this.lblIdTransporte.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIdT
            // 
            this.lblIdT.AutoSize = true;
            this.lblIdT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblIdT.Location = new System.Drawing.Point(196, 45);
            this.lblIdT.Name = "lblIdT";
            this.lblIdT.Size = new System.Drawing.Size(23, 21);
            this.lblIdT.TabIndex = 41;
            this.lblIdT.Text = "id";
            // 
            // FrmTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 349);
            this.ControlBox = false;
            this.Controls.Add(this.lblIdT);
            this.Controls.Add(this.lblIdTransporte);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbCaracterTransporte);
            this.Controls.Add(this.txtDireccionTransporte);
            this.Controls.Add(this.txtNombreTransporte);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCaracterTransporte);
            this.Controls.Add(this.lblDireccionTrasnporte);
            this.Controls.Add(this.lblTransporte);
            this.Name = "FrmTransporte";
            this.Text = "Transportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDireccionTransporte;
        private System.Windows.Forms.TextBox txtNombreTransporte;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCaracterTransporte;
        private System.Windows.Forms.Label lblDireccionTrasnporte;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.ComboBox cmbCaracterTransporte;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIdTransporte;
        private System.Windows.Forms.Label lblIdT;
    }
}