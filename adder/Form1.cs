using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adder
{
    public partial class Form1 : Form
    {
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            //double answer = number1 + number2;


            //label3.Text = $"Answer is {answer}";

        }

        private void operandClick(object sender, EventArgs e)
        {
           Button b = (Button)sender;

            operation = b.Text;

            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double answer;
            //label3.Text = "the operation is" + operation;

            switch (operation)
            {
                case "+":
                    answer = number1 + number2;
                    break;
                case "-":
                    answer = number1 - number2;
                    break;
                case "*":
                    answer = number1 * number2;
                    break;
                case "/":
                    answer = number1 / number2;
                    break;
                default: answer = 0;
                    break;
            }

            label3.Text = $"The answer is {Math.Round(answer, 1)}";

        }
    }
}
