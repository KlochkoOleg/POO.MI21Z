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
    public partial class Form1 : Form
    {
        Calc C;
        public Form1()
        {
            InitializeComponent();

            C = new Calc();

        }

        double znak;
        string s;
        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";
            C.Memory_Clear();
            C.Clear_A();
            s = "";
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text[0] == '-')
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            else
                labelNumber.Text = "-" + labelNumber.Text;
        }


        private void button0_Click(object sender, EventArgs e)
        {
            verif();
            labelNumber.Text += "0";
            s += (sender as Button).Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            verif();
            labelNumber.Text += "1";
            s += (sender as Button).Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            verif();
            labelNumber.Text += "2";
            s += (sender as Button).Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            verif();
            labelNumber.Text += "3";
            s += (sender as Button).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            verif();
            labelNumber.Text += "4";
            s += (sender as Button).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            verif();
            labelNumber.Text += "5";
            s += (sender as Button).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            verif();
            labelNumber.Text += "6";
            s += (sender as Button).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            verif();
            labelNumber.Text += "7";
            s += (sender as Button).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            verif();
            labelNumber.Text += "8";
            s += (sender as Button).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            verif();
            labelNumber.Text += "9";
            s += (sender as Button).Text;
        }

        
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            s += "=";
            switch (znak)
            {
                case '×':
                    labelNumber.Text = C.Multiplication(Convert.ToDouble(labelNumber.Text)).ToString();

                   
                    break;
                case '÷':
                    labelNumber.Text = C.Division(Convert.ToDouble(labelNumber.Text)).ToString();
                   
                   
                    break;
                case '+':
                    labelNumber.Text = C.Sum(Convert.ToDouble(labelNumber.Text)).ToString();
                   
                   
                    break;
                case '-':
                   labelNumber.Text = C.Subtraction(Convert.ToDouble(labelNumber.Text)).ToString();
                   
                    
                    break;


            }
            s += labelNumber.Text;
            s += " \n ";
            C.Clear_A();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                znak = (sender as Button).Text[0];
                 s += (sender as Button).Text[0];

            labelNumber.Text = "0";

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
           
                 C.Put_A(Convert.ToDouble(labelNumber.Text));

                 znak = (sender as Button).Text[0];
            s += (sender as Button).Text[0];


            labelNumber.Text = "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                znak = (sender as Button).Text[0];
            s += (sender as Button).Text[0];


            labelNumber.Text = "0";
        }

       
        private void buttonMinus_Click(object sender, EventArgs e)
        {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                znak = (sender as Button).Text[0];
            s += (sender as Button).Text[0];

            labelNumber.Text = "0";
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
            s += "√" + labelNumber.Text;
                labelNumber.Text = C.Sqrt().ToString();
            s += "=" + labelNumber.Text;

            C.Clear_A();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {

                C.Put_A(Convert.ToDouble(labelNumber.Text));
            s +=  labelNumber.Text+"^2 =";
            labelNumber.Text = C.Square().ToString();
            s += labelNumber.Text;
            C.Clear_A();
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            C.M_Sum(Convert.ToDouble(labelNumber.Text));
            labelNumber.Text = "0";
        }
        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            C.M_Subtraction(Convert.ToDouble(labelNumber.Text));
            labelNumber.Text = "0";
        }
        private void buttonMR_Click(object sender, EventArgs e)
        {
                    labelNumber.Text = C.MemoryShow().ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            C.Memory_Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

         void verif()
        {
            if ((labelNumber.Text[0] == '0') && (labelNumber.Text != ""))
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            labelNumber.Text += ".";
            s +=labelNumber.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (labelNumber.Text != "")
                labelNumber.Text = labelNumber.Text.Remove(labelNumber.Text.Length - 1, 1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(s);
        }
    }
}