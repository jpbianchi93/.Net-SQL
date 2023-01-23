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
            //condicionales

            int a = 10;
            int b = 12;
            //== != > >= < <=
            //! && ||

            //IF
            if (a == b)
            {
                Console.WriteLine("Son iguales");
            }
            else if (a == 15)
            {
                Console.WriteLine("a es igual a 15");
            }
            else if (a < 10)
            {
                Console.WriteLine("a es menor a 10");
            }
            else
            {
                Console.WriteLine("Ninguna condición cumplida");
            }
            //switch
            switch (a)
            {
                case 1:
                    //instrucciones
                    break;
                case 2:
                    //instrucciones
                    break:
                default:
                    //instrucciones
                    break;
            }
            Console.ReadKey();

        }
    }
}
