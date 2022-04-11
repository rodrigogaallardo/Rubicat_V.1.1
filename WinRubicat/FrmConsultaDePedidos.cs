using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using Entidades;
using SpreadsheetLight;

namespace WinRubicat
{
    public partial class FrmConsultaDePedidos : Form
    {
        public FrmConsultaDePedidos()
        {
            InitializeComponent();
            btnSalir.Click += botones;
            btnAceptarPedido.Click += botones;
            btnBorrarPedido.Click += botones;
            btnModificarPedido.Click += botones;
            TraerPedidos();
            TraerAprobados();
        }
        Logica.Pedido objPedido = new Logica.Pedido();
        Logica.Aprobado objLogAprobado = new Logica.Aprobado();

        void TraerPedidos()
        {
            Logica.Pedido objPedidos = new Logica.Pedido();
            dgvConsultaDePedidos.DataSource = objPedidos.TraerPedidos();
        }

        void TraerAprobados()
        {
            Logica.Aprobado objAprobado = new Logica.Aprobado();
            dgvAprobados.DataSource = objAprobado.TraerAprobados();
        }

        private void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            switch (boton.Name)
            {
                case "btnAceptarPedido":


                    int id2 = Convert.ToInt32(dgvConsultaDePedidos.CurrentRow.Cells[0].Value);

                    dtpFechaDeEntrega.Value = objPedido.TraerPorId(id2).FechaDeEntrega;
                    dtpFechaDePedido.Value = objPedido.TraerPorId(id2).FechaDePedido;
                    txtNumeroDeRemito.Text = Convert.ToString(objPedido.TraerPorId(id2).NumeroDeRemito);
                    txtIdCliente.Text = Convert.ToString(objPedido.TraerPorId(id2).ClienteId);
                    txtIdProducto.Text = Convert.ToString(objPedido.TraerPorId(id2).ProductoId);
                    txtIdTransporte.Text = Convert.ToString(objPedido.TraerPorId(id2).TransporteId);
                    txtTotal.Text = Convert.ToString(objPedido.TraerPorId(id2).ValorFinal);

                    Aprobado objAprobado = new Aprobado();
                    objAprobado.NumeroDeRemito = Convert.ToInt32(txtNumeroDeRemito.Text);
                    objAprobado.FechaDeEntrega = dtpFechaDeEntrega.Value;
                    objAprobado.FechaDePedido = dtpFechaDePedido.Value;
                    objAprobado.ClienteId = Convert.ToInt32(txtIdCliente.Text);
                    objAprobado.ProductoId = Convert.ToInt32(txtIdProducto.Text);
                    objAprobado.TransporteId = Convert.ToInt32(txtIdTransporte.Text);
                    objAprobado.ValorFinal = Convert.ToDecimal(txtTotal.Text);


                    objLogAprobado.AgregarAprobado(objAprobado);
                    objPedido.BorrarPedido(id2);
                    TraerAprobados();
                    TraerPedidos();



                    //Aprobado objApro = new Aprobado();
                    //objApro.IdAprobados = Convert.ToInt32(dgvConsultaDePedidos.CurrentRow.Cells[0].Value);
                    //objApro = objAprobado.TraerPorId(objApro.IdAprobados);

                    //FrmPedido frmAprobadoMod = new FrmPedido(objApro);
                    //frmAprobadoMod.StartPosition = FormStartPosition.CenterScreen;
                    //frmAprobadoMod.FormClosing += ActualizarGrid;
                    //frmAprobadoMod.Show();
                    
                    break;

                case "btnModificarPedido":
                    //Crear instancia de producto y cargar datos del registro seleccionado
                    Pedido objPed = new Pedido();
                    objPed.IdPedido = Convert.ToInt32(dgvConsultaDePedidos.CurrentRow.Cells[0].Value);
                    objPed = objPedido.TraerPorId(objPed.IdPedido);

                    // Mostrar formulario modificacion
                    FrmPedido frmPedidoMod = new FrmPedido(objPed);
                    frmPedidoMod.StartPosition = FormStartPosition.CenterScreen;
                    frmPedidoMod.FormClosing += ActualizarGrid;
                    frmPedidoMod.Show();
                    break;

                case "btnBorrarPedido":
                    int id = Convert.ToInt32(dgvConsultaDePedidos.CurrentRow.Cells[0].Value);
                    objPedido.BorrarPedido(id);
                    TraerPedidos();
                    break;
                    
                case "btnSalir":
                    this.Close();
                    break;
            }
        }

