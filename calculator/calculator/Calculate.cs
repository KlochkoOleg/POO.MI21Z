using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }
        double a = 0, b = 0, c = 0, d = 0, s = 0;
        char znak = '+';
        string p;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = s.ToString();
            textBox1.Clear();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            b= Convert.ToDouble(textBox1.Text);
            p += textBox1.Text;
            switch (znak)
            {
                case '+':c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '×':
                    c = a * b;
                    break;
                case '÷':
                    c = a / b;
                    break;
                

            }
            p += "=";
            textBox1.Text = c.ToString();
            p += textBox1.Text+"/";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            p += textBox1.Text;
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            p += znak;
            textBox1.Clear();
            
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            s = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            a = 1/a;
            textBox1.Text = a.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            a = a * a;
            textBox1.Text = a.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            d = ((a * b) / 100) + a;
            textBox1.Text = d.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            s = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            s += a;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            s -= a;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(p);
            //textBox1.Text = p;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s= Convert.ToDouble(textBox1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            d = -a;
            textBox1.Text = d.ToString();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            a = Math.Sqrt(a);
            textBox1.Text = a.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += (sender as Button).Text;

        }
    }
}
