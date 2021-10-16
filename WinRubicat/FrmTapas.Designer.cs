namespace WinRubicat
{
    partial class FrmTapas
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
            this.cmbTapas = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTapas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(172, 151);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(142, 29);
            this.txtCantidad.TabIndex = 36;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPeso.Location = new System.Drawing.Point(37, 154);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(50, 21);
            this.lblPeso.TabIndex = 35;
            this.lblPeso.Text = "Costo";
            // 
            // cmbTapas
            // 
            this.cmbTapas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTapas.FormattingEnabled = true;
            this.cmbTapas.Items.AddRange(new object[] {
            "Diseño Clasic",
            "Diseño Premium",
            "Diseño Super Premium"});
            this.cmbTapas.Location = new System.Drawing.Point(172, 95);
            this.cmbTapas.Name = "cmbTapas";
            this.cmbTapas.Size = new System.Drawing.Size(142, 29);
            this.cmbTapas.TabIndex = 34;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(184, 279);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 40);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(32, 279);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 40);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblTapas
            // 
            this.lblTapas.AutoSize = true;
            this.lblTapas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTapas.Location = new System.Drawing.Point(37, 98);
            this.lblTapas.Name = "lblTapas";
            this.lblTapas.Size = new System.Drawing.Size(121, 21);
            this.lblTapas.TabIndex = 29;
            this.lblTapas.Text = "Diseño de Tapas";
            this.lblTapas.Click += new System.EventHandler(this.lblAromas_Click);
            // 
            // FrmTapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 343);
            this.ControlBox = false;
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.cmbTapas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTapas);
            this.Name = "FrmTapas";
            this.Text = "Ingresar Tapas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.ComboBox cmbTapas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTapas;
    }
}