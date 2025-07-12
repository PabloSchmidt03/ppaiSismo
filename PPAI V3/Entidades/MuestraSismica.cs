using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_V3.Entidades
{
    internal class MuestraSismica
    {
        public DateTime fechaHoraMuestra { get; set; }
        public int valor { get; set; }
        public List<DetalleMuestraSismica> DetallesMuestraSismica { get; set; }
    }
}
