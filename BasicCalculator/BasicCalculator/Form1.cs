using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class back : Form
    {
        public back()
        {
            InitializeComponent();
        }
        double ans;
        string ansStr = "";
        string numStr = "";
        double num1, num2;
        string operation = "";
        private void zero_Click(object sender, EventArgs e)
        {
            add_char("0");
        }

        private void one_Click(object sender, EventArgs e)
        {
            add_char("1");
        }

        private void four_Click(object sender, EventArgs e)
        {
            add_char("4");

        }

        private void seven_Click(object sender, EventArgs e)
        {
            add_char("7");

        }

        private void two_Click(object sender, EventArgs e)
        {
            add_char("2");

        }

        private void five_Click(object sender, EventArgs e)
        {
            add_char("5");

        }

        private void eight_Click(object sender, EventArgs e)
        {
            add_char("8");

        }

        private void three_Click(object sender, EventArgs e)
        {
            add_char("3");
        }

        private void six_Click(object sender, EventArgs e)
        {
            add_char("6");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            add_char("9");

        }

        private void dot_Click(object sender, EventArgs e)
        {
            add_char(".");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            check_error("+");

        }

        private void minus_Click(object sender, EventArgs e)
        {
            check_error("-");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            check_error("x");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            check_error("/");
        }

        private void equals_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(numStr);
            operation_result_to_string();
            label1.Text = ansStr;
            numStr = ansStr;
            operation = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clean_Click(object sender, EventArgs e)
        {
            numStr = "";
            operation = "";
            label1.Text = "";
        }

        public void check_error(string _operation)
        {
            if (numStr == "" && operation == "")
            {
                label1.Text = "Enter a number!";
            }

            else if (operation != "")
                operation = _operation;

            else
            {
                num1 = Convert.ToDouble(numStr);

                label1.Text = numStr;

                numStr = "";

                operation = _operation;
            }


        }

        public void add_char(string new_char)
        {
            numStr += new_char;
            label1.Text = numStr;
        }

        public void operation_result_to_string()
        {
            if (operation == "/" && num2 == 0)
                ansStr = "You cannot divide by 0!";
            else
            {
                if (operation == "/")
                    ans = num1 / num2;
                else if (operation == "+")
                    ans = num1 + num2;

                else if (operation == "-")
                    ans = num1 - num2;

                else if (operation == "x")
                    ans = num1 * num2;

                ans = Math.Round(ans, 3);

                ansStr = Convert.ToString(ans);

            }


        }
    }
}

