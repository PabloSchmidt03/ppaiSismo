using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class EstacionSismologica
    {
        // Propiedades privadas
        public string codigoEstacion;
        public string documentoCertificacionAdq;
        public DateTime fechaSolicitudCertificacion;
        public double latitud;
        public double longitud;
        public string nombre;
        public string nroCertificacionAdquisicion;

        // Constructor (opcional)
        public EstacionSismologica(string codigo, string documentoCert, DateTime fechaSolicitud, double lat, double lon, string nombre, string nroCert)
        {
            this.codigoEstacion = codigo;
            this.documentoCertificacionAdq = documentoCert;
            this.fechaSolicitudCertificacion = fechaSolicitud;
            this.latitud = lat;
            this.longitud = lon;
            this.nombre = nombre;
            this.nroCertificacionAdquisicion = nroCert;
        }

        // Métodos públicos
        public string getCodigoEstacion()
        {
            return codigoEstacion;
        }

        public string getNombre()
        {
            return nombre;
        }
    }

}
