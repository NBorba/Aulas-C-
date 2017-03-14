using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora100317
{
    public partial class formCalc : Form
    {
        Util util = new Util();

        public formCalc()
        {
            InitializeComponent();
        }

        private void btnNumberClick(object sender, EventArgs e)
        {
            var btnClickedNumber = sender as Button;
            txtOutput.Text += btnClickedNumber.Text;
        }

        private void btnClearOutput(object sender, EventArgs e)
        {
            clearOutput();
        }

        private void btnOperationClick(object sender, EventArgs e)
        {
            var btnClickedOperation = sender as Button;
            
            string formula = txtOutput.Text;

            // Verifies if formula starts with an operation, if it does, formula is invalid
            bool canAddOperation = util.verifyText(formula);

            if(canAddOperation)
            { 
                txtOutput.Text += btnClickedOperation.Text;
                formula = txtOutput.Text;

                string[] operators = formula.Split(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" },StringSplitOptions.RemoveEmptyEntries);
                string[] numbers = formula.Split(new string[] { "+", "-", "*", "/", "="}, StringSplitOptions.RemoveEmptyEntries);

                int numbersCount = numbers.Count();
                int operatorsCount = operators.Count();

                if(numbersCount == 2 && operatorsCount == 2)
                {
                    int numberOne = Convert.ToInt32(numbers[0]);
                    int numberTwo = Convert.ToInt32(numbers[1]);

                    string operatorOne = operators[0];
                    string operatorTwo = operators[1];

                    int result = util.calculateFormula(operatorOne, numberOne, numberTwo);

                    if (btnClickedOperation.Text == "=")
                    {
                        clearOutput();
                        txtOutput.Text = result.ToString();
                    }
                    else
                    {
                        clearOutput();
                        txtOutput.Text = result + operatorTwo;
                    }
                }
            }
        }

        private void btnEqualsClick(object sender, EventArgs e)
        {
            //var btnClickedOperation = sender as Button;

            //string text = txtOutput.Text;
            //string operation = btnClickedOperation.Text;

            //int resultado = util.CalculateFormula(text,operation);

            //txtOutput.Text += resultado;

        }

        private void clearOutput()
        {
            txtOutput.Clear();
        }
    
    }
}
          




    

