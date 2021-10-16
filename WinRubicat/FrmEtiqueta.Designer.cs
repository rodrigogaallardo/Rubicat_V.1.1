namespace WinRubicat
{
    partial class FrmEtiqueta
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
            this.cmbDiseñoDeEtiqueta = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDiseñoDeEtiqueta
            // 
            this.lblDiseñoDeEtiqueta.AutoSize = true;
            this.lblDiseñoDeEtiqueta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDiseñoDeEtiqueta.Location = new System.Drawing.Point(34, 85);
            this.lblDiseñoDeEtiqueta.Name = "lblDiseñoDeEtiqueta";
            this.lblDiseñoDeEtiqueta.Size = new System.Drawing.Size(139, 21);
            this.lblDiseñoDeEtiqueta.TabIndex = 11;
            this.lblDiseñoDeEtiqueta.Text = "Diseño de etiqueta";
            // 
            // cmbDiseñoDeEtiqueta
            // 
            this.cmbDiseñoDeEtiqueta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbDiseñoDeEtiqueta.FormattingEnabled = true;
            this.cmbDiseñoDeEtiqueta.Items.AddRange(new object[] {
            "Diseño Classic",
            "Diseño Classic Lavanda",
            "Diseño Premium",
            "Diseño Super Premium"});
            this.cmbDiseñoDeEtiqueta.Location = new System.Drawing.Point(185, 85);
            this.cmbDiseñoDeEtiqueta.Name = "cmbDiseñoDeEtiqueta";
            this.cmbDiseñoDeEtiqueta.Size = new System.Drawing.Size(142, 29);
            this.cmbDiseñoDeEtiqueta.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(26, 289);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 40);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(190, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 40);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCantidad.Location = new System.Drawing.Point(34, 184);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(47, 21);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.Text = "costo";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(185, 181);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(142, 29);
            this.txtCantidad.TabIndex = 21;
            // 
            // FrmEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 350);
            this.ControlBox = false;
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbDiseñoDeEtiqueta);
            this.Controls.Add(this.lblDiseñoDeEtiqueta);
            this.Name = "FrmEtiqueta";
            this.Text = "Ingreso de Etiquetas";
            this.Load += new System.EventHandler(this.FrmEtiqueta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDiseñoDeEtiqueta;
        private System.Windows.Forms.ComboBox cmbDiseñoDeEtiqueta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}