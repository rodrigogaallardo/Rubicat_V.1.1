using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IngresoStock
    {
        public int IdIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Cantidad { get; set; }
        public int CantidadMinima { get; set; }
        public string Responsable { get; set; }
        public int DepositoId { get; set; }
        public int ProductoId { get; set; }
        public int SumaUnidadesIngresados { get; set; }
        public int SumaUnidadesUsadas { get; set; }
        public int StockFinal { get; set; }
        public int Status { get; set; }
        public List<Pedido> Pedidos { get; set; }
        //public List<Stock> Stocks { get; set; }
    }
}