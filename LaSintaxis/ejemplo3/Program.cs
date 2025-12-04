using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cilos: for, while, do while, foreach
            //Operadores: ++ -- += -= *= /= %=
            int a = 10;
            for (int x = 0; x < 10; x++)
            {
                while (a != 0)
                {
                    Console.WriteLine("Hola " + x); //Decremento
                    a--;
                }
                a = 10;
            }

            do
            {

            } while (a !=0 );

            Console.ReadKey();
        }
        
    }
}
