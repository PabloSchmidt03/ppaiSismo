using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class Estado
    {
        // Atributos privados
        public string ambito;
        public string nombreEstado;

        // Constructor opcional
        public Estado(string nombreEstado, string ambito)
        {
            this.nombreEstado = nombreEstado;
            this.ambito = ambito;
        }

        // Métodos que simulan validación de estado
        public bool EsAutoDetectado()
        {
            return nombreEstado == "AutoDetectado";
        }

        public bool EsPendienteDeRevision()
        {
            return nombreEstado == "PendienteDeRevision";
        }

        public bool EsAmbitoEventoSismico()
        {
            return ambito == "EventoSismico";
        }

        public bool SosBloqueadoEnRevision()
        {
            return nombreEstado == "BloqueadoEnRevision";
        }

        
    }
}
