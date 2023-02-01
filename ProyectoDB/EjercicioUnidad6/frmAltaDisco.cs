using dominio;
using negocio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace EjercicioUnidad6
{
    public partial class frmAltaDisco : Form
    {
        private Discos discos = null;
        private OpenFileDialog archivo = null;
        public frmAltaDisco()
        {
            InitializeComponent();
        }
        public frmAltaDisco(Discos discos)
        {
            InitializeComponent();
            this.discos = discos;
            Text = "Modificar disco";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                if(discos == null)
                    discos = new Discos();

                discos.Titulo = txtTitulo.Text;
                discos.FechaLanzamiento = DateTime.Parse(dtpFechaLanzamiento.Value.ToString());
                discos.CantidadCanciones = int.Parse(txtCantidadCanciones.Text);
                discos.UrlImagenTapa = txtUrlImagenTapa.Text;
                discos.Estilo = (Estilo)cboEstilo.SelectedItem;
                discos.Tipo = (TipoEdicion)cboTipoEdicion.SelectedItem;

                if (discos.Id != 0)
                {
                    negocio.Modificar(discos);
                    MessageBox.Show("Disco modificado a la lista");
                }
                else
                {
                negocio.Agregar(discos);
                MessageBox.Show("Disco agregado a la lista");
                }
                
                if (archivo != null && !(txtUrlImagenTapa.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio estilo = new EstiloNegocio();
            TipoEdicionNegocio tipo = new TipoEdicionNegocio();
            try
            {
                cboEstilo.DataSource = estilo.listar();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";
                cboTipoEdicion.DataSource = tipo.listar();
                cboTipoEdicion.ValueMember = "Id";
                cboTipoEdicion.DisplayMember = "Descripcion";

                if(discos != null)
                {
                    txtTitulo.Text = discos.Titulo;
                    dtpFechaLanzamiento.Text = discos.FechaLanzamiento.ToString();
                    txtCantidadCanciones.Text = discos.CantidadCanciones.ToString();
                    txtUrlImagenTapa.Text = discos.UrlImagenTapa;
                    cargarImagen(discos.UrlImagenTapa);
                    cboEstilo.SelectedValue = discos.Estilo.Id;
                    cboTipoEdicion.SelectedValue = discos.Tipo.Id;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtCantidadCanciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxUrlImagenTapa.Load(imagen);

            }
            catch (Exception)
            {
                //Carga imagen por defecto
                pbxUrlImagenTapa.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void txtUrlImagenTapa_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagenTapa.Text);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            archivo.ShowDialog();
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagenTapa.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
