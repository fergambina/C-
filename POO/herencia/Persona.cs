using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    abstract class Persona //La defino como abstract para que no pueda ser instanciada. Si la marco como Sealed no puede ser heredada
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
    }
}
