using System;
using System.Collections.Generic;

namespace PPAI_V3.Entidades
{
    internal class CargarDatos
    {
        public static List<EventoSismico> CrearEventos()
        {
            // ---- 1) Crear instancias de Estados ----
            var estadoPendiente = new Estado("sismo", "pendienteRevision");
            var estadoRevisado = new Estado("sismo", "revisado");

            // ---- 2) Crear tipos de dato ----
            var tipoLongitud = new TipoDeDato("longitud", "m", 0.0);
            var tipoFrecuencia = new TipoDeDato("frecuencia", "Hz", 0.0);
            var tipoVelocidad = new TipoDeDato("velocidad de onda", "m/s", 0.0);

            // ---- 3) Crear eventos ----
            var eventos = new List<EventoSismico>();

            eventos.Add(new EventoSismico(
                fechaHoraFin: new DateTime(2025, 5, 20, 10, 15, 0),
                fechaHoraOcurrencia: new DateTime(2025, 5, 20, 10, 0, 0),
                latitudEpicentro: -34,
                longitudEpicentro: -58,
                longitudHipocentro: -58,
                valorMagnitud: 5.4,
                clasificacionSismo: new ClasificacionSismo("Moderado"),
                origenDeGeneracion: new OrigenDeGeneracion("Tectónico"),
                alcanceSismo: new AlcanceSismo(100),
                seriesTemporales: new List<SerieTemporal>(),
                estado: estadoPendiente,
                empleado: new Empleado("Carlos"),
                cambioEstado: new CambioEstado(estadoPendiente, new DateTime(2025, 5, 20, 10, 0, 0))
            ));

            eventos.Add(new EventoSismico(
                fechaHoraFin: new DateTime(2025, 5, 19, 9, 15, 0),
                fechaHoraOcurrencia: new DateTime(2025, 5, 19, 8, 45, 0),
                latitudEpicentro: -33,
                longitudEpicentro: -60,
                longitudHipocentro: -60,
                valorMagnitud: 4.8,
                clasificacionSismo: new ClasificacionSismo("Leve"),
                origenDeGeneracion: new OrigenDeGeneracion("Volcánico"),
                alcanceSismo: new AlcanceSismo(50),
                seriesTemporales: new List<SerieTemporal>(),
                estado: estadoPendiente,
                empleado: new Empleado("Lucía"),
                cambioEstado: new CambioEstado(estadoPendiente, new DateTime(2025, 5, 19, 8, 45, 0))
            ));

            eventos.Add(new EventoSismico(
                fechaHoraFin: new DateTime(2025, 5, 17, 12, 30, 0),
                fechaHoraOcurrencia: new DateTime(2025, 5, 17, 12, 0, 0),
                latitudEpicentro: -35,
                longitudEpicentro: -57,
                longitudHipocentro: -58,
                valorMagnitud: 6.1,
                clasificacionSismo: new ClasificacionSismo("Fuerte"),
                origenDeGeneracion: new OrigenDeGeneracion("Tectónico"),
                alcanceSismo: new AlcanceSismo(150),
                seriesTemporales: new List<SerieTemporal>(),
                estado: estadoRevisado,
                empleado: new Empleado("Ana"),
                cambioEstado: new CambioEstado(estadoRevisado, new DateTime(2025, 5, 17, 12, 0, 0))
            ));

            return eventos;
        }
    }
}
