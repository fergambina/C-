using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primer lote con 10 registros de productos, cada producto tiene:
            //Codigo de Articulo (3 digitos no correlativos)
            //Precio
            //Codigo de Marca (1 a 10)

            //Segundo lote con las ventas de la semana. Cada venta tiene:
            //Codigo Articulo
            //Cantidad
            //Codigo Cliente (1 a 100)
            //Este lote corta con codigo Cliente cero

            Articulo[] articulos = new Articulo[10]; //Se declara el vector de articulos
            for(int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo();
                Console.WriteLine("Ingrese datos del articulo " + (x + 1) + ":");
                Console.WriteLine("Codigo de Articulo (3 digitos no correlativos): ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.Write("Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.Write("Codigo de Marca (1 a 10): ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }

            //cargado el vector completo con los 10 articulos

            Venta venta = new Venta();
            Console.WriteLine("Ingrese datos de la venta...");
            Console.Write("Ingrese codigo de cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());
            while(venta.CodigoCliente != 0)
            {
                Console.Write("Codigo articulo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.Write("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //trabajamos

                Console.WriteLine("Ingrese datos de la venta...");
                Console.Write("Ingrese codigo de cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }


        }
    }
}
