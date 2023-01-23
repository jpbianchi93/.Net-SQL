using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Gato : AnimalDomestico
    {
        //Sobreescribir método
        public override string comunicarse()
        {
            return "Miau... miau...";
        }

    }
}
