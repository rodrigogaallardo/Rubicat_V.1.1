using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class Zona
    {

        /// <summary>
        /// Recibe como parámetro una instancia del tipo <typeparamref name="Zona"/>
        /// y la agrega como registro a la tabla Zona de la BBDD
        /// </summary>
        /// <param name="zona"></param>
        public void AgregarZona(Entidades.Zona zona)
        {
            AdmZona.InsertZona(zona);
        }
        /// <summary>
        /// Recibe como parámetro una instancia del tipo <typeparamref name="Zona"/>
        /// y actualiza el registro de la tabla Zona de la BBDD cuyo ID coincida con
        /// la propiedad ID del parámetro recibido
        /// </summary>
        /// <param name="zona"></param>
        public void ModificarZona(Entidades.Zona zona)
        {
            AdmZona.UpdateZona(zona);
        }
        /// <summary>
        /// Recibe como parámetro una variable del tipo <typeparamref name="integer"/>
        /// y elimina el registro de la tabla Zona de la BBDD cuyo ID coincide con
        /// el parámetro recibido
        /// </summary>
        /// <param name="id"></param>
        public void BorrarZona(int id)
        {
            AdmZona.DeleteZona(id);
        }
        /// <summary>
        /// Devuelve un <typeparamref name="IEnumerable"/> con todos los
        /// registros de la tabla Zona de la BBDD
        /// </summary>
        /// <returns></returns>
        public List<Entidades.Zona> TraerZonas()
        {
            return AdmZona.SelectZonas();
        }
    }
}
