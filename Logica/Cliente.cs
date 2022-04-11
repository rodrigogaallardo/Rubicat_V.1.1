using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente
    {
        /// <summary>
        /// Recibe como parámetro una instancia del tipo <typeparamref name="Cliente"/>
        /// y lo agrega como registro a la BBDD
        /// </summary>
        /// <param name="cliente"></param>
        public void AgregarCliente(Entidades.Cliente cliente)
        {
            AdmCliente.InsertCliente(cliente);
        }
        /// <summary>
        /// Recibe como parámetro una instancia del tipo <typeparamref name="Cliente"/>
        /// y modifica el registro de la BBDD que tiene el mismo valor de campo ID
        /// </summary>
        /// <param name="cliente"></param>
        public void ModificarCliente(Entidades.Cliente cliente)
        {
            AdmCliente.UpdateCliente(cliente);
        }
        /// <summary>
        /// Recibe como parámetro un <typeparamref name="Integer"/> y elimina
        /// en la BBDD el registro cuya ID coincide con el parámetro recibido
        /// </summary>
        /// <param name="id"></param>
        public void BorrarCliente(int id)
        {
            AdmCliente.DeleteCliente(id);
        }
        /// <summary>
        /// Devuelve un tipo <typeparamref name="IEnumerable"/> con todos los registros
        /// de clientes de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<object> TraerClientes()
        {
            return AdmCliente.SelectClientes().ToList();
        }
        public Entidades.Cliente TraerPorId(int id)
        {
            return AdmCliente.SelectId(id);
        }
        public List<Entidades.Cliente> SelectCliente(string letra)
        {
            return AdmCliente.SelectClientes(letra);
        }
    }
}
