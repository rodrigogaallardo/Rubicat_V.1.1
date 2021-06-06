using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DetalleVenta
    {
        Producto infoProducto = new Producto();
        /// <summary>
        /// Recibe como parámetros una instancia de <typeparamref name="DetalleVenta"/>
        /// y una List de <typeparamref name="DetalleVenta"/>, comprueba si ya se agregaron en la lista
        /// datos con el mismo ID que el objeto que recibe y sino lo agrega
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="ventas"></param>
        public void CargarProductos(Entidades.DetalleVenta prod, List<Entidades.DetalleVenta> ventas)
        {
            int cont = 0;
            foreach (var venta in ventas)
            {
                if (venta.ProductoId == prod.ProductoId)
                {
                    venta.Cantidad += prod.Cantidad;
                    venta.Precio = prod.Precio;
                    venta.Peso = venta.Cantidad * (infoProducto.TraerPorId(venta.ProductoId).Peso);
                    cont++;
                }
            }
            if (cont == 0)
            {
                prod.Peso=prod.Cantidad* (infoProducto.TraerPorId(prod.ProductoId).Peso);
                ventas.Add(prod);
            }
        }
        public List<object> TraerDetalle()
        {
            return AdmDetalleVenta.SelectVentas().ToList();
        }
    }
}
