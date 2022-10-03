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
        public int ProductoId { get; set; }
        public int NumeroDeRemitoId{ get; set; }
        public int SumaUnidadesIngresados { get; set; }
        public int SumaUnidadesUsadas { get; set; }
        public int StockFinal { get; set; }
        public int StockMinimo { get; set; }
        public int Status { get; set; }
    }
}
