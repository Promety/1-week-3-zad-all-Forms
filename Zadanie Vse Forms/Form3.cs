using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_Vse_Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double f(double x, double a, double b)
        {
            double y;
           
            

            if (x * x - 5 * x < 0) y = a + b;

            else if (10 > x * x - 5 * x) y = a - b;
            else y = a * b;
            return y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
                double a;
                double b;
                double h;
            a = double.Parse(numericUpDown1.Text);
            b = double.Parse(numericUpDown2.Text);
            h = double.Parse(numericUpDown3.Text);
            if (b < a) MessageBox.Show("Некорректный ввод данных, b не может быть меньше а!");
            else if (h <= 0) MessageBox.Show("Некорректный ввод данных, h не может быть меньше или равно 0");
            else
            {
                for (double i = a; i <= b; i += h)
                {
                    textBox1.Text += ($"f({i}) = {f(i, a, b)}") + Environment.NewLine;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}
