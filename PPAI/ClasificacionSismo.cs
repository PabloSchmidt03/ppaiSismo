using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class ClasificacionSismo
    {
        private int kmProfundidad { get; set; }

        public string nombre { get; set; }
        public ClasificacionSismo(int desde, string nombre)
        {
            this.kmProfundidad = desde;
      
            this.nombre = nombre;
        }
    }
}
