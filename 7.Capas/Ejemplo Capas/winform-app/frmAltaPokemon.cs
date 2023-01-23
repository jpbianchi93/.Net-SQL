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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

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
                pokeNuevo.Tipo = (Elemento)cboTipo.SelectedItem;
                pokeNuevo.Debilidad = (Elemento)cboDebilidad.SelectedItem;

                //Mandar pokemon a la base de datos
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
            //cargar comboBox
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
    }
}