        //void LlenarCombos()
        //{
        //    //Clientes
        //    Logica.Cliente objLogicaCli = new Logica.Cliente();
        //    cboCliente.DataSource = objLogicaCli.TraerClientes();
        //    cboCliente.DisplayMember = "Nombre";
        //    cboCliente.ValueMember = "Id";

        //    //Transportes
        //    Logica.Transporte objLogicaTransporte = new Logica.Transporte();
        //    cboTransporte.DataSource = objLogicaTransporte.TraerTransporte();
        //    cboTransporte.DisplayMember = "NombreTransporte";
        //    cboTransporte.ValueMember = "IdTransporte";

        //    //Productos
        //    Logica.Producto objLogicaProd = new Logica.Producto();
        //    cboProducto.DataSource = objLogicaProd.TraerProductos();
        //    cboProducto.DisplayMember = "Arquetipo";
        //    cboProducto.ValueMember = "IdProducto";

        //}


        private void ActualizarGrid(object sender, FormClosingEventArgs e)
        {
            TraerPedidos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmConsultaDePedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument();
            SLStyle style = new SLStyle();
            SLStyle style2 = new SLStyle();

            style.Font.FontSize = 12;
            style.Font.Bold = true;
            //style.Border.LeftBorder.BorderStyle = BorderStyleValues.Thick;
            //style.Border.LeftBorder.Color = System.Drawing.Color.BlanchedAlmond;

            //style.Border.BottomBorder.BorderStyle = BorderStyleValues.DashDotDot;
            //style.Border.BottomBorder.Color = System.Drawing.Color.Brown;

            style.Border.BottomBorder.BorderStyle = BorderStyleValues.Medium;
            style.Border.RightBorder.BorderStyle = BorderStyleValues.Medium;
            style.Border.LeftBorder.BorderStyle = BorderStyleValues.Medium;
            style.Border.TopBorder.BorderStyle = BorderStyleValues.Medium;
            style.Border.BottomBorder.Color = System.Drawing.Color.Black;
            style.Border.RightBorder.Color = System.Drawing.Color.Black;
            style.Border.LeftBorder.Color = System.Drawing.Color.Black;
            style.Border.TopBorder.Color = System.Drawing.Color.Black;
            style.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightBlue, System.Drawing.Color.Blue);

            style2.Border.BottomBorder.BorderStyle = BorderStyleValues.Medium;
            style2.Border.RightBorder.BorderStyle = BorderStyleValues.Medium;
            style2.Border.LeftBorder.BorderStyle = BorderStyleValues.Medium;
            style2.Border.TopBorder.BorderStyle = BorderStyleValues.Medium;
            style2.Border.BottomBorder.Color = System.Drawing.Color.Black;
            style2.Border.RightBorder.Color = System.Drawing.Color.Black;
            style2.Border.LeftBorder.Color = System.Drawing.Color.Black;
            style2.Border.TopBorder.Color = System.Drawing.Color.Black;

            int iC = 1;

            foreach (DataGridViewColumn column in dgvAprobados.Columns)
            {
                sl.SetCellValue(1, iC, column.HeaderText.ToString());

                sl.SetCellStyle(1, iC, style);
                iC++;
            }

            int iR = 2;
            foreach (DataGridViewRow row in dgvAprobados.Rows)
            {
                sl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                sl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                sl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                sl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                sl.SetCellValue(iR, 5, row.Cells[4].Value.ToString());
                sl.SetCellValue(iR, 6, row.Cells[5].Value.ToString());
                sl.SetCellValue(iR, 7, row.Cells[6].Value.ToString());
                sl.SetCellValue(iR, 8, row.Cells[7].Value.ToString());
                sl.SetCellStyle(iR, 1, style2);
                sl.SetCellStyle(iR, 2, style2);
                sl.SetCellStyle(iR, 3, style2);
                sl.SetCellStyle(iR, 4, style2);
                sl.SetCellStyle(iR, 5, style2);
                sl.SetCellStyle(iR, 6, style2);
                sl.SetCellStyle(iR, 7, style2);
                sl.SetCellStyle(iR, 8,style2);
                iR++;
            }

            

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar archivo";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sl.SaveAs(saveFileDialog1.FileName);
                    MessageBox.Show("Archivo exportado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}
