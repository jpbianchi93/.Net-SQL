using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("Samsung", "A7");
            t1.NumeroDeTelefono = "3334255";
            t1.CodigoOperador = 4;
            Console.WriteLine("La marca del celular es: " + t1.Marca) ;
            Console.WriteLine("El modelo del celular es: " + t1.Modelo);
            Console.WriteLine("El número del celular es: " + t1.NumeroDeTelefono) ;
            Console.WriteLine("El código seleccionado es: " + t1.CodigoOperador) ;

            Console.WriteLine(t1.Llamar());
            Console.WriteLine(t1.Llamar("Raúl"));

            Console.ReadKey();
        }
    }
}
