namespace WinRubicat
{
    partial class FrmConsultaDeposito
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
            this.dgvDepositos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregarDeposito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepositos
            // 
            this.dgvDepositos.AllowUserToAddRows = false;
            this.dgvDepositos.AllowUserToDeleteRows = false;
            this.dgvDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositos.Location = new System.Drawing.Point(12, 24);
            this.dgvDepositos.Name = "dgvDepositos";
            this.dgvDepositos.Size = new System.Drawing.Size(595, 320);
            this.dgvDepositos.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalir.Location = new System.Drawing.Point(613, 304);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 40);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnModificar.Location = new System.Drawing.Point(613, 24);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 40);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBorrar.Location = new System.Drawing.Point(613, 79);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(114, 40);
            this.btnBorrar.TabIndex = 25;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDeposito
            // 
            this.btnAgregarDeposito.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAgregarDeposito.Location = new System.Drawing.Point(613, 139);
            this.btnAgregarDeposito.Name = "btnAgregarDeposito";
            this.btnAgregarDeposito.Size = new System.Drawing.Size(114, 54);
            this.btnAgregarDeposito.TabIndex = 27;
            this.btnAgregarDeposito.Text = "Agregar Deposito";
            this.btnAgregarDeposito.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 366);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregarDeposito);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDepositos);
            this.Name = "FrmConsultaDeposito";
            this.Text = "Depositos";
            this.Load += new System.EventHandler(this.FrmConsultaDeposito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepositos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregarDeposito;
    }
}