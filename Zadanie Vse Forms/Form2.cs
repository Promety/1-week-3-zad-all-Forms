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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            
        }
       static int F(int x)
        {
            if (x / 10000 == 0)
                return ((x % 1000) % 100) % 10;
            else if (x / 1000 == 0)
                return (x % 100) % 10;
            else if (x / 100 == 0)
                return x % 10;
            else
                return x;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            int z;

            int a = int.Parse(numericUpDown1.Text);

            int b = int.Parse(numericUpDown2.Text);
            z = F(a) + F(b);
                textBox1.Text = z.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
