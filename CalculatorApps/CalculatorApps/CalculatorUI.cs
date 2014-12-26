using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApps
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        Number aNumber=new Number();

        private void addButton_Click(object sender, EventArgs e)
        {
   
            resultTextBox.Text =aNumber.Add(Convert.ToInt32(firstNumberTextBox.Text), Convert.ToInt32(secondNumberTextBox.Text)).ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text =aNumber.Subtract(Convert.ToInt32(firstNumberTextBox.Text), Convert.ToInt32(secondNumberTextBox.Text)).ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text =aNumber.Multiply(Convert.ToInt32(firstNumberTextBox.Text), Convert.ToInt32(secondNumberTextBox.Text)).ToString();

        
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text =aNumber.Divide(Convert.ToInt32(firstNumberTextBox.Text), Convert.ToInt32(secondNumberTextBox.Text)).ToString();
        }


        }
    }

