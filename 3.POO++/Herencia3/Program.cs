using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Gato g1 = new Gato();
            g1.Nombre = "Pepe";

            Perro p1 = new Perro();
            p1.Nombre = "Negrito";

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(g1);
            animales.Add(new Aguila());
            animales.Add(new Gato());

            //Interfaz para segmentar objetos
            List<Flyable> listaDeVoladores = new List<Flyable>();
            listaDeVoladores.Add(new Canario());
            listaDeVoladores.Add(new Aguila());

            //Animal a1 = g1;
            //Gato g8 = (Gato)a1;
            //g8.Nombre = "Blanquito";

            //Console.WriteLine(g1.comunicarse());
            //Console.WriteLine(p1.comunicarse());
            //Console.WriteLine(g1.Nombre);

            //Polimorfismo
            //foreach (Animal item in animales)
            //{
            //    Console.WriteLine(item.comunicarse());
            //}

            Console.ReadKey();
        }
    }
}
