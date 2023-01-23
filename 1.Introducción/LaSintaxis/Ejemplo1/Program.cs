using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            // int float bool char
            // double decimal long short string datetime
            int a, b, c;
            float d, f;

            Console.WriteLine("Hola, cómo va?");
            Console.WriteLine("Ingrese un número:");
            a = int.Parse(Console.ReadLine()); 
            b = 10;
            c = a + b;

            Console.WriteLine("El resultado es: " + c);
            Console.ReadKey();
        }
    }
}
