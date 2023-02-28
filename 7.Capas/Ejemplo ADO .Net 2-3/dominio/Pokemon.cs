using System;
using System.Collections.Generic;
//7.DataGridView.2.1.Annotations
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    //Hacer visible la clase para que la vea Winform-app (public)
    public class Pokemon
    {
        //7.DataGridView.2.Annotatons
        [DisplayName("Número")]
        public int Numero { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public Elemento Tipo { get; set; }
        public Elemento Debilidad { get; set; }

    }
}
