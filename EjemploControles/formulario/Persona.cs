using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Nacionalidad { get; set; }

        //Metodos
        public string Saludar()
        {
            string mensaje = "Nombre: " + Nombre + ", Apellido: " + Apellido + ", Fecha de nacimiento: " + FechaNacimiento + ", Email: " + Email + ", Nacionalidad: " + Nacionalidad;
            return mensaje;
        }
    }
}
