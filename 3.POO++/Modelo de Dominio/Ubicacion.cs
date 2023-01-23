using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Ubicacion : Deposito
    {
        public int ID { get; set; }
        public int Pasillo { get; set; }
        public char Lado { get; set; }
        public Compartimiento Compartimiento { get; set; }
    }
}
