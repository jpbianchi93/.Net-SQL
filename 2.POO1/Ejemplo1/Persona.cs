using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        //Persona: Edad, Sueldo, Nombre
        //ATRIBUTOS o MIEMBROS

        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }



        //Herramienta para ingresar datos de Persona
        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }

        //Métodos
        public string saludar()
        { 
            return "Hola, soy " + nombre; 
        }

        //Sobrecarga de método
        public string saludar(string personaje)
        {
            return "Hola "+ personaje + ", soy " + nombre;
        }
    }
}
