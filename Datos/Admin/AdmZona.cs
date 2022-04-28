using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using System.Data.Entity;

namespace Datos
{
    public static class AdmZona
    {
        public static void InsertZona(Entidades.Zona zona)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            rubicatDB.Zonas.Add(zona);
            rubicatDB.SaveChanges();
        }
        public static void UpdateZona(Entidades.Zona zona)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var mZona = rubicatDB.Zonas.Find(zona.IdZona);
            mZona.Nombre = zona.Nombre;
            rubicatDB.Entry(mZona).State = EntityState.Modified;
            rubicatDB.SaveChanges();
        }
        public static void DeleteZona(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var zona = rubicatDB.Zonas.Find(id);
            rubicatDB.Zonas.Remove(zona);
            rubicatDB.SaveChanges();
        }
        public static List<Entidades.Zona> SelectZonas()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var zonas = (from z in rubicatDB.Zonas
                         select z).ToList();
            return zonas;
        }
        public static List<Entidades.Zona> SelectZonas(string letra)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var zona = (from z in rubicatDB.Zonas
                            where z.Nombre.StartsWith(letra)

                            select z).ToList();
            return zona;
        }
    }
}
