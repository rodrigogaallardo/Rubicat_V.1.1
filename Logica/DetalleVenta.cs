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
        //Producto infoProducto = new Producto();
        ///// <summary>
        ///// Recibe como parámetros una instancia de <typeparamref name="DetalleVenta"/>
        ///// y una List de <typeparamref name="DetalleVenta"/>, comprueba si ya se agregaron en la lista
        ///// datos con el mismo ID que el objeto que recibe y sino lo agrega
        ///// </summary>
        ///// <param name="prod"></param>
        ///// <param name="ventas"></param>
        //public void CargarCarrito(Entidades.DetalleVenta prod, List<Entidades.DetalleVenta> carrito)
        //{
        //    int cont = 0;
        //    foreach (var venta in carrito)
        //    {
        //        if (venta.ProductoId == prod.ProductoId)
        //        {
        //            venta.Cantidad += prod.Cantidad;
        //            venta.Precio = prod.Precio;
        //            venta.Peso = venta.Cantidad * (infoProducto.TraerPorId(venta.ProductoId).Peso);
        //            cont++;
        //        }
        //    }
        //    if (cont == 0)
        //    {
        //        prod.Peso=prod.Cantidad* (infoProducto.TraerPorId(prod.ProductoId).Peso);
        //        carrito.Add(prod);
        //    }
        //}
        //public void ModificarCarrito(int cant, decimal importe, int id, List<Entidades.DetalleVenta> carrito)
        //{
        //    foreach (var prod in carrito)
        //    {
        //        if (prod.ProductoId == id)
        //        {
        //            prod.Cantidad = cant;
        //            prod.Precio = importe;
        //        }
        //    }
        //}
        //public decimal CargarTotal(List<Entidades.DetalleVenta> carrito)
        //{
        //    decimal total = 0;
        //    foreach(var prod in carrito)
        //    {
        //        total += prod.Cantidad * prod.Precio;
        //    }
        //    return total;
        //}
        //public decimal CargarSubtotal(List<Entidades.DetalleVenta> carrito)
        //{
        //    decimal subtotal = 0;
        //    foreach (var prod in carrito)
        //    {
        //        subtotal += prod.Cantidad * prod.Precio;
        //    }
        //    return subtotal;
        //}
        //public decimal TraerDescuento(List<Entidades.DetalleVenta> carrito, decimal desc, string tipo)
        //{
        //    decimal total = 0;
        //    foreach(var prod in carrito)
        //    {
        //        total += prod.Precio * prod.Cantidad;
        //    }
        //    if (tipo == "Efectivo")
        //    {
        //        total -= desc;
        //    }
        //    else if (tipo=="Porcentaje")
        //    {
        //        total = total-(total * desc / 100);
        //    }
        //    return total;
        //}
        //public List<object> TraerDetalle()
        //{
        //    return AdmDetalleVenta.SelectVentas().ToList();
        //}
        //public List<object> FiltrarDetalle(string tabla, DateTime inicio, DateTime fin, string orden)
        //{
        //    List<object> lista = new List<object>();
        //    switch (tabla)
        //    {
        //        case "Clientes":
        //            lista = AdmDetalleVenta.FiltrarClientes(inicio, fin, orden).ToList();
        //            break;
        //        case "Vendedores":
        //            lista = AdmDetalleVenta.FiltrarVendedores(inicio, fin, orden).ToList();
        //            break;
        //        case "Productos":
        //            lista = AdmDetalleVenta.FiltrarProductos(inicio, fin, orden).ToList();
        //            break;
        //        default:
        //            break;
        //    }
            
        //    return lista;
        //}
    }
}
