using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class Empleado
    {
        // Atributos privados
        private string apellido;
        private string nombre;
        private string mail;
        private string telefono;

        // Constructor (opcional)
        public Empleado(string apellido, string nombre, string mail, string telefono)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.mail = mail;
            this.telefono = telefono;
        }

        // Método público: verifica si es responsable de una reparación
        public bool esResponsableDeReparacion()
        {
            // Lógica de ejemplo (a completar según tu aplicación)
            return true;
        }

        // Método público: devuelve el mail
        public string obtenerMail()
        {
            return mail;
        }

        // Getters y Setters (opcional, si necesitás acceder/modificar desde afuera)
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }

}
