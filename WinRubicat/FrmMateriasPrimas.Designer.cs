namespace WinRubicat
{
    partial class FrmMateriasPrimas
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMateriasPrimas = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCostos = new System.Windows.Forms.TextBox();
            this.cmbMateriasPrimas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(72, 238);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 40);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(271, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblMateriasPrimas
            // 
            this.lblMateriasPrimas.AutoSize = true;
            this.lblMateriasPrimas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMateriasPrimas.Location = new System.Drawing.Point(12, 62);
            this.lblMateriasPrimas.Name = "lblMateriasPrimas";
            this.lblMateriasPrimas.Size = new System.Drawing.Size(191, 21);
            this.lblMateriasPrimas.TabIndex = 9;
            this.lblMateriasPrimas.Text = "Nombre de Materia Prima";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCantidad.Location = new System.Drawing.Point(131, 157);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(50, 21);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Costo";
            // 
            // txtCostos
            // 
            this.txtCostos.Location = new System.Drawing.Point(234, 158);
            this.txtCostos.Name = "txtCostos";
            this.txtCostos.Size = new System.Drawing.Size(170, 20);
            this.txtCostos.TabIndex = 14;
            // 
            // cmbMateriasPrimas
            // 
            this.cmbMateriasPrimas.FormattingEnabled = true;
            this.cmbMateriasPrimas.Items.AddRange(new object[] {
            "Arena Sanitaria Rubicat Classic",
            "Arena Sanitaria Rubicat Premium",
            "Arena Sanitaria Rubicat Super Premium"});
            this.cmbMateriasPrimas.Location = new System.Drawing.Point(234, 65);
            this.cmbMateriasPrimas.Name = "cmbMateriasPrimas";
            this.cmbMateriasPrimas.Size = new System.Drawing.Size(170, 21);
            this.cmbMateriasPrimas.TabIndex = 15;
            // 
            // FrmMateriasPrimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 337);
            this.ControlBox = false;
            this.Controls.Add(this.cmbMateriasPrimas);
            this.Controls.Add(this.txtCostos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblMateriasPrimas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmMateriasPrimas";
            this.Text = "Materias Primas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMateriasPrimas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCostos;
        private System.Windows.Forms.ComboBox cmbMateriasPrimas;
    }
}