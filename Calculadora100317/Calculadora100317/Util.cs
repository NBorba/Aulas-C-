using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora100317
{
    class Util
    {
        public int calculateValues(string operation, int numberOne, int numberTwo)
        {
            int resultado = 0;

            if (operation == "+")
            {
                resultado = numberOne + numberTwo;
            }

            if (operation == "-")
            {
                resultado = numberOne - numberTwo;
            }

            if (operation == "*")
            {
                resultado = numberOne * numberTwo;
            }

            if (operation == "/")
            {
                resultado = numberOne / numberTwo;
            }
            return resultado;
        }

        public bool verifyText(string output)
        {
            if (output.Length == 0)
            {
                return false;
            }

            if (output.EndsWith("+") || output.EndsWith("-") || output.EndsWith("/") || output.EndsWith("*"))
            {
                return false;
            }

            return true;
        }

        private int arrayCount = 0;
        private int arrayPositionCount = 1;
        private int tamanhoTextoAnterior = 0;

        public int CalculateFormula(string output, string operationText)
        {

            string[] operations = new string[4] { "+", "-", "/", "*" };
            int[] number = new int[2];
            string operation = "";

            // Verifies if formula starts with an operation, if it does, formula is invalid
            bool canAddOperation = verifyText(output);

            int textLength = output.Length;
            int resultado = 0;
            string numero = "";

            if (!canAddOperation)
            {
                MessageBox.Show("Erro de formula.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (arrayPositionCount == 1)
                {
                    operation = operationText;
                }

                string[] numbers = output.Split(new string[] { "+", "-", "*", "/" }, StringSplitOptions.None);

                numero = numbers[arrayCount];

                number[arrayCount] = (Convert.ToInt32(numero));

                tamanhoTextoAnterior += numero.Length;

                if (arrayCount >= 1)
                {
                    resultado = calculateValues(operation, number[arrayCount - 1], number[arrayCount]);
                    number[0] = number[arrayCount - 1];
                    number[1] = 0;

                    clrData();
                    tamanhoTextoAnterior = resultado.ToString().Length;
                    output += resultado;
                }

                if (resultado == 0)
                {
                    output += operation;
                    arrayCount++;
                    arrayPositionCount++;
                }
                return resultado;
            }
        }

        private void clrData()
        {
            arrayCount = 0;
            arrayPositionCount = 1;
        }
    }
}
