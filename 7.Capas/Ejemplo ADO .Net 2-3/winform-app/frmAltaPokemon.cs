using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmAltaPokemon : Form
    {
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        //3.InsertSimple.1.1.CerrarVentana
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //3.InsertSimple.2.Crear pokemon
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //crear pokemon
            Pokemon pokeNuevo = new Pokemon();
            //declarar objeto
            PokemonNegocio negocio = new PokemonNegocio();
            //leer datos ingresados
            try
            {
                pokeNuevo.Numero = int.Parse(txtNumero.Text);
                pokeNuevo.Nombre = txtNombre.Text;
                pokeNuevo.Descripcion = txtDescripcion.Text;
                pokeNuevo.UrlImagen = txtUrlImagen.Text;
                //4.AgregarDesplegables.2.Capturar valor del desplegable
                pokeNuevo.Tipo = (Elemento)cboTipo.SelectedItem;
                pokeNuevo.Debilidad = (Elemento)cboDebilidad.SelectedItem;

                //3.InsertSimple.2.1.Mandar pokemon a la base de datos
                negocio.Agregar(pokeNuevo);
                MessageBox.Show("Pokemon agregado a la lista");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            //4.AgregarDesplegables.1.Cargar comboBox
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cboTipo.DataSource = elementoNegocio.listar();
                cboDebilidad.DataSource = elementoNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            //8.AgregarImagenAlAlta.1.1
            cargarImagen(txtUrlImagen.Text);
        }

        //8.AgregarImagenAlAlta.1.Carga de imagen de alta con leave
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAltaPokemon.Load(txtUrlImagen.Text);
            }
            catch (Exception ex)
            {
                pbxAltaPokemon.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
    }
}
