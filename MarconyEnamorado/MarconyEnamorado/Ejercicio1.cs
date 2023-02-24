using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarconyEnamorado
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        String[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal Interes = 0;
            Decimal Cantidad = 0;

            Calculo(Interes, Cantidad);
        }


        public void Calculo(Decimal Interes, Decimal Cantidad)
        {

            for (int mes = 0; mes < Meses.Length; mes++)
            {
                MeseslistBox.Items.Add(Meses[mes]);

                Interes = Convert.ToDecimal(200000 * 0.015 * 1);
                Cantidad = Cantidad + Interes;

                MeseslistBox.Items.Add(Cantidad);
                MeseslistBox.Items.Add("");
            }

            label3.Text = Convert.ToString(Cantidad);
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }
    }
}
