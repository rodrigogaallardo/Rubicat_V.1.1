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

            mMateriaPrima.FamiliaMateriaPrima = materiaPrima.FamiliaMateriaPrima;
            mMateriaPrima.ArquetipoMateriaPrima = materiaPrima.ArquetipoMateriaPrima;
            mMateriaPrima.DescripcionMateriaPrima = materiaPrima.DescripcionMateriaPrima;
            mMateriaPrima.CantidadMateriaPrima = materiaPrima.CantidadMateriaPrima;
            mMateriaPrima.CostoMateriaPrima = materiaPrima.CostoMateriaPrima;
            mMateriaPrima.PesoMateriaPrima = materiaPrima.PesoMateriaPrima;

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
        public static IEnumerable<object> SelectMateriaPrima()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var articulo = (from m in rubicatDB.MateriaPrimas
                             select new {
                                 Id_de_MateriaPrima = m.IdMateriaPrima,
                                 Familia = m.FamiliaMateriaPrima,
                                 Arquetipo = m.ArquetipoMateriaPrima,
                                 Descripcion = m.DescripcionMateriaPrima,
                                 Costo = m.CostoMateriaPrima,
                                 Cantidad = m.CantidadMateriaPrima,
                                 Peso = m.PesoMateriaPrima
                             }
                             ).ToList();
            return articulo;
        }

        public static Entidades.MateriaPrima SelectId(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var materiaPrima = rubicatDB.MateriaPrimas.Find(id);
            return materiaPrima;
        }
    }
}
