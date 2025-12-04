using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        //Botella: Esta clase representa una botella con propiedades como capacidad, color y material.
        private int capacidad; //Capacidad de la botella en litros
        private string color;   //Color de la botella
        private string material; //Material de la botella (plástico, vidrio, etc.)

        //Propiedad:
        public int Capacidad 
        {
            get { return capacidad; }
            set { capacidad = value;  }
        }
    }
}
