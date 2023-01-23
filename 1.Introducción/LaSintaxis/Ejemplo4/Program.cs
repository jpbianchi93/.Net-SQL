using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vectores
            //int, float, char, bool

            int[] numeros = new int[10];
            numeros[0] = 10;
            numeros[5] = 7;

            int j = numeros[5];
            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
}
