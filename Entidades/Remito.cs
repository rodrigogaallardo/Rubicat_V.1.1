using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remito
    {
        public int IdRemito { get; set; }
        public int IdPedido { get; set; }                     //Tabla de otra entidad
        public string Cliente { get; set; }                   //Tabla de otra entidad
        public int Cuil { get; set; }                         //Tabla de otra entidad
        public string Direccion { get; set; }                 //Tabla de otra entidad
        public string Transporte { get; set; }                //Tabla de otra entidad
        public string TransporteDireccion { get; set; }       //Tabla de otra entidad
        public DateTime FechaDeEmision { get; set; }
        public DateTime HoraDeRecepcionTransporte{ get; set; }
        public DateTime HoraDeRecepcionCliente { get; set; }
        public string ProductoTerminado { get; set; }          //Tabla de otra entidad
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
    }
}
