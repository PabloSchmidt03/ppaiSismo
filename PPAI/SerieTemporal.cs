using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class SerieTemporal
    {
        // Propiedades
        public string CondicionAlarma { get; set; }
        public DateTime FechaHoraInicioRegistroMuestras { get; set; }
        public DateTime FechaHoraRegistro { get; set; }
        public double FrecuenciaMuestreo { get; set; }
        public List<MuestraSismica> MuestrasSismicas { get; set; }
        public Sismografo Sismografo { get; set; }

        // Constructor opcional
        public SerieTemporal(string condicionAlarma, DateTime inicioMuestras, DateTime registro, double frecuencia)
        {
            CondicionAlarma = condicionAlarma;
            FechaHoraInicioRegistroMuestras = inicioMuestras;
            FechaHoraRegistro = registro;
            FrecuenciaMuestreo = frecuencia;
        }

        // Método para obtener datos
        public void GetDatos()
        {
            // Obtiene los datos de la serie temporal y se comunica con las muestras temporales para obtener sus datos
            // Acá iría la lógica de consulta o cálculo
        }
    }

}
