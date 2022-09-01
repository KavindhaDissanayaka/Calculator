using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operationPerform = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")|| (isOperationPerformed))
                textBox1.Clear();
            isOperationPerformed = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;
            
          
            
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                button13.PerformClick();
                operationPerform = button.Text;
                isOperationPerformed = true;
                label1.Text = result + " " + operationPerform;
            }
            else
            {
                operationPerform = button.Text;
                result = double.Parse(textBox1.Text);
                isOperationPerformed = true;
                label1.Text = result + " " + operationPerform;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch(operationPerform)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;


            }
            result = Double.Parse(textBox1.Text);
            label1.Text = "";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
