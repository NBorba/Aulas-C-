using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            var btnClickedOperation = sender as Button;
            var canAddOperation = verifyText();

            if (!canAddOperation)
            {
                MessageBox.Show("Erro de formula.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    if (btnClickedOperation.Text == "+")
                    {
                        txtOutput.Text += btnClickedOperation.Text;
                        plusCount += 1;
                    }

                    if (btnClickedOperation.Text == "-")
                    {
                        txtOutput.Text += btnClickedOperation.Text;
                        minusCount += 1;
                    }

                    if (btnClickedOperation.Text == "*")
                    {
                        txtOutput.Text += btnClickedOperation.Text;
                        multiplyCount += 1;
                    }

                    if (btnClickedOperation.Text == "/")
                    {
                        txtOutput.Text += btnClickedOperation.Text;
                        divideCount += 1;
                    }
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
        }

    }
}
