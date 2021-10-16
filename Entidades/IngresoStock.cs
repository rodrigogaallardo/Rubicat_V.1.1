using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IngresoStock
    {
        public int IdIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Cantidad { get; set; }
        public int NumeroRemito { get; set; }
        public string Responsable { get; set; }

        public int MateriaPrimaId { get; set; }
        public int DepositoId { get; set; }

        public List<MateriaPrima> MateriasPrimas { get; set; }
        public List<Deposito> Depositos { get; set; }
    }
}