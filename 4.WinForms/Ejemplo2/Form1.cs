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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar elemento a lv.Elementos:
            //string elem = txtElemento.Text;
            //lvElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Agregar colores al ComboBox
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Naranja");
            cboColorFavorito.Items.Add("Amarillo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Azul");
            cboColorFavorito.Items.Add("Violeta");
            cboColorFavorito.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            //Recopilación de datos
            string nombre = txtNombre.Text;
            
            DateTime fecha = dtpFechaNac.Value;
           
                //Operador Ternario:
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el Chocolate";
           
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";
           
            string colorFavorito = cboColorFavorito.SelectedItem.ToString();

            string numeroFavorito = nupNumeroFavorito.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + ", su color favorito es " + colorFavorito + 
                ", su número es: " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + " Fecha: " + fecha + ", " + mensaje);
        }
    }
}
