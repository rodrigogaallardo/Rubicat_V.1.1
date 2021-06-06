using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinRubicat
{
    public partial class ConsultaVentas : WinRubicat.FrmConsultas
    {
        public ConsultaVentas()
        {
            InitializeComponent();
            lblTipo.Text = "Clientes";
            btnNuevo.Click += botones;
            //btnModificar.Click += botones;
            //btnBorrar.Click += botones;
            btnModificar.Visible = false;
            btnBorrar.Visible = false;
            btnVentas.Click += botones;
            btnDetalle.Click += botones;

            LlenarGridView();
        }
        Logica.DetalleVenta logDetalle;
        Logica.Venta logVenta;

        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            switch (boton.Name)
            {
                case "btnNuevo":
                    ConsultaVentas frmConsulta = new ConsultaVentas();
                    frmConsulta.MdiParent = this;
                    frmConsulta.StartPosition = FormStartPosition.CenterScreen;
                    frmConsulta.Show();
                    break;
                case "btnModificar":
                    break;
                case "btnVentas":
                    logVenta = new Logica.Venta();
                    dgvDatos.DataSource = logVenta.TraerVentas();
                    break;
                case "btnDetalle":
                    logDetalle = new Logica.DetalleVenta();
                    dgvDatos.DataSource = logDetalle.TraerDetalle();
                    break;
                default:
                    break;
            }
        }
        void LlenarGridView()
        {
            logVenta = new Logica.Venta();
            dgvDatos.DataSource = logVenta.TraerVentas();
        }
    }
}
