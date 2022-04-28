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
    public partial class FrmZona : Form
    {
        public FrmZona()
        {
            InitializeComponent();
            btnAgregarZona.Click += botones;
            btnCancelar.Click += botones;
            //btnAgregarZona.Text = "Agregar";
            //btnCancelar.Text = "Cancelar";
        }
        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            Logica.Zona objLogZona = new Logica.Zona();
            Zona modelZona = new Zona();

            switch (boton.Name)
            {
                case "btnAgregarZona":
                    modelZona.Nombre = txtNombre.Text;
                    if (modelZona.Nombre == "")
                    {
                        MessageBox.Show("No puede dejar vacío el área: 'Zona'", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    objLogZona.AgregarZona(modelZona);
                    MessageBox.Show("Zona agregada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    break;
                case "btnCancelar":
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void btnAgregarZona_Click(object sender, EventArgs e)
        {

        }
    }
}
