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
        public static void UpdateIngresos(Entidades.IngresoStock ingresosstock)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();

            var mIngresos = rubicatDB.IngresosStock.Find(ingresosstock.IdIngreso);
            mIngresos.FechaIngreso = ingresosstock.FechaIngreso;
            mIngresos.Cantidad = ingresosstock.Cantidad;
            mIngresos.NumeroRemito = ingresosstock.NumeroRemito;
            mIngresos.Responsable = ingresosstock.Responsable;
            mIngresos.MateriaPrimaId = ingresosstock.MateriaPrimaId;
            mIngresos.DepositoId = ingresosstock.DepositoId;

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

                         join m in rubicatDB.MateriaPrimas on i.MateriaPrimaId equals m.IdMateriaPrima
                         join d in rubicatDB.Depositos on i.DepositoId equals d.IdDeposito

                         select new
                         {
                             Registro_de_Ingreso = i.IdIngreso,
                             Fecha_de_Ingreso = i.FechaIngreso,
                             Numero_de_Remito= i.NumeroRemito,
                             i.Responsable,
                             Materia_Prima = m.NombreMateriaPrima,
                             Deposito = d.Nombre,
                             i.Cantidad
                         }).ToList();
            return query;
        }
    }
}
