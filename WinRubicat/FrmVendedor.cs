using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinRubicat
{
    public partial class FrmVendedor : Form
    {
        public enum Operacion
        {
            Alta,
            Modificacion
        }
        public Operacion Estado { get; set; }
        //Form nuevo vendedor
        public FrmVendedor()
        {
            InitializeComponent();
            //LlenarCombos();
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
            btnNuevaZona.Click += botones;
            this.Text = "Agregar Vendedor";
            Estado = Operacion.Alta;
        }
        //Form modificar vendedor
        public FrmVendedor(Entidades.Vendedor vendedor)
        {
            InitializeComponent();
            //LlenarCombos();
            this.Text = "Modificar Vendedor";
            btnAgregar.Text = "Modificar";
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
            btnNuevaZona.Click += botones;
            txtNombre.Text = vendedor.Nombre;
            txtTelefono.Text = Convert.ToString(vendedor.Telefono);
            lblCod.Text = "Cod";
            lblId.Text = vendedor.IdVendedor.ToString();
            cboZona.SelectedValue = vendedor.ZonaId;
            Estado = Operacion.Modificacion;
        }

        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            Vendedor modelVendedor = new Vendedor();
            Logica.Vendedor objLogica = new Logica.Vendedor();

            switch (boton.Name)
            {
                case "btnAgregar":

                    ///////////////////////////////////////VERIFICACIÓN DE CAMPOS//////////////////////////////////////////////////////////

                    modelVendedor.Nombre = txtNombre.Text;

                    if (modelVendedor.Nombre == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Nombre de Vendedor'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    try
                    {
                        modelVendedor.Telefono = Convert.ToInt64(txtTelefono.Text);
                    }
                    catch (FormatException)
                    {
                        //Aca entra cuando es null y cuando ingreso caracteres 
                        MessageBox.Show("Ingresar un valor numérico en el área: 'Teléfono de Vendedor'", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Número fuera de rango en el área: 'Teléfono de Vendedor'", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }

                    try
                    {
                        _ = cboZona.SelectedItem.ToString() != null;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No puede dejar vacío el área: 'Zona'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    modelVendedor.ZonaId = Convert.ToInt32(cboZona.SelectedValue);
                    ////////////////////////////////////////////////FIN DE VERIFICACIÓN DE CAMPOS/////////////////////////////////////////////////

                    switch (Estado)
                    {
                        case Operacion.Alta:
                            objLogica.AgregarVendedor(modelVendedor);
                            MessageBox.Show("Vendedor agregado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNombre.Clear();
                            txtTelefono.Clear();
                            break;
                        case Operacion.Modificacion:
                            modelVendedor.IdVendedor = Convert.ToInt32(lblId.Text);
                            objLogica.ModificarVendedor(modelVendedor);
                            MessageBox.Show("Vendedor modificado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                            break;
                        default:
                            break;
                    }
                    break;

                case "btnNuevaZona":
                    FrmZona frmZona = new FrmZona();
                    frmZona.StartPosition = FormStartPosition.CenterScreen;
                    frmZona.Show();
                    LlenarCombos();
                    break;
                case "btnCancelar":
                    Close();
                    break;
                default:
                    break;
            }
        }
        void LlenarCombos()
        {
            Logica.Zona objLogZona = new Logica.Zona();
            cboZona.DataSource = objLogZona.TraerZonas();
            cboZona.DisplayMember = "Nombre";
            cboZona.ValueMember = "IdZona";
        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void cboZona_TextChanged(object sender, EventArgs e)
        {
            Logica.Zona objLogicaCliente = new Logica.Zona();
            cboZona.DataSource = objLogicaCliente.SelectZona(cboZona.Text);
            cboZona.DisplayMember = "Nombre";
            cboZona.ValueMember = "IdZona";
        }
    }
}
