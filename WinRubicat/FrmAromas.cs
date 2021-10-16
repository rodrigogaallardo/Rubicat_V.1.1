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
    public partial class FrmAromas : Form
    {
        public FrmAromas()
        {
            InitializeComponent();
            //subcribir los eventos click de los 2 botones
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
        }

        private void botones(object sender, EventArgs e)
        {
            //codigo va a ejecutarse cuando el usuario 
            //haga click en alguno de los 2 botones
            Button boton = sender as Button; // vuelvo a poner las propiades del boton de .net
            switch (boton.Name)
            {
                case "btnCancelar":
                    Close();
                    break;
                case "btnAgregar":
                    //comunicarnos con la capa de logica
                    Logica.MateriasPrimas objLogica = new Logica.MateriasPrimas();

                    Entidades.MateriaPrima objEntidad = new Entidades.MateriaPrima();

                    objEntidad.NombreMateriaPrima = cmbAromas.SelectedItem.ToString();
                    objEntidad.CostoMateriaPrima = Convert.ToInt32(txtCantidad.Text);

                    objLogica.AgregarMateriaPrima(objEntidad);
                    MessageBox.Show("Producto agregado a la base de datos!");
                    break;
            }


        }

        private void FrmAromas_Load(object sender, EventArgs e)
        {

        }
    }
}
