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

        // Parameter for verifying if the first number on array is a result from a previous operation
        bool isNumberFromResult = false;

        public formCalc()
        {
            InitializeComponent();
        }

        private void btnNumberClick(object sender, EventArgs e)
        {
           var btnClickedNumber = sender as Button;
           string output = txtOutput.Text;

           // Verifies if formula ends with an operation, if it does, clears isNumberFromResult parameter to start new operation and not clear the formula
           bool endsWithOperation = util.verifyEndsWithOp(output);

           if (endsWithOperation)
            {
                clearResult();
            }

           // If the number on screen is a result from a previus operation, resets output and result and sets output to new number
            if(isNumberFromResult == true)
            {
                clearOutput();
                clearResult();
                txtOutput.Text = btnClickedNumber.Text;
            }
            else
            {
                txtOutput.Text += btnClickedNumber.Text;
            } 
        }

        // Clears output and result
        private void btnClearOutput(object sender, EventArgs e)
        {
            clearOutput();
            clearResult();
        }

        // Triggers when an operation button is clicked
        private void btnOperationClick(object sender, EventArgs e)
        {

            var btnClickedOperation = sender as Button;

            string formula = txtOutput.Text + btnClickedOperation.Text;

            // Verifies if formula starts with an operation, if it does, formula is invalid
            bool canAddOperation = util.verifyText(formula);

            if(canAddOperation)
            {
                // Shows formula on screen
                txtOutput.Text = formula;

                string [] operators = formula.Split(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" },StringSplitOptions.RemoveEmptyEntries);
                string [] numbers = formula.Split(new string[] { "+", "-", "*", "/", "="}, StringSplitOptions.RemoveEmptyEntries);

                int numbersCount = numbers.Count();
                int operatorsCount = operators.Count();

                string operatorOne = "";
                string operatorTwo = "";
                int numberOne = 0;
                int numberTwo = 0;

                // Both positions from the array are not empty, can calculate
                if (numbersCount == 2 && operatorsCount == 2)
                {
                    numberOne = Convert.ToInt32(numbers[0]);
                    numberTwo = Convert.ToInt32(numbers[1]);

                    operatorOne = operators[0];
                    operatorTwo = operators[1];

                    // Clears output, calculates and shows result...
                    operationsAndNumbersForCalc(operatorOne, operatorTwo, numberOne, numberTwo, btnClickedOperation.Text);
                }
                // Condition specifically made to calculate negative first numbers
                // If there are 3 operators on array and the first one is "-", then calculates the first number as negative instead of using
                // minus as an operator.
                else if (operatorsCount > 2 && formula.StartsWith("-"))
                {
                    // Adds minus to number so it becomes negative
                    numberOne = Convert.ToInt32("-" + numbers[0]);
                    numberTwo = Convert.ToInt32(numbers[1]);

                    operatorOne = operators[1];
                    operatorTwo = operators[2];

                    // Clears output, calculates and shows result...
                    operationsAndNumbersForCalc(operatorOne,operatorTwo,numberOne,numberTwo,btnClickedOperation.Text);
                } 
            }
        }

        // Clears output, calculates and shows result...
        private void operationsAndNumbersForCalc(string operatorOne, string operatorTwo, int numberOne, int numberTwo, string btnClickedOperation)
        {
            // Calculates using operation from user
            int result = util.calculateFormula(operatorOne, numberOne, numberTwo);

            // Sets parameter to true, the number that will show on the output is a result from an operation
            isNumberFromResult = true;
            
            // On equals click clears output and shows result
            if (btnClickedOperation == "=")
            {
                clearOutput();
                txtOutput.Text = result.ToString();
            }
            else
            {
                clearOutput();
                clearResult();
                txtOutput.Text = result + operatorTwo;
            }
        }

        private void clearOutput()
        {
            txtOutput.Clear();
        }

        private void clearResult()
        {
            isNumberFromResult = false;
        }

        // Associates key to functions and buttons
        private void CalcForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.D0:
                    btnZero.Focus();
                    btnZero.PerformClick();
                break;
                case Keys.D1:
                    btnOne.Focus();
                    btnOne.PerformClick();
                break;
                case Keys.D2:
                    btnTwo.Focus();
                    btnTwo.PerformClick();
                break;
                case Keys.D3:
                    btnThree.Focus();
                    btnThree.PerformClick();
                break;
                case Keys.D4:
                    btnFour.Focus();
                    btnFour.PerformClick();
                break;
                case Keys.D5:
                    btnFive.Focus();
                    btnFive.PerformClick();
                break;
                case Keys.D6:
                    btnSix.Focus();
                    btnSix.PerformClick();
                break;
                case Keys.D7:
                    btnSeven.Focus();
                    btnSeven.PerformClick();
                break;
                case Keys.D8:
                    btnEight.Focus();
                    btnEight.PerformClick();
                break;
                case Keys.D9:
                    btnNine.Focus();
                    btnNine.PerformClick();
                break;
                case Keys.Oemplus:
                    btnPlus.Focus();
                    btnPlus.PerformClick();
                break;
                case Keys.OemMinus:
                    btnMinus.Focus();
                    btnMinus.PerformClick();
                break;
                case Keys.OemQuestion:
                    btnDivide.Focus();
                    btnDivide.PerformClick();
                break;
                case (Keys.Shift | Keys.D8):
                    btnMultiply.Focus();
                    btnMultiply.PerformClick();
                break;
                case Keys.Return:
                    btnEquals.Focus();
                    btnEquals.PerformClick();
                break;
                case Keys.Back:
                    btnClear.Focus();
                    btnClear.PerformClick();
                break;
            }
        }
    }
}