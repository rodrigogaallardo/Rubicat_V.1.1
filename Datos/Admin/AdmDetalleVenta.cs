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
                         join p in rubicatDB.Productos on v.ProductoId equals p.IdProducto
                         join vta in rubicatDB.Ventas on v.VentaId equals vta.IdVenta
                         join vdr in rubicatDB.Vendedores on vta.VendedorId equals vdr.IdVendedor
                         join c in rubicatDB.Clientes on vta.ClienteId equals c.IdCliente
                         select new
                         {
                             Cod_Vta=v.VentaId,
                             Producto=p.Nombre,
                             v.Cantidad,
                             Precio_Un=v.Precio,
                             Costo_Un=v.Costo,
                             Importe=(v.Cantidad*v.Precio),
                             CVM=v.Cantidad*v.Costo,
                             Rent_Bruta=(v.Cantidad*v.Precio)-(v.Cantidad*v.Costo),
                             Cliente=c.Nombre,
                             Vendedor=vdr.Nombre
                         });
            return query;
        }
    }
}
