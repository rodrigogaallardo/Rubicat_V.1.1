﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remito
    {
        public int IdRemito { get; set; }
        public int VentaId { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public string Referencias { get; set; }
    }
}
