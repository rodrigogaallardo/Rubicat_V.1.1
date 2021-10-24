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
    public partial class FrmConsultasMateriasPrimas : Form
    {
        public FrmConsultasMateriasPrimas()
        {
            InitializeComponent();
            btnSalir.Click += botones;

            btnAgregarPackaging.Click += botones;
            btnAgregarEtiquetas.Click += botones;
            btnAgregarMateriaPrima.Click += botones;
            btnAgregarTapas.Click += botones;
            btnAgregarAroma.Click += botones;

            btnBorrar.Click += botones;
            btnModificar.Click += botones;
            TraerMateriasPrimas();
        }

        Logica.MateriasPrimas objLogMatPrima = new Logica.MateriasPrimas(); // necesario para eliminar

        public void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            switch (boton.Name)
            {
                case "btnSalir":
                    Close();
                    break;
                case "btnAgregarMateriaPrima":
                    FrmMateriasPrimas frmMateriasPrimas = new FrmMateriasPrimas();
                    frmMateriasPrimas.StartPosition = FormStartPosition.CenterScreen;
                    frmMateriasPrimas.FormClosing += ActualizarGrid;
                    frmMateriasPrimas.Show();
                    break;
                case "btnAgregarPackaging":
                    FrmPackaging frmPackaging = new FrmPackaging();
                    frmPackaging.StartPosition = FormStartPosition.CenterScreen;
                    frmPackaging.FormClosing += ActualizarGrid;
                    frmPackaging.Show();
                    break;
                case "btnAgregarEtiquetas":
                    FrmEtiqueta frmEtiqueta = new FrmEtiqueta();
                    frmEtiqueta.StartPosition = FormStartPosition.CenterScreen;
                    frmEtiqueta.FormClosing += ActualizarGrid;
                    frmEtiqueta.Show();
                    break;
                case "btnAgregarTapas":
                    FrmTapas frmtapa = new FrmTapas();
                    frmtapa.StartPosition = FormStartPosition.CenterScreen;
                    frmtapa.FormClosing += ActualizarGrid;
                    frmtapa.Show();
                    break;
                case "btnAgregarAroma":
                    FrmAromas frmAroma = new FrmAromas();
                    frmAroma.StartPosition = FormStartPosition.CenterScreen;
                    frmAroma.FormClosing += ActualizarGrid;
                    frmAroma.Show();
                    break;
                case "btnBorrar":
                    int id = Convert.ToInt32(dgvStockMateriasPrimas.CurrentRow.Cells[0].Value);
                    objLogMatPrima.BorrarMateriaPrima(id);
                    TraerMateriasPrimas();
                    break;

                case "btnModificar":
                    //Crear instancia de producto y cargar datos del registro seleccionado
                    MateriaPrima materiaPrimaMod = new MateriaPrima();
                    materiaPrimaMod.IdMateriaPrima = Convert.ToInt32(dgvStockMateriasPrimas.CurrentRow.Cells[0].Value);

                    materiaPrimaMod = objLogMatPrima.SelectId(materiaPrimaMod.IdMateriaPrima);

                    // Mostrar formulario modificacion
                    FrmModificar materiaPrimaModi = new FrmModificar(materiaPrimaMod);
                    materiaPrimaModi.StartPosition = FormStartPosition.CenterScreen;
                    materiaPrimaModi.FormClosing += ActualizarGrid;
                    materiaPrimaModi.Show();
                    break;

            }
        }

        private void ActualizarGrid(object sender, FormClosingEventArgs e)
        {
            TraerMateriasPrimas();
        }

        void TraerMateriasPrimas()
        {
            Logica.MateriasPrimas objlogica = new Logica.MateriasPrimas();
            dgvStockMateriasPrimas.DataSource = objlogica.TraerMateriaPrimas();
        }

        private void FrmConsultasMateriasPrimas_Load(object sender, EventArgs e)
        {

        }
    }
}
