using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_app
{
    internal class Elemento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        //Sobreescribir método ToString()
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
