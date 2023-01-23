using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class MiPrimeraApp : Form
    {
        public MiPrimeraApp()
        {
            InitializeComponent();
        }

        private void MiPrimeraApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenicos a C#");
        }

        private void MiPrimeraApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau ...");
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparó el evento Click", "Atención");
            //this.BackColor = Color.BlueViolet;
            if (txtCajaTexto.Text == "")
                txtCajaTexto.BackColor = Color.Red;
            else
                txtCajaTexto.BackColor = System.Drawing.SystemColors.Control;
        }

        private void MiPrimeraApp_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Presionó el botón Izquierdo", "Atención");
            }
            else if (click.Button == MouseButtons.Right)
            {
                MessageBox.Show("Presionó el botón Derecho", "Atención");
            }
            else if (click.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Presionó el botón del Medio", "Atención");

            }
        }

        private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e)
        {
            //Cambiar el color de la propiedad BackColor
            lblEtiqueta.BackColor = Color.Cyan;

            //Cambiar el estilo del cursor
            lblEtiqueta.Cursor = Cursors.Hand;
        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            //Restablecer el color de fondo de la etiqueta
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;

            //Restablecer el estilo del cursor
            lblEtiqueta.Cursor = Cursors.Arrow;
        }

        private void txtCajaTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtCajaTextoMultilinea_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtCajaTextoMultilinea.Text.Length + " Caracteres");

        }
    }
}
