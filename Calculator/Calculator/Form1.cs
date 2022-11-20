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
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operation = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                clearTextbox();
            }


            Button button = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            resultValue = Double.Parse(textBoxResult.Text);
            label1.Text = resultValue + " " + operation;
            isOperationPerformed = true;
        }

        public void clearTextbox()
        {
            textBoxResult.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    label1.Text = "";
                    break;
                case "-":
                    textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    label1.Text = "";
                    break;
                case "*":
                    textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    label1.Text = "";
                    break;
                case "/":
                    textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    label1.Text = "";
                    break;
                default:
                    label1.Text = "Operation has not been chosen";
                    break;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearTextbox();
            resultValue = 0;
            label1.Text = "";
        }
    }

}

