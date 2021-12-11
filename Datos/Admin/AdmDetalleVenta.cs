using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using Datos.Data;
using System.Data.SqlClient;

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
                             Producto_Terminado=p.Arquetipo,
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
        public static IEnumerable<object> FiltrarClientes(DateTime inicio, DateTime fin, string orden)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();

            var clientes = (from vta in rubicatDB.Ventas
                            where vta.Fecha < fin && vta.Fecha > inicio
                            group vta by vta.ClienteId into gp
                            join cli in rubicatDB.Clientes on gp.FirstOrDefault().ClienteId equals cli.IdCliente
                            select new
                            {
                               Cliente = cli.Nombre,
                               Cantidad = gp.Sum(v => v.Cantidad),
                               CVM = Math.Round(gp.Sum(v => v.Cvm),2),
                               Importe_Tot = Math.Round(gp.Sum(v => v.Importe),2),
                               Rentabilidad = Math.Round(gp.Sum(v => v.Importe) - gp.Sum(v => v.Cvm),2),
                               Peso = Math.Round(gp.Sum(v => v.Peso),2)
                            });
            
            return clientes;
        }
        public static IEnumerable<object> FiltrarVendedores(DateTime inicio, DateTime fin, string orden)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            
            var vendedores = (from vta in rubicatDB.Ventas
                              where vta.Fecha<fin && vta.Fecha>inicio
                              group vta by vta.VendedorId into gp
                              join ven in rubicatDB.Vendedores on gp.FirstOrDefault().VendedorId equals ven.IdVendedor
                              select new
                              {
                                  Vendedor = ven.Nombre,
                                  Cantidad = gp.Sum(v => v.Cantidad),
                                  CVM = Math.Round(gp.Sum(v => v.Cvm),2),
                                  Importe_Tot = Math.Round(gp.Sum(v => v.Importe),2),
                                  Rentabilidad = Math.Round(gp.Sum(v => v.Importe) - gp.Sum(v => v.Cvm),2),
                                  Peso = Math.Round(gp.Sum(v => v.Peso),2)
                              });
            
            return vendedores;
        }
        public static IEnumerable<object> FiltrarProductos(DateTime inicio, DateTime fin, string orden)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();

            var productos = (from dv in rubicatDB.DetalleVentas
                             join vta in rubicatDB.Ventas on dv.VentaId equals vta.IdVenta
                             where vta.Fecha < fin && vta.Fecha > inicio
                             group dv by dv.ProductoId into gp
                            join p in rubicatDB.Productos on gp.FirstOrDefault().ProductoId equals p.IdProducto
                            select new
                            {
                                Producto = p.Arquetipo,
                                Cantidad = gp.Sum(v => v.Cantidad),
                                CVM = gp.Sum(v=>v.Venta.Cvm),//Math.Round(gp.Sum(v => v.Costo),2),
                                Importe_Tot = gp.Sum(v => v.Venta.Importe),//Math.Round(gp.Sum(v => v.Precio),2),
                                Rentabilidad = gp.Sum(v => v.Venta.Importe)- gp.Sum(v => v.Venta.Cvm),//Math.Round(gp.Sum(v => v.Precio) - gp.Sum(v => v.Costo),2),
                                Peso = Math.Round(gp.Sum(v => v.Peso), 2)
                            });

            return productos;
        }
    }
}
