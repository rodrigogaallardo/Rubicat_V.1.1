using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using System.Data.Entity;


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
            mProducto.Nombre = producto.Nombre;
            mProducto.Peso = producto.Peso;
            mProducto.Costo = producto.Costo;
            mProducto.Precio = producto.Precio;
            mProducto.Ean = producto.Ean;

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
        public static List<Entidades.Producto> SelectProductos()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var productos = (from p in rubicatDB.Productos
                             select p).ToList();
            return productos;
        }
        public static Entidades.Producto SelectId(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var producto = rubicatDB.Productos.Find(id);
            return producto;
        }
    }
}
