using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRubicat
{
    public partial class FrmIngresosStock : Form
    {
        public FrmIngresosStock()
        {
            InitializeComponent();
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
        }      

       
        Logica.Producto objLogProd = new Logica.Producto();
        Logica.Depositos objLogDeposito = new Logica.Depositos();
        Logica.Stock objStock = new Logica.Stock();

        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            switch (boton.Name)
            {
                case "btnCancelar":
                    Close();
                    break;
                case "btnAgregar":

                    Logica.IngresosStock objLogica = new Logica.IngresosStock();

                    /* Valores que son comun para todos los productos*/
                    Entidades.IngresoStock objEntidad = new Entidades.IngresoStock();

                    objEntidad.FechaIngreso = dtpFechaDeIngresoStock.Value;
                    objEntidad.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    objEntidad.Responsable = txtResponsable.Text;
                    objEntidad.DepositoId = Convert.ToInt32(cmbSectorIngresos.SelectedValue);
                    objEntidad.ProductoId = Convert.ToInt32(cboProducto.SelectedValue);
                    objEntidad.CantidadMinima = Convert.ToInt32(txtCantidadMinima.Text);
                    objEntidad.SumaUnidadesIngresados = Convert.ToInt32(txtCantidad.Text) + objEntidad.SumaUnidadesIngresados;
                    objEntidad.SumaUnidadesUsadas = 0;
                    objEntidad.StockFinal = objEntidad.SumaUnidadesIngresados - objEntidad.SumaUnidadesUsadas;
                    objEntidad.Status = 0;
                    objLogica.AgregarIngresos(objEntidad);

                    //objEntidadStock.SumaUnidadesIngresados = Convert.ToInt32(txtCantidad.Text);
                    //objEntidadStock.SumaUnidadesUsadas = 0;
                    //objEntidadStock.StockFinal = objEntidadStock.SumaUnidadesIngresados - objEntidadStock.SumaUnidadesUsadas;
                    //objEntidadStock.StockMinimo = Convert.ToInt32(txtCantidadMinima.Text);
                    //objStock.AgregarStock(objEntidadStock);


                    MessageBox.Show("Articulo ingresados en stock");
                    break;
            }
        }

        //Carga de combobox de producto, carga de combobox de 
        private void cboProducto_TextChanged(object sender, EventArgs e)
        {
            Logica.Producto objLogicaProd = new Logica.Producto();
            cboProducto.DataSource = objLogicaProd.SelectProducto(cboProducto.Text);
            cboProducto.DisplayMember = "CodProducto";
            cboProducto.ValueMember = "IdProducto";
        }
        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboProducto.SelectedValue);
            txtCodigoProducto.Text = objLogProd.TraerPorId(id).Nombre;
        }
        private void cmbSectorIngresos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbSectorIngresos.SelectedValue);
            txtNombreDeposito.Text = objLogDeposito.TraerPorId(id).Descripcion;
        }
        private void cmbSectorIngresos_TextChanged(object sender, EventArgs e)
        {
            cmbSectorIngresos.DataSource = objLogDeposito.SelectDeposito(cmbSectorIngresos.Text);
            cmbSectorIngresos.DisplayMember = "Nombre";
            cmbSectorIngresos.ValueMember = "IdDeposito";
        }
    }
}
