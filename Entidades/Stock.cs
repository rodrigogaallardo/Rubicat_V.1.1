using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Stock
    {
        public int IdStockTotal { get; set; }
        public int Cantidad { get; set; }

        public int MateriaPrimaID { get; set; }
        public int DepositoID { get; set; }

        public MateriaPrima MateriaPrima { get; set; }
        public Deposito Deposito { get; set; }
    }
}
