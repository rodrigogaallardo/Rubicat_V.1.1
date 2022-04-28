using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
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
            txtFamilia.Text = producto.Familia.ToString();
            txtArquetipo.Text = producto.Arquetipo.ToString();
            txtDescripcion.Text = producto.Descripcion.ToString();
            txtCantidad.Text = producto.Cantidad.ToString();
            txtPeso.Text = producto.Peso.ToString();
            txtCosto.Text = producto.Costo.ToString();
            //txtPrecio.Text = producto.Precio.ToString();
            //txtEan.Text = producto.Ean.ToString();

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

                    ///////////////////////////////////////VERIFICACIÓN DE CAMPOS//////////////////////////////////////////////////////////

                    modelProd.Familia = txtFamilia.Text;
                    if (modelProd.Familia == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Familia de Producto'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    modelProd.Arquetipo = txtArquetipo.Text;
                    if (modelProd.Arquetipo == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Arquetipo de Producto'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    modelProd.Nombre = txtNombre.Text;
                    if (modelProd.Nombre == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Nombre de Producto'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }                                    
                    modelProd.Descripcion = txtDescripcion.Text;
                    if (modelProd.Descripcion == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Descripción de Producto'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    try
                    {
                        modelProd.Peso = Convert.ToDecimal(txtPeso.Text);
                    }
                    catch (FormatException)
                    {
                        //Aca entra cuando es null y cuando ingreso caracteres 
                        MessageBox.Show("Ingrese un peso en el area: 'Peso'", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Ingreso un peso fuera de los limites permitidos", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    catch (UpdateException)
                    {
                        MessageBox.Show("Ingreso un peso fuera de los limites permitidos", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }

                    try
                    {
                        modelProd.Costo = Convert.ToDecimal(txtCosto.Text);
                    }
                    catch (FormatException)
                    {
                        //Aca entra cuando es null y cuando ingreso caracteres 
                        MessageBox.Show("Ingrese un costo en el area: 'Costo'", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Ingreso un costo fuera de los limites permitidos", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    catch (UpdateException)
                    {
                        MessageBox.Show("Ingreso un costo fuera de los limites permitidos", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }


                    try
                    {
                        modelProd.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    }
                    catch (FormatException)
                    {
                        //Aca entra cuando es null y cuando ingreso caracteres 
                        MessageBox.Show("Ingrese una cantidad en el area: 'Camtidad'", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Ingreso una cantidad fuera de los limites permitidos", "Campo mal ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    

                    //modelProd.Precio = Convert.ToDecimal(txtPrecio.Text);
                    //modelProd.Ean = Convert.ToInt32(txtEan.Text);

                    ////////////////////////////////////////////////FIN DE VERIFICACIÓN DE CAMPOS/////////////////////////////////////////////////
                    switch (Estado)
                    {
                        case Operacion.Alta:
                            objLogProd.AgregarProducto(modelProd);
                            MessageBox.Show("Producto agregado correctamente.","Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtFamilia.Clear();
                            txtArquetipo.Clear();
                            txtNombre.Clear();
                            txtDescripcion.Clear();
                            txtPeso.Clear();
                            txtCosto.Clear();
                            txtCantidad.Clear();
                            break;
                        case Operacion.Modificacion:
                            modelProd.IdProducto = Convert.ToInt32(lblCod.Text);
                            objLogProd.ModificarProducto(modelProd);
                            MessageBox.Show("Producto modificado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
