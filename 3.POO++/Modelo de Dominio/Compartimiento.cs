using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Compartimiento
    {
        public int ID { get; set; }
        public float Alto { get; set; }
        public float Ancho { get; set; }
        public Producto Producto { get; set; }
    }
}
