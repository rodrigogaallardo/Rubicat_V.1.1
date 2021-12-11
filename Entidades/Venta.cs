using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public int Cantidad { get; set; }
        public double Peso { get; set; }
        public decimal Importe { get; set; }
        public decimal Cvm { get; set; }
        public decimal RentBruta { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public DateTime Fecha { get; set; }

        public string Transporte { get; set; }
        public DateTime FechaDeEntrega { get; set; }

        #region propiedades de navegacion
        public List<DetalleVenta> DetalleVentas { get; set; }
        public List<Producto> Productos { get; set; }
        #endregion
    }
}
