using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarconyEnamorado
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Ejercicio1button_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio= new Ejercicio1();
            ejercicio.ShowDialog();
        }

        private void Ejercicio2button_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio2= new Ejercicio2();
            ejercicio2.ShowDialog();
        }

        private void Ejercicio3button_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.ShowDialog();
        }
    }
}
