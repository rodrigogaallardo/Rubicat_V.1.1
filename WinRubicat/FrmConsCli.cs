using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace WinRubicat
{
    public partial class FrmConsCli : WinRubicat.FrmConsultas
    {
        public FrmConsCli()
        {
            InitializeComponent();
            lblTipo.Text = "Clientes";
            btnNuevo.Click += botones;
            btnModificar.Click += botones;
            btnBorrar.Click += botones;
            
            TraerClientes();
        }
        Logica.Cliente objLogCli = new Logica.Cliente();
        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            switch (boton.Name)
            {
                case "btnNuevo":
                    FrmCliente frmCli = new FrmCliente();
                    frmCli.StartPosition = FormStartPosition.CenterScreen;
                    frmCli.Show();
                    break;
                case "btnModificar":
                    Entidades.Cliente modelCliente = new Entidades.Cliente();
                    modelCliente.IdCliente = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                    modelCliente.Nombre = dgvDatos.CurrentRow.Cells[1].Value.ToString();
                    modelCliente.RazonSocial = dgvDatos.CurrentRow.Cells[2].Value.ToString();
                    modelCliente.Cuit = Convert.ToInt32(dgvDatos.CurrentRow.Cells[3].Value);
                    modelCliente.IngBrutos = Convert.ToInt32(dgvDatos.CurrentRow.Cells[4].Value);
                    modelCliente.TipoIngBrutos = dgvDatos.CurrentRow.Cells[5].Value.ToString();
                    modelCliente.DomicilioFiscal = dgvDatos.CurrentRow.Cells[6].Value.ToString();
                    modelCliente.Telefono = Convert.ToInt32(dgvDatos.CurrentRow.Cells[7].Value);
                    modelCliente.VendedorId = Convert.ToInt32(dgvDatos.CurrentRow.Cells[8].Value);
                    modelCliente.ZonaId = Convert.ToInt32(dgvDatos.CurrentRow.Cells[9].Value);
                    FrmCliente modCli = new FrmCliente(modelCliente);
                    modCli.StartPosition = FormStartPosition.CenterScreen;
                    modCli.Show();
                    break;
                case "btnBorrar":
                    int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                    objLogCli.BorrarCliente(id);
                    break;
                default:
                    break;
            }
            TraerClientes();
        }
        void TraerClientes()
        {
            dgvDatos.DataSource = objLogCli.TraerClientes();
        }
    }
}
