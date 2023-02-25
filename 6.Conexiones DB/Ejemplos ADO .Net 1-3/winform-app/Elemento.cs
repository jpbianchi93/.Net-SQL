using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_app
{
    //3.DatosRelacionadosDB.1.Crear clase elemento
    internal class Elemento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        //3.DatosRelacionadosDB.3.Sobreescribir método ToString()
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
