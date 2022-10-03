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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransporte));
            this.txtDireccionTransporte = new System.Windows.Forms.TextBox();
            this.txtNombreTransporte = new System.Windows.Forms.TextBox();
            this.lblCaracterTransporte = new System.Windows.Forms.Label();
            this.lblDireccionTrasnporte = new System.Windows.Forms.Label();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.cmbCaracterTransporte = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIdTransporte = new System.Windows.Forms.Label();
            this.lblIdT = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDireccionTransporte
            // 
            this.txtDireccionTransporte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDireccionTransporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDireccionTransporte.Location = new System.Drawing.Point(196, 195);
            this.txtDireccionTransporte.Name = "txtDireccionTransporte";
            this.txtDireccionTransporte.Size = new System.Drawing.Size(142, 29);
            this.txtDireccionTransporte.TabIndex = 2;
            // 
            // txtNombreTransporte
            // 
            this.txtNombreTransporte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNombreTransporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombreTransporte.Location = new System.Drawing.Point(196, 141);
            this.txtNombreTransporte.Name = "txtNombreTransporte";
            this.txtNombreTransporte.Size = new System.Drawing.Size(142, 29);
            this.txtNombreTransporte.TabIndex = 1;
            this.txtNombreTransporte.TextChanged += new System.EventHandler(this.txtNombreDeposito_TextChanged);
            // 
            // lblCaracterTransporte
            // 
            this.lblCaracterTransporte.AutoSize = true;
            this.lblCaracterTransporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracterTransporte.Location = new System.Drawing.Point(102, 374);
            this.lblCaracterTransporte.Name = "lblCaracterTransporte";
            this.lblCaracterTransporte.Size = new System.Drawing.Size(82, 21);
            this.lblCaracterTransporte.TabIndex = 32;
            this.lblCaracterTransporte.Text = "Caracter";
            // 
            // lblDireccionTrasnporte
            // 
            this.lblDireccionTrasnporte.AutoSize = true;
            this.lblDireccionTrasnporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionTrasnporte.Location = new System.Drawing.Point(10, 198);
            this.lblDireccionTrasnporte.Name = "lblDireccionTrasnporte";
            this.lblDireccionTrasnporte.Size = new System.Drawing.Size(179, 21);
            this.lblDireccionTrasnporte.TabIndex = 31;
            this.lblDireccionTrasnporte.Text = "Direccion de locacion";
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransporte.Location = new System.Drawing.Point(10, 144);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(185, 21);
            this.lblTransporte.TabIndex = 30;
            this.lblTransporte.Text = "Nombre de Transporte";
            this.lblTransporte.Click += new System.EventHandler(this.lblDeposito_Click);
            // 
            // cmbCaracterTransporte
            // 
            this.cmbCaracterTransporte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbCaracterTransporte.DisplayMember = "Local";
            this.cmbCaracterTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCaracterTransporte.FormattingEnabled = true;
            this.cmbCaracterTransporte.Items.AddRange(new object[] {
            "Local",
            "Externo"});
            this.cmbCaracterTransporte.Location = new System.Drawing.Point(196, 374);
            this.cmbCaracterTransporte.Name = "cmbCaracterTransporte";
            this.cmbCaracterTransporte.Size = new System.Drawing.Size(142, 28);
            this.cmbCaracterTransporte.TabIndex = 5;
            this.cmbCaracterTransporte.ValueMember = "Local";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(87, 62);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(181, 19);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "Nombre de Transporte";
            // 
            // lblIdTransporte
            // 
            this.lblIdTransporte.AutoSize = true;
            this.lblIdTransporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTransporte.Location = new System.Drawing.Point(52, 98);
            this.lblIdTransporte.Name = "lblIdTransporte";
            this.lblIdTransporte.Size = new System.Drawing.Size(142, 21);
            this.lblIdTransporte.TabIndex = 40;
            this.lblIdTransporte.Text = "Id de Transporte:";
            this.lblIdTransporte.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIdT
            // 
            this.lblIdT.AutoSize = true;
            this.lblIdT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdT.Location = new System.Drawing.Point(192, 98);
            this.lblIdT.Name = "lblIdT";
            this.lblIdT.Size = new System.Drawing.Size(24, 21);
            this.lblIdT.TabIndex = 41;
            this.lblIdT.Text = "id";
            // 
            // txtHorario
            // 
            this.txtHorario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtHorario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHorario.Location = new System.Drawing.Point(196, 305);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(142, 29);
            this.txtHorario.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTelefono.Location = new System.Drawing.Point(196, 251);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(142, 29);
            this.txtTelefono.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Horario de Transporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Telefono de Transporte";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(196, 439);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 53);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregar.Location = new System.Drawing.Point(14, 439);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 53);
            this.btnAgregar.TabIndex = 46;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(91, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 509);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdT);
            this.Controls.Add(this.lblIdTransporte);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbCaracterTransporte);
            this.Controls.Add(this.txtDireccionTransporte);
            this.Controls.Add(this.txtNombreTransporte);
            this.Controls.Add(this.lblCaracterTransporte);
            this.Controls.Add(this.lblDireccionTrasnporte);
            this.Controls.Add(this.lblTransporte);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTransporte";
            this.Text = "Transportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDireccionTransporte;
        private System.Windows.Forms.TextBox txtNombreTransporte;
        private System.Windows.Forms.Label lblCaracterTransporte;
        private System.Windows.Forms.Label lblDireccionTrasnporte;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.ComboBox cmbCaracterTransporte;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIdTransporte;
        private System.Windows.Forms.Label lblIdT;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}