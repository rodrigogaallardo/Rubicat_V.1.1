using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public int Ean { get; set; }

        #region propiedades de navegacion
        public List<Venta> Ventas { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; }
        #endregion
    }
}
