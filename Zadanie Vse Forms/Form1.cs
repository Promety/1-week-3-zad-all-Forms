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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newfrm = new Form2();
            newfrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newfrm = new Form3();
            newfrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newfrm = new Form4();
            newfrm.Show();
        }
    }
}
