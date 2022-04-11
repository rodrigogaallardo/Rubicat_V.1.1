using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Transporte
    {
        public int IdTransporte { get; set; }
        public string NombreTransporte { get; set; }
        public string DireccionTransporte { get; set; }
        public string CaracterTransporte { get; set; }
        public long TelefonoTransporte { get; set; }
        public string HorarioDeTransporte { get; set; }

        #region propiedades de navegación
        public List<Cliente> Clientes { get; set; }
        public List<Pedido> Pedidos { get; set; }
        #endregion
    }
}
