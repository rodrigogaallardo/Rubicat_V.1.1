using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos.Admin;

namespace Logica
{
    public class Pedido
    {
        public void AgregarPedido(Entidades.Pedido pedido)
        {
            AdmPedido.InsertPedido(pedido);
        }
        public void ModificarPedido(Entidades.Pedido pedido)
        {
            AdmPedido.UpdatePedido(pedido);
        }
        public void BorrarPedido(int id)
        {
            AdmPedido.DeletePedido(id);
        }

        public List<object> TraerPedidos()
        {
            return AdmPedido.SelectPedidos().ToList();
        }

       
        public Entidades.Pedido TraerPorId(int id)
        {
            return AdmPedido.SelectId(id);
        }
    }
}
