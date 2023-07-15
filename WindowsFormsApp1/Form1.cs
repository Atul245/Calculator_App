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
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        string OperatorClicked = "";
        bool isOperatorClicked = false;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Click_button(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || (isOperatorClicked))
                resultBox.Clear();

            isOperatorClicked = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!resultBox.Text.Contains("."))
                    resultBox.Text = resultBox.Text + button.Text;
            }
            else
            {
                resultBox.Text = resultBox.Text + button.Text;
            }
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                btnequal.PerformClick();
                OperatorClicked = button.Text;
                isOperatorClicked = true;
            }
            else
            {
                OperatorClicked = button.Text;
                resultValue = Double.Parse(resultBox.Text);
                isOperatorClicked = true;
            }

            OperatorClicked = button.Text;
            resultValue = Double.Parse(resultBox.Text); 
        }

        private void Clear_btn(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            resultValue = 0;
        }

        private void Click_equalButton(object sender, EventArgs e)
        {
            switch (OperatorClicked)
            {
                case "+":
                    resultBox.Text = (resultValue + Double.Parse(resultBox.Text)).ToString();
                    break;
                case "-":
                    resultBox.Text = (resultValue - Double.Parse(resultBox.Text)).ToString();
                    break;
                case "*":
                    resultBox.Text = (resultValue * Double.Parse(resultBox.Text)).ToString();
                    break;
                case "%":
                    resultBox.Text = (resultValue / Double.Parse(resultBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
