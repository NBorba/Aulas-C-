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
        public bool verifyText(string output)
        {
            string[] operators = output.Split(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" }, StringSplitOptions.RemoveEmptyEntries);
            string [] numbers = output.Split(new string[] { "+", "-", "*", "/", "=" }, StringSplitOptions.None);

            int operatorsCount = operators.Count();
            int numbersCount = numbers.Count();

            // One operator after another
            if (operators[0].Length >= 2) {
                return false;
            }
            
            // If the first operator is Equals, the formulha is incorrect
            if (operators[0] == "=")
            {
                return false;
            }
            
            // Formula cannot start with an operator except for minus
            if(output.StartsWith("+") || output.StartsWith("-") || output.StartsWith("/") || output.StartsWith("*") || output.StartsWith("="))
            {
                return false;
            }

            if (output.Length == 0)
            {
                return false;
            }
            return true;
        }

        public int calculateFormula(string operation, int numberOne, int numberTwo)
        {
            int result = 0;

            if (operation == "+")
            {
                result = numberOne + numberTwo;
            }

            if (operation == "-")
            {
                result = numberOne - numberTwo;
            }

            if (operation == "*")
            {
                result = numberOne * numberTwo;
            }

            if (operation == "/")
            {
                result = numberOne / numberTwo;
            }

            return result;
        }
     
    }
}
