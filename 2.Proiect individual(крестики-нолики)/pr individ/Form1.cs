using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_individ
{
    public partial class Form1 : Form
    {
        Act C;
        public Form1()
        {
            InitializeComponent();
            C = new Act();
        }
        int s = 0, k = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click_1(object sender, EventArgs e)
        {

            if (k % 2 == 0 && (sender as Button).Text == "") { (sender as Button).Text = "X"; k++; (sender as Button).Name = Convert.ToString(s++); }
            if (k % 2 != 0 && (sender as Button).Text == "") { (sender as Button).Text = "O"; k++; (sender as Button).Name = Convert.ToString(s++); }
            verify();
        }
        void verify()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") { if (C.results(button1.Text) == 23) clear(); else this.Close(); }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") { if (C.results(button4.Text) == 23) clear(); else this.Close(); }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "") { if (C.results(button7.Text) == 23) clear(); else this.Close(); }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") { if (C.results(button1.Text) == 23) clear(); else this.Close(); }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") { if (C.results(button2.Text) == 23) clear(); else this.Close(); }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") { if (C.results(button3.Text) == 23) clear(); else this.Close(); }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") { if (C.results(button1.Text) == 23) clear(); else this.Close(); }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "") { if (C.results(button3.Text) == 23) clear(); else this.Close(); }
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "") clear();
        }
        void clear()
        {
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
        }


    }


    }

