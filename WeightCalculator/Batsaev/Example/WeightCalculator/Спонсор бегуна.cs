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
    public partial class Спонсор_бегуна : Form
    {
        public Спонсор_бегуна()
        {
            InitializeComponent();
        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            label13.Text = "$" + "textBox6.Text";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int summa = Convert.ToInt32(textBox6.Text);
            summa = summa + 50;
            textBox6.Text = summa.ToString();
            label13.Text = "$" + "textBox6.Text";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int summa = Convert.ToInt32(textBox6.Text);
            if (summa) 
            summa = summa + 50;
            textBox6.Text = summa.ToString();
        }
    }
}
