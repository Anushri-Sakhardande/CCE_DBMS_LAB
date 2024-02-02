using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        double op1,op2;
        double res = 0.0;
        char Operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            input = input + "7";
            this.label1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            input = input + "8";
            this.label1.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            input = input + "9";
            this.label1.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            input = input + "4";
            this.label1.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            input = input + "5";
            this.label1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            input = input + "6";
            this.label1.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            input = input + "1"; 
            this.label1.Text= input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            input = input + "2";
            this.label1.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            input = input + "3";
            this.label1.Text = input;
        }
        
        private void button0_Click(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            input = input + "0";
            this.label1.Text = input;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out op2);
            if (Operator == '+')
            {
                res = op1 + op2;
            }
            if (Operator == '-')
            {
                res = op1 - op2;
            }
            if (Operator == '*')
            {
                res = op1 * op2;
            }
            if (Operator == '/')
            {
                if (op2 != 0)
                    res = op1 + op2;
                else {
                    MessageBox.Show("Can't divide by zero");
                    res = 0;
                }
            }
            if (Operator == '^')
            {
                res = Math.Pow(op1, op2);
            }
            this.label1.Text = res.ToString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out op1);
            Operator = '+';
            input = string.Empty;
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out op1);
            Operator = '-';
            input = string.Empty;
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out op1);
            Operator = '*';
            input = string.Empty;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out op1);
            Operator = '/';
            input = string.Empty;
        }

        private void button_sq_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out op1);
            res = op1*op1;
            this.label1.Text = res.ToString();
        }

        private void button_pow_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out op1);
            Operator = '^';
            input = string.Empty;
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out op1);
            res = Math.Sqrt(op1);
            this.label1.Text = res.ToString();
        }


        private void button_sin_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out op1);
            res = Math.Sin(op1);
            this.label1.Text = res.ToString();
        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out op1);
            res = Math.Cos(op1);
            this.label1.Text = res.ToString();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            op1 = 0;
            op2 = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out op1);
            res = Math.Log(op1);
            this.label1.Text = res.ToString();
        }
    }
}
