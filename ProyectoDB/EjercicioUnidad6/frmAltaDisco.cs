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

namespace EjercicioUnidad6
{
    public partial class frmAltaDisco : Form
    {
        public frmAltaDisco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Discos discoNuevo = new Discos();
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                discoNuevo.Titulo = txtTitulo.Text;
                discoNuevo.FechaLanzamiento = DateTime.Parse(dtpFechaLanzamiento.Value.ToString());
                discoNuevo.CantidadCanciones = int.Parse(txtCantidadCanciones.Text);
                discoNuevo.Estilo = (Estilo)cboEstilo.SelectedItem;
                discoNuevo.Tipo = (TipoEdicion)cboTipoEdicion.SelectedItem;

                negocio.Agregar(discoNuevo);
                MessageBox.Show("Disco agregado a la lista");
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
                cboTipoEdicion.DataSource = tipo.listar();
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
    }
}
