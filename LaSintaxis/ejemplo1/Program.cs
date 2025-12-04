using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables:
            //int float bool char
            //double decimal string long short datetime
            int a, b, c; //Declaracion de variable
            float d, f;
            Console.WriteLine("Hola como va?");
            Console.WriteLine("Ingrese un numero:");
            a = int.Parse(Console.ReadLine()); //Asignacion de variable, utilizo un parse para convertir el string a int
            b = 10;
            c = a + b;  //Asignacion de variable

            Console.WriteLine("El resultado de la suma es: " + c); //Concatenacion
            Console.ReadKey(); 



        }
    }
}
