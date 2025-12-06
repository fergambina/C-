using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro(); //// Se crea una nueva instancia de la clase Perro y se asigna a la variable 'p1'.
            Perro p2 = new Perro();
            Gato g1 = new Gato();
            Gato g2 = new Gato();
            Gato g3 = new Gato();
            Tigre t1 = new Tigre();
            Aguila a1 = new Aguila();

            List<Animal> animales = new List<Animal>(); // Se crea una nueva lista dinámica vacía para almacenar objetos del tipo Animal.
            animales.Add(p1);
            animales.Add(p2);
            animales.Add(g1);
            animales.Add(g2);
            animales.Add(g3);
            animales.Add(t1);
            animales.Add(a1);

            Console.WriteLine("La cantidad de animales hasta el momento es: " + animales.Count);
            Console.WriteLine("Eliminando animales de la lists...");

            animales.Remove(g3);
            animales.Remove(g1);
            animales.Remove(a1);

            foreach (Animal item in animales)
            {
                item.comunicarse();
            }

            Console.WriteLine("La cantidad de animales al final es: " + animales.Count);

            Console.ReadKey();

        }
    }
}
