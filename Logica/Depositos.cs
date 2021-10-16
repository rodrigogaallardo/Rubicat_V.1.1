using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;


namespace Logica
{
    public class Depositos
    {

        public void AgregarDeposito(Entidades.Deposito deposito)
        {
            AdmDeposito.InsertDeposito(deposito);
        }
        public void ModificarDeposito(Entidades.Deposito deposito)
        {
            AdmDeposito.UpdateDeposito(deposito);
        }
        public void BorrarDeposito(int id)
        {
            AdmDeposito.DeleteDeposito(id);
        }
        public List<Entidades.Deposito> TraerDeposito()
        {
            return AdmDeposito.SelectDepositos();
        }

    }
}
