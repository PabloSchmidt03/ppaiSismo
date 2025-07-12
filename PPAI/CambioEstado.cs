using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class CambioEstado
    {
        // Atributos
        private DateTime fechaHoraInicio;
        public DateTime? fechaHoraFin;
        private Estado estado;

        // Constructor
        public CambioEstado(Estado estado, DateTime inicio)
        {
            this.estado = estado;
            fechaHoraInicio = inicio;
            fechaHoraFin = null;
        }
        public CambioEstado()
        {

        }

        // Marca el cambio de estado como cerrado (le pone fecha/hora de fin)
        public void SetFechaHoraFin(DateTime fin)
        {
            fechaHoraFin = fin;
        }

        // Consulta si este es el estado actual (es decir, no tiene fecha de fin)
        public bool EsEstadoActual()
        {
            return fechaHoraFin == null;
        }

        // Consulta si el estado asociado es AutoDetectado
        public bool EsAutoDetectado()
        {
            return estado.EsAutoDetectado();
        }

        // Consulta si el estado asociado es PendienteDeRevision
        public bool EsPendienteDeRevision()
        {
            return estado.EsPendienteDeRevision();
        }

        // Consulta si el estado es de cierto ámbito
        public bool EsDelAmbito(string ambitoBuscado)
        {
            return estado.ambito == ambitoBuscado;
        }

        // Getter por si lo necesitás
        public Estado GetEstado()
        {
            return estado;
        }

        public DateTime GetFechaHoraInicio()
        {
            return fechaHoraInicio;
        }

        public DateTime? GetFechaHoraFin()
        {
            return fechaHoraFin;
        }
    }

}
