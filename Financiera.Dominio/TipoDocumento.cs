﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Dominio
{
    public class TipoDocumento
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
    }
}
