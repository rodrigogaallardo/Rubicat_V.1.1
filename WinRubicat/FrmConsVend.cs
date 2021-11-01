using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinRubicat
{
    public partial class FrmConsVend : Form
    {
        public FrmConsVend()
        {
            InitializeComponent();
            btnNuevoVend.Click += botones;
            btnSalir.Click += botones;
            dgvVendedores.DoubleClick += DgvVendedores_DoubleClick;
            TraerVendedores();
        }

        private void DgvVendedores_DoubleClick(object sender, EventArgs e)
        {
            Vendedor modelVendedor = new Vendedor();
            modelVendedor.IdVendedor = Convert.ToInt32(dgvVendedores.CurrentRow.Cells[0].Value);
            modelVendedor.Nombre = dgvVendedores.CurrentRow.Cells[1].Value.ToString();
            modelVendedor.Telefono = Convert.ToInt32(dgvVendedores.CurrentRow.Cells[2].Value);
            //modelVendedor.ZonaId = Convert.ToInt32(dgvVendedores.CurrentRow.Cells[3].Value);

            FrmVendedor frmVendedor = new FrmVendedor(modelVendedor);
            frmVendedor.Show();
        }

        Logica.Vendedor objLogVend = new Logica.Vendedor();
        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            switch (boton.Name)
            {
                case "btnNuevoVend":
                    FrmVendedor frmVendedor = new FrmVendedor();
                    frmVendedor.StartPosition = FormStartPosition.CenterScreen;
                    frmVendedor.Show();
                    break;
                case "btnSalir":
                    Close();
                    break;
                default:
                    break;
            }
            TraerVendedores();
        }
        void TraerVendedores()
        {
            dgvVendedores.DataSource = objLogVend.TraerVendedores();
        }
    }
}
