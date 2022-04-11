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
        public long Cuit { get; set; }
        public int IngBrutos { get; set; }
        public string TipoIngBrutos { get; set; }
        public string DomicilioFiscal { get; set; }
        public long Telefono { get; set; }

        public int VendedorId { get; set; }
        public int ZonaId { get; set; }
        public int TransporteId { get; set; }

        //Agregados para finalizar la primer etapa del proyecto
        public string Mail { get; set; }
        public string Localidad { get; set; }
        public string CondicionVenta { get; set; }
        public string HorarioAtencion { get; set; }


        #region propiedades de navegacion
        public List<Venta> Ventas { get; set; }
        public List<Pedido> Pedidos { get; set; }
        #endregion
    }
}
