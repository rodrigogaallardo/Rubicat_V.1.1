using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HojaDePedido
    {
        public int IdPedido { get; set; }
        public string Cliente { get; set; }                 //Tabla de otra entidad
        public string Transporte { get; set; }              //Tabla de otra entidad
        public DateTime FechaDeEntrega { get; set; }
        public DateTime HoraDeEntrega { get; set; }
        public string ProductoTerminado { get; set; }       //Tabla de otra entidad
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string ContactoLogistico { get; set; }
        public int NumeroLogistico { get; set; }

    }
}
