using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora100317
{
    public partial class formCalc : Form
    {
        private int arrayCount = 0;
        private int arrayPositionCount = 1;
        private int tamanhoTextoAnterior = 0;
        int [] numbers = new int [2];
        int[] fixedNumber = new int[1];
        Util util = new Util();

        public formCalc()
        {
            InitializeComponent();
        }

        private void btnNumberClick(object sender, EventArgs e)
        {
            var btnClickedNumber = sender as Button;

            if (fixedNumber[0] != 0 && numbers[1] == 0) {
                MessageBox.Show("Erro de formula.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                txtOutput.Text += btnClickedNumber.Text;
            }
        }

        private void btnClearOutput(object sender, EventArgs e)
        {
            clrData();
        }

        private void btnOperationClick(object sender, EventArgs e)
        {
            var btnClickedOperation = sender as Button;

            // Verifies if formula starts with an operation, if it does, formula is invalid
            bool canAddOperation = util.verifyText(txtOutput.Text);

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
                    numero = txtOutput.Text.Substring(tamanhoTextoAnterior + 1, textLength - tamanhoTextoAnterior - 1);
                }

                numbers[arrayCount] = (Convert.ToInt32(numero));

                tamanhoTextoAnterior += numero.Length;

                if (arrayCount >= 1)
                {
                    resultado = util.calculateValues(operation, numbers[arrayCount - 1], numbers[arrayCount]);
                    fixedNumber[0] = numbers[arrayCount - 1];
                    numbers[0] = fixedNumber[0];
                    numbers[1] = 0;
                    clrData();
                    tamanhoTextoAnterior = resultado.ToString().Length;
                    txtOutput.Text += resultado;
                }

                if (resultado == 0)
                {
                    txtOutput.Text += operation;
                    arrayCount++;
                    arrayPositionCount++;
                }

            }

         
        }

        private void clrData()
        {
            txtOutput.Clear();
            arrayCount = 0;
            arrayPositionCount = 1;
        }
 
    }
} 
