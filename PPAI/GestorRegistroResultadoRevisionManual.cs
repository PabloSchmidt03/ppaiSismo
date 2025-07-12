using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI
{
    public class GestorRegistroResultadoRevisionManual
    {

        private List<EventoSismico> datosEventoSismico;

        private EventoSismico seleccionEventoSismico;//array de 1

        private int valoresAlcanzadosDeSeriesTemporales; //array de alcance magnitud origen 

        private bool selecciónRechazo;

        private string sesionEmpleado;

        private int fechaHoraFinEventoSismico;




        public List<EventoSismico> buscarSismosAutoDetectadosNoRevisados()
        {
            var eventos = new List<EventoSismico>
    {
        new EventoSismico
        {
            FechaHoraFin = new DateTime(2025, 2, 21, 19, 15, 41),
            FechaHoraOcurrencia = new DateTime(2025, 2, 21, 19, 5, 41),
            LatitudEpicentro = -34.60,
            LatitudHipocentro = -34.70,
            LongitudEpicentro = -58.38,
            LongitudHipocentro = -58.50,
            ValorMagnitud = 4.5,
            Estado = new Estado("AutoDetectado", "EventoSismico"),
            clasificacionSismo = new ClasificacionSismo(0, "Superficial"),
            origenDeGeneracion = new OrigenDeGeneracion("sismo interplaca"),
            alcanceSismo = new AlcanceSismo(100),
            SerieTemporal = new List<SerieTemporal>
            {
                new SerieTemporal("Sin Alarma", DateTime.Now.AddMinutes(-10), DateTime.Now, 100.0)
                {
                    Sismografo = new Sismografo(
                        DateTime.Now.AddYears(-2),
                        "SISMO001",
                        "SN-001",
                        new EstacionSismologica(
                            "EST001",
                            "DOC123",
                            DateTime.Now.AddYears(-3),
                            -34.60,
                            -58.38,
                            "Estación Central",
                            "CERT-987"
                        )
                    ),
                    MuestrasSismicas = new List<MuestraSismica>
                    {
                        new MuestraSismica(DateTime.Now.AddMinutes(-5))
                        {
                            detalleMuestaSismica = new List<DetalleMuestraSismica>
                            {
                                new DetalleMuestraSismica
                                {
                                    valor = 85,
                                    tipoDeDato = new TipoDeDato
                                    {
                                        Denominacion = "Frecuencia de onda",
                                        NombreUnidadMedida = "Hz",
                                        ValorUbral = 90
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },

        new EventoSismico
        {
            FechaHoraFin = new DateTime(2025, 2, 22, 2, 10, 41),
            FechaHoraOcurrencia = new DateTime(2025, 2, 21, 22, 10, 41),
            LatitudEpicentro = -33.12,
            LatitudHipocentro = -33.30,
            LongitudEpicentro = -60.25,
            LongitudHipocentro = -60.40,
            ValorMagnitud = 3.8,
            Estado = new Estado("PendienteDeRevision", "EventoSismico"),
            clasificacionSismo = new ClasificacionSismo(62, "Intermedio"),
            origenDeGeneracion = new OrigenDeGeneracion("sismo volcanico"),
            alcanceSismo = new AlcanceSismo(900),
            SerieTemporal = new List<SerieTemporal>
            {
                new SerieTemporal("Moderada", DateTime.Now.AddHours(-2), DateTime.Now.AddMinutes(-10), 80.0)
                {
                    Sismografo = new Sismografo(
                        DateTime.Now.AddYears(-1),
                        "SISMO002",
                        "SN-002",
                        new EstacionSismologica(
                            "EST002",
                            "DOC456",
                            DateTime.Now.AddYears(-2),
                            -33.12,
                            -60.25,
                            "Estación Sur",
                            "CERT-654"
                        )
                    ),
                    MuestrasSismicas = new List<MuestraSismica>
                    {
                        new MuestraSismica(DateTime.Now.AddMinutes(-50))
                        {
                            detalleMuestaSismica = new List<DetalleMuestraSismica>
                            {
                                new DetalleMuestraSismica
                                {
                                    valor = 110,
                                    tipoDeDato = new TipoDeDato
                                    {
                                        Denominacion = "Longitud de onda",
                                        NombreUnidadMedida = "m",
                                        ValorUbral = 100
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },

        new EventoSismico
        {
            FechaHoraFin = new DateTime(2025, 2, 20, 15, 10, 0),
            FechaHoraOcurrencia = new DateTime(2025, 2, 20, 14, 55, 0),
            LatitudEpicentro = -35.00,
            LatitudHipocentro = -35.10,
            LongitudEpicentro = -57.90,
            LongitudHipocentro = -58.00,
            ValorMagnitud = 5.2,
            Estado = new Estado("Confirmado", "EventoSismico"),
            clasificacionSismo = new ClasificacionSismo(600, "Profundo"),
            origenDeGeneracion = new OrigenDeGeneracion("sismo volcanico"),
            alcanceSismo = new AlcanceSismo(2000),
            SerieTemporal = new List<SerieTemporal>
            {
                new SerieTemporal("Crítica", DateTime.Now.AddHours(-5), DateTime.Now.AddHours(-4), 120.0)
                {
                    Sismografo = new Sismografo(
                        DateTime.Now.AddYears(-3),
                        "SISMO003",
                        "SN-003",
                        new EstacionSismologica(
                            "EST003",
                            "DOC789",
                            DateTime.Now.AddYears(-4),
                            -35.00,
                            -57.90,
                            "Estación Norte",
                            "CERT-321"
                        )
                    ),
                    MuestrasSismicas = new List<MuestraSismica>
                    {
                        new MuestraSismica(DateTime.Now.AddHours(-4).AddMinutes(-30))
                        {
                            detalleMuestaSismica = new List<DetalleMuestraSismica>
                            {
                                new DetalleMuestraSismica
                                {
                                    valor = 150,
                                    tipoDeDato = new TipoDeDato
                                    {
                                        Denominacion = "Presión sísmica",
                                        NombreUnidadMedida = "kPa",
                                        ValorUbral = 140
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    };

            eventos = buscarSismosAutoDetectadosPendienteDeRevision(eventos);
            return eventos;
        }




        public List<EventoSismico> buscarSismosAutoDetectadosPendienteDeRevision(List<EventoSismico> eventos)
        {
 
            return eventos.Where(e =>
                e.Estado.EsAutoDetectado() ||
                e.Estado.EsPendienteDeRevision()).ToList();
        }


        public List<EventoSismico> ordenarEventosSismicosPorFechaYHora(List<EventoSismico> eventos)
        {
            return eventos
                .OrderBy(e => e.FechaHoraOcurrencia)
                .ToList();
        }


        public void validarDatosEvento(EventoSismico evento)
        {
            evento.validarDatosSismo();
            
            // hace una consuilta al evento seleccionado y se asegura que alcance magnitud y origen no son valores nulos
        }

        public void validarSelecciónConfirmación()
        {
            obtenerFechaHoraActual();
        }

        public void tomarSeleccionEventoSismico(EventoSismico seleccion)
        {
            cambiarEventoSismicoSeleccionadoABloqueadoEnRevisión(seleccion);
        }

        public void buscarDatosSismicosRegistradosParaElEventoSismicoSeleccionado()
        {
            return;
        }

        public void obtenerValoresAlcanzadosDeSeriesTemporales(EventoSismico evento)
        {
            //aca adentro estan todos los loops anidados
            evento.GetDatosSismicosRegistradosParaEventoSismicoSeleccionado(evento.SerieTemporal);
            clasificarMuestrasPorEstacionSismologica(evento);
            llamarAlCasoDeUsoGenerarSismograma();


        }

        private void llamarAlCasoDeUsoGenerarSismograma()
        {
            PantallaGestionRegistroResultadoRevisionManual pantalla = new PantallaGestionRegistroResultadoRevisionManual();
            pantalla.habilitarOpcionVisualizacionMapaConEstacionesSismologicasInvolucradas("C:\\Users\\pablo\\Desktop\\sismo.png");
           
        }
        public void clasificarMuestrasPorEstacionSismologica(EventoSismico evento)
        {

        }






        public void tomarSelecciónRechazo()
        {
            //despues de mostrarle el confirmar rechazar o derivar se elige la opcion de rechazo
        }

        public void obtenerFechaHoraActual()
        {
            obtenerEmpleadoSesion();

        }

        public void obtenerEmpleadoSesion()
        {
            Sesion sesion = new Sesion();
            sesion.getEmpleado();
            cambiarEventoSismicoSeleccionadoARechazado();
        }

        public void cambiarEventoSismicoSeleccionadoARechazado()
        {
            CambioEstado cambio = new CambioEstado();
            cambio.SetFechaHoraFin(DateTime.Now);
        }

        public void cambiarEventoSismicoSeleccionadoABloqueadoEnRevisión(EventoSismico seleccion)
        {

            //esto va recien en CambiarEstadoEventoSismicoABloqueadoEnRevision
            if (seleccion.Estado.SosBloqueadoEnRevision() == false)
            {
               
                seleccion.Estado.nombreEstado = "BloqueadoEnRevision";

                
            }
            ;
            seleccion.CrearCambioEstado();

            seleccion.CambioEstado.SetFechaHoraFin(seleccion.FechaHoraFin);
            buscarDatosSismicosRegistradosParaElEventoSismicoSeleccionado();
            PantallaGestionRegistroResultadoRevisionManual pantalla = new PantallaGestionRegistroResultadoRevisionManual();
            pantalla.mostrarDatosEventoSismicoSeleccionado(seleccion);


            finCU();


        }

        public void finCU()
        {
            MessageBox.Show(
    "✅ ¡Caso de uso finalizado con éxito!\n\n" +
    "📌 Estado del evento sísmico: Rechazado\n" +
    "🕒 Fecha y hora del cambio registrada " +
    "👤 Analista responsable registrado.",
    "Evento sísmico actualizado",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);

        }




    }
}
