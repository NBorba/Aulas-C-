using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora100317
{
    public partial class formCalc : Form
    {
        private int plusCount;
        private int minusCount;
        private int divideCount;
        private int multiplyCount;
        private int arrayCount = 0;
        private int arrayPositionCount = 1;
        private int tamanhoTextoAnterior = 0;
        List<int> numbers = new List<int>();

        public formCalc()
        {
            InitializeComponent();

            int plusCount = 0;
            int minusCount = 0;
            int divideCount = 0;
            int multiplyCount = 0;
        }

        private void btnNumberClick(object sender, EventArgs e)
        {
            var btnClickedNumber = sender as Button;
            txtOutput.Text += btnClickedNumber.Text;
        }

        private void btnClearOutput(object sender, EventArgs e)
        {
            txtOutput.Clear();
            clrOperationCount();
        }

        private void btnOperationClick(object sender, EventArgs e)
        {
            // Array number count is increased everytime an operation button is clicked
            

            var btnClickedOperation = sender as Button;

            // Verifies if formula starts with an operation, if it does, formula is invalid
            bool canAddOperation = verifyText();

            int textLength = 0;
            int resultado = 0;
            string numero = "";
            string operation = btnClickedOperation.Text;

            if (!canAddOperation)
            {
                MessageBox.Show("Erro de formula.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textLength = txtOutput.TextLength;
                
                if (arrayPositionCount == 1)
                {
                    numero = txtOutput.Text.Substring(0, textLength);
                }
                else
                {
                    numero = txtOutput.Text.Substring(tamanhoTextoAnterior+1, textLength-tamanhoTextoAnterior-1);
                }
                
                numbers.Add(Convert.ToInt32(numero));

                tamanhoTextoAnterior += numero.Length;

                if (arrayCount >= 1)
                {
                    resultado = calculatesValues(operation, numbers[arrayCount - 1], numbers[arrayCount]);
                    numbers[0] = numbers[arrayCount - 1];
                    numbers[1] = 0;
                    clrOperationCount();
                    tamanhoTextoAnterior = resultado.ToString().Length;
                    txtOutput.Text += resultado;
                }

                
                
            }
        if(resultado == 0)
        {
            txtOutput.Text += operation;
            arrayCount++;
            arrayPositionCount++;
        }
        }

        private bool verifyText()
        {
            if (txtOutput.TextLength == 0)
            {
                return false;
            }

            if (txtOutput.Text.EndsWith("+") || txtOutput.Text.EndsWith("-") || txtOutput.Text.EndsWith("/") || txtOutput.Text.EndsWith("*"))
            {
                return false;
            }

            return true;
        }

        private void clrOperationCount()
        {
            plusCount = 0;
            minusCount = 0;
            divideCount = 0;
            multiplyCount = 0;
            arrayCount = 0;
            arrayPositionCount = 1;
        }

        private int calculatesValues(string operation,int numberOne, int numberTwo)
        {
            int resultado = 0;
            if (operation == "+")
            {
                txtOutput.Clear();
                resultado = numberOne + numberTwo;
            }

            if (operation == "-")
            {
                txtOutput.Text += operation;
                resultado = numberOne - numberTwo;
            }

            if (operation == "*")
            {
                txtOutput.Text += operation;
                if (arrayCount > 1)
                {
                    resultado = numberOne * numberTwo;
                }
            }

            if (operation == "/")
            {
                txtOutput.Text += operation;
                if (arrayCount > 1)
                {
                    resultado = numberOne / numberTwo;
                }
            }
            return resultado;
        }
    }
}
