namespace WinRubicat
{
    partial class FrmConsultasMateriasPrimas
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
            this.dgvStockMateriasPrimas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregarMateriaPrima = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMateriasPrimas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockMateriasPrimas
            // 
            this.dgvStockMateriasPrimas.AllowUserToAddRows = false;
            this.dgvStockMateriasPrimas.AllowUserToDeleteRows = false;
            this.dgvStockMateriasPrimas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockMateriasPrimas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockMateriasPrimas.Location = new System.Drawing.Point(10, 10);
            this.dgvStockMateriasPrimas.Name = "dgvStockMateriasPrimas";
            this.dgvStockMateriasPrimas.Size = new System.Drawing.Size(593, 303);
            this.dgvStockMateriasPrimas.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalir.Location = new System.Drawing.Point(611, 273);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 40);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBorrar.Location = new System.Drawing.Point(609, 56);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(114, 40);
            this.btnBorrar.TabIndex = 23;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnModificar.Location = new System.Drawing.Point(611, 10);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 40);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMateriaPrima
            // 
            this.btnAgregarMateriaPrima.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateriaPrima.Location = new System.Drawing.Point(609, 102);
            this.btnAgregarMateriaPrima.Name = "btnAgregarMateriaPrima";
            this.btnAgregarMateriaPrima.Size = new System.Drawing.Size(114, 54);
            this.btnAgregarMateriaPrima.TabIndex = 26;
            this.btnAgregarMateriaPrima.Text = "Agregar Materia Prima";
            this.btnAgregarMateriaPrima.UseVisualStyleBackColor = true;
            // 
            // FrmConsultasMateriasPrimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 323);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregarMateriaPrima);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvStockMateriasPrimas);
            this.Name = "FrmConsultasMateriasPrimas";
            this.Text = "Materias Primas ";
            this.Load += new System.EventHandler(this.FrmConsultasMateriasPrimas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMateriasPrimas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockMateriasPrimas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregarMateriaPrima;
    }
}