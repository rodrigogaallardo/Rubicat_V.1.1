using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }
        public string Nombre { get; set; }
        public long Telefono { get; set; }
        public int ZonaId { get; set; }

        #region propiedades de navegacion
        public List<Venta> Ventas { get; set; }
        public List<Cliente> Clientes { get; set; }
        #endregion
    }
}
