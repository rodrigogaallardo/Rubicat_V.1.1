using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using System.Data.Entity;

namespace Datos
{
    public static class AdmDeposito
    {
        public static void InsertDeposito(Entidades.Deposito deposito) 
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            rubicatDB.Depositos.Add(deposito);
            rubicatDB.SaveChanges();
        }
        public static void UpdateDeposito(Entidades.Deposito deposito)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();

            var mDeposito = rubicatDB.Depositos.Find(deposito.IdDeposito);
            mDeposito.Nombre = deposito.Nombre;
            mDeposito.Espacio = deposito.Espacio;
            mDeposito.Descripcion = deposito.Descripcion;

            rubicatDB.Entry(mDeposito).State = EntityState.Modified;
            rubicatDB.SaveChanges();
        }
        public static void DeleteDeposito (int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var mDeposito = rubicatDB.Depositos.Find(id);
            rubicatDB.Depositos.Remove(mDeposito);
            rubicatDB.SaveChanges();

        }
        public static IEnumerable<object> SelectDepositos()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var deposito = (from d in rubicatDB.Depositos
                             select new
                             {
                                 Id_de_Deposito= d.IdDeposito,
                                 d.Nombre,
                                 d.Descripcion,
                                 d.Espacio
                             }).ToList();
            return deposito;
        }
        public static Entidades.Deposito SelectId(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var deposito = rubicatDB.Depositos.Find(id);
            return deposito;
        }
        public static List<Entidades.Deposito> SelectDeposito(string letra)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var deposito = (from d in rubicatDB.Depositos
                            where d.Nombre.StartsWith(letra)
                            select d).ToList();
            return deposito;
        }
    }
}
