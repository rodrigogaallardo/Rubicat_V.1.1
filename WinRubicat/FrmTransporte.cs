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
    public partial class FrmTransporte : Form
    {
        public enum Operacion
        {
            Alta,
            Modificacion
        }
        public Operacion Estado { get; set; }

        public FrmTransporte()
        {
            InitializeComponent();
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
            lblTitulo.Text = "Agregar Transporte";
            lblIdTransporte.Text = "";
            lblIdT.Text = "";
            Estado = Operacion.Alta;
        }

        public FrmTransporte(Entidades.Transporte transporte)
        {
            InitializeComponent();
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
            lblIdT.Text = transporte.IdTransporte.ToString();
            lblTitulo.Text = "Modificar Deposito";
            btnAgregar.Text = "Modificar";

            txtNombreTransporte.Text = transporte.NombreTransporte;
            txtDireccionTransporte.Text = transporte.DireccionTransporte;
            cmbCaracterTransporte.Text = transporte.CaracterTransporte;

            Estado = Operacion.Modificacion;
        }

        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            Transporte transporteMod = new Transporte();
            Logica.Transporte objTransporte = new Logica.Transporte();

            switch (boton.Name)
            {
                case "btnCancelar":
                    Close();
                    break;
                case "btnAgregar":

                    transporteMod.NombreTransporte = txtNombreTransporte.Text;
                    transporteMod.DireccionTransporte = txtDireccionTransporte.Text;
                    transporteMod.CaracterTransporte = cmbCaracterTransporte.SelectedItem.ToString();
                    

                    switch (Estado)
                    {
                        case Operacion.Alta:
                            objTransporte.AgregarTransporte(transporteMod);
                            MessageBox.Show("Transporte agregado correctamente.");
                            Close();
                            break;
                        case Operacion.Modificacion:
                            transporteMod.IdTransporte = Convert.ToInt32(lblIdT.Text);
                            objTransporte.ModificarTransporte(transporteMod);
                            MessageBox.Show("Deposito modificado correctamente.");
                            Close();
                            break;
                        default:
                            break;
                    }

                    break;
            }


        }

        private void lblDeposito_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreDeposito_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
