using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using System.Data.Entity;

namespace Datos
{
    public class AdmStock
    {
        public static void InsertStock(Entidades.Stock stock)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            rubicatDB.Stocks.Add(stock);
            rubicatDB.SaveChanges();
        }

        //public static void UpdateStock(Entidades.Stock stock)
        //{
        //    DBRubicatContext rubicatDB = new DBRubicatContext();
        //    var mStock = rubicatDB.Productos.Find(stock.IdProducto);
        //    mProducto.Nombre = producto.Nombre;
        //    mProducto.Peso = producto.Peso;
        //    mProducto.Costo = producto.Costo;
        //    mProducto.Precio = producto.Precio;
        //    mProducto.Ean = producto.Ean;

        //    rubicatDB.Entry(mProducto).State = EntityState.Modified;

        //    rubicatDB.SaveChanges();
        //}

        //public static void DeleteStock(int id)
        //{
        //    DBRubicatContext rubicatDB = new DBRubicatContext();
        //    var producto = rubicatDB.Productos.Find(id);
        //    rubicatDB.Productos.Remove(producto);
        //    rubicatDB.SaveChanges();
        //}

        public static List<Entidades.Stock> SelectStock()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var stock = (from p in rubicatDB.Stocks
                             select p).ToList();
            return stock;
        }
    }
}
