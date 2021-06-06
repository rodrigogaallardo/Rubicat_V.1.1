using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Zona
    {
        public int IdZona { get; set; }
        public string Nombre { get; set; }

        #region propiedades de navegación
        public List<Vendedor> Vendedores { get; set; }
        public List<Cliente> Clientes { get; set; }
        #endregion
    }
}
