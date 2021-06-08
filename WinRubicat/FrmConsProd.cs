using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace WinRubicat
{
    public partial class FrmConsProd : WinRubicat.FrmConsultas
    {
        public FrmConsProd()
        {
            InitializeComponent();
            lblTipo.Text = "Productos";
            btnNuevo.Click += botones;
            btnModificar.Click += botones;
            btnBorrar.Click += botones;

            TraerProductos();
        }
        Logica.Producto objLogProd = new Logica.Producto();
        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            switch (boton.Name)
            {
                case "btnNuevo":
                    FrmProd frmProd = new FrmProd();
                    frmProd.StartPosition = FormStartPosition.CenterScreen;
                    frmProd.Show();
                    break;
                case "btnModificar":
                    //Crear instancia de producto y cargar datos del registro seleccionado
                    Producto modelProd = new Producto();
                    modelProd.IdProducto = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                    modelProd.Nombre = dgvDatos.CurrentRow.Cells[1].Value.ToString();
                    modelProd.Peso = Convert.ToDouble(dgvDatos.CurrentRow.Cells[2].Value);
                    modelProd.Costo = Convert.ToDecimal(dgvDatos.CurrentRow.Cells[3].Value);
                    modelProd.Precio = Convert.ToDecimal(dgvDatos.CurrentRow.Cells[4].Value);
                    modelProd.Ean = Convert.ToInt32(dgvDatos.CurrentRow.Cells[5].Value);
                    // Mostrar formulario modificacion
                    FrmProd modifProd = new FrmProd(modelProd);
                    modifProd.StartPosition = FormStartPosition.CenterScreen;
                    modifProd.Show();
                    break;
                case "btnBorrar":
                    int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                    objLogProd.BorrarProducto(id);
                    break;
                default:
                    break;
            }
            TraerProductos();
            dgvDatos.Columns[3].DefaultCellStyle.Format = "N2";
            dgvDatos.Columns[4].DefaultCellStyle.Format = "N2";
        }
        void TraerProductos()
        {
            dgvDatos.DataSource = objLogProd.TraerProductos();
            dgvDatos.Columns[3].DefaultCellStyle.Format = "N2";
            dgvDatos.Columns[4].DefaultCellStyle.Format = "N2";
        }
    }
}
