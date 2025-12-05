using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Telefono
    {
        //Atributos de la clase Telefono
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador; //(1, 2 o 3)

        //Constructor
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        //Propiedades
        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; }
        }

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value == 1 || value == 2 || value == 3)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }

        //Metodos
        public string llamar()
        {
            return "Realizando llamada...";
        }

        public string llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }


    }
}
