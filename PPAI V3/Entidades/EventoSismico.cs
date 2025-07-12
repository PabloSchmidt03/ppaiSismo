using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_V3.Entidades
{
    internal class EventoSismico
    {
        public int Id { get; set; }
        public string Ubicacion { get; set; }
        public bool Revisado { get; set; }

        public DateTime FechaHoraFin { get; set; }
        public DateTime FechaHoraOcurrencia { get; set; }
        public int LatitudEpicentro { get; set; }
        public int LongitudEpicentro { get; set; }
        public int LongitudHipocentro { get; set; }
        public double ValorMagnitud { get; set; }
        public ClasificacionSismo ClasificacionSismo { get; set; }
        public OrigenDeGeneracion OrigenDeGeneracion { get; set; }
        public AlcanceSismo AlcanceSismo { get; set; }
        public List<SerieTemporal> SeriesTemporales { get; set; }
        public Estado Estado { get; set; }
        public Empleado Empleado { get; set; }
        public CambioEstado CambioEstado { get; set; }

        public EventoSismico(
            DateTime fechaHoraFin,
            DateTime fechaHoraOcurrencia,
            int latitudEpicentro,
            int longitudEpicentro,
            int longitudHipocentro,
            double valorMagnitud,
            ClasificacionSismo clasificacionSismo,
            OrigenDeGeneracion origenDeGeneracion,
            AlcanceSismo alcanceSismo,
            List<SerieTemporal> seriesTemporales,
            Estado estado,
            Empleado empleado,
            CambioEstado cambioEstado)
        {
            FechaHoraFin = fechaHoraFin;
            FechaHoraOcurrencia = fechaHoraOcurrencia;
            LatitudEpicentro = latitudEpicentro;
            LongitudEpicentro = longitudEpicentro;
            LongitudHipocentro = longitudHipocentro;
            ValorMagnitud = valorMagnitud;
            ClasificacionSismo = clasificacionSismo;
            OrigenDeGeneracion = origenDeGeneracion;
            AlcanceSismo = alcanceSismo;
            SeriesTemporales = seriesTemporales;
            Estado = estado;
            Empleado = empleado;
            CambioEstado = cambioEstado;
        }
    }
}


