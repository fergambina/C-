using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Persona: Esta clase representa a una persona con propiedades básicas como nombre, sueldo y edad.
        //Atributos o miembros de la clase Persona
        private int edad;
        private float sueldo;
        private string nombre;

        public void setEdad(int e)
        {
            edad = e;   //Le asigna el valor del parámetro e al atributo edad   
        }

        public int getEdad()
        {
            return edad; //Devuelve el valor del atributo edad

        }
    }
}
