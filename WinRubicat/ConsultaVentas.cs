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
            lblTipo.Text = "Pedidos";
            dtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            dtpFechaFin.Value = DateTime.Now;
            btnNuevo.Click += botones;
            btnModificar.Visible = false;
            btnBorrar.Visible = false;
            btnVentas.Click += botones;
            btnDetalle.Click += botones;
            btnAplicar.Click += botones;
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
                    this.Close();
                    FrmVenta frmVta = new FrmVenta();
                    frmVta.StartPosition = FormStartPosition.CenterScreen;
                    frmVta.Show();
                    break;
                case "btnModificar":
                    break;
                case "btnVentas":
                    logVenta = new Logica.Venta();
                    LlenarGridView();
                    break;
                case "btnDetalle":
                    logDetalle = new Logica.DetalleVenta();
                    dgvDatos.DataSource = logDetalle.TraerDetalle();
                    dgvDatos.Columns[3].DefaultCellStyle.Format = "N2";
                    dgvDatos.Columns[4].DefaultCellStyle.Format = "N2";
                    dgvDatos.Columns[5].DefaultCellStyle.Format = "N2";
                    dgvDatos.Columns[6].DefaultCellStyle.Format = "N2";
                    dgvDatos.Columns[7].DefaultCellStyle.Format = "N2";
                    break;
                case "btnAplicar":
                    string strTabla = cboTabla.SelectedItem.ToString();
                    DateTime dtInicio = dtpFechaInicio.Value;
                    DateTime dtFin = dtpFechaFin.Value;
                    string strOrden;
                    if (rbAscendente.Checked)
                    {
                        strOrden = "asc";
                    }
                    else
                    {
                        strOrden = "desc";
                    }
                    logDetalle = new Logica.DetalleVenta();
                    dgvDatos.DataSource= logDetalle.FiltrarDetalle(strTabla, dtInicio, dtFin, strOrden);
                    break;
                default:
                    break;
            }
        }
        void LlenarGridView()
        {
            logVenta = new Logica.Venta();
            dgvDatos.DataSource = logVenta.TraerVentas();
            dgvDatos.Columns[3].DefaultCellStyle.Format = "N2";
            dgvDatos.Columns[4].DefaultCellStyle.Format = "N2";
            dgvDatos.Columns[5].DefaultCellStyle.Format = "N2";
        }
    }
}
