using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class IngresosStock
    {

        public void AgregarIngresos(Entidades.IngresoStock ingresosStock)
        {
            AdmIngresoStock.InsertIngresos(ingresosStock);
        }

        public void ModificarIngresos(Entidades.IngresoStock ingresoStock)
        {
            AdmIngresoStock.UpdateIngresos(ingresoStock);
        }

        public void BorrarIngresos(int id)
        {
            AdmIngresoStock.DeleteIngresos(id);
        }
        //public List<Entidades.IngresoStock> TraerIngresos()
        //{
        //    return AdmIngresoStock.SelectIngresos();
        //}

        public List<object> TraerIngresosStock()
        {
            return AdmIngresoStock.SelectIngresos().ToList();
        }
    }
}