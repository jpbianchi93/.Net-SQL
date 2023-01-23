using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;

            Console.WriteLine("La fecha es: " + fecha.ToString("ddd/MMM/yy"));

            Console.ReadKey();
        }
    }
}
