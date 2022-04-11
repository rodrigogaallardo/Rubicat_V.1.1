using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Admin;

namespace Logica
{
    public class Aprobado
    {
        public void AgregarAprobado(Entidades.Aprobado aprobado)
        {
            AdmAprobado.InsertAprobado(aprobado);
        }
        public void ModificarAprobado(Entidades.Aprobado aprobado)
        {
            AdmAprobado.UpdateAprobado(aprobado);
        }
        public void BorrarAprobado(int id)
        {
            AdmAprobado.DeleteAprobado(id);
        }
        public List<object> TraerAprobados()
        {
            return AdmAprobado.SelectAprobado().ToList();
        }
        public Entidades.Aprobado TraerPorId(int id)
        {
            return AdmAprobado.SelectId(id);
        }
    }
}
