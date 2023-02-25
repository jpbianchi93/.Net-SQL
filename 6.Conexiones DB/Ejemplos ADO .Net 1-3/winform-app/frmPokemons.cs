using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmPokemons : Form
    {
        //2.ImagenDesdeDB.3.Crear atributo privado de la lista
        private List<Pokemon> listaPokemons;
        public frmPokemons()
        {
            InitializeComponent();
        }

        //1.LescturaDB.3. Generar elemento load del formulario, carga de elemento
        private void frmPokemons_Load(object sender, EventArgs e)
        {
            //1.LescturaDB.3.a.Invocar lectura de lista
            PokemonNegocio negocio = new PokemonNegocio();
            //2.ImagenDesdeDB.3.a.Cargar Grilla desde función
            listaPokemons = negocio.listar();
            dgvPokemons.DataSource = listaPokemons;
            //2.ImagenDesdeDB.3.b.Ocultar columna URLImagen
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            //2.ImagenDesdeDB.4.Cargar imagen
            cargarImagen(listaPokemons[0].UrlImagen);
        }

        //2.ImagenDesdeDB.5.Seleccionar imagen a mostrar con elementos de la grilla
        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            //2.ImagenDesdeDB.5.a.Guardar en  objeto Pokemon
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        //2.ImagenDesdeDB.4.a.Cargar imagen con exepción
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);

            }
            catch (Exception)
            {
                //Carga imagen por defecto
                pbxPokemon.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }
    }
}
