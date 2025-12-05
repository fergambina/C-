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

            //Persona p1 = new Persona("Fer"); //Se crea un objeto de la clase Persona
            //p1.setEdad(20); //Se llama al método setEdad para asignar un valor a la edad
            //Console.WriteLine(p1.saludar());
            //Console.WriteLine(p1.saludar("Facu"));
            //Console.WriteLine("La edad de la persona es: " + p1.getEdad()); //Se llama al método getEdad para obtener el valor de la edad y se muestra en pantalla);


            Botella b1 = new Botella("Rojo", "Plastico"); //Primero esta el tipo de dato, luego el nombre de variable. Despues de la asignacion esta NEW en la que invocamos al constructor de la clase
            Console.WriteLine("La capacidad de la botella es: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual de la botella es: " + b1.CantidadActual);
            b1.recargar(20);
            Console.WriteLine("Luego de recargar, la cantidad actual de la botella es: " + b1.CantidadActual);
    


            //Perro perro1 = new Perro(); 
            //Console.WriteLine("Ingrese nombre del perro: ");
            //string nombrePerro = Console.ReadLine(); 
            //perro1.setNombre(nombrePerro);
            //Console.WriteLine("Ingrese color del perro: ");
            //string colorPerro = Console.ReadLine();
            //perro1.Color = colorPerro;
            //Console.WriteLine("Ingrese origen del perro: ");
            //string origenPerro = Console.ReadLine();
            //perro1.setOrigen(origenPerro);
            //Console.WriteLine("El nombre del perro es: " + perro1.getNombre());
            //Console.WriteLine("El color del perro es: " + perro1.Color);
            //Console.WriteLine("El origen del perro es: " + perro1.getOrigen());


            //armar clase articulo: codigo, precio
            //articulo articulo1 = new articulo(); //se crea un objeto de la clase articulo
            //console.writeline("ingrese codigo del articulo: ");
            //int codigo = int.parse(console.readline());
            //articulo1.setcodigo(codigo);
            //console.writeline("ingrese precio del articulo: ");
            //float precio = float.parse(console.readline());
            //articulo1.setprecio(precio);
            //console.writeline("el codigo del articulo es: " + articulo1.getcodigo());
            //console.writeline("el precio del articulo es: " + articulo1.getprecio());



            //venta: esta clase representa una venta realizada, que incluye el codigo del articulo vendido, la cantidad vendida y el codigo del cliente que realizó la compra.
            //venta v1 = new venta();
            //console.writeline("ingrese codigo del articulo: ");
            //int codigoarticulo = int.parse(console.readline());
            //v1.setcodigoarticulo(codigoarticulo);
            //console.writeline("ingrese cantidad: ");
            //int cantidad = int.parse(console.readline());
            //v1.setcantidad(cantidad);
            //console.writeline("ingrese codigo del cliente: ");
            //int codigocliente = int.parse(console.readline());
            //v1.setcodigocliente(codigocliente);
            //console.writeline("el codigo del articulo es: " + v1.getcodigoarticulo());
            //console.writeline("la cantidad es: " + v1.getcantidad());
            //console.writeline("el codigo del cliente es: " + v1.getcodigocliente());

            Console.ReadKey();

        }
    }
}


//Existe una clase que se llama clase object que es la clase base de donde nace absolutamente todo.
//Cualquier clase que yo cree ser hija de la clase object. Por clase hija va a heredar ciertas
//caracteristicas de la clase object.
//Asi como se hereda ciertas caracteristicas/funcionalidades tambien se hereda un constructor estandar que me permite
//crear un objeto de tipo botella (por ejemplo). Por ej: puedo crear la vairable Botella b2; pero esta sera vacia
//Recien cuando hago new Botella(), ahi se invoca al constructor y se genera la instancia. Es decir se genera
//en memoria el objeto botella. 
