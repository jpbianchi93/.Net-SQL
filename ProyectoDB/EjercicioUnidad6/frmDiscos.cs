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
using EjercicioUnidad6;
using negocio;

namespace winform_app
{
    public partial class frmDiscos : Form
    {
        private List<Discos> listaDiscos;
        public frmDiscos()
        {
            InitializeComponent();
        }

        private void frmDiscos_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Título");
            cboCampo.Items.Add("Cantidad de canciones");
            cboCampo.Items.Add("Estilo");
            cboCampo.Items.Add("Tipo de edición");

        }

        private void cargar()
        {
            DiscosNegocio acceso = new DiscosNegocio();
            try
            {
                listaDiscos = acceso.listar();
                dgvDiscos.DataSource = listaDiscos;
                ocultarColumnas();
                cargarImagen(listaDiscos[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas() 
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDiscos.Load(imagen);

            }
            catch (Exception)
            {
                //Carga imagen por defecto
                pbxDiscos.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void txtCantCanciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            //Para que no se rompa por valor null
            if (dgvDiscos.CurrentRow != null)
            {
                Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagenTapa);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco alta = new frmAltaDisco();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Discos seleccionado;
            seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            frmAltaDisco modificar = new frmAltaDisco(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            Discos seleccionado;
            DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                negocio.Eliminar(seleccionado.Id);

            }
            cargar();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            //Filtro avanzado
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvDiscos.DataSource = negocio.Filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Filtro rápido
            //List<Discos> listaFiltrada;
            //string filtro = txtFiltroRapido.Text;

            //if (filtro != "")
            //{
            //    //                 ciclo -> FindAll == ForEach
            //    listaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || 
            //                                        x.CantidadCanciones.ToString() == filtro ||
            //                                        x.FechaLanzamiento.ToString().Contains(filtro) ||
            //                                        x.Estilo.Descripcion.ToUpper().Contains(filtro.ToUpper()) ||
            //                                        x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            //}
            //else
            //{
            //    //resetar lista original
            //    listaFiltrada = listaDiscos;
            //}

            //dgvDiscos.DataSource = null;
            //dgvDiscos.DataSource = listaFiltrada;
            //ocultarColumnas();
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Cantidad de canciones")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }
                if (!(soloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Solo números para filtrar por un campo numérico...");
                    return true;
                }

            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Discos> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro.Length >= 3)
            {
                //                 ciclo -> FindAll == ForEach
                listaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) ||
                                                    x.CantidadCanciones.ToString() == filtro ||
                                                    x.FechaLanzamiento.ToString().Contains(filtro) ||
                                                    x.Estilo.Descripcion.ToUpper().Contains(filtro.ToUpper()) ||
                                                    x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                //resetar lista original
                listaFiltrada = listaDiscos;
            }
            
            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Cantidad de canciones")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

    }

}
