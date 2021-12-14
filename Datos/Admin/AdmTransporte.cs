using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using System.Data.Entity;

namespace Datos.Admin
{
    public static class AdmTransporte
    {
        public static void InsertTransporte(Entidades.Transporte transporte)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            rubicatDB.Transportes.Add(transporte);
            rubicatDB.SaveChanges();
        }
        public static void UpdateTransporte(Entidades.Transporte transporte)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();

            var mtransporte = rubicatDB.Transportes.Find(transporte.IdTransporte);

            mtransporte.NombreTransporte = transporte.NombreTransporte;
            mtransporte.DireccionTransporte = transporte.DireccionTransporte;
            mtransporte.CaracterTransporte = transporte.CaracterTransporte;

            rubicatDB.Entry(mtransporte).State = EntityState.Modified;
            rubicatDB.SaveChanges();
        }
        public static void DeleteTransporte(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var mTransporte = rubicatDB.Transportes.Find(id);
            rubicatDB.Transportes.Remove(mTransporte);
            rubicatDB.SaveChanges();
        }
        public static List<Entidades.Transporte> SelectTransporte()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var transporte = (from t in rubicatDB.Transportes
                              select t
                           
                             ).ToList();
            return transporte;
        }
        public static Entidades.Transporte SelectId(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var transporte = rubicatDB.Transportes.Find(id);
            return transporte;
        }
    }
}
