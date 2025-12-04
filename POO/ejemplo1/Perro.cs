using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Perro
    {
        private string nombre;
        private string color;
        private string origen;

        //Metodos para el atributo nombre
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string n)
        {
            nombre = n;
        }

        //Propiedades del atributo color
        public string Color
        {
            get { return color; }
            set { color = value; }

         }

        //Metodos para el atributo origen
        public string getOrigen()
        {
            return origen;
        }

        public void setOrigen(string o)
        {
            origen = o;
        }
    }
}
