using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Data;
using System.Data.Entity;
using NHibernate.Linq;

namespace Datos
{
    public static class AdmCliente
    {
        public static void InsertCliente(Entidades.Cliente cliente)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            rubicatDB.Clientes.Add(cliente);
            rubicatDB.SaveChanges();
        }
        public static void UpdateCliente(Entidades.Cliente cliente)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var mCliente = rubicatDB.Clientes.Find(cliente.IdCliente);
            mCliente.Nombre = cliente.Nombre;
            mCliente.RazonSocial = cliente.RazonSocial;
            mCliente.Cuit = cliente.Cuit;
            mCliente.IngBrutos = cliente.IngBrutos;
            mCliente.TipoIngBrutos = cliente.TipoIngBrutos;
            mCliente.DomicilioFiscal = cliente.DomicilioFiscal;
            mCliente.Telefono = cliente.Telefono;
            mCliente.VendedorId = cliente.VendedorId;
            mCliente.ZonaId = cliente.ZonaId;
            mCliente.TransporteId = cliente.TransporteId;
            mCliente.Mail = cliente.Mail;
            mCliente.Localidad = cliente.Localidad;
            mCliente.CondicionVenta = cliente.CondicionVenta;
            mCliente.HorarioAtencion = cliente.HorarioAtencion;

            rubicatDB.Entry(mCliente).State = EntityState.Modified;

            rubicatDB.SaveChanges();
        }
        public static void DeleteCliente(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var cliente = rubicatDB.Clientes.Find(id);
            rubicatDB.Clientes.Remove(cliente);
            rubicatDB.SaveChanges();
        }
        //public static List<Entidades.Cliente> SelectClientes()
        //{
        //    DBRubicatContext rubicatDB = new DBRubicatContext();
        //    var clientes = (from c in rubicatDB.Clientes
        //                    select c).ToList();
        //    return clientes;
        //}
        public static IEnumerable<object> SelectClientes()
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var query = (from c in rubicatDB.Clientes
                         join v in rubicatDB.Vendedores on c.VendedorId equals v.IdVendedor
                         join z in rubicatDB.Zonas on c.ZonaId equals z.IdZona
                         join t in rubicatDB.Transportes on c.TransporteId equals t.IdTransporte
                         select new
                         {
                             Id = c.IdCliente,
                             c.Nombre,
                             Raz_Soc=c.RazonSocial,
                             CUIT=c.Cuit,
                             Ing_Brutos=c.IngBrutos,
                             Tipo_IngBrutos=c.TipoIngBrutos,
                             Domicilio=c.DomicilioFiscal,
                             c.Telefono,
                             Vendedor=v.Nombre,
                             Zona=z.Nombre,
                             Transporte= t.NombreTransporte,
                             c.Localidad,
                             c.Mail,
                             c.HorarioAtencion,
                             Cond_de_Venta = c.CondicionVenta
                         }).ToList();
            return query;
        }
        public static Entidades.Cliente SelectId(int id)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var cliente = rubicatDB.Clientes.Find(id);
            return cliente;
        }
        public static List<Entidades.Cliente> SelectClientes(string letra)
        {
            DBRubicatContext rubicatDB = new DBRubicatContext();
            var cliente = (from c in rubicatDB.Clientes
                              where c.Nombre.StartsWith(letra)

                              select c).ToList();
            return cliente;
        }

    }
}
