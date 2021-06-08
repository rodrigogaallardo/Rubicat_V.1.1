using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class Venta
    {
        /// <summary>
        /// Recibe como parámetro una instancia del tipo <typeparamref name="Venta"/>
        /// y lo agrega como registro a la tabla Venta de la BBDD
        /// </summary>
        /// <param name="venta"></param>
        public void AgregarVenta(Entidades.Venta venta)
        {
            AdmVenta.InsertVenta(venta);
        }
        /// <summary>
        /// Recibe como parámetro una instancia del tipo <typeparamref name="Venta"/>
        /// y actualiza el registro de la BBDD cuyo ID coincida con la propiedad
        /// ID del parámetro recibido
        /// </summary>
        /// <param name="venta"></param>
        public void ModificarVenta(Entidades.Venta venta)
        {
            AdmVenta.UpdateVenta(venta);
        }
        /// <summary>
        /// Recibe como parámetro una variable del tipo <typeparamref name="integer"/>
        /// y elimina el registro cuyo ID coincida con el parámetro recibido
        /// </summary>
        /// <param name="id"></param>
        public void BorrarVenta(int id)
        {
            AdmVenta.DeleteVenta(id);
        }
        /// <summary>
        /// Devuelve un <typeparamref name="IEnumerable"/> con todos los registros
        /// de la tabla Venta de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<object> TraerVentas()
        {
            return AdmVenta.SelectVentas().ToList();
        }
        /// <summary>
        /// Recibe como parámetros una instancia de <typeparamref name="Venta"/> y una
        /// instancia de tipo List de <typeparamref name="DetalleVenta"/> y carga las
        /// propiedades Cvm, Importe, RentBruta y Peso del objeto <typeparamref name="Venta"/>
        /// recibido
        /// </summary>
        /// <param name="venta"></param>
        /// <param name="prods"></param>
        /// <returns></returns>
        public Entidades.Venta CargarVenta(Entidades.Venta venta, List<Entidades.DetalleVenta> prods)
        {
            foreach(var prod in prods)
            {
                venta.Cvm += prod.Costo*prod.Cantidad;
                //venta.Importe += prod.Precio*prod.Cantidad;
                venta.Cantidad += prod.Cantidad;
                venta.Peso += prod.Peso;
            }
            venta.RentBruta = venta.Importe - venta.Cvm;
            venta.DetalleVentas = prods;
            return venta;
        }
    }
}
