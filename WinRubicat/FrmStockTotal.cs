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
    public partial class FrmStockTotal : Form
    {
        public FrmStockTotal()
        {
            InitializeComponent();
            btnSalir.Click += botones;
            //btnStockReal.Click += botones;
            TraerStockTotal();
        }

        void TraerStockTotal()
        {
            Logica.IngresosStock objLogica = new Logica.IngresosStock();
            dgvStockTotal.DataSource = objLogIngreso.TraertStockReal();
        }

        Logica.IngresosStock objLogIngreso = new Logica.IngresosStock();

        public void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            switch (boton.Name)
            {
                case "btnStockReal":
                    dgvStockTotal.DataSource = objLogIngreso.TraertStockReal();
                    break;
                case "btnSalir":
                    Close();
                    break;
            }
        }
    }
}
