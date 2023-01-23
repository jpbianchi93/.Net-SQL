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
            string nombre = "Juan";

            nombre = "Hola, como estas?" + nombre;
            
            int cantidadDeCaracteres = nombre.Length;
            nombre = nombre.ToUpper();
            nombre = nombre.ToLower();
            nombre = nombre.Replace('a', 'e');
            Console.WriteLine(nombre);
        }
    }
}
