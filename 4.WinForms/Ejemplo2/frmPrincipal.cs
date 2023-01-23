using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();

            //Navegar a otra ventana
            //ventana.ShowDialog();

            //Ventana contenedora para abrir una sola vez la ventana
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya hay una ventana abierta.");
                    return;
                }
            } 
            
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            
            //Navegar a otra ventana
            //ventana.ShowDialog();

            // Ventana contenedora
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
