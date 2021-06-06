namespace WinRubicat
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.msVentas = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoVendedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaVendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaProd = new System.Windows.Forms.ToolStripMenuItem();
            this.msVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // msVentas
            // 
            resources.ApplyResources(this.msVentas, "msVentas");
            this.msVentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.msVentas.Name = "msVentas";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevaVenta,
            this.tsmiConsultaVentas});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            resources.ApplyResources(this.ventasToolStripMenuItem, "ventasToolStripMenuItem");
            // 
            // tsmiNuevaVenta
            // 
            this.tsmiNuevaVenta.Name = "tsmiNuevaVenta";
            resources.ApplyResources(this.tsmiNuevaVenta, "tsmiNuevaVenta");
            // 
            // tsmiConsultaVentas
            // 
            this.tsmiConsultaVentas.Name = "tsmiConsultaVentas";
            resources.ApplyResources(this.tsmiConsultaVentas, "tsmiConsultaVentas");
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoCliente,
            this.tsmiConsultaClientes});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            resources.ApplyResources(this.clientesToolStripMenuItem, "clientesToolStripMenuItem");
            // 
            // tsmiNuevoCliente
            // 
            this.tsmiNuevoCliente.Name = "tsmiNuevoCliente";
            resources.ApplyResources(this.tsmiNuevoCliente, "tsmiNuevoCliente");
            // 
            // tsmiConsultaClientes
            // 
            this.tsmiConsultaClientes.Name = "tsmiConsultaClientes";
            resources.ApplyResources(this.tsmiConsultaClientes, "tsmiConsultaClientes");
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoVendedor,
            this.tsmiConsultaVendedores});
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            resources.ApplyResources(this.vendedoresToolStripMenuItem, "vendedoresToolStripMenuItem");
            // 
            // tsmiNuevoVendedor
            // 
            this.tsmiNuevoVendedor.Name = "tsmiNuevoVendedor";
            resources.ApplyResources(this.tsmiNuevoVendedor, "tsmiNuevoVendedor");
            // 
            // tsmiConsultaVendedores
            // 
            this.tsmiConsultaVendedores.Name = "tsmiConsultaVendedores";
            resources.ApplyResources(this.tsmiConsultaVendedores, "tsmiConsultaVendedores");
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoProd,
            this.tsmiConsultaProd});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            resources.ApplyResources(this.productosToolStripMenuItem, "productosToolStripMenuItem");
            // 
            // tsmiNuevoProd
            // 
            this.tsmiNuevoProd.Name = "tsmiNuevoProd";
            resources.ApplyResources(this.tsmiNuevoProd, "tsmiNuevoProd");
            // 
            // tsmiConsultaProd
            // 
            this.tsmiConsultaProd.Name = "tsmiConsultaProd";
            resources.ApplyResources(this.tsmiConsultaProd, "tsmiConsultaProd");
            // 
            // MenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.msVentas);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msVentas;
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msVentas.ResumeLayout(false);
            this.msVentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msVentas;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevaVenta;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaVentas;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoVendedor;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaVendedores;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoProd;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaProd;
    }
}

