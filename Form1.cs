using System.Data;
using System;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] operands = new char[] { '-', '+', '*', '/', '.'};
        private void buttonZeroClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        private void buttonOneClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        private void buttonTwoClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }
        private void buttonThreeClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void buttonFourClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void buttonFiveClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }
        private void buttonSixClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }
        private void buttonSevenClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }
        private void buttonEightClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }
        private void buttonNineClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }
        private void buttonEqualClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = new DataTable().Compute(textBox1.Text, null).ToString();
            }
            catch (Exception){ }
        }

        private void op(char op) 
        {
            if (operands.Any(x => textBox1.Text.EndsWith(x)))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1) + op;
            }
            else
            {
                textBox1.Text = textBox1.Text + op;
            }
        }
        private void buttonPlusClick(object sender, EventArgs e)
        {
            op('+');    
        }
        private void buttonMinusClick(object sender, EventArgs e)
        {
            op('-');
        }
        private void buttonMultiplyClick(object sender, EventArgs e)
        {
            op('*');
        }
        private void buttonDivideClick(object sender, EventArgs e)
        {
            op('/');
        }
        private void buttonDotClick(object sender, EventArgs e)
        {
            if (!operands.Any(x => textBox1.Text.EndsWith(x)) && !textBox1.Text.EndsWith('.') && textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }
        private void buttonClearClick(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {

        }
    }
}