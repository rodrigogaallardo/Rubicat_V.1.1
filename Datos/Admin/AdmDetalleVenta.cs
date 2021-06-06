using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using Datos.Data;

namespace Datos
{
    public static class AdmDetalleVenta
    {
        public static IEnumerable<object> SelectVentas()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var query = (from v in rubicatDB.DetalleVentas
                         select new
                         {
                             Cod_Vta=v.VentaId,
                             Cod_Prod=v.ProductoId,
                             v.Cantidad,
                             Precio_Un=v.Precio,
                             Costo_Un=v.Costo,
                             Importe=(v.Cantidad*v.Precio),
                             CVM=v.Cantidad*v.Costo,
                             Rent_Bruta=(v.Cantidad*v.Precio)-(v.Cantidad*v.Costo)
                         });
            return query;
        }
    }
}
