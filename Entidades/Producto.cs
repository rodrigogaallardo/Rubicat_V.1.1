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
        public string Familia { get; set; }
        public string Arquetipo { get; set; }
        
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public decimal Costo { get; set; }
        public int Cantidad { get; set; }
        //public decimal Precio { get; set; }
        //public int Ean { get; set; }

        #region propiedades de navegacion
        public List<Venta> Ventas { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; }
        public List<Pedido> Pedidos { get; set; }
        #endregion
    }
}
