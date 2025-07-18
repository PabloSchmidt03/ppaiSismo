﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_V3.Entidades
{
    internal class TipoDeDato
    {
        public string Denominacion { get; set; }
        public string NombreUnidadMedida { get; set; }
        public double ValorUmbral { get; set; }

        public TipoDeDato(string denominacion, string nombreUnidadMedida, double valorUmbral)
        {
            Denominacion = denominacion;
            NombreUnidadMedida = nombreUnidadMedida;
            ValorUmbral = valorUmbral;
        }
    }

}

