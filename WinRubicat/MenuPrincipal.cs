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
            //******************************************//
            //********Ingresar Productos a Stock********//
            //******************************************//

            tsmiPackaging.Click += OpcionesMenu;
            tsmiEtiquetas.Click += OpcionesMenu;
            tsmiAromas.Click += OpcionesMenu;
            tsmiTapas.Click += OpcionesMenu;
            tsmiMateriaPrima.Click += OpcionesMenu;

            tsmiIngresarDepositos.Click += OpcionesMenu;
            tsmiIngresarStock.Click += OpcionesMenu;
            //******************************************//
            //****Consultar el stock de los productos***//
            //******************************************//

            tsmiArticulos.Click += OpcionesMenu;
            tsmiVerDepositos.Click += OpcionesMenu;
            tsmiConsultarStock.Click += OpcionesMenu;
            tsmiStockTotal.Click += OpcionesMenu;
            //*****************************************//
        }

        private void TsmiIngresarStock_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TsmiIngresarDepositos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
                //******************************************//
                //********Consultar Productos a Stock********//
                //******************************************//
                case "tsmiConsultarStock":
                    FrmConsultasStock FrmConsultasStockPri = new FrmConsultasStock();
                    FrmConsultasStockPri.MdiParent = this;
                    FrmConsultasStockPri.StartPosition = FormStartPosition.CenterScreen;
                    FrmConsultasStockPri.Dock = DockStyle.Fill;
                    FrmConsultasStockPri.Show();
                    break;
                case "tsmiVerDepositos":
                    FrmConsultaDeposito FrmConsultaDepositoPri = new FrmConsultaDeposito();
                    FrmConsultaDepositoPri.MdiParent = this;
                    FrmConsultaDepositoPri.StartPosition = FormStartPosition.CenterScreen;
                    FrmConsultaDepositoPri.Dock = DockStyle.Fill;
                    FrmConsultaDepositoPri.Show();
                    break;
                case "tsmiArticulos":
                    FrmConsultasMateriasPrimas FrmConsultaMateriasPrimasPri = new FrmConsultasMateriasPrimas();
                    FrmConsultaMateriasPrimasPri.MdiParent = this;
                    FrmConsultaMateriasPrimasPri.StartPosition = FormStartPosition.CenterScreen;
                    FrmConsultaMateriasPrimasPri.Dock = DockStyle.Fill;
                    FrmConsultaMateriasPrimasPri.Show();
                    break;
                case "tsmiStockTotal":
                    FrmStockTotal FrmStockTotalPri = new FrmStockTotal();
                    FrmStockTotalPri.MdiParent = this;
                    FrmStockTotalPri.StartPosition = FormStartPosition.CenterScreen;
                    FrmStockTotalPri.Dock = DockStyle.Fill;
                    FrmStockTotalPri.Show();
                    break;

                //******************************************//
                //********Ingresar Productos a Stock********//
                //******************************************//

                case "tsmiIngresarStock":
                    FrmIngresosStock FrmIngresosStockPri = new FrmIngresosStock();
                    FrmIngresosStockPri.MdiParent = this;
                    FrmIngresosStockPri.StartPosition = FormStartPosition.CenterScreen;
                    FrmIngresosStockPri.Dock = DockStyle.Fill;
                    FrmIngresosStockPri.Show();
                    break;

                case "tsmiIngresarDepositos":
                    FrmDepositos FrmDepositosPrim = new FrmDepositos();
                    FrmDepositosPrim.MdiParent = this;
                    FrmDepositosPrim.StartPosition = FormStartPosition.CenterScreen;
                    FrmDepositosPrim.Dock = DockStyle.Fill;
                    FrmDepositosPrim.Show();
                    break;

                case "tsmiMateriaPrima":
                    FrmMateriasPrimas FrmMateriasPrimasPri = new FrmMateriasPrimas();
                    FrmMateriasPrimasPri.MdiParent = this;
                    FrmMateriasPrimasPri.StartPosition = FormStartPosition.CenterScreen;
                    FrmMateriasPrimasPri.Dock = DockStyle.Fill;
                    FrmMateriasPrimasPri.Show();
                    break;

                case "tsmiAromas":
                    FrmAromas FrmAromasPrim = new FrmAromas();
                    FrmAromasPrim.MdiParent = this;
                    FrmAromasPrim.StartPosition = FormStartPosition.CenterScreen;
                    FrmAromasPrim.Dock = DockStyle.Fill;
                    FrmAromasPrim.Show();
                    break;

                case "tsmiTapas":
                    FrmTapas FrmTapasPrim = new FrmTapas();
                    FrmTapasPrim.MdiParent = this;
                    FrmTapasPrim.StartPosition = FormStartPosition.CenterScreen;
                    FrmTapasPrim.Dock = DockStyle.Fill;
                    FrmTapasPrim.Show();
                    break;

                case "tsmiPackaging":
                    FrmPackaging FrmPacka = new FrmPackaging();
                    FrmPacka.MdiParent = this;
                    FrmPacka.StartPosition = FormStartPosition.CenterScreen;
                    FrmPacka.Dock = DockStyle.Fill;
                    FrmPacka.Show();
                    break;

                case "tsmiEtiquetas":
                    FrmEtiqueta FrmEtiq = new FrmEtiqueta();
                    FrmEtiq.MdiParent = this;
                    FrmEtiq.StartPosition = FormStartPosition.CenterScreen;
                    FrmEtiq.Dock = DockStyle.Fill;
                    FrmEtiq.Show();
                    break;
                //******************************************//

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

        private void sectorBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
