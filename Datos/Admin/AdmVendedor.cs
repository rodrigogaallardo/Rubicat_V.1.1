using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;

namespace Datos
{
    public static class AdmVendedor
    {
        public static void InsertVendedor(Entidades.Vendedor vendedor)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            rubicatDB.Vendedores.Add(vendedor);
            rubicatDB.SaveChanges();
        }
        public static void UpdateVendedor(Entidades.Vendedor vendedor)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var mVendedor = rubicatDB.Vendedores.Find(vendedor.IdVendedor);
            mVendedor.Nombre = vendedor.Nombre;
            mVendedor.Telefono = vendedor.Telefono;
            mVendedor.ZonaId = vendedor.ZonaId;

            rubicatDB.Entry(mVendedor).State = EntityState.Modified;

            rubicatDB.SaveChanges();
        }
        public static void DeleteVendedor(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var vendedor = rubicatDB.Vendedores.Find(id);
            rubicatDB.Vendedores.Remove(vendedor);
            rubicatDB.SaveChanges();
        }
        
        public static IEnumerable<object> SelectVendedores()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var query = (from v in rubicatDB.Vendedores
                         join z in rubicatDB.Zonas
                         on v.ZonaId equals z.IdZona
                         select new
                         {
                             Id = v.IdVendedor,
                             v.Nombre,
                             v.Telefono,
                             Zona = z.Nombre

                         }).ToList();
            return query;
        }
    }
}
