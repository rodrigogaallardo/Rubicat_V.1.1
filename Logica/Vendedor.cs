using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class Vendedor
    {

        /// <summary>
        /// Recibe como parámetro una instancia del tipo <typeparamref name="Vendedor"/>
        /// y lo agrega como registro a la tabla Vendedor de la BBDD
        /// </summary>
        /// <param name="vendedor"></param>
        public void AgregarVendedor(Entidades.Vendedor vendedor)
        {
            AdmVendedor.InsertVendedor(vendedor);
        }
        /// <summary>
        /// Recibe como parámetro una instancia del tipo <typeparamref name="Vendedor"/>
        /// y actualiza el registro cuyo ID coincide con la propiedad ID del parámetro
        /// recibido
        /// </summary>
        /// <param name="vendedor"></param>
        public void ModificarVendedor(Entidades.Vendedor vendedor)
        {
            AdmVendedor.UpdateVendedor(vendedor);
        }
        /// <summary>
        /// Recibe como parámetro una variable del tipo <typeparamref name="integer"/>
        /// y elimina el registro de la BBDD cuyo ID coincide con el parámetro recibido
        /// </summary>
        /// <param name="id"></param>
        public void BorrarVendedor(int id)
        {
            AdmVendedor.DeleteVendedor(id);
        }
        /// <summary>
        /// Devuelve un <typeparamref name="IEnumerable"/> con todos los
        /// registros de la tabla Vendedor de la BBDD
        /// </summary>
        /// <returns></returns>
        /// 
        public List<object> TraerVendedores()
        {
            return AdmVendedor.SelectVendedores().ToList();
        }
        public Entidades.Vendedor TraerPorId(int id)
        {
            return AdmVendedor.SelectId(id);
        }
    }
}
