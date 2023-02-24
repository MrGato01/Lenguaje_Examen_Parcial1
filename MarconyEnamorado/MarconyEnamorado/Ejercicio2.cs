using System;
using System.Collections;
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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        static double dinero = 0;
        public async void button1_Click(object sender, EventArgs e)
        {
            String[] Productos = new string[10];
            double CantidadProducto = Convert.ToInt64(CantidadtextBox.Text);
            decimal PrecioProducto = Convert.ToDecimal(PreciotextBox.Text);

            ProductoslistBox.Items.Add(ProductotextBox.Text.ToString());
            ProductoslistBox.Items.Add(CantidadtextBox.Text.ToString());
            ProductoslistBox.Items.Add("");

            dinero = dinero + Convert.ToDouble(PrecioProducto * (decimal)CantidadProducto);

            double Total = (double) await CalculoAsync(dinero);

            label7.Text = Convert.ToString(Total);
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            ProductotextBox.Text = "";
            CantidadtextBox.Text = "";
            PreciotextBox.Text = "";
        }

        private async Task<decimal> CalculoAsync(double dinero)
        {
            double Total = await Task.Run(() =>
            {
                return dinero - (dinero * 0.15);
            });

            return (decimal) Total;
        }

        private void VaciarListabutton_Click(object sender, EventArgs e)
        {
            ProductoslistBox.Items.Clear();
            label7.Text = "0.00";
            dinero = 0;
        }
    }

}
