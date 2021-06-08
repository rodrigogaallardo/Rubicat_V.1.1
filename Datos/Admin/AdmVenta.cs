using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class AdmVenta
    {
        public static void InsertVenta(Entidades.Venta venta)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            DataTable dtProds = new DataTable();

            dtProds.Columns.Add("ProductoId", typeof(int));
            dtProds.Columns.Add("Cantidad", typeof(int));
            dtProds.Columns.Add("Precio", typeof(decimal));
            dtProds.Columns.Add("Costo", typeof(decimal));
            dtProds.Columns.Add("Peso", typeof(double));
            foreach (var prod in venta.DetalleVentas)
            {
                DataRow fila = dtProds.NewRow();
                fila["ProductoId"] = prod.ProductoId;
                fila["Cantidad"] = prod.Cantidad;
                fila["Precio"] = prod.Precio;
                fila["Costo"] = prod.Costo;
                fila["Peso"] = prod.Peso;
                dtProds.Rows.Add(fila);
            }
            SqlParameter paramProds = new SqlParameter();
            paramProds.TypeName = "TDetalle";
            paramProds.ParameterName = "@Detalle";
            paramProds.Direction = ParameterDirection.Input;
            paramProds.SqlDbType = SqlDbType.Structured;
            paramProds.Value = dtProds;

            rubicatDB.Database.ExecuteSqlCommand("exec SP_NuevaVenta @Cantidad, @Peso, @Importe, @RentBruta, @Cvm, @ClienteId, @VendedorId, @Fecha, @Detalle",
                new SqlParameter("@Cantidad", venta.Cantidad),
                new SqlParameter("@Peso", venta.Peso),
                new SqlParameter("@Importe", venta.Importe),
                new SqlParameter("@RentBruta", venta.RentBruta),
                new SqlParameter("@Cvm", venta.Cvm),
                new SqlParameter("ClienteId", venta.ClienteId),
                new SqlParameter("@VendedorId", venta.VendedorId),
                new SqlParameter("@Fecha", venta.Fecha),
                paramProds
                );
            rubicatDB.SaveChanges();
        }
        public static void UpdateVenta(Entidades.Venta venta)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var mVenta = rubicatDB.Ventas.Find(venta.IdVenta);
            mVenta.Cantidad = venta.Cantidad;
            mVenta.Peso = venta.Peso;
            mVenta.Importe = venta.Importe;
            mVenta.RentBruta = venta.RentBruta;
            mVenta.Cvm = venta.Cvm;
            mVenta.ClienteId = venta.ClienteId;
            mVenta.VendedorId = venta.VendedorId;
            mVenta.Fecha = venta.Fecha;

            rubicatDB.Entry(mVenta).State = EntityState.Modified;

            rubicatDB.SaveChanges();
        }
        public static void DeleteVenta(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var venta = rubicatDB.Ventas.Find(id);
            rubicatDB.Ventas.Remove(venta);
            rubicatDB.SaveChanges();
        }
        //public static List<Entidades.Venta> SelectVentas()
        //{
        //    DBRubicatContext rubicatDB = new DBRubicatContext();
        //    var ventas = (from v in rubicatDB.Ventas
        //                  select v).ToList();
        //    return ventas;
        //}
        public static IEnumerable<object> SelectVentas()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var query = (from v in rubicatDB.Ventas
                         join c in rubicatDB.Clientes on v.ClienteId equals c.IdCliente
                         join p in rubicatDB.Vendedores on v.VendedorId equals p.IdVendedor
                         select new
                         {
                             Id = v.IdVenta,
                             v.Cantidad,
                             Peso_Tot = Math.Round(v.Peso, 2),
                             Imp_Vta = Math.Round(v.Importe, 2),
                             CVM=Math.Round(v.Cvm,2),
                             Rent_Bruta=Math.Round(v.RentBruta,2),
                             Cliente = c.Nombre,
                             Vendedor = p.Nombre,
                             v.Fecha
                         }).ToList();
            return query;
        }
    }
}
