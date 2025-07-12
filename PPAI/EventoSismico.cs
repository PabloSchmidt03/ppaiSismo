using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class EventoSismico
    {
        // Atributos como propiedades
        public DateTime FechaHoraFin { get; set; }
        public DateTime FechaHoraOcurrencia { get; set; }
        public double LatitudEpicentro { get; set; }
        public double LatitudHipocentro { get; set; }
        public double LongitudEpicentro { get; set; }
        public double LongitudHipocentro { get; set; }
        public double ValorMagnitud { get; set; }

        public Estado Estado { get; set; }
        public CambioEstado CambioEstado { get; set; }   

        public List<SerieTemporal> SerieTemporal {  get; set; }
        public ClasificacionSismo clasificacionSismo { get; set; }
        public OrigenDeGeneracion origenDeGeneracion { get; set; }
        public AlcanceSismo alcanceSismo { get; set; } 

            
        // Métodos para estados (placeholders)
        public bool EstaEnEstadoAutoDetectado()
        {
            // Simulación para pruebas
            return ValorMagnitud < 5;
        }

        public bool EstaEnEstadoPendienteDeRevision()
        {
            return ValorMagnitud >= 4 && ValorMagnitud < 5;
        }

        // Método resumen para obtener los datos del evento
        public void GetDatosEventoSismico()
        {
            // Puede mostrar o retornar un DTO con todos los datos del evento
            throw new NotImplementedException();
        }

        // Métodos "self" tipo getter si el modelo los exige explícitamente
        public DateTime GetFechaHoraOcurrencia() => FechaHoraOcurrencia;
        public double GetLatitudEpicentro() => LatitudEpicentro;
        public double GetLatitudHipocentro() => LatitudHipocentro;
        public double GetLongitudEpicentro() => LongitudEpicentro;
        public double GetLongitudHipocentro() => LongitudHipocentro;
        public double GetValorMagnitud() => ValorMagnitud;

        // Métodos que se ejecutan cuando el evento es seleccionado
        public void CambiarEstadoEventoSismicoABloqueadoEnRevision(EventoSismico seleccion)
        {
            seleccion.Estado.nombreEstado = "BloqueadoEnRevision"; ;

            CrearCambioEstado();
        }

        public void CrearCambioEstado()
        {
            this.CambioEstado = new CambioEstado(this.Estado, DateTime.Now);
        }

        public void GetDatosSismicosRegistradosParaEventoSismicoSeleccionado(List<SerieTemporal> serieTemporal)
        {
     
            foreach (var serie in SerieTemporal)
            {
                foreach (var muestra in serie.MuestrasSismicas)
                {
                    foreach (var detalle in muestra.detalleMuestaSismica)
                    {
                        // Acá ya tenés acceso a:
                        // - serie (SerieTemporal)
                        // - muestra (MuestraSismica)
                        // - detalle (DetalleMuestraSismica)
                        // - detalle.tipoDeDato

                        // Podés usar por ejemplo:
                        // detalle.valor
                        // detalle.tipoDeDato.Denominacion
                        // muestra.FechaHoraMuestra
                    }
                }
            
            }
            GestorRegistroResultadoRevisionManual gestor = new GestorRegistroResultadoRevisionManual();
            EventoSismico evento = new EventoSismico();
            gestor.clasificarMuestrasPorEstacionSismologica(evento);

        }

        public void GetOrigen()
        {

        }

        public void GetAlcance()
        {

        }

        public void GetClasificacion()
        {

        }

        public void GetValoresAlcanzadosPorCadaInstanteDeTiempo()
        {
            // Recorrer series temporales y obtener datos
            throw new NotImplementedException();
        }

        public void EsDeEstacionSismologica()
        {
            // Se comunica con sismógrafo y consulta si pertenece
            throw new NotImplementedException();
        }

        // Para mostrarlo fácilmente en controles como ListBox
        public override string ToString()
        {
            return $"[{FechaHoraOcurrencia:dd/MM/yyyy HH:mm}] Mag {ValorMagnitud} - Epicentro ({LatitudEpicentro}, {LongitudEpicentro})";
        }
        public void validarDatosSismo()
        {
            GetOrigen();
            GetValorMagnitud();
            GetAlcance();
            GestorRegistroResultadoRevisionManual gestor = new GestorRegistroResultadoRevisionManual();
            gestor.validarSelecciónConfirmación();
        }
    }


}
