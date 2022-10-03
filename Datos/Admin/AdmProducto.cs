using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using System.Data.Entity;
using NHibernate.Linq;

namespace Datos
{
    public static class AdmProducto
    {
        public static void InsertProducto(Entidades.Producto producto)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            rubicatDB.Productos.Add(producto);
            rubicatDB.SaveChanges();
        }
        public static void UpdateProducto(Entidades.Producto producto)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var mProducto = rubicatDB.Productos.Find(producto.IdProducto);
            mProducto.CodProducto = producto.CodProducto;
            mProducto.Familia = producto.Familia;
            mProducto.Arquetipo = producto.Arquetipo;
            mProducto.Nombre = producto.Nombre;            
            mProducto.Descripcion = producto.Descripcion;
            mProducto.Peso = producto.Peso;
            mProducto.uniDeMedida = producto.uniDeMedida;
            mProducto.Costo = producto.Costo;

            rubicatDB.Entry(mProducto).State = EntityState.Modified;

            rubicatDB.SaveChanges();
        }
        public static void DeleteProducto(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var producto = rubicatDB.Productos.Find(id);
            rubicatDB.Productos.Remove(producto);
            rubicatDB.SaveChanges();
        }
        public static IEnumerable<object> SelectProductos()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var productos = (from p in rubicatDB.Productos
                             select new
                             { 
                                 p.IdProducto,
                                 Cod_de_Producto=p.CodProducto,
                                 p.Familia,
                                 p.Arquetipo,
                                 p.Nombre,
                                 p.Descripcion,
                                 p.Peso,
                                 Unidad_de_Medida=p.uniDeMedida,
                                 p.Costo
                             }).ToList();
            return productos;
        }
        public static Entidades.Producto SelectId(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var producto = rubicatDB.Productos.Find(id);
            return producto;
        }

        public static List<Entidades.Producto> SelectProducto(string letra)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var producto = (from p in rubicatDB.Productos
                            where p.CodProducto.StartsWith(letra) 
                            
                            select p).ToList();
            return producto;
        }
    }
}
