using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Capturar Excepción
            //int a, b, r;
            int resultado; 
            try
            {
                //a = int.Parse(txtUno.Text);
                //b = int.Parse(txtDos.Text);
                //r = a / b;
                //lblResultado.Text = "= " + r;
                resultado = calcular();
                lblResultado.Text = "= " + resultado;
            }
            catch (Exception ex) // genérico
            {
                MessageBox.Show(ex.ToString()); // te muestra el error
            }
            //catch (FormatException ex)
            //{ 
            //    MessageBox.Show("Por favor, ingrese solo números..."); 
            //}
            //catch (DivideByZeroException ex)
            //{
            //    MessageBox.Show("No se puede dividir por cero...");
            //}
            //Finally
            finally
            {
                //instrucciones...
                //operación sensible...
            }
        }
        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtUno.Text);
                b = int.Parse(txtDos.Text);
                r = a / b;
                return r;
            }
            catch (Exception ex)
            {
                //guardar registro de error en archivo...
                throw ex;
            }
        }
    }
}
