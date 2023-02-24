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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void MostrarNumerobutton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0)
                {
                    NumerolistBox.Items.Add("Marcony");
                }

                if (i % 5 == 0)
                {
                    NumerolistBox.Items.Add("Enamorado");
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    NumerolistBox.Items.Add("Marcony Enamorado");
                }


               if (i %3 !=0 && i % 5 != 0)
                {
                    NumerolistBox.Items.Add(Convert.ToString(i));
                }

                

            }
        }
    }
}
