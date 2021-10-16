using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinRubicat
{
    public partial class FrmProd : Form
    {
        public enum Operacion
        {
            Alta,
            Modificacion
        }
        public Operacion Estado { get; set; }
        //Form agrega producto
        public FrmProd()
        {
            InitializeComponent();
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
            lblTitulo.Text = "Agregar Producto";
            lblCod.Text = "";
            Estado = Operacion.Alta;
        }
        //Form modifica producto
        public FrmProd(Entidades.Producto producto)
        {
            InitializeComponent();
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
            lblCod.Text = producto.IdProducto.ToString();
            lblTitulo.Text = "Modificar Producto";
            btnAgregar.Text = "Modificar";

            txtNombre.Text = producto.Nombre;
            txtPeso.Text = producto.Peso.ToString();
            txtCosto.Text = producto.Costo.ToString();
            txtPrecio.Text = producto.Precio.ToString();
            txtEan.Text = producto.Ean.ToString();

            Estado = Operacion.Modificacion;
        }

        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            //Objetos de models y de logica para traer propiedades y metodos
            Producto modelProd = new Producto();
            Logica.Producto objLogProd = new Logica.Producto();

            switch (boton.Name)
            {
                case "btnAgregar":
                    modelProd.Nombre = txtNombre.Text;
                    modelProd.Peso = Convert.ToDouble(txtPeso.Text);
                    modelProd.Costo = Convert.ToDecimal(txtCosto.Text);
                    modelProd.Precio = Convert.ToDecimal(txtPrecio.Text);
                    modelProd.Ean = Convert.ToInt32(txtEan.Text);
                    switch (Estado)
                    {
                        case Operacion.Alta:
                            objLogProd.AgregarProducto(modelProd);
                            MessageBox.Show("Producto agregado correctamente.");
                            Close();
                            break;
                        case Operacion.Modificacion:
                            modelProd.IdProducto = Convert.ToInt32(lblCod.Text);
                            objLogProd.ModificarProducto(modelProd);
                            MessageBox.Show("Producto modificado correctamente.");
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
    }
}
