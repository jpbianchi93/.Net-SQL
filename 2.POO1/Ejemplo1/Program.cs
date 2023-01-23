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
            //int edad;
            //float sueldo;
            //string nombre;
            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            //edad = 8;
            //edades[5] = 30;

            //Persona: Edad, Sueldo, Nombre
            //Persona p1 = new Persona("Pepe");
            //p1.setEdad(20);
            //Console.WriteLine(p1.saludar());
            //Console.WriteLine(p1.saludar("Maxi"));
            //Console.WriteLine("La edad de la persona es " + p1.getEdad());

            //Botella: Capacidad, Color, Material
            Botella b1 = new Botella("Rojo", "Plástico");
            //b1.Capacidad = 200;
            //Botella b2 = new Botella();

            Console.WriteLine("Capacidad Botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantidadActual);



            //int capacidadBotella = b1.Capacidad;

            ////Perro: Nombre, Color, Origen
            //Perro[] perros = new Perro[10];
            //Perro perro1 = new Perro();
            //Console.WriteLine("Registro Nacional de los perros");
            //Console.WriteLine("1. Ingresar datos de algún perro.");
            //Console.WriteLine("2. Revisar datos de algún perro.");
            //Console.WriteLine("3. Eliminar datos de algún perro.");
            //Console.WriteLine("4. Salir.");
            //int opcion = int.Parse(Console.ReadLine());
            //if (opcion == 1)
            //{
            //Console.WriteLine("Introduzca los siguientes datos:");
            //Console.WriteLine("Nombre:");
            //perro1.Nombre = Console.ReadLine();
            //Console.WriteLine("Color:");
            //perro1.Color = Console.ReadLine();
            //Console.WriteLine("Origen:");
            //perro1.Origen = Console.ReadLine();
            //}
            //else if (opcion == 2)
            //{
            //    Console.WriteLine("Indique número del perro a revisar: ");
            //    int numPerro = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Revise que los datos son los correctos: ");
            //Console.WriteLine(perro1.Nombre);
            //Console.WriteLine(perro1.Color);
            //Console.WriteLine(perro1.Origen);


            Console.ReadKey();
        }
    }
}
