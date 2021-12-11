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
            txtFamilia.Text = materiasPrimas.FamiliaMateriaPrima.ToString();
            txtArquetipo.Text = materiasPrimas.ArquetipoMateriaPrima.ToString();
            txtDescripcion.Text = materiasPrimas.DescripcionMateriaPrima.ToString();
            txtCosto.Text = materiasPrimas.CostoMateriaPrima.ToString();
            txtCantidad.Text = materiasPrimas.CantidadMateriaPrima.ToString();
            txtPeso.Text = materiasPrimas.PesoMateriaPrima.ToString();
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
                    materiaPrimaMod.FamiliaMateriaPrima = txtFamilia.Text;
                    materiaPrimaMod.ArquetipoMateriaPrima = txtArquetipo.Text;
                    materiaPrimaMod.DescripcionMateriaPrima = txtDescripcion.Text;
                    materiaPrimaMod.CostoMateriaPrima = Convert.ToDecimal(txtCosto.Text);
                    materiaPrimaMod.CantidadMateriaPrima = Convert.ToInt32(txtCantidad.Text);
                    materiaPrimaMod.PesoMateriaPrima = Convert.ToInt32(txtPeso.Text);
                    objLogMatMod.ModificarMateriaPrima(materiaPrimaMod);
                    MessageBox.Show("Articulo modificado correctamente.");
                    Close();
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
