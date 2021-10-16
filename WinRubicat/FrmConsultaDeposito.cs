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
                    frmDeposito.Show();
                    break;
                case "btnBorrar":
                    int id = Convert.ToInt32(dgvDepositos.CurrentRow.Cells[0].Value);
                    objDep.BorrarDeposito(id);

                    break;
                case "btnModificar":
                    //Crear instancia de producto y cargar datos del registro seleccionado
                    Deposito depositoMod = new Deposito();
                    depositoMod.IdDeposito = Convert.ToInt32(dgvDepositos.CurrentRow.Cells[0].Value);
                    depositoMod.Nombre = dgvDepositos.CurrentRow.Cells[1].Value.ToString();
                    depositoMod.Descripcion = dgvDepositos.CurrentRow.Cells[2].Value.ToString();
                    depositoMod.Espacio = dgvDepositos.CurrentRow.Cells[3].Value.ToString();
                    // Mostrar formulario modificacion
                    FrmDepositos frmDepositoMod = new FrmDepositos(depositoMod);
                    frmDepositoMod.StartPosition = FormStartPosition.CenterScreen;
                    frmDepositoMod.Show();
                    break;
                case "btnSalir":
                    Close();
                    break;
            }
        }

        private void FrmConsultaDeposito_Load(object sender, EventArgs e)
        {

        }
    }
}
