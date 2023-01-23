using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //static internal class Lider : Persona
    //{
    //    // Tipo Static
    //}
    internal class Lider : Persona
    {
           //Tipo no static pero miembros static
        public int Legajo { get; set; }
        public static string algo()
        {
            return "Hola";
        }

    }
}
