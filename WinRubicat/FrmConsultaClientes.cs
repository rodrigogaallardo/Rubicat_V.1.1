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
    public partial class FrmConsultaClientes : Form
    {
        public FrmConsultaClientes()
        {
            InitializeComponent();
            btnAgregarCliente.Click += botones;
            btnModificar.Click += botones;
            btnBorrar.Click += botones;
            btnSalir.Click += botones;
            TraerClientes();
        }

        private void ActualizarGrid(object sender, FormClosingEventArgs e)
        {
            TraerClientes();
        }

        void TraerClientes()
        {
            dgvClientes.DataSource = objLogCli.TraerClientes();
        }

        Logica.Cliente objLogCli = new Logica.Cliente();

        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            switch (boton.Name)
            {
                case "btnAgregarCliente":
                    FrmCliente frmCli = new FrmCliente();
                    frmCli.StartPosition = FormStartPosition.CenterScreen;
                    frmCli.FormClosing += ActualizarGrid;
                    frmCli.Show();
                    TraerClientes();
                    break;

                case "btnModificar":
                    Entidades.Cliente modelCliente = new Entidades.Cliente();
                    modelCliente.IdCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                    modelCliente = objLogCli.TraerPorId(modelCliente.IdCliente);

                    FrmCliente modCli = new FrmCliente(modelCliente);
                    modCli.StartPosition = FormStartPosition.CenterScreen;
                    modCli.FormClosing += ActualizarGrid;
                    modCli.Show();
                    TraerClientes();
                    break;
                case "btnBorrar":
                    int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                    objLogCli.BorrarCliente(id);
                    TraerClientes();
                    break;
                case "btnSalir":
                    Close();
                    break;
                default:
                    break;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
