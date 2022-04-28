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
            //LlenarCombos();
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
            //LlenarCombos();
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
                    if (modelCliente.Nombre == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Nombre de Cliente'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    modelCliente.RazonSocial = txtRazSocial.Text;
                    if (modelCliente.RazonSocial == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Razón Social'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    
                    try
                    {
                        modelCliente.Cuit = Convert.ToInt64(txtCuit.Text);
                    }
                    catch (FormatException)
                    {
                        //Aca entra cuando es null y cuando ingreso caracteres 
                        MessageBox.Show("Ingresar un valor numérico en el area: 'Cuit de Cliente'", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Número fuera de rango en el area: 'Cuit de Cliente'", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }

                    

                    try
                    {
                        modelCliente.IngBrutos = Convert.ToInt32(txtIngBrutos.Text);
                    }
                    catch (FormatException)
                    {
                        //Aca entra cuando es null y cuando ingreso caracteres 
                        MessageBox.Show("Ingresar un valor numérico en el área: 'Ingresos Brutos '", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Número fuera de rango en el área: 'Ingresos Brutos ''", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }

                    modelCliente.TipoIngBrutos = Convert.ToString(txtTipoIngB.Text);

                    if (modelCliente.TipoIngBrutos == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Tipo de Ingresos Brutos'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    modelCliente.DomicilioFiscal = txtDomFiscal.Text;

                    if (modelCliente.DomicilioFiscal == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Domicilio Fiscal'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    modelCliente.Localidad = txtLocalidad.Text;
                    if (modelCliente.Localidad == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Localidad'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    try
                    {
                        modelCliente.Telefono = Convert.ToInt64(txtTelefono.Text);
                    }
                    catch (FormatException)
                    {
                        //Aca entra cuando es null y cuando ingreso caracteres 
                        MessageBox.Show("Ingresar un valor numérico en el área: 'Teléfono del Cliente'", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Número fuera de rango en el área: 'Teléfono del Cliente''", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    
                    modelCliente.Mail = txtMail.Text;
                    if (modelCliente.Mail == "" ) 
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Email'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (modelCliente.Mail.IndexOf("@") == -1)
                    {
                        MessageBox.Show("Ingresar un mail valido en el area: 'Email'", "Email Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    modelCliente.CondicionVenta = txtCondicionDeVenta.Text;
                    if (modelCliente.CondicionVenta == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Condición de venta'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    modelCliente.HorarioAtencion = txtHorarioDeAtencion.Text;
                    if (modelCliente.HorarioAtencion == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Horario de Atencion'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    
                    try
                    {
                        _ = cboTransporte.SelectedItem.ToString() != null;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No puede dejar vacío el área: 'Transporte'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    modelCliente.TransporteId = Convert.ToInt32(cboTransporte.SelectedValue);

                    try
                    {
                        _ = cboVendedor.SelectedItem.ToString() != null;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No puede dejar vacío el área: 'Vendedor'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    modelCliente.VendedorId = Convert.ToInt32(cboVendedor.SelectedValue);

                    try
                    {
                        _ = cboZona.SelectedItem.ToString() != null;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No puede dejar vacío el área: 'Zona'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    modelCliente.ZonaId = Convert.ToInt32(cboZona.SelectedValue);

                    switch (Estado)
                    {
                        case Operacion.Alta:
                            objLogicaCliente.AgregarCliente(modelCliente);
                            MessageBox.Show("Cliente agregado correctamente.","Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNombre.Clear();
                            txtRazSocial.Clear();
                            txtCuit.Clear();
                            txtIngBrutos.Clear();
                            txtTipoIngB.Clear();
                            txtDomFiscal.Clear();
                            txtLocalidad.Clear();
                            txtTelefono.Clear();
                            txtMail.Clear();
                            txtCondicionDeVenta.Clear();
                            txtHorarioDeAtencion.Clear();
                            break;
                            
                        case Operacion.Modificacion:
                            modelCliente.IdCliente = Convert.ToInt32(lblCod.Text);
                            objLogicaCliente.ModificarCliente(modelCliente);
                            MessageBox.Show("Cliente modificado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cboZona_TextChanged(object sender, EventArgs e)
        {
            Logica.Zona objLogicaCliente = new Logica.Zona();
            cboZona.DataSource = objLogicaCliente.SelectZona(cboZona.Text);
            cboZona.DisplayMember = "Nombre";
            cboZona.ValueMember = "IdZona";
        }

        private void cboTransporte_TextChanged(object sender, EventArgs e)
        {
            Logica.Transporte objLogicaTransp = new Logica.Transporte();
            cboTransporte.DataSource = objLogicaTransp.SelectTransporte(cboTransporte.Text);
            cboTransporte.DisplayMember = "NombreTransporte";
            cboTransporte.ValueMember = "IdTransporte";
        }

        private void cboVendedor_TextChanged(object sender, EventArgs e)
        {
            Logica.Vendedor objLogicaVendedor = new Logica.Vendedor();
            cboVendedor.DataSource = objLogicaVendedor.SelectCliente(cboVendedor.Text);
            cboVendedor.DisplayMember = "Nombre";
            cboVendedor.ValueMember = "IdVendedor";
        }
    }
}
