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
    public partial class FrmConsultasStock : Form
    {
        public FrmConsultasStock()
        {
            InitializeComponent();
            btnSalir.Click += botones;
            TraerIngresosStock();
        }

        void TraerIngresosStock()
        {
            Logica.IngresosStock objLogica = new Logica.IngresosStock();
            dgvIngresosStock.DataSource = objLogica.TraerIngresosStock();
            dgvIngresosStock.Columns[0].Visible = false;
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
