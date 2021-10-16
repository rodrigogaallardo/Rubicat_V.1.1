using System;
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
    public partial class FrmModificar : Form
    {
        public FrmModificar(Entidades.MateriaPrima materiasPrimas)
        {
            InitializeComponent();
            btnModificar.Click += botones;
            btnCancelar.Click += botones;
            lblCodigo.Text = materiasPrimas.IdMateriaPrima.ToString();
            txtNombreArticulo.Text = materiasPrimas.NombreMateriaPrima.ToString();
            txtCosto.Text = materiasPrimas.CostoMateriaPrima.ToString();
        }

        private void botones(object sender, EventArgs e)
        {
            
            Button boton = sender as Button;

            //Objetos de models y de logica para traer propiedades y metodos
            MateriaPrima materiaPrimaMod = new MateriaPrima();
            Logica.MateriasPrimas objLogMatMod = new Logica.MateriasPrimas();

            switch (boton.Name)
            {
                case "btnCancelar":
                    Close();
                    break;
                case "btnModificar":
                    materiaPrimaMod.IdMateriaPrima = Convert.ToInt32(lblCodigo.Text);
                    materiaPrimaMod.NombreMateriaPrima = txtNombreArticulo.Text;
                    materiaPrimaMod.CostoMateriaPrima = Convert.ToDecimal(txtCosto.Text);

                    objLogMatMod.ModificarMateriaPrima(materiaPrimaMod);
                    MessageBox.Show("Articulo modificado correctamente.");
                    Close();
                    break;
            }


        }
    }
}
