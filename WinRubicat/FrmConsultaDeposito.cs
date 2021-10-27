using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinRubicat
{
    public partial class FrmConsultaDeposito : Form
    {
        public FrmConsultaDeposito()
        {
            InitializeComponent();
            btnAgregarDeposito.Click += botones;
            btnBorrar.Click += botones;
            btnModificar.Click += botones;
            btnSalir.Click += botones;
            TraerDepositos();
        }
        void TraerDepositos()
        {
            Logica.Depositos objlogica = new Logica.Depositos();
            dgvDepositos.DataSource = objlogica.TraerDeposito();
        }

        Logica.Depositos objDep = new Logica.Depositos();

        public void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            switch (boton.Name)
            {
                case "btnAgregarDeposito":
                    FrmDepositos frmDeposito = new FrmDepositos();
                    frmDeposito.StartPosition = FormStartPosition.CenterScreen;
                    frmDeposito.FormClosing += ActualizarGrid;
                    frmDeposito.Show();
                    break;
                case "btnBorrar":
                    int id = Convert.ToInt32(dgvDepositos.CurrentRow.Cells[0].Value);
                    objDep.BorrarDeposito(id);
                    TraerDepositos();
                    break;
                case "btnModificar":
                    //Crear instancia de producto y cargar datos del registro seleccionado
                    Deposito depositoMod = new Deposito();
                    depositoMod.IdDeposito = Convert.ToInt32(dgvDepositos.CurrentRow.Cells[0].Value);
                    depositoMod = objDep.TraerPorId(depositoMod.IdDeposito);

                    // Mostrar formulario modificacion
                    FrmDepositos frmDepositoMod = new FrmDepositos(depositoMod);
                    frmDepositoMod.StartPosition = FormStartPosition.CenterScreen;
                    frmDepositoMod.FormClosing += ActualizarGrid;
                    frmDepositoMod.Show();
                    break;
                case "btnSalir":
                    Close();
                    break;
             
            }
            
        }

        private void ActualizarGrid(object sender, FormClosingEventArgs e)
        {
            TraerDepositos();
        }

        private void FrmConsultaDeposito_Load(object sender, EventArgs e)
        {

        }
    }
}
