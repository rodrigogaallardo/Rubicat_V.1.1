using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public int Cuit { get; set; }
        public int IngBrutos { get; set; }
        public string TipoIngBrutos { get; set; }
        public string DomicilioFiscal { get; set; }
        public int Telefono { get; set; }
        public int VendedorId { get; set; }
        public int ZonaId { get; set; }

        #region propiedades de navegacion
        public List<Venta> Ventas { get; set; }
        #endregion
    }
}
