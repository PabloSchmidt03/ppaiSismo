using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class Sismografo
    {
        // Propiedades privadas
        private DateTime fechaAdquisicion;
        private string identificadorSismografo;
        private string nroSerie;

        // Relación (suposición): una estación asociada
        private EstacionSismologica estacionAsociada;

        // Constructor (opcional)
        public Sismografo(DateTime fechaAdquisicion, string identificador, string nroSerie, EstacionSismologica estacion)
        {
            this.fechaAdquisicion = fechaAdquisicion;
            this.identificadorSismografo = identificador;
            this.nroSerie = nroSerie;
            this.estacionAsociada = estacion;
        }

        // Método que verifica si el sismógrafo coincide con uno pasado (por identificador)
        public bool sosDeSismografo(string idBuscado)
        {
            return identificadorSismografo == idBuscado;
        }

        // Método que obtiene la estación sismológica asociada
        public EstacionSismologica getEstacionSismologica()
        {
            return estacionAsociada;
        }
    }

}
