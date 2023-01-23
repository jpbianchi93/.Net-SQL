using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo > Auto > AutoDeportivo > AutoUrbano
            //>Camioneta
            //>Moto
            //Vehiculo v1 = new Vehiculo();
            //Camioneta c1 = new Camioneta();
            //Camioneta c2 = new Camioneta();
            //Camioneta c3 = new Camioneta();

            //v1.Motor = "Fire 1.4";
            //c1.CargaMaxima = 1000;

            //c1.Color = "Amarillo";
            //c2.Color = "Roja";
            //c3.Color = "Blanca";
            
            //Vehiculo v2 = new Camioneta();

            ////Colección
            //List<Camioneta> listaCamionetas = new List<Camioneta>();
            //listaCamionetas.Add(c1);
            //listaCamionetas.Add(c2);
            //listaCamionetas.Add(c3);

            //Console.WriteLine("La cantidad de camionetas en la lista es: " + listaCamionetas.Count);
            //listaCamionetas[1].Color = "Negra";
            //Console.WriteLine("El color de la segunda camioneta es: " + listaCamionetas[1].Color);
            //listaCamionetas.Remove(c3);
            //Console.WriteLine("La cantidad de camionetas en la lista es: " + listaCamionetas.Count);

            //foreach (Camioneta item in listaCamionetas)
            //{
            //    Console.WriteLine("Color: " + item.Color);
            //}

            Auto a1 = new Auto();
            a1.Motor = new Motor();

            Console.ReadKey();
        }
    }
}
