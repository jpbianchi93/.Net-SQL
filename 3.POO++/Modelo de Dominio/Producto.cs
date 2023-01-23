using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Producto
    {
        public string Tipo { get; set; }
        public float Peso { get; set; }
        public float Alto { get; set; }
        public float Ancho { get; set; }
        public bool Fragil { get; set; }
    }
}
