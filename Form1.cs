using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        string operation = "";
        double firstNumber, secondNumber,memory;
        public Form1()
        {
            InitializeComponent();
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    t1.Text = (firstNumber + secondNumber).ToString();
                    memory = (firstNumber + secondNumber);
                    break;
                case "-":
                    t1.Text = (firstNumber - secondNumber).ToString();
                    memory = (firstNumber - secondNumber);
                    break;
                case "*":
                    t1.Text = (firstNumber * secondNumber).ToString();
                    memory = (firstNumber * secondNumber);
                    break;
                case "/":
                    if (secondNumber != 0)
                        t1.Text = (firstNumber / secondNumber).ToString();
                
                    else
                        t1.Text = "Error";
                    memory = (firstNumber / secondNumber);
                    break;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            t1.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            t1.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            t1.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            t1.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            t1.Text += "5";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            t1.Text += "8";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(t1.Text);
            t1.Clear();
            operation = "+";

        }

        private void button24_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(t1.Text);

            switch (operation)
            {
                case "+":
                    t1.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    t1.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    t1.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    if (secondNumber != 0)
                        t1.Text = (firstNumber / secondNumber).ToString();
                    else
                        t1.Text = "Error";
                    break;
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            t1.Text += "0";
        }

        private void sqr_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(t1.Text);
            double sqr = number * number;
            t1.Text = sqr.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            t1.Clear();
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        private void road_Click(object sender, EventArgs e)
        {
            t1.Text = memory.ToString();
            memory = firstNumber;
        }
    }
}
