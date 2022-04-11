using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinRubicat
{
    public partial class FrmCliente : Form
    {
        public enum Operacion
        {
            Alta,
            Modificacion
        }
        public Operacion Estado { get; set; }

        //Form agregar cliente
        public FrmCliente()
        {
            InitializeComponent();
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
            lblTitulo.Text = "Agregar Cliente";
            lblCod.Text = "";
            LlenarCombos();
            Estado = Operacion.Alta;
        }

        //Form modificar cliente
        public FrmCliente(Entidades.Cliente cliente)
        {
            Cliente modelCliente = new Cliente();
            Logica.Cliente objLogicaCliente = new Logica.Cliente();

            InitializeComponent();
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
            lblCod.Text = cliente.IdCliente.ToString();
            lblTitulo.Text = "Modificar Cliente";
            btnAgregar.Text = "Modificar";
            lblCod.Text = cliente.IdCliente.ToString();
            txtNombre.Text = cliente.Nombre;
            txtRazSocial.Text = cliente.RazonSocial;
            txtCuit.Text = cliente.Cuit.ToString();
            txtIngBrutos.Text = cliente.IngBrutos.ToString();
            txtTipoIngB.Text = cliente.TipoIngBrutos;
            txtDomFiscal.Text = cliente.DomicilioFiscal;
            txtTelefono.Text = cliente.Telefono.ToString();
            txtLocalidad.Text = cliente.Localidad;
            txtMail.Text = cliente.Mail;
            txtCondicionDeVenta.Text = cliente.CondicionVenta;
            txtHorarioDeAtencion.Text = cliente.HorarioAtencion;
            LlenarCombos();
            Estado = Operacion.Modificacion;
        }

        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            switch (boton.Name)
            {
                case "btnAgregar":
                    Cliente modelCliente = new Cliente();
                    Logica.Cliente objLogicaCliente = new Logica.Cliente();

                    modelCliente.Nombre = txtNombre.Text;
                    modelCliente.RazonSocial = txtRazSocial.Text;
                    modelCliente.Cuit = Convert.ToInt64(txtCuit.Text);
                    modelCliente.IngBrutos = Convert.ToInt32(txtIngBrutos.Text);
                    modelCliente.TipoIngBrutos = Convert.ToString(txtTipoIngB.Text);
                    modelCliente.DomicilioFiscal = txtDomFiscal.Text;
                    modelCliente.Telefono = Convert.ToInt64(txtTelefono.Text);
                    modelCliente.Localidad = txtLocalidad.Text;
                    modelCliente.Mail = txtMail.Text;
                    modelCliente.HorarioAtencion = txtHorarioDeAtencion.Text;
                    modelCliente.CondicionVenta = txtCondicionDeVenta.Text;
                    modelCliente.VendedorId = Convert.ToInt32(cboVendedor.SelectedValue);
                    modelCliente.ZonaId = Convert.ToInt32(cboZona.SelectedValue);
                    modelCliente.TransporteId = Convert.ToInt32(cboTransporte.SelectedValue);

                    switch (Estado)
                    {
                        case Operacion.Alta:
                            objLogicaCliente.AgregarCliente(modelCliente);
                            MessageBox.Show("Cliente agregado correctamente.");
                            Close();
                            break;
                        case Operacion.Modificacion:
                            modelCliente.IdCliente = Convert.ToInt32(lblCod.Text);

                            objLogicaCliente.ModificarCliente(modelCliente);
                            MessageBox.Show("Cliente modificado correctamente.");
                            Close();
                            break;
                        default:
                            break;
                    }
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
            Logica.Transporte objTransporte = new Logica.Transporte();
            cboTransporte.DataSource = objTransporte.TraerTransporte();
            cboTransporte.DisplayMember = "NombreTransporte";
            cboTransporte.ValueMember = "IdTransporte";

            Logica.Vendedor objLogVen = new Logica.Vendedor();
            cboVendedor.DataSource = objLogVen.TraerVendedores();
            cboVendedor.DisplayMember = "Nombre";
            cboVendedor.ValueMember = "Id";

            Logica.Zona objLogZona = new Logica.Zona();
            cboZona.DataSource = objLogZona.TraerZonas();
            cboZona.DisplayMember = "Nombre";
            cboZona.ValueMember = "IdZona";
        }
    }
}
