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
            TraerStockTotal();
        }

        void TraerStockTotal()
        {
            Logica.Stock objLogica = new Logica.Stock();
            dgvStockTotal.DataSource = objLogica.TraerStock();
        }

        public void botones(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            switch (boton.Name)
            {
                case "btnSalir":
                    Close();
                    break;
            }
        }
    }
}
