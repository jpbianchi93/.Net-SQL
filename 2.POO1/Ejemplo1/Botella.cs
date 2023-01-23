using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        //Capacidad máxima: 100
        //Cantidad actual: Inicia en cero
        //método recarga: carga al 100 y devuelve el costo de recarga. 50 cada 100.
        
        //Constructor
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        // Sobrecargar el constructor
        public Botella() { }

        //Destrucción
        ~Botella() 
        { 
         //lógica
        }


        //Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantidadActual
        {
            get { return cantidadActual;}   
        }
        //PROPIEDAD
        //public int Capacidad
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}

        //Método
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                //100 50
                //dif X=?
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }
        //Sobrecarga de método
        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
            //100       50
            //cantidad  X=?
        }
    }
}
