using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_app
{
    class Pokemon
    {
        //Clase que define el objeto a utilizar
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //Imagen
        public string UrlImagen { get; set; }
        //Tipo elemento
        public Elemento Tipo { get; set; }
        public Elemento Debilidad { get; set; }


    }
}
