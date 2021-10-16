using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using System.Data.Entity;

namespace Datos
{
    public static class AdmMateriaPrima
    {
        public static void InsertMateriaPrima(Entidades.MateriaPrima materiaPrima)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            rubicatDB.MateriaPrimas.Add(materiaPrima);
            rubicatDB.SaveChanges();
        }
        public static void UpdateMateriaPrima(Entidades.MateriaPrima materiaPrima)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();

            var mMateriaPrima = rubicatDB.MateriaPrimas.Find(materiaPrima.IdMateriaPrima);
            mMateriaPrima.NombreMateriaPrima = materiaPrima.NombreMateriaPrima;
            mMateriaPrima.CostoMateriaPrima = materiaPrima.CostoMateriaPrima;

            rubicatDB.Entry(mMateriaPrima).State = EntityState.Modified;
            rubicatDB.SaveChanges();
        }
        public static void DeleteMateriaPrima(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var mMateriaPrima = rubicatDB.MateriaPrimas.Find(id);
            rubicatDB.MateriaPrimas.Remove(mMateriaPrima);
            rubicatDB.SaveChanges();
        }
        public static List<Entidades.MateriaPrima> SelectMateriaPrima()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var productos = (from p in rubicatDB.MateriaPrimas
                             select p).ToList();
            return productos;
        }
    }
}
