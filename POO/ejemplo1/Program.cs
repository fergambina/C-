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
            //Persona: Esta clase representa a una persona con propiedades básicas como nombre, sueldo y edad.
            //int edad;
            //float sueldo;
            //string nombre;


            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            Persona p1 = new Persona(); //Se crea un objeto de la clase Persona

            p1.setEdad(20); //Se llama al método setEdad para asignar un valor a la edad
            Console.WriteLine("La edad de la persona es: " + p1.getEdad()); //Se llama al método getEdad para obtener el valor de la edad y se muestra en pantalla);
            
            Botella b1 = new Botella();
            b1.Capacidad = 2; //Se asigna el valor 2 a la propiedad Capacidad de la botella
            int algo = b1.Capacidad; //Se obtiene el valor de la propiedad Capacidad de la botella

            Perro perro1 = new Perro(); 

            Console.WriteLine("Ingrese nombre del perro: ");
            string nombrePerro = Console.ReadLine(); 
            perro1.setNombre(nombrePerro);
            Console.WriteLine("Ingrese color del perro: ");
            string colorPerro = Console.ReadLine();
            perro1.Color = colorPerro;
            Console.WriteLine("Ingrese origen del perro: ");
            string origenPerro = Console.ReadLine();
            perro1.setOrigen(origenPerro);

            Console.WriteLine("El nombre del perro es: " + perro1.getNombre());
            Console.WriteLine("El color del perro es: " + perro1.Color);
            Console.WriteLine("El origen del perro es: " + perro1.getOrigen());


            //Armar clase Articulo: Codigo, Precio
            Articulo articulo1 = new Articulo(); //Se crea un objeto de la clase Articulo
            Console.WriteLine("Ingrese codigo del articulo: ");
            int codigo = int.Parse(Console.ReadLine());
            articulo1.setCodigo(codigo);
            Console.WriteLine("Ingrese precio del articulo: ");
            float precio = float.Parse(Console.ReadLine());
            articulo1.setPrecio(precio);
            Console.WriteLine("El codigo del articulo es: " + articulo1.getCodigo());
            Console.WriteLine("El precio del articulo es: " + articulo1.getPrecio());


            //Venta: Esta clase representa una venta realizada, que incluye el codigo del articulo vendido, la cantidad vendida y el codigo del cliente que realizó la compra.
            Venta v1 = new Venta();
            Console.WriteLine("Ingrese codigo del articulo: ");
            int codigoArticulo = int.Parse(Console.ReadLine());
            v1.setCodigoArticulo(codigoArticulo);
            Console.WriteLine("Ingrese cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());
            v1.setCantidad(cantidad);
            Console.WriteLine("Ingrese codigo del cliente: ");
            int codigoCliente = int.Parse(Console.ReadLine());
            v1.setCodigoCliente(codigoCliente);
            Console.WriteLine("El codigo del articulo es: " + v1.getCodigoArticulo());
            Console.WriteLine("La cantidad es: " + v1.getCantidad());
            Console.WriteLine("El codigo del cliente es: " + v1.getCodigoCliente());    


            Console.ReadKey();
        }
    }
}
