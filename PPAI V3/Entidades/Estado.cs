﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_V3.Entidades
{
    internal class Estado
    {
        public string ambito { get; set; }
        public string nombreEstado { get; set; }
        public Estado(string ambito, string nombreEstado)
        {
            this.ambito = ambito;
            this.nombreEstado = nombreEstado;
        }
    }
}
