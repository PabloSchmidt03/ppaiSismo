﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_V3.Entidades
{
    internal class ClasificacionSismo
    {
        public int kmProfundidadDesde { get; set; }
        public int kmProfundidadHasta { get; set; }
        public string nombre { get; set; }
        public ClasificacionSismo(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
