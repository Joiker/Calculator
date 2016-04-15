using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{


    public partial class CalculatorForm : Form
    {
        float x1, x2;
        bool symbol = true;
        int switch_case;


        public CalculatorForm()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ",";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            label3.Text = "   ";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            x1 = float.Parse(textBox.Text);
            textBox.Clear();
            switch_case = 1;
            label3.Text = x1.ToString() + "+";
            symbol = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            x1 = float.Parse(textBox.Text);
            textBox.Clear();
            switch_case = 2;
            label3.Text = x1.ToString() + "-";
            symbol = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x1 = float.Parse(textBox.Text);
            textBox.Clear();
            switch_case = 3;
            label3.Text = x1.ToString() + "*";
            symbol = true;
        }


        private void button13_Click(object sender, EventArgs e)
        {
            x1 = float.Parse(textBox.Text);
            textBox.Clear();
            switch_case = 4;
            label3.Text = x1.ToString() + "/";
            symbol = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculate();
            label3.Text = "   ";
        }

        private void buttonSymbol_Click(object sender, EventArgs e)
        {
            if (symbol == true)
            {
                textBox.Text = "-" + textBox.Text;
                symbol = false;
            }

            else if (symbol == false)
            {
                textBox.Text = textBox.Text.Replace("-", " ");
                symbol = true;
            }
        }
             
        

        private void calculate()
        {
            switch (switch_case)
            {

                case 1:
                    x2 = x1 + float.Parse(textBox.Text);
                    textBox.Text = x2.ToString();
                    break;

                case 2:
                    x2 = x1 - float.Parse(textBox.Text);
                    textBox.Text = x2.ToString();
                    break;

                case 3:
                    x2 = x1 * float.Parse(textBox.Text);
                    textBox.Text = x2.ToString();
                    break;

                case 4:
                    x2 = x1 / float.Parse(textBox.Text);
                    textBox.Text = x2.ToString();
                    break;

                
            }

        }
    }
}
