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
        public FormBorderStyle BorderStyle { get; internal set; }

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
            txtHorario.Text = transporte.HorarioDeTransporte;
            txtTelefono.Text = transporte.TelefonoTransporte.ToString(); // captura el valor 

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

                    ///////////////////////////////////////VERIFICACIÓN DE CAMPOS//////////////////////////////////////////////////////////

                    transporteMod.NombreTransporte = txtNombreTransporte.Text;
                    if (transporteMod.NombreTransporte == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área Nombre de Trasnporte","Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    transporteMod.DireccionTransporte = txtDireccionTransporte.Text;
                    if (transporteMod.DireccionTransporte == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Dirección de Transporte'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }


                    try {
                        transporteMod.TelefonoTransporte = Convert.ToInt64(txtTelefono.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Solo esta permitido números en el area Teléfono", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    catch (Exception) {
                        //este seria para un campo nulo o cualquier otro error
                        MessageBox.Show("Error en el campo teléfono", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    transporteMod.HorarioDeTransporte = txtHorario.Text;

                    try
                    {
                        _ = cmbCaracterTransporte.SelectedItem.ToString() != null;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No puede dejar vacío el área: 'Caracter'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                                       
                    transporteMod.CaracterTransporte = cmbCaracterTransporte.SelectedItem.ToString();

                    ////////////////////////////////////////////////FIN DE VERIFICACIÓN DE CAMPOS/////////////////////////////////////////////////

                    switch (Estado)
                    {
                        case Operacion.Alta:
                           
                            objTransporte.AgregarTransporte(transporteMod);
                            MessageBox.Show("Transporte agregado correctamente.","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Close();
                            break;
                        case Operacion.Modificacion:
                            transporteMod.IdTransporte = Convert.ToInt32(lblIdT.Text);
                            objTransporte.ModificarTransporte(transporteMod);
                            MessageBox.Show("Transporte modificado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
