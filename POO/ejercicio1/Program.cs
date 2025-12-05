using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("G52", "Motorola");
            Console.Write("Ingrese numero telefonico: ");
            t1.NumeroTelefonico = Console.ReadLine();
            Console.Write("Ingrese codigo de operador: ");
            t1.CodigoOperador = int.Parse(Console.ReadLine());
            Console.WriteLine("Modelo: " + t1.Modelo);
            Console.WriteLine("Marca: " + t1.Marca);
            Console.WriteLine("Numero telefonico: " + t1.NumeroTelefonico);
            Console.WriteLine("Codigo operador: " + t1.CodigoOperador);

            Console.WriteLine(t1.llamar());
            Console.WriteLine(t1.llamar("Luca"));

            Console.ReadKey();

        }
    }
}
