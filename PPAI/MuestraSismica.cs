using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class MuestraSismica
    {
        // Propiedad
        public DateTime FechaHoraMuestra { get; set; }
        public List<DetalleMuestraSismica> detalleMuestaSismica { get; set; }

        // Constructor opcional
        public MuestraSismica(DateTime fechaHoraMuestra)
        {
            FechaHoraMuestra = fechaHoraMuestra;
        }

        // Método para obtener los datos
        public void GetDatos()
        {
            // Busca los valores en el detalle de la muestra
            // Aquí iría la lógica correspondiente
        }
    }

}
