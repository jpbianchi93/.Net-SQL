using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDateTimeInterfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            //DateTimePicker 
            //MessageBox.Show("La fecha seleccionada es: " + dtpFecha.Value.ToShortDateString());
            
            DateTime fecha1;
            fecha1 = dtpFecha.Value;
            MessageBox.Show("La fecha seleccionada es: " + fecha1.ToShortDateString());
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es desde: " + calFecha.SelectionStart.ToShortDateString()
                            + ", hasta: " + calFecha.SelectionEnd.ToShortDateString());

        }
    }
}
