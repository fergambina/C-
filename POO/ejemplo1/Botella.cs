using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {   
        //Capacidad Maxima = 100
        //cantidadActual = inicia en cero
        //Metodo recarga: carga al 100 y devuelve el costo de recargar. 50 de 100

        //Constructor
        public Botella(string color, string material) 
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        //Sobrecargar el constructor
        public Botella() { }

        ~ Botella() { 
            //Codigo que necesite...
        }

        //Defincion de la clase
        private int capacidad; 
        private string color;   
        private string material; 
        private int cantidadActual;   

        public int Capacidad
        {
            get { return capacidad; }
        }
        
        public string Color
        {
            get { return color; }
        }

        public string Material
        {
            get { return material; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        //public int Capacidad 
        //{
          //  get { return capacidad; }
            //set { capacidad = value;  }
        //}

        //Metodos o comportamientos de la botella:
        public float recargar()
        {
            if(cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
        }


    }
}
