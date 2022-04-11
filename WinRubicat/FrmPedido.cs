﻿using System;
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
    public partial class FrmPedido : Form
    {
        public enum Operacion
        {
            Alta,
            Modificacion
        }
        public Operacion Estado { get; set; }
        public FrmPedido()
        {
            InitializeComponent();
            btnCancelar.Click += botones;
            btnActualizar.Click += botones;
            btnParcialPedido.Click += botones;
            btnAplicarDescuento.Click += botones;
            btnAgregarPedido.Click += botones;
            
            //LlenarCombos();
            //LlenarTxtBoxClientes();
            //LlenarTxtBoxTransporte();
            //LlenarTxtBoxProducto();
            lblTitulo.Text = "Nuevo Pedido";
            lblCodigo.Text = "";
            lblId.Text = "";
            Estado = Operacion.Alta;
        }
        public FrmPedido(Entidades.Pedido pedido)
        {
            InitializeComponent();
            btnCancelar.Click += botones;
            btnActualizar.Click += botones;
            btnParcialPedido.Click += botones;
            btnAplicarDescuento.Click += botones;
            btnAgregarPedido.Click += botones;
            
            LlenarCombos();
            //LlenarTxtBoxClientes();
            //LlenarTxtBoxTransporte();
            //LlenarTxtBoxProducto();
            lblCodigo.Text = pedido.IdPedido.ToString();
            lblTitulo.Text = "Modificar Deposito";
            txtNumeroDeRemito.Text = pedido.NumeroDeRemito.ToString();
            Estado = Operacion.Modificacion;
        }

        List<Pedido> ListaPedido = new List<Pedido>();

        Logica.Aprobado objLogAprobado = new Logica.Aprobado();
        Logica.Pedido objLogicaPedido = new Logica.Pedido();
        Logica.Producto objLogProd = new Logica.Producto();
        Logica.Transporte objLogicaTransporte = new Logica.Transporte();
        Logica.Cliente objCliente = new Logica.Cliente();

       
        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            switch (boton.Name)
            {
                case "btnBuscar":

                    break;
                case "btnAgregarPedido":

                    Pedido objPedido = new Pedido();
                    objPedido.NumeroDeRemito = Convert.ToInt32(txtNumeroDeRemito.Text);
                    objPedido.FechaDeEntrega = dtpFechaDeEntrega.Value;
                    objPedido.FechaDePedido = dtpFechaDePedido.Value;
                    objPedido.ClienteId = Convert.ToInt32(cboCliente.SelectedValue);
                    objPedido.ProductoId = Convert.ToInt32(cboProducto.SelectedValue);
                    objPedido.TransporteId = Convert.ToInt32(cboTransporte.SelectedValue);
                    objPedido.ValorFinal = AplicarDescuento();


                    switch (Estado)
                    {
                        case Operacion.Alta:
                            objLogicaPedido.AgregarPedido(objPedido);
                            //objLogAprobado.AgregarAprobado(objAprobado);
                            MessageBox.Show("Pedido agregado correctamente.");
                            dgvPedidoParcial.Columns.Clear();
                            break;

                        case Operacion.Modificacion:
                            objPedido.IdPedido = Convert.ToInt32(lblCodigo.Text);
                            objLogicaPedido.ModificarPedido(objPedido);
                            MessageBox.Show("Pedido modificado correctamente.");
                            dgvPedidoParcial.Columns.Clear();
                            break;

                        default:
                            break;
                    }

                    break;

                case "btnAplicarDescuento" :
                    ActualizarPedidoParcial();
                    break;

                case "btnParcialPedido":
                    ActualizarPedidoParcial();
                    break;

                case "btnActualizar":
                    ActualizarDatos();
                    break;

                case "btnCancelar":
                    this.Close();
                    break;
            }
        }
        void ActualizarPedidoParcial()
        {
            //if (Convert.ToInt32(dgvPedidoParcial.CurrentRow.Cells[0].Value))
            //{

            //}
            dgvPedidoParcial.DataSource = null;
            Pedido objPedido = new Pedido();
            objPedido.NumeroDeRemito = Convert.ToInt32(txtNumeroDeRemito.Text);
            objPedido.FechaDeEntrega = dtpFechaDeEntrega.Value;
            objPedido.FechaDePedido = dtpFechaDePedido.Value;
            objPedido.ClienteId = Convert.ToInt32(cboCliente.SelectedValue);
            objPedido.ProductoId = Convert.ToInt32(cboProducto.SelectedValue);
            objPedido.TransporteId = Convert.ToInt32(cboTransporte.SelectedValue);

            //Descuento

            objPedido.ValorFinal = AplicarDescuento();
            txtSubTotal.Text = Convert.ToString(Convert.ToInt32(txtCantidadProducto.Text) * Convert.ToDecimal(txtPrecioProducto.Text));
            txtTotal.Text = Convert.ToString(objPedido.ValorFinal);
            ListaPedido.Add(objPedido);

            
            dgvPedidoParcial.DataSource = ListaPedido;
        }

        private decimal AplicarDescuento()
        {
            decimal ValorInicial = Convert.ToInt32(txtCantidadProducto.Text) * Convert.ToDecimal(txtPrecioProducto.Text);
            decimal ValorFinal;
            decimal Descuento;
            
            if (rbEfectivo.Checked == true)
            {
                Descuento = Convert.ToDecimal(txtDescuento.Text);
                ValorFinal = ValorInicial - Descuento;
                txtVerDesc.Text = Convert.ToString(Descuento);
                return ValorFinal;

            }
            else if (rbPorcentaje.Checked == true)
            {
                Descuento = (ValorInicial * (Convert.ToDecimal(txtDescuento.Text) / 100));
                ValorFinal = ValorInicial - Descuento;
                txtVerDesc.Text = Convert.ToString(Descuento);
                return ValorFinal;
            }
            else
            {
                txtVerDesc.Text = Convert.ToString(0);
                return ValorFinal = Convert.ToInt32(txtCantidadProducto.Text) * Convert.ToDecimal(txtPrecioProducto.Text);
            }    
            


        }
        void CargarTabla()
        {
            DataTable dtPedidoParcial = new DataTable();
            dtPedidoParcial.Columns.Add("Fecha de pedido", typeof(DateTime));
            dtPedidoParcial.Columns.Add("Fecha de entrega", typeof(DateTime));
            dtPedidoParcial.Columns.Add("Numero de remito", typeof(int));
            dtPedidoParcial.Columns.Add("Cliente", typeof(string));
            dtPedidoParcial.Columns.Add("Producto", typeof(string));
            dtPedidoParcial.Columns.Add("Precio unidad", typeof(decimal));

            

            //foreach (var venta in pedidos)
            //{
            //    DataRow fila = dtProductos.NewRow();
            //    fila["IdProducto"] = venta.ProductoId; ;
            //    fila["Nombre"] = objLogProd.TraerPorId(venta.ProductoId).Arquetipo;
            //    fila["Cantidad"] = venta.Cantidad;
            //    fila["Costo unidad"] = Math.Round(venta.Costo, 2);
            //    fila["Precio unidad"] = Math.Round(venta.Precio, 2);
            //    fila["Importe"] = Math.Round(venta.Precio * venta.Cantidad, 2);
            //    fila["Rentabilidad Bruta"] = Math.Round((venta.Precio * venta.Cantidad) - (venta.Costo * venta.Cantidad), 2);
            //    fila["CMV"] = Math.Round(venta.Costo * venta.Cantidad, 2);

            //    dtProductos.Rows.Add(fila);
            //}
            dgvPedidoParcial.DataSource = dtPedidoParcial;
        }

        void ActualizarDatos()
        {
            //LlenarTxtBoxClientes();
            //LlenarTxtBoxTransporte();
            //LlenarTxtBoxProducto();
        }
        
        void LlenarTxtBoxClientes()
        {
           

            switch (cboCliente.SelectedIndex)
            {
                default:
                    int id = Convert.ToInt32(cboCliente.SelectedValue);
                    txtDomicilio.Text = objCliente.TraerPorId(id).DomicilioFiscal;
                    txtLocalidad.Text = objCliente.TraerPorId(id).Localidad;
                    txtIva.Text = objCliente.TraerPorId(id).TipoIngBrutos;
                    txtCondicion.Text = objCliente.TraerPorId(id).CondicionVenta;
                    txtCuit.Text = Convert.ToString(objCliente.TraerPorId(id).Cuit);
               break;
            }
            
            
            
        }
        void LlenarTxtBoxTransporte()
        {
            int id = Convert.ToInt32(cboTransporte.SelectedValue);
            txtDireccionTransporte.Text = objLogicaTransporte.TraerPorId(id).DireccionTransporte;
            txtTelefonoTransporte.Text = Convert.ToString(objLogicaTransporte.TraerPorId(id).TelefonoTransporte);
            txtHorarioTransporte.Text = objLogicaTransporte.TraerPorId(id).HorarioDeTransporte;
        }
        void LlenarTxtBoxProducto()
        {
            int id = Convert.ToInt32(cboProducto.SelectedValue);
            txtCantidadProducto.Text = Convert.ToString(objLogProd.TraerPorId(id).Cantidad);
            txtPrecioProducto.Text = Convert.ToString(objLogProd.TraerPorId(id).Costo);
        }

        void LlenarCombos()
        {
            //Clientes
            Logica.Cliente objLogicaCli = new Logica.Cliente();
            cboCliente.DataSource = objLogicaCli.TraerClientes();
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "Id";

            //Transportes
            Logica.Transporte objLogicaTransporte = new Logica.Transporte();
            cboTransporte.DataSource = objLogicaTransporte.TraerTransporte();
            cboTransporte.DisplayMember = "NombreTransporte";
            cboTransporte.ValueMember = "IdTransporte";

            //Productos
            Logica.Producto objLogicaProd = new Logica.Producto();
            cboProducto.DataSource = objLogicaProd.TraerProductos();
            cboProducto.DisplayMember = "Nombre";
            cboProducto.ValueMember = "IdProducto";
            
        }



        private void cboProducto_TextChanged(object sender, EventArgs e)
        {
            Logica.Producto objLogicaProd = new Logica.Producto();
            cboProducto.DataSource = objLogicaProd.SelectProducto(cboProducto.Text);
            cboProducto.DisplayMember = "Nombre";
            cboProducto.ValueMember = "IdProducto";
        }

       

        private void cboTransporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cuando cambio un item llena los textboxs
            int id = Convert.ToInt32(cboTransporte.SelectedValue);
            txtDireccionTransporte.Text = objLogicaTransporte.TraerPorId(id).DireccionTransporte;
            txtTelefonoTransporte.Text = Convert.ToString(objLogicaTransporte.TraerPorId(id).TelefonoTransporte);
            txtHorarioTransporte.Text = objLogicaTransporte.TraerPorId(id).HorarioDeTransporte;

        }

        private void cboTransporte_TextChanged(object sender, EventArgs e)
        {
            Logica.Transporte objLogicaTransp = new Logica.Transporte();
            cboTransporte.DataSource = objLogicaTransp.SelectTransporte(cboTransporte.Text);
            cboTransporte.DisplayMember = "NombreTransporte";
            cboTransporte.ValueMember = "IdTransporte";
        }

        private void cboCliente_TextChanged(object sender, EventArgs e)
        {
            Logica.Cliente objLogicaCliente = new Logica.Cliente();
            cboCliente.DataSource = objLogicaCliente.SelectCliente(cboCliente.Text);
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "IdCliente";
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboCliente.SelectedValue);
            txtDomicilio.Text = objCliente.TraerPorId(id).DomicilioFiscal;
            txtLocalidad.Text = objCliente.TraerPorId(id).Localidad;
            txtIva.Text = objCliente.TraerPorId(id).TipoIngBrutos;
            txtCondicion.Text = objCliente.TraerPorId(id).CondicionVenta;
            txtCuit.Text = Convert.ToString(objCliente.TraerPorId(id).Cuit);
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cuando cambio un item llena los textboxs
            int id = Convert.ToInt32(cboProducto.SelectedValue);
            txtCantidadProducto.Text = Convert.ToString(objLogProd.TraerPorId(id).Cantidad);
            txtPrecioProducto.Text = Convert.ToString(objLogProd.TraerPorId(id).Costo);
        }
    }
}
