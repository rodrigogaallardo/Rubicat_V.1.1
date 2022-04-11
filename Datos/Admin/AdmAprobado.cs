using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using System.Data.Entity;

namespace Datos.Admin
{
    public class AdmAprobado
    {
        public static void InsertAprobado(Entidades.Aprobado aprobado)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            rubicatDB.Aprobados.Add(aprobado);
            rubicatDB.SaveChanges();
        }
        public static void UpdateAprobado(Entidades.Aprobado aprobado)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var mAprobado = rubicatDB.Aprobados.Find(aprobado.IdAprobados);

            mAprobado.FechaDeEntrega = aprobado.FechaDeEntrega;
            mAprobado.FechaDePedido = aprobado.FechaDePedido;
            mAprobado.NumeroDeRemito = aprobado.NumeroDeRemito;
            mAprobado.ClienteId = aprobado.ClienteId;
            mAprobado.ProductoId = aprobado.ProductoId;
            mAprobado.TransporteId = aprobado.TransporteId;
            mAprobado.ValorFinal = aprobado.ValorFinal;
            rubicatDB.Entry(mAprobado).State = EntityState.Modified;
            rubicatDB.SaveChanges();
        }
        public static void DeleteAprobado(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var aprobado = rubicatDB.Aprobados.Find(id);
            rubicatDB.Aprobados.Remove(aprobado);
            rubicatDB.SaveChanges();
        }
        public static IEnumerable<object> SelectAprobado()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var pedidos = (from a in rubicatDB.Aprobados
                           join pr in rubicatDB.Productos on a.ProductoId equals pr.IdProducto
                           join cl in rubicatDB.Clientes on a.ClienteId equals cl.IdCliente
                           join tr in rubicatDB.Transportes on a.TransporteId equals tr.IdTransporte
                           select new
                           {
                               Numero_de_pedido = a.IdAprobados,
                               Numero_de_Remito = a.NumeroDeRemito,
                               Fecha_de_Pedido = a.FechaDePedido,
                               Fecha_de_Entrega = a.FechaDeEntrega,
                               Cliente = cl.Nombre,
                               Producto = pr.Arquetipo,
                               Transporte = tr.NombreTransporte,
                               Importe = a.ValorFinal

                           }
                           ).ToList();
            return pedidos;
        }
        public static Entidades.Aprobado SelectId(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var aprobado = rubicatDB.Aprobados.Find(id);
            return aprobado;
        }
    }
}
