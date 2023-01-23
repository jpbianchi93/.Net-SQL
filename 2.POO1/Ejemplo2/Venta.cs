using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Venta
    {
        //- Código Artículo (3 dígitos no correlativos)
        //- Cantindad
        //- Código Cliente (1 a 100)
        public int CodigoArticulo { get; set; }
        public int Cantidad { get; set; }
        public int CodigoCliente { get; set; }
    }
}
