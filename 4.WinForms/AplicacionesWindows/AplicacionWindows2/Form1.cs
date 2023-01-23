using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows2
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" || txtNombre.Text == "" || txtEdad.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Falta completar algún casillero","Atención");
                _ = txtApellido.Text == "" ? txtApellido.BackColor = Color.Red : txtApellido.BackColor = System.Drawing.SystemColors.Window;
                _ = txtNombre.Text == "" ? txtNombre.BackColor = Color.Red : txtNombre.BackColor = System.Drawing.SystemColors.Window;
                _ = txtEdad.Text == "" ? txtEdad.BackColor = Color.Red : txtEdad.BackColor = System.Drawing.SystemColors.Window;
                _ = txtDireccion.Text == "" ? txtDireccion.BackColor = Color.Red : txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                txtApellido.BackColor = System.Drawing.SystemColors.Window;
                txtNombre.BackColor = System.Drawing.SystemColors.Window;
                txtEdad.BackColor = System.Drawing.SystemColors.Window;
                txtDireccion.BackColor = System.Drawing.SystemColors.Window;

                txtmResultado.Text = "Apellido y Nombre: " + txtApellido.Text + ", " + txtNombre.Text
                    + Environment.NewLine + "Edad: " + txtEdad.Text 
                    + Environment.NewLine + "Dirección: " + txtDireccion.Text;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}