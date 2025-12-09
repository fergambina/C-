using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // No se puede instanciar: Persona p1 = new Persona();
            Developer d1 = new Developer();
            Lider.algo();
        }

        //Las clases estaticas se usan para tener metodos de validaciones.
    }
}
