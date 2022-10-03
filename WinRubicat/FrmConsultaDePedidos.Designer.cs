
namespace WinRubicat
{
    partial class FrmConsultaDePedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaDePedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPedidosPendientes = new System.Windows.Forms.Label();
            this.lblPedidosAprobados = new System.Windows.Forms.Label();
            this.dtpFechaDePedido = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDeEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroDeRemito = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIdTransporte = new System.Windows.Forms.TextBox();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptarPedido = new System.Windows.Forms.Button();
            this.btnBorrarPedido = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.dgvConsultaDePedidos = new System.Windows.Forms.DataGridView();
            this.dgvAprobados = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDePedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprobados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedidosPendientes
            // 
            this.lblPedidosPendientes.AutoSize = true;
            this.lblPedidosPendientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidosPendientes.Location = new System.Drawing.Point(186, 15);
            this.lblPedidosPendientes.Name = "lblPedidosPendientes";
            this.lblPedidosPendientes.Size = new System.Drawing.Size(277, 23);
            this.lblPedidosPendientes.TabIndex = 50;
            this.lblPedidosPendientes.Text = "Tabla de Pedidos Pendientes";
            this.lblPedidosPendientes.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPedidosAprobados
            // 
            this.lblPedidosAprobados.AutoSize = true;
            this.lblPedidosAprobados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidosAprobados.Location = new System.Drawing.Point(207, 335);
            this.lblPedidosAprobados.Name = "lblPedidosAprobados";
            this.lblPedidosAprobados.Size = new System.Drawing.Size(280, 23);
            this.lblPedidosAprobados.TabIndex = 51;
            this.lblPedidosAprobados.Text = "Tabla de Pedidos Aprobados";
            // 
            // dtpFechaDePedido
            // 
            this.dtpFechaDePedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaDePedido.Location = new System.Drawing.Point(12, 275);
            this.dtpFechaDePedido.Name = "dtpFechaDePedido";
            this.dtpFechaDePedido.Size = new System.Drawing.Size(162, 20);
            this.dtpFechaDePedido.TabIndex = 52;
            this.dtpFechaDePedido.Visible = false;
            // 
            // dtpFechaDeEntrega
            // 
            this.dtpFechaDeEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaDeEntrega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaDeEntrega.Location = new System.Drawing.Point(180, 275);
            this.dtpFechaDeEntrega.Name = "dtpFechaDeEntrega";
            this.dtpFechaDeEntrega.Size = new System.Drawing.Size(184, 20);
            this.dtpFechaDeEntrega.TabIndex = 53;
            this.dtpFechaDeEntrega.Value = new System.DateTime(2022, 2, 19, 0, 0, 0, 0);
            this.dtpFechaDeEntrega.Visible = false;
            // 
            // txtNumeroDeRemito
            // 
            this.txtNumeroDeRemito.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumeroDeRemito.Location = new System.Drawing.Point(370, 275);
            this.txtNumeroDeRemito.Name = "txtNumeroDeRemito";
            this.txtNumeroDeRemito.Size = new System.Drawing.Size(162, 20);
            this.txtNumeroDeRemito.TabIndex = 55;
            this.txtNumeroDeRemito.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTotal.Location = new System.Drawing.Point(538, 299);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 59;
            this.txtTotal.Text = "0";
            this.txtTotal.Visible = false;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIdCliente.Location = new System.Drawing.Point(12, 302);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(162, 20);
            this.txtIdCliente.TabIndex = 60;
            this.txtIdCliente.Visible = false;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIdProducto.Location = new System.Drawing.Point(180, 302);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(184, 20);
            this.txtIdProducto.TabIndex = 61;
            this.txtIdProducto.Visible = false;
            // 
            // txtIdTransporte
            // 
            this.txtIdTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIdTransporte.Location = new System.Drawing.Point(370, 302);
            this.txtIdTransporte.Name = "txtIdTransporte";
            this.txtIdTransporte.Size = new System.Drawing.Size(162, 20);
            this.txtIdTransporte.TabIndex = 62;
            this.txtIdTransporte.Visible = false;
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificarPedido.FlatAppearance.BorderSize = 2;
            this.btnModificarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnModificarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificarPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarPedido.Image")));
            this.btnModificarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificarPedido.Location = new System.Drawing.Point(655, 40);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(114, 53);
            this.btnModificarPedido.TabIndex = 64;
            this.btnModificarPedido.Text = "Editar";
            this.btnModificarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarPedido.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalir.Location = new System.Drawing.Point(655, 516);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 53);
            this.btnSalir.TabIndex = 68;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnAceptarPedido
            // 
            this.btnAceptarPedido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAceptarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptarPedido.FlatAppearance.BorderSize = 2;
            this.btnAceptarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAceptarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAceptarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAceptarPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarPedido.Image")));
            this.btnAceptarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAceptarPedido.Location = new System.Drawing.Point(655, 196);
            this.btnAceptarPedido.Name = "btnAceptarPedido";
            this.btnAceptarPedido.Size = new System.Drawing.Size(114, 53);
            this.btnAceptarPedido.TabIndex = 67;
            this.btnAceptarPedido.Text = "Pedido";
            this.btnAceptarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarPedido.UseVisualStyleBackColor = false;
            // 
            // btnBorrarPedido
            // 
            this.btnBorrarPedido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBorrarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrarPedido.FlatAppearance.BorderSize = 2;
            this.btnBorrarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBorrarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBorrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBorrarPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarPedido.Image")));
            this.btnBorrarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBorrarPedido.Location = new System.Drawing.Point(655, 119);
            this.btnBorrarPedido.Name = "btnBorrarPedido";
            this.btnBorrarPedido.Size = new System.Drawing.Size(114, 53);
            this.btnBorrarPedido.TabIndex = 66;
            this.btnBorrarPedido.Text = "Eliminar";
            this.btnBorrarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrarPedido.UseVisualStyleBackColor = false;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarExcel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExportarExcel.FlatAppearance.BorderSize = 2;
            this.btnExportarExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnExportarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarExcel.Location = new System.Drawing.Point(655, 432);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(114, 53);
            this.btnExportarExcel.TabIndex = 63;
            this.btnExportarExcel.Text = "Exportar";
            this.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // dgvConsultaDePedidos
            // 
            this.dgvConsultaDePedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultaDePedidos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvConsultaDePedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultaDePedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvConsultaDePedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaDePedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaDePedidos.ColumnHeadersHeight = 45;
            this.dgvConsultaDePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaDePedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaDePedidos.EnableHeadersVisualStyles = false;
            this.dgvConsultaDePedidos.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvConsultaDePedidos.Location = new System.Drawing.Point(12, 40);
            this.dgvConsultaDePedidos.Name = "dgvConsultaDePedidos";
            this.dgvConsultaDePedidos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsultaDePedidos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultaDePedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaDePedidos.Size = new System.Drawing.Size(629, 219);
            this.dgvConsultaDePedidos.TabIndex = 69;
            // 
            // dgvAprobados
            // 
            this.dgvAprobados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAprobados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAprobados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAprobados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAprobados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAprobados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAprobados.ColumnHeadersHeight = 45;
            this.dgvAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAprobados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAprobados.EnableHeadersVisualStyles = false;
            this.dgvAprobados.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAprobados.Location = new System.Drawing.Point(20, 360);
            this.dgvAprobados.Name = "dgvAprobados";
            this.dgvAprobados.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAprobados.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAprobados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAprobados.Size = new System.Drawing.Size(629, 219);
            this.dgvAprobados.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(236, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConsultaDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(775, 605);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAprobados);
            this.Controls.Add(this.dgvConsultaDePedidos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptarPedido);
            this.Controls.Add(this.btnBorrarPedido);
            this.Controls.Add(this.btnModificarPedido);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.txtIdTransporte);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNumeroDeRemito);
            this.Controls.Add(this.dtpFechaDeEntrega);
            this.Controls.Add(this.dtpFechaDePedido);
            this.Controls.Add(this.lblPedidosAprobados);
            this.Controls.Add(this.lblPedidosPendientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaDePedidos";
            this.Text = "Consulta de Pedidos";
            this.Load += new System.EventHandler(this.FrmConsultaDePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDePedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprobados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPedidosPendientes;
        private System.Windows.Forms.Label lblPedidosAprobados;
        private System.Windows.Forms.DateTimePicker dtpFechaDePedido;
        private System.Windows.Forms.DateTimePicker dtpFechaDeEntrega;
        private System.Windows.Forms.TextBox txtNumeroDeRemito;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdTransporte;
        private System.Windows.Forms.Button btnModificarPedido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptarPedido;
        private System.Windows.Forms.Button btnBorrarPedido;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.DataGridView dgvConsultaDePedidos;
        private System.Windows.Forms.DataGridView dgvAprobados;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}