using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinRubicat;

namespace RubicatDemo
{
    public partial class MenuPrincipal_V : Form
    {
        public MenuPrincipal_V()
        {
            InitializeComponent();
            this.MaximizeBox = true;
            IsMdiContainer = true;

            tsmiPedido.Click += OpcionesMenu;
            tsmiConsultaDePedidos.Click += OpcionesMenu;

            tsmiNuevoCliente.Click += OpcionesMenu;
            tsmiConsultaClientes.Click += OpcionesMenu;

            tsmiNuevoVendedor.Click += OpcionesMenu;
            tsmiConsultaVendedores.Click += OpcionesMenu;

            tsmiNuevoProd.Click += OpcionesMenu;
            tsmiConsultaProd.Click += OpcionesMenu;

            tsmiAltaTransporte.Click += OpcionesMenu;
            tsmiConsultaTransporte.Click += OpcionesMenu;

        }
        private void OpcionesMenu(object sender, EventArgs e)
        {
            ToolStripMenuItem opcion = sender as ToolStripMenuItem;
            foreach (var mdi in MdiChildren)
            {
                mdi.Close();
            }
            switch (opcion.Name)
            {
                //---------Pedido-----------//
                case "tsmiPedido":

                    FrmPedido frmPedido = new FrmPedido();
                    frmPedido.MdiParent = this;
                    frmPedido.StartPosition = FormStartPosition.CenterScreen;
                    frmPedido.Dock = DockStyle.Fill;
                    frmPedido.Show();
                    break;

                case "tsmiConsultaDePedidos":

                    FrmConsultaDePedidos frmPedidoConsulta = new FrmConsultaDePedidos();
                    frmPedidoConsulta.MdiParent = this;
                    frmPedidoConsulta.StartPosition = FormStartPosition.CenterScreen;
                    frmPedidoConsulta.Dock = DockStyle.Fill;
                    frmPedidoConsulta.Show();
                    break;
                //--------Cliente----------//
                case "tsmiNuevoCliente":

                    FrmCliente frmCliente = new FrmCliente();
                    frmCliente.MdiParent = this;
                    frmCliente.StartPosition = FormStartPosition.CenterScreen;
                    frmCliente.Dock = DockStyle.Fill;
                    frmCliente.Show();
                    break;

                case "tsmiConsultaClientes":

                    FrmConsultaClientes frmClienteConsulta = new FrmConsultaClientes();
                    frmClienteConsulta.MdiParent = this;
                    frmClienteConsulta.StartPosition = FormStartPosition.CenterScreen;
                    frmClienteConsulta.Dock = DockStyle.Fill;
                    frmClienteConsulta.Show();
                    break;
                //--------Vendedor----------//
                case "tsmiNuevoVendedor":

                    FrmVendedor frmVendedor = new FrmVendedor();
                    frmVendedor.MdiParent = this;
                    frmVendedor.StartPosition = FormStartPosition.CenterScreen;
                    frmVendedor.Dock = DockStyle.Fill;
                    frmVendedor.Show();
                    break;

                case "tsmiConsultaVendedores":

                    FrmConsVend frmVendedorConsulta = new FrmConsVend();
                    frmVendedorConsulta.MdiParent = this;
                    frmVendedorConsulta.StartPosition = FormStartPosition.CenterScreen;
                    frmVendedorConsulta.Dock = DockStyle.Fill;
                    frmVendedorConsulta.Show();
                    break;
                //---------Producto--------//
                case "tsmiNuevoProd":

                    FrmProd frmProducto = new FrmProd();
                    frmProducto.MdiParent = this;
                    frmProducto.StartPosition = FormStartPosition.CenterScreen;
                    frmProducto.Dock = DockStyle.Fill;
                    frmProducto.Show();
                    break;

                case "tsmiConsultaProd":

                    FrmConsultaProducto frmProductoConsulta = new FrmConsultaProducto();
                    frmProductoConsulta.MdiParent = this;
                    frmProductoConsulta.StartPosition = FormStartPosition.CenterScreen;
                    frmProductoConsulta.Dock = DockStyle.Fill;
                    frmProductoConsulta.Show();
                    break;
                //-------Transporte------//
                case "tsmiAltaTransporte":

                    FrmTransporte frmTransporte = new FrmTransporte();
                    frmTransporte.MdiParent = this;
                    frmTransporte.StartPosition = FormStartPosition.CenterScreen;
                    frmTransporte.Dock = DockStyle.Fill;
                    frmTransporte.Show();
                    break;

                case "tsmiConsultaTransporte":

                    FrmConsultaTransporte frmTransporteConsulta = new FrmConsultaTransporte();
                    frmTransporteConsulta.MdiParent = this;
                    frmTransporteConsulta.StartPosition = FormStartPosition.CenterScreen;
                    frmTransporteConsulta.Dock = DockStyle.Fill;
                    frmTransporteConsulta.Show();
                    break;

                default:
                    break;
            }
        }

    }
}
