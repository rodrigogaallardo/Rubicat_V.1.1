using System;
using System.Windows.Forms;
using Entidades;


namespace WinRubicat
{
    public partial class FrmConsultaTransporte : Form

    {
        void TraerTransporte()
        {
            Logica.Transporte objTransporte = new Logica.Transporte();
            dgvTransporte.DataSource = objTransporte.TraerTransporte();

        }
        public FrmConsultaTransporte()
        {
            InitializeComponent();
            btnAgregarTransporte.Click += botones;
            btnBorrar.Click += botones;
            btnModificar.Click += botones;
            btnSalir.Click += botones;
            TraerTransporte();
        }
        private void ActualizarGrid(object sender, FormClosingEventArgs e)
        {
            TraerTransporte();
        }
        Logica.Transporte objTransporte = new Logica.Transporte();

        public void botones(object sender, EventArgs e)
        {
            
              Button boton = sender as Button;
            switch (boton.Name)
            {
                case "btnAgregarTransporte":
                    FrmTransporte frmTransporte = new FrmTransporte();
                    frmTransporte.StartPosition = FormStartPosition.CenterScreen;
                    frmTransporte.FormBorderStyle = FormBorderStyle.FixedSingle;
                    frmTransporte.FormClosing += ActualizarGrid;
                    frmTransporte.Show();
                    break;
                case "btnBorrar":
                    int id = Convert.ToInt32(dgvTransporte.CurrentRow.Cells[0].Value);
                    objTransporte.BorrarTransporte(id);
                    TraerTransporte();
                    break;
                case "btnModificar":
                    //Crear instancia de producto y cargar datos del registro seleccionado
                    Transporte transporteMod = new Transporte();
                    transporteMod.IdTransporte = Convert.ToInt32(dgvTransporte.CurrentRow.Cells[0].Value);
                    transporteMod = objTransporte.TraerPorId(transporteMod.IdTransporte);

                    // Mostrar formulario modificacion
                    FrmTransporte frmTransporteMod = new FrmTransporte(transporteMod);
                    frmTransporteMod.FormBorderStyle = FormBorderStyle.FixedSingle;
                    frmTransporteMod.StartPosition = FormStartPosition.CenterScreen;           
                    frmTransporteMod.FormClosing += ActualizarGrid;
                    frmTransporteMod.Show();
                    break;
                case "btnSalir":
                    Close();
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
