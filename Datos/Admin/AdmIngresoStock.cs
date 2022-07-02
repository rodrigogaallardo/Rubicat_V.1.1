using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using System.Data.Entity;

namespace Datos
{
    public class AdmIngresoStock
    {
        public static void InsertIngresos(Entidades.IngresoStock ingresosstock)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();

            //var uStock = rubicatDB.Stocks.Find(ingresosstock.MateriaPrimaId);
            //uStock.Cantidad += ingresosstock.Cantidad;
            //rubicatDB.Entry(uStock).State = EntityState.Modified;

            rubicatDB.IngresosStock.Add(ingresosstock);
            rubicatDB.SaveChanges();
        }
        public static Entidades.IngresoStock SelectId(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var IngresosStock = rubicatDB.IngresosStock.Find(id);
            return IngresosStock;
        }
        public static void UpdateIngresos(Entidades.IngresoStock ingresosstock)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();

            var mIngresos = rubicatDB.IngresosStock.Find(ingresosstock.IdIngreso);
            mIngresos.FechaIngreso = ingresosstock.FechaIngreso;
            mIngresos.Cantidad = ingresosstock.Cantidad;
            mIngresos.CantidadMinima = ingresosstock.CantidadMinima;
            mIngresos.Responsable = ingresosstock.Responsable;
            mIngresos.DepositoId = ingresosstock.DepositoId;
            mIngresos.ProductoId = ingresosstock.ProductoId;
            mIngresos.SumaUnidadesIngresados = ingresosstock.SumaUnidadesIngresados;
            mIngresos.SumaUnidadesUsadas = ingresosstock.SumaUnidadesUsadas;
            mIngresos.StockFinal = ingresosstock.StockFinal;
            mIngresos.Status = ingresosstock.Status;

            rubicatDB.Entry(mIngresos).State = EntityState.Modified;
            rubicatDB.SaveChanges();
        }
        public static void DeleteIngresos(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var mIngreso = rubicatDB.IngresosStock.Find(id);
            rubicatDB.IngresosStock.Remove(mIngreso);
            rubicatDB.SaveChanges();
        }
        //public static List<Entidades.IngresoStock> SelectIngresos()
        //{
        //    DBRubicatContext rubicatDB = new DBRubicatContext();
        //    var ingresos = (from p in rubicatDB.IngresosStock
        //                     select p).ToList();
        //    return ingresos;
        //}

        public static IEnumerable<object> SelectIngresos()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var query = (from i in rubicatDB.IngresosStock
                         join p in rubicatDB.Productos on i.ProductoId equals p.IdProducto
                         join d in rubicatDB.Depositos on i.DepositoId equals d.IdDeposito

                         select new
                         {
                             Registro_de_Ingreso = i.IdIngreso,
                             Fecha_de_Ingreso = i.FechaIngreso,
                             i.Responsable,
                             Producto = p.Nombre,
                             Deposito = d.Nombre,
                             i.Cantidad
                         }).ToList();
            return query;
        }

        public static IEnumerable<object> SelectStockFinal()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var query = (from i in rubicatDB.IngresosStock
                         join p in rubicatDB.Productos on i.ProductoId equals p.IdProducto
                         join d in rubicatDB.Depositos on i.DepositoId equals d.IdDeposito

                         select new
                         {
                             Producto = p.Nombre,
                             Unidades_Ingresadas= i.SumaUnidadesIngresados,
                             Unidades_Usadas = i.SumaUnidadesUsadas,
                             Codigo = p.CodProducto,
                             Stock = i.StockFinal,
                             Stock_Minimo = i.CantidadMinima,
                             Status = i.Status
                         }).ToList();
            return query;
        }

        public static IEnumerable<object> StockReal()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();

            var query = (from i in rubicatDB.IngresosStock
                         join p in rubicatDB.Productos on i.ProductoId equals p.IdProducto
                         group i by new { p.CodProducto, p.Descripcion} into g
                         
                         select new
                         {
                             Codigo_de_Producto=g.Key.CodProducto ,
                             Nombre_de_Producto = g.Key.Descripcion,
                             Stock = g.Sum (q=>q.SumaUnidadesIngresados),
                             
                         }).ToList();
            return query;
        }
    }
}
