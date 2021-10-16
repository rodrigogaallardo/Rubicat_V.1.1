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
    public partial class FrmDepositos : Form
    {
        public enum Operacion
        {
            Alta,
            Modificacion
        }
        public Operacion Estado { get; set; }

        public FrmDepositos()
        {
            InitializeComponent();
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
            lblTitulo.Text = "Agregar Producto";
            lblCodigo.Text = "";
            lblId.Text = "";
            Estado = Operacion.Alta;
        }
        public FrmDepositos(Entidades.Deposito deposito)
        {
            InitializeComponent();
            btnAgregar.Click += botones;
            btnCancelar.Click += botones;
            lblCodigo.Text = deposito.IdDeposito.ToString();
            lblTitulo.Text = "Modificar Deposito";
            btnAgregar.Text = "Modificar";

            txtNombreDeposito.Text = deposito.Nombre;
            txtDescDeposito.Text = deposito.Descripcion;
            txtEspacioDeposito.Text = deposito.Espacio;

            Estado = Operacion.Modificacion;
        }

        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            Deposito depositoMod = new Deposito();
            Logica.Depositos objLogDep = new Logica.Depositos();

            switch (boton.Name)
            {
                case "btnCancelar":
                    Close();
                    break;
                case "btnAgregar":
                    
                    depositoMod.Nombre = txtNombreDeposito.Text;
                    depositoMod.Descripcion = txtDescDeposito.Text;
                    depositoMod.Espacio= txtEspacioDeposito.Text;
                    switch (Estado)
                    {
                        case Operacion.Alta:
                            objLogDep.AgregarDeposito(depositoMod);
                            MessageBox.Show("Producto agregado correctamente.");
                            Close();
                            break;
                        case Operacion.Modificacion:
                            depositoMod.IdDeposito = Convert.ToInt32(lblCodigo.Text);
                            objLogDep.ModificarDeposito(depositoMod);
                            MessageBox.Show("Deposito modificado correctamente.");
                            Close();
                            break;
                        default:
                            break;
                    }

                    break;
            }


        }
    }
}