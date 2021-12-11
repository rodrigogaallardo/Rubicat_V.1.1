using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class MateriasPrimas
    {

        public void AgregarMateriaPrima(Entidades.MateriaPrima materiasPrimas)
        {
            AdmMateriaPrima.InsertMateriaPrima(materiasPrimas);
        }
        public void ModificarMateriaPrima(Entidades.MateriaPrima materiaPrimas)
        {
            AdmMateriaPrima.UpdateMateriaPrima(materiaPrimas);
        }

        public void BorrarMateriaPrima(int id)
        {
            AdmMateriaPrima.DeleteMateriaPrima(id);
        }

        //public List<Entidades.MateriaPrima> TraerMateriaPrimas()
        //{
        //    return AdmMateriaPrima.SelectMateriaPrima();
        //}
        public List<object> TraerMateriaPrimas()
        {
            return AdmMateriaPrima.SelectMateriaPrima().ToList();
        }

        public Entidades.MateriaPrima SelectId(int id)
        {
            return AdmMateriaPrima.SelectId(id);
        }
    }
}