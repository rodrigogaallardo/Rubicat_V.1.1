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
    public partial class FrmMateriasPrimas : Form
    {
        
        public FrmMateriasPrimas()
        {
            InitializeComponent();
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
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

                    Logica.MateriasPrimas objLogica = new Logica.MateriasPrimas();

                    Entidades.MateriaPrima objEntidad = new Entidades.MateriaPrima();
                    objEntidad.FamiliaMateriaPrima = txtFamilia.Text;
                    objEntidad.ArquetipoMateriaPrima = txtArquetipo.Text;
                    objEntidad.DescripcionMateriaPrima = txtDescripcion.Text;
                    objEntidad.CostoMateriaPrima = Convert.ToDecimal(txtCosto.Text);
                    objEntidad.CantidadMateriaPrima = Convert.ToInt32(txtCantidad.Text);
                    objEntidad.PesoMateriaPrima = Convert.ToInt32(txtPeso.Text);

                    objLogica.AgregarMateriaPrima(objEntidad);
                    MessageBox.Show("Producto agregado a la base de datos!");
                    break;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
