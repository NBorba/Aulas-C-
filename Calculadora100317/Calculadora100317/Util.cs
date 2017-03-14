using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
