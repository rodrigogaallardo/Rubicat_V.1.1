namespace WinRubicat
{
    partial class FrmModificar
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
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCosto.Location = new System.Drawing.Point(184, 125);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(142, 29);
            this.txtCosto.TabIndex = 30;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPeso.Location = new System.Drawing.Point(49, 128);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(50, 21);
            this.lblPeso.TabIndex = 29;
            this.lblPeso.Text = "Costo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(194, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 40);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnModificar.Location = new System.Drawing.Point(42, 231);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 40);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNombreArticulo.Location = new System.Drawing.Point(31, 72);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(147, 21);
            this.lblNombreArticulo.TabIndex = 25;
            this.lblNombreArticulo.Text = "Nombre de Articulo";
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombreArticulo.Location = new System.Drawing.Point(184, 69);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(142, 29);
            this.txtNombreArticulo.TabIndex = 31;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCodigo.Location = new System.Drawing.Point(240, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(38, 21);
            this.lblCodigo.TabIndex = 32;
            this.lblCodigo.Text = "Cod";
            // 
            // FrmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 338);
            this.ControlBox = false;
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblNombreArticulo);
            this.Name = "FrmModificar";
            this.ShowInTaskbar = false;
            this.Text = "Modificar Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.Label lblCodigo;
    }
}