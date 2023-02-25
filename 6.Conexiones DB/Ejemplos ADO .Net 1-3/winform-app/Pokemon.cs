using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_app
{
    //1.LescturaDB.1.GenerarClase
    class Pokemon
    {
        //1.LescturaDB.1.a.Clase que define el objeto a utilizar
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //2.ImagenDesdeDB.1.Dar la propiedad
        public string UrlImagen { get; set; }
        //3.DatosRelacionadosDB.1.Agrerar objetos de Tipo elemento
        public Elemento Tipo { get; set; }
        public Elemento Debilidad { get; set; }


    }
}
