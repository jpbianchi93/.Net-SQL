using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclos
            //++ -- += -=
            //*= /=
            int a = 10;

            //for y while
            for (int i = 0; i < 10; i++)
            {
                while (a != 0)
                {
                    Console.WriteLine("Hola " + i);
                    a--;
                }
                a= 10;
            }
            Console.ReadKey();

            //do while
            do
            {
                Console.WriteLine("Hola " + i);
                a--;
            } while (a != 0);
        }
    }
}
