using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinRubicat
{
    public partial class FrmVenta : Form
    {
        public delegate void DelegadoTabla(List<DetalleVenta> carrito);
        List<DetalleVenta> carrito = new List<DetalleVenta>();

        // Clases a usar en los métodos
        Logica.Venta objLogicaVenta = new Logica.Venta();
        Logica.Producto objLogProd = new Logica.Producto();
        Logica.DetalleVenta objLogDet = new Logica.DetalleVenta();
        public FrmVenta()
        {
            
            InitializeComponent();
            btnAgregarVta.Click += Botones;
            btnCancelar.Click += Botones;
            btnNuevoCliente.Click += Botones;
            btnNuevoVendedor.Click += Botones;
            btnAgregarProd.Click += Botones;
            btnDescuento.Click += Botones;
            dgvProductos.CellEndEdit += ModificarCarrito;
            dtpFecha.Value = DateTime.Now;
            LlenarCombos();
        }

        /// <summary>
        /// Modificar el carrito del <typeparamref name="DataGridView"/> basándose en las modificaciones
        /// hechas en el control y carga Subtotal y Total
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModificarCarrito(object sender, DataGridViewCellEventArgs e)
        {
            int intCant = Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value);
            decimal decImporte = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[4].Value);
            int intIndex = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);

            objLogDet.ModificarCarrito(intCant, decImporte, intIndex, carrito);
            CargarTotales();
            AplicarDescuento();
            BeginInvoke(new DelegadoTabla(CargarTabla), carrito);
        }

        private void Botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            switch (boton.Name)
            {
                case "btnAgregarVta":
                    Venta objModelVenta = new Venta();
                    objModelVenta.Importe = Convert.ToDecimal(txtTotal.Text);
                    objLogicaVenta.CargarVenta(objModelVenta, carrito);
                    objModelVenta.Fecha = dtpFecha.Value;
                    objModelVenta.ClienteId = Convert.ToInt32(cboCliente.SelectedValue);
                    objModelVenta.VendedorId = Convert.ToInt32(cboVendedor.SelectedValue);
                    objLogicaVenta.AgregarVenta(objModelVenta);
                    MessageBox.Show("Venta agregada correctamente.");
                    Close();
                    break;
                case "btnNuevoCliente":
                    // Muestra formulario de cliente
                    FrmCliente FrmNuevoCli = new FrmCliente();
                    FrmNuevoCli.Dock = DockStyle.Fill;
                    FrmNuevoCli.Show();
                    break;
                case "btnNuevoVendedor":
                    // Muestra formulario de vendedor
                    FrmVendedor FrmNuevoVend = new FrmVendedor();
                    FrmNuevoVend.Dock = DockStyle.Fill;
                    FrmNuevoVend.Show();
                    break;
                case "btnAgregarProd":
                    //Agrega productos a la DataGridView del formulario
                    DetalleVenta nItem = new DetalleVenta();
                    Producto prod;
                    prod = objLogProd.TraerPorId(Convert.ToInt32(cboProducto.SelectedValue));
                    decimal precio = Convert.ToDecimal(txtPrecio.Text);
                    nItem.ProductoId = Convert.ToInt32(cboProducto.SelectedValue);
                    nItem.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    nItem.Precio = precio;
                    nItem.Costo = prod.Costo;
                    nItem.Peso = prod.Peso;
                    // Comprueba si ya se agrego un producto con el mismo id y sino lo agrega
                    objLogDet.CargarCarrito(nItem, carrito);
                    // Carga la tabla en base al carrito
                    CargarTotales();
                    AplicarDescuento();
                    CargarTabla(carrito);
                    break;
                case "btnDescuento":
                    AplicarDescuento();
                    break;
                case "btnCancelar":
                    this.Close();
                    break;
            }
        }

        void CargarTotales()
        {
            txtSubTotal.Text = objLogDet.CargarSubtotal(carrito).ToString();
            txtTotal.Text = objLogDet.CargarTotal(carrito).ToString();
        }

        /// <summary>
        /// Crea una <typeparamref name="DataTable"/> en memoria, para cargarla recibe
        /// un parámetro del tipo lista de <typeparamref name="DetalleVenta"/>
        /// </summary>
        /// <param name="ventas"></param>
        void CargarTabla(List<DetalleVenta> ventas)
        {
            DataTable dtProductos = new DataTable();
            dtProductos.Columns.Add("IdProducto", typeof(int));
            dtProductos.Columns.Add("Nombre", typeof(string));
            dtProductos.Columns.Add("Cantidad", typeof(int));
            dtProductos.Columns.Add("Costo unidad", typeof(decimal));
            dtProductos.Columns.Add("Precio unidad", typeof(decimal));
            dtProductos.Columns.Add("Importe", typeof(decimal));
            dtProductos.Columns.Add("Rentabilidad Bruta", typeof(decimal));
            dtProductos.Columns.Add("CMV", typeof(decimal));
            
            foreach (var venta in ventas)
            {
                DataRow fila = dtProductos.NewRow();
                fila["IdProducto"] = venta.ProductoId; ;
                fila["Nombre"] = objLogProd.TraerPorId(venta.ProductoId).Arquetipo;
                fila["Cantidad"] = venta.Cantidad;
                fila["Costo unidad"] = Math.Round(venta.Costo, 2);
                fila["Precio unidad"] = Math.Round(venta.Precio, 2);
                fila["Importe"] = Math.Round(venta.Precio * venta.Cantidad,2);
                fila["Rentabilidad Bruta"] = Math.Round((venta.Precio * venta.Cantidad) - (venta.Costo * venta.Cantidad), 2);
                fila["CMV"] = Math.Round(venta.Costo * venta.Cantidad, 2);

                dtProductos.Rows.Add(fila);
            }
            dgvProductos.DataSource = dtProductos;
        }

        void AplicarDescuento()
        {
            decimal descuento=0;
            string tipo;
            if (txtDescuento.Text=="")
            {
                txtDescuento.Text = "0";
            }
            else
            {
                txtVerDesc.Text = txtDescuento.Text;
            }
            descuento = Convert.ToDecimal(txtVerDesc.Text);

            if (rbEfectivo.Checked==true & carrito.Count>0)
            {
                tipo = rbEfectivo.Text;
                txtTotal.Text = Convert.ToString(objLogDet.TraerDescuento(carrito, descuento, tipo));
            }
            else if(rbPorcentaje.Checked==true & carrito.Count > 0)
            {
                tipo = rbPorcentaje.Text;
                txtTotal.Text = Convert.ToString(objLogDet.TraerDescuento(carrito, descuento, tipo));
            }
        }

        /// <summary>
        /// Carga los ComboBox del formulario mostrando el campo "Nombre" del registro
        /// y guardando como valor el campo "Id" del mismo
        /// </summary>
        void LlenarCombos()
        {
            //Transportes
            cboTransporte.DisplayMember = "DireccionTransporte";
            cboTransporte.ValueMember = "IdTransporte";
            Logica.Transporte objLogicaTransporte = new Logica.Transporte();
            cboTransporte.DataSource = objLogicaTransporte.TraerTransporte();
            //Productos
            cboProducto.DisplayMember = "Arquetipo";
            cboProducto.ValueMember = "IdProducto";
            Logica.Producto objLogicaProd = new Logica.Producto();
            cboProducto.DataSource = objLogicaProd.TraerProductos();

            //Clientes
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "Id";
            Logica.Cliente objLogicaCli = new Logica.Cliente();
            cboCliente.DataSource = objLogicaCli.TraerClientes();

            //Vendedores
            cboVendedor.DisplayMember = "Nombre";
            cboVendedor.ValueMember = "Id";
            Logica.Vendedor objLogicaVend = new Logica.Vendedor();
            cboVendedor.DataSource = objLogicaVend.TraerVendedores();
        }

    }
}
