
namespace RubicatDemo
{
    partial class MenuPrincipal_V
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal_V));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaDePedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoVendedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaVendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoProd = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaProd = new System.Windows.Forms.ToolStripMenuItem();
            this.transporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaTransporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaTransporte = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.tsmiNuevoProd,
            this.transporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPedido,
            this.tsmiConsultaDePedidos});
            this.pedidosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidosToolStripMenuItem.Image")));
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // tsmiPedido
            // 
            this.tsmiPedido.Name = "tsmiPedido";
            this.tsmiPedido.Size = new System.Drawing.Size(234, 26);
            this.tsmiPedido.Text = "Pedido";
            // 
            // tsmiConsultaDePedidos
            // 
            this.tsmiConsultaDePedidos.Name = "tsmiConsultaDePedidos";
            this.tsmiConsultaDePedidos.Size = new System.Drawing.Size(234, 26);
            this.tsmiConsultaDePedidos.Text = "Consulta De Pedido";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoCliente,
            this.tsmiConsultaClientes});
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // tsmiNuevoCliente
            // 
            this.tsmiNuevoCliente.Name = "tsmiNuevoCliente";
            this.tsmiNuevoCliente.Size = new System.Drawing.Size(233, 26);
            this.tsmiNuevoCliente.Text = "Agregar Cliente";
            // 
            // tsmiConsultaClientes
            // 
            this.tsmiConsultaClientes.Name = "tsmiConsultaClientes";
            this.tsmiConsultaClientes.Size = new System.Drawing.Size(233, 26);
            this.tsmiConsultaClientes.Text = "Cartera de Clientes";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoVendedor,
            this.tsmiConsultaVendedores});
            this.vendedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vendedoresToolStripMenuItem.Image")));
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(132, 25);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // tsmiNuevoVendedor
            // 
            this.tsmiNuevoVendedor.Name = "tsmiNuevoVendedor";
            this.tsmiNuevoVendedor.Size = new System.Drawing.Size(237, 26);
            this.tsmiNuevoVendedor.Text = "Agregar Vendedor";
            // 
            // tsmiConsultaVendedores
            // 
            this.tsmiConsultaVendedores.Name = "tsmiConsultaVendedores";
            this.tsmiConsultaVendedores.Size = new System.Drawing.Size(237, 26);
            this.tsmiConsultaVendedores.Text = "Lista de Vendedores";
            // 
            // tsmiNuevoProd
            // 
            this.tsmiNuevoProd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.tsmiConsultaProd});
            this.tsmiNuevoProd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNuevoProd.Image")));
            this.tsmiNuevoProd.Name = "tsmiNuevoProd";
            this.tsmiNuevoProd.Size = new System.Drawing.Size(116, 25);
            this.tsmiNuevoProd.Text = "Productos";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            // 
            // tsmiConsultaProd
            // 
            this.tsmiConsultaProd.Name = "tsmiConsultaProd";
            this.tsmiConsultaProd.Size = new System.Drawing.Size(222, 26);
            this.tsmiConsultaProd.Text = "Lista de Productos";
            // 
            // transporteToolStripMenuItem
            // 
            this.transporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAltaTransporte,
            this.tsmiConsultaTransporte});
            this.transporteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("transporteToolStripMenuItem.Image")));
            this.transporteToolStripMenuItem.Name = "transporteToolStripMenuItem";
            this.transporteToolStripMenuItem.Size = new System.Drawing.Size(121, 25);
            this.transporteToolStripMenuItem.Text = "Transporte";
            // 
            // tsmiAltaTransporte
            // 
            this.tsmiAltaTransporte.Name = "tsmiAltaTransporte";
            this.tsmiAltaTransporte.Size = new System.Drawing.Size(249, 26);
            this.tsmiAltaTransporte.Text = "Agregar Transporte";
            // 
            // tsmiConsultaTransporte
            // 
            this.tsmiConsultaTransporte.Name = "tsmiConsultaTransporte";
            this.tsmiConsultaTransporte.Size = new System.Drawing.Size(249, 26);
            this.tsmiConsultaTransporte.Text = "Lista de Transportistas";
            // 
            // MenuPrincipal_V
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal_V";
            this.Text = "Rubicat";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoProd;
        private System.Windows.Forms.ToolStripMenuItem transporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPedido;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaDePedidos;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoVendedor;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaVendedores;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaProd;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaTransporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaTransporte;
    }
}