using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRubicat
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.MaximizeBox = true;
            tsmiNuevaVenta.Click += OpcionesMenu;
            tsmiConsultaVentas.Click += OpcionesMenu;
            tsmiNuevoVendedor.Click += OpcionesMenu;
            tsmiConsultaVendedores.Click += OpcionesMenu;
            tsmiNuevoCliente.Click += OpcionesMenu;
            tsmiConsultaClientes.Click += OpcionesMenu;
            tsmiNuevoProd.Click += OpcionesMenu;
            tsmiConsultaProd.Click += OpcionesMenu;
        }

        private void OpcionesMenu(object sender, EventArgs e)
        {
            ToolStripMenuItem opcion = sender as ToolStripMenuItem;
            foreach(var mdi in MdiChildren)
            {
                mdi.Close();
            }
            switch (opcion.Name)
            {
                case "tsmiNuevaVenta":
                    FrmVenta FrmNuevaVent = new FrmVenta();
                    FrmNuevaVent.MdiParent = this;
                    FrmNuevaVent.StartPosition = FormStartPosition.CenterScreen;
                    FrmNuevaVent.Dock = DockStyle.Fill;
                    FrmNuevaVent.Show();
                    break;
                case "tsmiConsultaVentas":
                    ConsultaVentas FrmConsultaVent = new ConsultaVentas();
                    FrmConsultaVent.MdiParent = this;
                    FrmConsultaVent.StartPosition = FormStartPosition.CenterScreen;
                    FrmConsultaVent.Dock = DockStyle.Fill;
                    FrmConsultaVent.Show();
                    break;
                case "tsmiNuevoVendedor":
                    FrmVendedor FrmNuevoVend = new FrmVendedor();
                    FrmNuevoVend.MdiParent = this;
                    FrmNuevoVend.StartPosition = FormStartPosition.CenterScreen;
                    FrmNuevoVend.Dock = DockStyle.Fill;
                    FrmNuevoVend.Show();
                    break;
                case "tsmiConsultaVendedores":
                    FrmConsVend frmConsVend = new FrmConsVend();
                    frmConsVend.MdiParent = this;
                    frmConsVend.StartPosition = FormStartPosition.CenterScreen;
                    frmConsVend.Dock = DockStyle.Fill;
                    frmConsVend.Show();
                    break;
                case "tsmiNuevoCliente":
                    FrmCliente FrmNuevoCli = new FrmCliente();
                    FrmNuevoCli.MdiParent = this;
                    FrmNuevoCli.StartPosition = FormStartPosition.CenterScreen;
                    FrmNuevoCli.Dock = DockStyle.Fill;
                    FrmNuevoCli.Show();
                    break;
                case "tsmiConsultaClientes":
                    FrmConsCli frmConsCliente = new FrmConsCli();
                    frmConsCliente.MdiParent = this;
                    frmConsCliente.StartPosition = FormStartPosition.CenterScreen;
                    frmConsCliente.Dock = DockStyle.Fill;
                    frmConsCliente.Show();
                    break;
                case "tsmiNuevoProd":
                    FrmProd frmNuevoProd = new FrmProd();
                    frmNuevoProd.MdiParent = this;
                    frmNuevoProd.StartPosition = FormStartPosition.CenterScreen;
                    frmNuevoProd.Dock = DockStyle.Fill;
                    frmNuevoProd.Show();
                    break;
                case "tsmiConsultaProd":
                    FrmConsProd frmConsProducto = new FrmConsProd();
                    frmConsProducto.MdiParent = this;
                    frmConsProducto.StartPosition = FormStartPosition.CenterScreen;
                    frmConsProducto.Dock = DockStyle.Fill;
                    frmConsProducto.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
