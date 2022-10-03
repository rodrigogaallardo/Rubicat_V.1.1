using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using System.Data.Entity;
using NHibernate.Linq;

namespace Datos.Admin
{
    public class AdmPedido
    {
        public static void InsertPedido(Entidades.Pedido pedido)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            rubicatDB.Pedidos.Add(pedido);
            rubicatDB.SaveChanges();
        }
        public static void UpdatePedido(Entidades.Pedido pedido)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var mPedido = rubicatDB.Pedidos.Find(pedido.IdPedido);
            
            mPedido.FechaDeEntrega = pedido.FechaDeEntrega;
            mPedido.FechaDePedido = pedido.FechaDePedido;
            mPedido.NumeroDeRemito = pedido.NumeroDeRemito;
            mPedido.ClienteId = pedido.ClienteId;
            mPedido.ProductoId = pedido.ProductoId;
            mPedido.TransporteId = pedido.TransporteId;
            mPedido.ValorFinal = pedido.ValorFinal;
            rubicatDB.Entry(mPedido).State = EntityState.Modified;
            rubicatDB.SaveChanges();
        }
        public static void DeletePedido(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var pedido = rubicatDB.Pedidos.Find(id);
            rubicatDB.Pedidos.Remove(pedido);
            rubicatDB.SaveChanges();
        }
        public static IEnumerable<object> SelectPedidos()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var pedidos = (from p in rubicatDB.Pedidos
                           join pr in rubicatDB.Productos on p.ProductoId equals pr.IdProducto
                           join cl in rubicatDB.Clientes on p.ClienteId equals cl.IdCliente
                           join tr in rubicatDB.Transportes on p.TransporteId equals tr.IdTransporte
                           select new 
                           {
                             Numero_de_pedido= p.IdPedido,
                             Numero_de_Remito = p.NumeroDeRemito,
                             Fecha_de_Pedido = p.FechaDePedido,
                             Fecha_de_Entrega = p.FechaDeEntrega,
                             Cliente = cl.Nombre,
                             Producto = pr.Nombre,
                             Transporte = tr.NombreTransporte,
                             Importe = p.ValorFinal

                           }).ToList();
            return pedidos;
        }
        
        public static Entidades.Pedido SelectId(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var pedidos = rubicatDB.Pedidos.Find(id);
            return pedidos;
        }
    }
}
