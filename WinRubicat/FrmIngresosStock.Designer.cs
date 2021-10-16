namespace WinRubicat
{
    partial class FrmIngresosStock
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
        this.lblFechaDeIngreso = new System.Windows.Forms.Label();
        this.dtpFechaDeIngresoStock = new System.Windows.Forms.DateTimePicker();
        this.lblIngresos = new System.Windows.Forms.Label();
        this.cmbSectorIngresos = new System.Windows.Forms.ComboBox();
        this.lblAromas = new System.Windows.Forms.Label();
        this.txtResponsable = new System.Windows.Forms.TextBox();
        this.btnCancelar = new System.Windows.Forms.Button();
        this.btnAgregar = new System.Windows.Forms.Button();
        this.txtCantidad1 = new System.Windows.Forms.TextBox();
        this.label7 = new System.Windows.Forms.Label();
        this.label8 = new System.Windows.Forms.Label();
        this.cmbIngresosMateriasPrimas1 = new System.Windows.Forms.ComboBox();
        this.txtRemito1 = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // lblFechaDeIngreso
        // 
        this.lblFechaDeIngreso.AutoSize = true;
        this.lblFechaDeIngreso.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.lblFechaDeIngreso.Location = new System.Drawing.Point(109, 68);
        this.lblFechaDeIngreso.Name = "lblFechaDeIngreso";
        this.lblFechaDeIngreso.Size = new System.Drawing.Size(127, 21);
        this.lblFechaDeIngreso.TabIndex = 22;
        this.lblFechaDeIngreso.Text = "Fecha de Ingreso";
        // 
        // dtpFechaDeIngresoStock
        // 
        this.dtpFechaDeIngresoStock.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
        this.dtpFechaDeIngresoStock.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.dtpFechaDeIngresoStock.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpFechaDeIngresoStock.Location = new System.Drawing.Point(103, 101);
        this.dtpFechaDeIngresoStock.Name = "dtpFechaDeIngresoStock";
        this.dtpFechaDeIngresoStock.Size = new System.Drawing.Size(142, 29);
        this.dtpFechaDeIngresoStock.TabIndex = 23;
        // 
        // lblIngresos
        // 
        this.lblIngresos.AutoSize = true;
        this.lblIngresos.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.lblIngresos.Location = new System.Drawing.Point(504, 68);
        this.lblIngresos.Name = "lblIngresos";
        this.lblIngresos.Size = new System.Drawing.Size(131, 21);
        this.lblIngresos.TabIndex = 26;
        this.lblIngresos.Text = "Sector de Ingreso";
        // 
        // cmbSectorIngresos
        // 
        this.cmbSectorIngresos.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.cmbSectorIngresos.FormattingEnabled = true;
        this.cmbSectorIngresos.Location = new System.Drawing.Point(493, 104);
        this.cmbSectorIngresos.Name = "cmbSectorIngresos";
        this.cmbSectorIngresos.Size = new System.Drawing.Size(142, 29);
        this.cmbSectorIngresos.TabIndex = 28;
        // 
        // lblAromas
        // 
        this.lblAromas.AutoSize = true;
        this.lblAromas.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.lblAromas.Location = new System.Drawing.Point(325, 68);
        this.lblAromas.Name = "lblAromas";
        this.lblAromas.Size = new System.Drawing.Size(98, 21);
        this.lblAromas.TabIndex = 29;
        this.lblAromas.Text = "Responsable";
        // 
        // txtResponsable
        // 
        this.txtResponsable.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.txtResponsable.Location = new System.Drawing.Point(297, 104);
        this.txtResponsable.Name = "txtResponsable";
        this.txtResponsable.Size = new System.Drawing.Size(142, 29);
        this.txtResponsable.TabIndex = 30;
        this.txtResponsable.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
        // 
        // btnCancelar
        // 
        this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.btnCancelar.Location = new System.Drawing.Point(409, 263);
        this.btnCancelar.Name = "btnCancelar";
        this.btnCancelar.Size = new System.Drawing.Size(114, 40);
        this.btnCancelar.TabIndex = 34;
        this.btnCancelar.Text = "Cancelar";
        this.btnCancelar.UseVisualStyleBackColor = true;
        // 
        // btnAgregar
        // 
        this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.btnAgregar.Location = new System.Drawing.Point(208, 263);
        this.btnAgregar.Name = "btnAgregar";
        this.btnAgregar.Size = new System.Drawing.Size(109, 40);
        this.btnAgregar.TabIndex = 33;
        this.btnAgregar.Text = "Agregar";
        this.btnAgregar.UseVisualStyleBackColor = true;
        // 
        // txtCantidad1
        // 
        this.txtCantidad1.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.txtCantidad1.Location = new System.Drawing.Point(297, 168);
        this.txtCantidad1.Name = "txtCantidad1";
        this.txtCantidad1.Size = new System.Drawing.Size(142, 29);
        this.txtCantidad1.TabIndex = 48;
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.label7.Location = new System.Drawing.Point(337, 144);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(72, 21);
        this.label7.TabIndex = 47;
        this.label7.Text = "Cantidad";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.label8.Location = new System.Drawing.Point(144, 144);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(64, 21);
        this.label8.TabIndex = 46;
        this.label8.Text = "Articulo";
        // 
        // cmbIngresosMateriasPrimas1
        // 
        this.cmbIngresosMateriasPrimas1.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.cmbIngresosMateriasPrimas1.FormattingEnabled = true;
        this.cmbIngresosMateriasPrimas1.Location = new System.Drawing.Point(97, 168);
        this.cmbIngresosMateriasPrimas1.Name = "cmbIngresosMateriasPrimas1";
        this.cmbIngresosMateriasPrimas1.Size = new System.Drawing.Size(142, 29);
        this.cmbIngresosMateriasPrimas1.TabIndex = 45;
        this.cmbIngresosMateriasPrimas1.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
        // 
        // txtRemito1
        // 
        this.txtRemito1.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.txtRemito1.Location = new System.Drawing.Point(493, 168);
        this.txtRemito1.Name = "txtRemito1";
        this.txtRemito1.Size = new System.Drawing.Size(142, 29);
        this.txtRemito1.TabIndex = 57;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.label1.Location = new System.Drawing.Point(533, 144);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(60, 21);
        this.label1.TabIndex = 56;
        this.label1.Text = "Remito";
        // 
        // FrmIngresosStock
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(711, 347);
        this.ControlBox = false;
        this.Controls.Add(this.txtRemito1);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.txtCantidad1);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.label8);
        this.Controls.Add(this.cmbIngresosMateriasPrimas1);
        this.Controls.Add(this.btnCancelar);
        this.Controls.Add(this.btnAgregar);
        this.Controls.Add(this.txtResponsable);
        this.Controls.Add(this.lblAromas);
        this.Controls.Add(this.cmbSectorIngresos);
        this.Controls.Add(this.lblIngresos);
        this.Controls.Add(this.dtpFechaDeIngresoStock);
        this.Controls.Add(this.lblFechaDeIngreso);
        this.Name = "FrmIngresosStock";
        this.Text = "Ingresos de Stock";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblFechaDeIngreso;
    private System.Windows.Forms.DateTimePicker dtpFechaDeIngresoStock;
    private System.Windows.Forms.Label lblIngresos;
    private System.Windows.Forms.ComboBox cmbSectorIngresos;
    private System.Windows.Forms.Label lblAromas;
    private System.Windows.Forms.TextBox txtResponsable;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.TextBox txtCantidad1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ComboBox cmbIngresosMateriasPrimas1;
    private System.Windows.Forms.TextBox txtRemito1;
    private System.Windows.Forms.Label label1;
}
}