namespace WinRubicat
{
    partial class FrmPackaging
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
            this.lblDiseñoDeEtiqueta = new System.Windows.Forms.Label();
            this.cmbModeloDeBidon = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiseñoDeEtiqueta
            // 
            this.lblDiseñoDeEtiqueta.AutoSize = true;
            this.lblDiseñoDeEtiqueta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDiseñoDeEtiqueta.Location = new System.Drawing.Point(32, 87);
            this.lblDiseñoDeEtiqueta.Name = "lblDiseñoDeEtiqueta";
            this.lblDiseñoDeEtiqueta.Size = new System.Drawing.Size(128, 21);
            this.lblDiseñoDeEtiqueta.TabIndex = 12;
            this.lblDiseñoDeEtiqueta.Text = "Modelo de Bidon";
            // 
            // cmbModeloDeBidon
            // 
            this.cmbModeloDeBidon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbModeloDeBidon.FormattingEnabled = true;
            this.cmbModeloDeBidon.Items.AddRange(new object[] {
            "Modelo de Bidon Classic",
            "Modelo de Bidon Premium",
            "Modelo de Bidon Super Premium"});
            this.cmbModeloDeBidon.Location = new System.Drawing.Point(185, 84);
            this.cmbModeloDeBidon.Name = "cmbModeloDeBidon";
            this.cmbModeloDeBidon.Size = new System.Drawing.Size(142, 29);
            this.cmbModeloDeBidon.TabIndex = 16;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(35, 271);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 40);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(198, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 40);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(185, 152);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(142, 29);
            this.txtCantidad.TabIndex = 23;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCantidad.Location = new System.Drawing.Point(34, 155);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(50, 21);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Costo";
            // 
            // FrmPackaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 350);
            this.ControlBox = false;
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbModeloDeBidon);
            this.Controls.Add(this.lblDiseñoDeEtiqueta);
            this.Name = "FrmPackaging";
            this.Text = "Ingreso de Packaging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDiseñoDeEtiqueta;
        private System.Windows.Forms.ComboBox cmbModeloDeBidon;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
    }
}