using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MateriaPrima
    {
        public int IdMateriaPrima { get; set; }
        public string NombreMateriaPrima { get; set; }
        public decimal CostoMateriaPrima { get; set; }

        public List<IngresoStock> IngresosStock { get; set; }
        public List<Stock> Stock { get; set; }

        
    }
}
