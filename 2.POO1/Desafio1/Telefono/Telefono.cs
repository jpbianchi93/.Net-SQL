using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefono
{
    internal class Telefono
    {
        //Telefono: Modelo, Marca, NumeroDeTelefono, CodigoOperador.
        //Atributos
        //private string marca;
        private string modelo;
        //private string numeroDeTelefono;
        private int codigoOperador;
        
        //Propiedades
        public string Marca { get; }
        public string Modelo { get { return modelo; } }
        public string NumeroDeTelefono { get; set; }
        //{
        //    get { return numeroDeTelefono; } 
        //    set { numeroDeTelefono = value; } 
        //}
        public int CodigoOperador
        {
            get { return codigoOperador;}
            set
            {
                if (value == 1 || value == 2 || value == 3)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }
    
        //Constructor
        public Telefono(string marca, string modelo)
        {
            this.Marca = marca;
            this.modelo = modelo;
        }   

        //Método
        public string Llamar()
        {
            return "Realizando llamada..." ;
        }

        //Sobrecarga de método
        public string Llamar(string contacto)
        {
            return "Realizando llamada a: " + contacto;
        }
    }
}
