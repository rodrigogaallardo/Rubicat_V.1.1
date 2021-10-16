using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito
    {
        public int IdDeposito { get; set; }
        public string Nombre { get; set; }
        public string Descripcion{ get; set; }
        public string Espacio { get; set; }

        public List<IngresoStock> IngresosStock { get; set; }
        public List<Stock> Stock { get; set; }

        
    }
}