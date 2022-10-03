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
        public string CodProducto { get; set; }
        public string Familia { get; set; }
        public string Arquetipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }        
        public decimal Peso { get; set; }
        public string uniDeMedida { get; set; }
        public decimal Costo { get; set; }

        #region propiedades de navegacion
        public List<Venta> Ventas { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; }
        //public List<Pedido> Pedidos { get; set; }
        public List<IngresoStock> IngresosStock { get; set; }
        #endregion
    }
}
