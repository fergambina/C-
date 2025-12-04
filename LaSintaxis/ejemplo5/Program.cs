using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aqui estoy dentro de la funcion main
            //Funciones...  
            //"texto"
            string hola = saludar("fer");
            Console.WriteLine(hola);
            int b = 10;
            int r = sumar(a, ref b);
            Console.ReadKey();
        }
        static int sumar(int a, ref int z)
        {
            return a + z;
        }
        static string saludar(string nombre)
        {
            return "Hola " + nombre;
        }

    }
}
