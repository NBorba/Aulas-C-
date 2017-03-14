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
