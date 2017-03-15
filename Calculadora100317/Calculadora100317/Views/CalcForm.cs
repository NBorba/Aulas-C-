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
        bool hasResult = false;

        public formCalc()
        {
            InitializeComponent();
        }

        private void btnNumberClick(object sender, EventArgs e)
        {
            var btnClickedNumber = sender as Button;

            if(hasResult == true)
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

        private void btnClearOutput(object sender, EventArgs e)
        {
            clearOutput();
            clearResult();
        }

        private void btnOperationClick(object sender, EventArgs e)
        {
            var btnClickedOperation = sender as Button;

            string formula = txtOutput.Text + btnClickedOperation.Text;

            // Verifies if formula starts with an operation, if it does, formula is invalid
            bool canAddOperation = util.verifyText(formula);

            if(canAddOperation)
            {
                txtOutput.Text = formula;

                string [] operators = formula.Split(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" },StringSplitOptions.RemoveEmptyEntries);
                string [] numbers = formula.Split(new string[] { "+", "-", "*", "/", "="}, StringSplitOptions.RemoveEmptyEntries);

                int numbersCount = numbers.Count();
                int operatorsCount = operators.Count();

                if(numbersCount == 2 && operatorsCount == 2)
                {
                    int numberOne = Convert.ToInt32(numbers[0]);
                    int numberTwo = Convert.ToInt32(numbers[1]);

                    string operatorOne = operators[0];
                    string operatorTwo = operators[1];

                    int result = util.calculateFormula(operatorOne, numberOne, numberTwo);
                    hasResult = true;

                    if (btnClickedOperation.Text == "=")
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
            }
        }

        private void clearOutput()
        {
            txtOutput.Clear();
        }

        private void clearResult()
        {
            hasResult = false;
        }

        private void CalcForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
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
                case Keys.Add:
                    btnPlus.Focus();
                    btnPlus.PerformClick();
                break;
                case Keys.Subtract:
                    btnMinus.Focus();
                    btnMinus.PerformClick();
                break;
                case Keys.Divide:
                    btnDivide.Focus();
                    btnDivide.PerformClick();
                break;
                case Keys.Multiply:
                    btnMultiply.Focus();
                    btnMultiply.PerformClick();
                break;
                case Keys.Enter:
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


          




    

