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
            TraerMateriasPrimas();
            TraerDepositos();
        }

        void TraerMateriasPrimas()
        {
            Logica.MateriasPrimas objLogicaMateriasPrimas = new Logica.MateriasPrimas();

            cmbIngresosMateriasPrimas1.DataSource = objLogicaMateriasPrimas.TraerMateriaPrimas();
            cmbIngresosMateriasPrimas1.DisplayMember = "NombreMateriaPrima";
            cmbIngresosMateriasPrimas1.ValueMember = "IdMateriaPrima";
            
        }

        void TraerDepositos()
        {
            Logica.Depositos objLogicaDepositos = new Logica.Depositos();
            cmbSectorIngresos.DataSource = objLogicaDepositos.TraerDeposito();
            cmbSectorIngresos.DisplayMember = "Nombre";
            cmbSectorIngresos.ValueMember = "IdDeposito";

        }

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
                    objEntidad.Responsable = txtResponsable.Text;
                    objEntidad.Cantidad = Convert.ToInt32(txtCantidad1.Text);
                    objEntidad.NumeroRemito = Convert.ToInt32(txtRemito1.Text);

                    //Entidades.Deposito objDepositos = new Entidades.Deposito();
                    //objDepositos.IdDeposito = Convert.ToInt32(cmbSectorIngresos.SelectedValue);
                    objEntidad.DepositoId = (int)cmbSectorIngresos.SelectedValue;

                    //Entidades.MateriaPrima objMateriasPrimas = new Entidades.MateriaPrima(); //Declaracion de variable Materias Primas
                    //objMateriasPrimas.IdMateriaPrima = Convert.ToInt32(cmbIngresosMateriasPrimas1.SelectedValue);
                    objEntidad.MateriaPrimaId = (int)cmbIngresosMateriasPrimas1.SelectedValue;

                    objLogica.AgregarIngresos(objEntidad); //Primer objeto enviado a la transaccion de stock

                    //Envio el articulo y la cantidad a la tabla de Stock

                    Logica.Stock ObjLogicaStock = new Logica.Stock();

                    Entidades.Stock ObjEntidadStock = new Entidades.Stock();
                    ObjEntidadStock.Cantidad = Convert.ToInt32(txtCantidad1.Text);
                    ObjEntidadStock.MateriaPrimaID = (int)cmbIngresosMateriasPrimas1.SelectedValue; 
                    ObjEntidadStock.DepositoID = (int)cmbSectorIngresos.SelectedValue;

                    ObjLogicaStock.AgregarStock(ObjEntidadStock);

                    MessageBox.Show("Articulo ingresados en stock");
                    break;
            }


        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
