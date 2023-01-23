using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //funciones
            string alho = saludar("Juan")
            Console.WriteLine(alho);
            Console.ReadKey();

            int b = 10;
            sumar(3,ref b);

        }

        static int sumar(int a, ref int b)
        {
            return a + b;
        }
        static string saludar( string nombre)
        {
            return "Hola " + nombre;
        }
    }
}
