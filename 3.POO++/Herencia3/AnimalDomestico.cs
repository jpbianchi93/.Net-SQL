using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        //Sobreescritura de Método
        public override string ToString()
        {
            return "Animal Doméstico: " + Nombre;
        }
    }
}
