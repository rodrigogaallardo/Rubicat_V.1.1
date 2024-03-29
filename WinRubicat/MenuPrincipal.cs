﻿using System;
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
            tsmiPedido.Click += OpcionesMenu;

            //******************************************//
            //********Ingresar Productos a Stock********//
            //******************************************//

            tsmiMateriaPrima.Click += OpcionesMenu;
            tsmiIngresarDepositos.Click += OpcionesMenu;
            tsmiIngresarStock.Click += OpcionesMenu;
            tsmiAltaTransporte.Click += OpcionesMenu;
            //******************************************//
            //****Consultar el stock de los productos***//
            //******************************************//

            tsmiConsultarMateriasPrimas.Click += OpcionesMenu;
            tsmiConsultarDepositos.Click += OpcionesMenu;
            tsmiConsultarStock.Click += OpcionesMenu;
            tsmiStockTotal.Click += OpcionesMenu;
            tsmiConsultaTransporte.Click += OpcionesMenu;
            tsmiConsultaDePedidos.Click += OpcionesMenu;
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

                //********Transporte********//
                case "tsmiAltaTransporte":
                    FrmTransporte FrmIngresosTransporte = new FrmTransporte();
                    FrmIngresosTransporte.MdiParent = this;
                    FrmIngresosTransporte.StartPosition = FormStartPosition.CenterScreen;
                    FrmIngresosTransporte.FormBorderStyle = FormBorderStyle.Fixed3D;
                    //FrmIngresosTransporte.Dock = DockStyle.Fill;
                    FrmIngresosTransporte.Show();
                    break;
                case "tsmiConsultaTransporte":
                    FrmConsultaTransporte FrmConsultasTransporte = new FrmConsultaTransporte();
                    FrmConsultasTransporte.MdiParent = this;
                    FrmConsultasTransporte.StartPosition = FormStartPosition.CenterScreen;
                    FrmConsultasTransporte.Dock = DockStyle.Fill;
                    FrmConsultasTransporte.Show();
                    break;
                //********Producto********//
                case "tsmiNuevoProd":
                    FrmProd frmNuevoProd = new FrmProd();
                    frmNuevoProd.MdiParent = this;
                    frmNuevoProd.StartPosition = FormStartPosition.CenterScreen;
                    frmNuevoProd.FormBorderStyle = FormBorderStyle.Fixed3D;
                    //frmNuevoProd.Dock = DockStyle.Fill;
                    frmNuevoProd.Show();
                    break;
                case "tsmiConsultaProd":
                    FrmConsultaProducto frmConsProducto = new FrmConsultaProducto();
                    frmConsProducto.MdiParent = this;
                    frmConsProducto.StartPosition = FormStartPosition.CenterScreen;
                    frmConsProducto.Dock = DockStyle.Fill;
                    frmConsProducto.Show();
                    break;
                //********Vendedor********//
                case "tsmiNuevoVendedor":
                    FrmVendedor FrmNuevoVend = new FrmVendedor();
                    FrmNuevoVend.MdiParent = this;
                    FrmNuevoVend.StartPosition = FormStartPosition.CenterScreen;
                    FrmNuevoVend.FormBorderStyle = FormBorderStyle.Fixed3D;
                    //FrmNuevoVend.Dock = DockStyle.Fill;
                    FrmNuevoVend.Show();
                    break;
                case "tsmiConsultaVendedores":
                    FrmConsVend frmConsVend = new FrmConsVend();
                    frmConsVend.MdiParent = this;
                    frmConsVend.StartPosition = FormStartPosition.CenterScreen;
                    frmConsVend.Dock = DockStyle.Fill;
                    frmConsVend.Show();
                    break;
                //********Cliente********//
                case "tsmiNuevoCliente":
                    FrmCliente FrmNuevoCli = new FrmCliente();
                    FrmNuevoCli.MdiParent = this;
                    FrmNuevoCli.StartPosition = FormStartPosition.CenterScreen;
                    FrmNuevoCli.FormBorderStyle = FormBorderStyle.Fixed3D;
                    //FrmNuevoCli.Dock = DockStyle.Fill;
                    FrmNuevoCli.Show();
                    break;
                case "tsmiConsultaClientes":
                    FrmConsultaClientes frmConsCliente = new FrmConsultaClientes();
                    frmConsCliente.MdiParent = this;
                    frmConsCliente.StartPosition = FormStartPosition.CenterScreen;
                    frmConsCliente.Dock = DockStyle.Fill;
                    frmConsCliente.Show();
                    break;
                //********Pedido********//
                case "tsmiConsultaDePedidos":
                    FrmConsultaDePedidos FrmPedido = new FrmConsultaDePedidos();
                    FrmPedido.MdiParent = this;
                    FrmPedido.StartPosition = FormStartPosition.CenterScreen;
                    FrmPedido.Dock = DockStyle.Fill;
                    FrmPedido.Show();
                    break;
                case "tsmiPedido":
                    FrmPedido FrmRemito = new FrmPedido();
                    FrmRemito.MdiParent = this;
                    FrmRemito.StartPosition = FormStartPosition.CenterScreen;
                    FrmRemito.Dock = DockStyle.Fill;
                    FrmRemito.Show();
                    break;
                //**********Ingrensos de Stock************//
                case "tsmiStockTotal":
                    FrmStockTotal FrmStockTotalPri = new FrmStockTotal();
                    FrmStockTotalPri.MdiParent = this;
                    FrmStockTotalPri.StartPosition = FormStartPosition.CenterScreen;
                    FrmStockTotalPri.Dock = DockStyle.Fill;
                    FrmStockTotalPri.Show();
                    break;
                case "tsmiConsultarStock":
                    FrmConsultasStock FrmConsultasStockPri = new FrmConsultasStock();
                    FrmConsultasStockPri.MdiParent = this;
                    FrmConsultasStockPri.StartPosition = FormStartPosition.CenterScreen;
                    FrmConsultasStockPri.Dock = DockStyle.Fill;
                    FrmConsultasStockPri.Show();
                    break;

                case "tsmiIngresarStock":
                    FrmIngresosStock FrmIngresosStockPri = new FrmIngresosStock();
                    FrmIngresosStockPri.MdiParent = this;
                    FrmIngresosStockPri.StartPosition = FormStartPosition.CenterScreen;
                    FrmIngresosStockPri.FormBorderStyle = FormBorderStyle.Fixed3D;
                    //FrmIngresosStockPri.Dock = DockStyle.Fill;
                    FrmIngresosStockPri.Show();
                    break;
                //************Ingreso de depositos***********//
                case "tsmiIngresarDepositos":
                    FrmDepositos FrmDepositosPrim = new FrmDepositos();
                    FrmDepositosPrim.MdiParent = this;
                    FrmDepositosPrim.StartPosition = FormStartPosition.CenterScreen;
                    FrmDepositosPrim.FormBorderStyle = FormBorderStyle.Fixed3D;
                    //FrmDepositosPrim.Dock = DockStyle.Fill;
                    FrmDepositosPrim.Show();
                    break;
                case "tsmiConsultarDepositos":
                    FrmConsultaDeposito FrmConsultaDepositoPri = new FrmConsultaDeposito();
                    FrmConsultaDepositoPri.MdiParent = this;
                    FrmConsultaDepositoPri.StartPosition = FormStartPosition.CenterScreen;
                    FrmConsultaDepositoPri.Dock = DockStyle.Fill;
                    FrmConsultaDepositoPri.Show();
                    break;
                //************************************************//

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

                case "tsmiConsultarMateriasPrimas":
                    FrmConsultasMateriasPrimas FrmConsultaMateriasPrimasPri = new FrmConsultasMateriasPrimas();
                    FrmConsultaMateriasPrimasPri.MdiParent = this;
                    FrmConsultaMateriasPrimasPri.StartPosition = FormStartPosition.CenterScreen;
                    FrmConsultaMateriasPrimasPri.Dock = DockStyle.Fill;
                    FrmConsultaMateriasPrimasPri.Show();
                    break;
                
                case "tsmiMateriaPrima":
                    FrmMateriasPrimas FrmMateriasPrimasPri = new FrmMateriasPrimas();
                    FrmMateriasPrimasPri.MdiParent = this;
                    FrmMateriasPrimasPri.StartPosition = FormStartPosition.CenterScreen;
                    FrmMateriasPrimasPri.Dock = DockStyle.Fill;
                    FrmMateriasPrimasPri.Show();
                    break;

                default:
                    break;
            }
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            SetBackGroundColorOfMDIForm();
        }
        private void SetBackGroundColorOfMDIForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)

                // If the control is the correct type,
                // change the color.
                {
                    ctl.BackColor = System.Drawing.Color.FromArgb(37,37,37);
                }
            }
        }
    }

}
