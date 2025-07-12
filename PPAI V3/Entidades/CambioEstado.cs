using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_V3.Entidades
{
    internal class CambioEstado
    {
        public DateTime FechaHoraFin { get; set; }
        public DateTime FechaHoraInicio{ get; set; }
        public Estado Estado { get; set; }
        public Empleado Empleado { get; set; }
        //public CambioEstado(DateTime fechaHora, Estado estado, Empleado empleado)
        //{
        //    FechaHora = fechaHora;
        //    Estado = estado;
        //    Empleado = empleado;
        //}
        //public override string ToString()
        //{
        //    return $"Cambio de Estado: FechaHora={FechaHora}, Estado={Estado.nombreEstado}, Empleado={Empleado}";
        //}
    }
}
