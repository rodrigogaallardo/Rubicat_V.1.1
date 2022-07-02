using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Producto
    {

        /// <summary>
        /// Recibe como parámetro una instancia del tipo <typeparamref name="Producto"/>
        /// y lo agrega como registro a la BBDD
        /// </summary>
        /// <param name="producto"></param>
        public void AgregarProducto(Entidades.Producto producto)
        {
            AdmProducto.InsertProducto(producto);
        }
        /// <summary>
        /// Recibe como parametro una instancia del tipo <typeparamref name="Producto"/>
        /// y actualiza el registro de la BBDD que coincida con el ID del parametro recibido
        /// </summary>
        /// <param name="producto"></param>
        public void ModificarProducto(Entidades.Producto producto)
        {
            AdmProducto.UpdateProducto(producto);
        }
        /// <summary>
        /// Recibe como parámetro una variable del tipo <typeparamref name="integer"/>
        /// y elimina el registro cuyo ID coincida con el parámetro recibido
        /// </summary>
        /// <param name="id"></param>
        public void BorrarProducto(int id)
        {
            AdmProducto.DeleteProducto(id);
        }
        /// <summary>
        /// Devuelve un <typeparamref name="IEnumerable"/> con todos los registros
        /// de la tabla Producto
        /// </summary>
        /// <returns></returns>
        public List<object> TraerProductos()
        {
            return AdmProducto.SelectProductos().ToList();
        }
        /// <summary>
        /// Recibe como parámetro una variable del tipo <typeparamref name="integer"/>
        /// y devuelve un <typeparamref name="IEnumerable"/> con el registro
        /// cuyo ID coincida con el parámetro recibido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Entidades.Producto TraerPorId(int id)
        {
            return AdmProducto.SelectId(id);
        }

        public List<Entidades.Producto> SelectProducto(string letra)
        {
            return AdmProducto.SelectProducto(letra);
        }

    }
}
