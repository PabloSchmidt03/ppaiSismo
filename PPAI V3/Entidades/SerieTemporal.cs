using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_V3.Entidades
{
    internal class SerieTemporal
    {
        public DateTime fechaHoraInicioRegistro { get; set; }
        public DateTime fechaHoraRegistro { get; set; }
        public int condicionAlarma { get; set; }
        public int frecuenciaMuestreo { get; set; }
        public List<MuestraSismica> MuestrasSismicas { get; set; }  
    }
}
