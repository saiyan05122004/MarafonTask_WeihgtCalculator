using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _404
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox1.Text);
            float b = Convert.ToInt32(textBox2.Text);
            float c = Convert.ToInt32(a / 100);
            float BIA = a / (c * c);
            ;
            label16.Text = Convert.ToString(BIA);
            if (BIA < 18.5)
            {
                label16.Text = "Недостаточный вес";
                trackBar1.Value = Convert.ToInt32(BIA);
            }
            if (BIA < 18.5 && BIA < 24.9)
            {
                label16.Text = "Нормальный вес";
                trackBar1.Value = Convert.ToInt32(BIA);
            }
            if (BIA < 18.5 && BIA < 29.9)
            {
                label16.Text = "Изюыточный  вес";
                trackBar1.Value = Convert.ToInt32(BIA);
            }
            else { label16.Text = "Ожирение"; trackBar1.Value = 45; }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Спонсор_бегуна form = new Спонсор_бегуна();
            form.Show();
        }
    }
}

