using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_de_Dominio
{
    internal class Cliente : Deposito
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public Producto Producto { get; set; }
    }
}
