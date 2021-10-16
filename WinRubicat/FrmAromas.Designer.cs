namespace WinRubicat
{
    partial class FrmAromas
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.cmbAromas = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblAromas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(197, 151);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(142, 29);
            this.txtCantidad.TabIndex = 24;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPeso.Location = new System.Drawing.Point(62, 154);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(50, 21);
            this.lblPeso.TabIndex = 23;
            this.lblPeso.Text = "Costo";
            // 
            // cmbAromas
            // 
            this.cmbAromas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbAromas.FormattingEnabled = true;
            this.cmbAromas.Items.AddRange(new object[] {
            "Lavanda"});
            this.cmbAromas.Location = new System.Drawing.Point(197, 95);
            this.cmbAromas.Name = "cmbAromas";
            this.cmbAromas.Size = new System.Drawing.Size(142, 29);
            this.cmbAromas.TabIndex = 22;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(207, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 40);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(55, 277);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 40);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblAromas
            // 
            this.lblAromas.AutoSize = true;
            this.lblAromas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAromas.Location = new System.Drawing.Point(62, 98);
            this.lblAromas.Name = "lblAromas";
            this.lblAromas.Size = new System.Drawing.Size(64, 21);
            this.lblAromas.TabIndex = 13;
            this.lblAromas.Text = "Aromas";
            // 
            // FrmAromas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 350);
            this.ControlBox = false;
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.cmbAromas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblAromas);
            this.Name = "FrmAromas";
            this.Text = "Ingresar Aromas";
            this.Load += new System.EventHandler(this.FrmAromas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.ComboBox cmbAromas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblAromas;
    }
}