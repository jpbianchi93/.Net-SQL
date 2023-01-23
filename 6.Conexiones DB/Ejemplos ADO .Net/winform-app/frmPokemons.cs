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
        //Atributo de la lista
        private List<Pokemon> listaPokemons;
        public frmPokemons()
        {
            InitializeComponent();
        }

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            //Invocar lectura de lista
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemons = negocio.listar();
            dgvPokemons.DataSource = listaPokemons;
            //Ocultar columna URLImagen
            dgvPokemons.Columns["UrlImagen"].Visible = false; 
            //Cargar imagen
            cargarImagen(listaPokemons[0].UrlImagen);
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            //Seleccionar imagen a mostrar con elementos de la grilla
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        //Capturar exepción de imagen
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
