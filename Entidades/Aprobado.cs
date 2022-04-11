using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aprobado
    {
        public int IdAprobados { get; set; }
        public int NumeroDeRemito { get; set; }
        public DateTime FechaDePedido { get; set; }
        public DateTime FechaDeEntrega { get; set; }
        public int ClienteId { get; set; }
        public int ProductoId { get; set; }
        public int TransporteId { get; set; }
        public decimal ValorFinal { get; set; }
    }
}
