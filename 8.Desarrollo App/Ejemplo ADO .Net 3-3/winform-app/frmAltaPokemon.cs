using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
//LevantarYGuardarImagenLocal.1.1 - <appSettings> en App.config
using System.Configuration;

namespace winform_app
{
    public partial class frmAltaPokemon : Form
    {
        //1.Modificar.2.1 - Aributo privado Pokemon = Null
        private Pokemon pokemon = null;
        //7.LevantarYGuardarImagenLocal.2
        private OpenFileDialog archivo = null;

        public frmAltaPokemon()
        {
            InitializeComponent();
        }
        //1.Modificar.2 - Agrega parametro pokemon para modificarlo
        public frmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            //Pasaje de parámetro entre ventanas
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                //Modificar.6 - agrega un pokemon nuevo si la propiedad es null
                if (pokemon == null)
                    pokemon = new Pokemon();

                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.UrlImagen = txtUrlImagen.Text;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;

                //Modificar.6.1 - agregas no tiene id, si modificas tiene id !=0
                if(pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");
                }

                //7.LevantarYGuardarImagenLocal.3 - Guardo imagen si la levantó localmente:
                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                //1.Modificar.4.1 - Indicar el valor preseleccionado del comboBox
                cboTipo.DataSource = elementoNegocio.listar();
                //Valor clave, interno... propiedades de elementos
                cboTipo.ValueMember = "Id";
                //valor que se muestra
                cboTipo.DisplayMember = "Descripcion";
                cboDebilidad.DataSource = elementoNegocio.listar();
                cboDebilidad.ValueMember = "Id";
                cboDebilidad.DisplayMember = "Descripcion";

                //1.Modificar.4 - Precargar los datos del pokemon para modificar
                if (pokemon != null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtUrlImagen.Text = pokemon.UrlImagen;
                    //precargar imagen
                    cargarImagen(pokemon.UrlImagen);
                    //valor preseleccionado a los desplegables
                    cboTipo.SelectedValue = pokemon.Tipo.Id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxPokemon.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        //7.LevantarYGuardarImagenLocal.1
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            //crear objeto
            archivo = new OpenFileDialog();
            //filtro, tipo de archivo en la entrada de dialogo
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            //cuadro de dialogo
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                //nombre del archivo
                txtUrlImagen.Text = archivo.FileName;
                //cargar imagen
                cargarImagen(archivo.FileName);

                //7.LevantarYGuardarImagenLocal.1.2.Guardo la imagen - Using System.Configuration
                //          archivo de origen,                       destino                    + nombre archivo
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }

        }
    }
}
