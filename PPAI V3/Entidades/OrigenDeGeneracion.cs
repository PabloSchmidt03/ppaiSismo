using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_V3.Entidades
{
    internal class OrigenDeGeneracion
    {
        public string descripcion { get; set; }
        public string nombre { get; set; }
        public OrigenDeGeneracion(string descripcion, string nombre)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }
    }
}
