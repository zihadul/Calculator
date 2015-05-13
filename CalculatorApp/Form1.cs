using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        double fistNumber, secondNumber;
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            fistNumber = double.Parse(firstNumberTextBox.Text);
            secondNumber = double.Parse(secondNumberTextBox.Text);

            resultTextBox.Text = (fistNumber + secondNumber )+ "";
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            fistNumber = double.Parse(firstNumberTextBox.Text);
            secondNumber = double.Parse(secondNumberTextBox.Text);

            resultTextBox.Text = (fistNumber - secondNumber) + "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            fistNumber = double.Parse(firstNumberTextBox.Text);
            secondNumber = double.Parse(secondNumberTextBox.Text);

            resultTextBox.Text = (fistNumber * secondNumber) + "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            fistNumber = double.Parse(firstNumberTextBox.Text);
            secondNumber = double.Parse(secondNumberTextBox.Text);

            resultTextBox.Text = (fistNumber / secondNumber) + "";
        }

        private void secondNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
