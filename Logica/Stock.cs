using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class Stock
    {
        public void AgregarStock(Entidades.Stock ingresosStock)
        {
            AdmStock.InsertStock(ingresosStock);
        }

        public List<object> TraerStock()
        {
            return AdmStock.SelectStock().ToList();
        }

        //public List<Entidades.Stock> TraerStock()
        //{
        //    return AdmStock.SelectStock();
        //}
    }
}