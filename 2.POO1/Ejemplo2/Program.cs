using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Primer lote con 10 registros de productos, cada producto tiene:
                - Código Artículo (3 dígitos no correlativos)
                - Precio
                - Código de Marca (1 a 10)
            Segundo lote con las ventas de la semana. Cada venta tiene:
                - Código de Artículo
                - Cantidad
                - Código de Cliente (1 a 100)
            Este lote corta con el Código de Cliente cero.
            */

            Artículo[] articulos = new Artículo[10];
            articulos[6].CodigoMarca = 3;

            for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Artículo();
                Console.WriteLine("Ingrese los datos del producto..");
                Console.WriteLine("Código:");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 a 10):");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());

                // Cargado el vector completo con los 10 artículos
                Venta venta = new Venta();
                Console.WriteLine("Ingrese la venta:");
                Console.WriteLine("Código de Cliente:");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
                while (venta.CodigoCliente != 0)
                {
                    Console.WriteLine("Código Articulo:");
                    venta.CodigoArticulo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Cantidad:");
                    venta.Cantidad = int.Parse(Console.ReadLine());

                    //trabajamos...

                    //pido cliente nuevamente:
                    Console.WriteLine("Ingrese la venta:");
                    Console.WriteLine("Código de Cliente:");
                    venta.CodigoCliente = int.Parse(Console.ReadLine());
                }

            }
        }
    }
}
