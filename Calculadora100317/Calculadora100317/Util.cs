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
        public bool validatesFormula(string output)
        {
            string[] operators = output.Split(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" }, StringSplitOptions.RemoveEmptyEntries);
            string[] numbers = output.Split(new string[] { "+", "-", "*", "/", "=" }, StringSplitOptions.None);

            int operatorsCount = operators.Count();
            int numbersCount = numbers.Count();

            // One operator after another
            if (operators[0].Length >= 2 ) {
                return false;
            }

            // One operator after another on second operator
            if (operatorsCount >= 2)
            {
                if (operators[1].Length >= 2)
                {
                    return false;
                }
            }
            
            // If the first operator is Equals, the formulha is incorrect
            if (operators[0] == "=")
            {
                return false;
            }
            
            // Formula cannot start with an operator except for minus
            if(output.StartsWith("+") || output.StartsWith("/") || output.StartsWith("*") || output.StartsWith("="))
            {
                return false;
            }

            if (output.Length == 0)
            {
                return false;
            }

            return true;
        }

        // Calculates operation from user 
        public int CalculateFormula(formCalc.Operations? operation, int numberOne, int numberTwo)
        {
            int result = 0;

            switch (operation)
            {
                case formCalc.Operations.Add:
                    result = numberOne + numberTwo;
                break;

                case formCalc.Operations.Subtract:
                    result = numberOne - numberTwo;
                break;

                case formCalc.Operations.Multiply:
                    result = numberOne * numberTwo;
                break;

                case formCalc.Operations.Divide:
                    if (numberTwo != 0)
                    {
                        result = numberOne / numberTwo;
                    }
                    else
                    {
                        result = 0;
                    }
                break;
            }
            return result;
        }
        
        // True if ends with operation
        public bool verifyEndsWithOp(string output)
        {
            if (output.EndsWith("+") || output.EndsWith("-") || output.EndsWith("*") || output.EndsWith("/") || output.EndsWith("="))
            {
                return true;
            }

            return false;
        }

        // Splits formula and returns all operators
        public string[] returnsOperators(string output) {
            string[] operators = output.Split(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" }, StringSplitOptions.RemoveEmptyEntries);

            return operators;
        }

        // Splits formula and returns all numbers
        public string[] returnsNumbers(string output)
        {
            string[] numbers = output.Split(new string[] { "+", "-", "*", "/", "=" }, StringSplitOptions.RemoveEmptyEntries);

            return numbers;
        }
    }
}
