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

        public formCalc()
        {
            InitializeComponent();
        }

        private void btnNumberClick(object sender, EventArgs e)
        {
            var btnClickedNumber = sender as Button;

                txtOutput.Text += btnClickedNumber.Text;
        }

        private void btnClearOutput(object sender, EventArgs e)
        {
            clearOutput();
        }

        private void btnOperationClick(object sender, EventArgs e)
        {
            var btnClickedOperation = sender as Button;

            string text = txtOutput.Text;

            int resultado = util.CalculateFormula(text);

        }

        private void btnEqualsClick(object sender, EventArgs e)
        {
            //var btnClickedOperation = sender as Button;

            //string text = txtOutput.Text;
            //string operation = btnClickedOperation.Text;

            //int resultado = util.CalculateFormula(text,operation);

            //txtOutput.Text += resultado;

        }

        private void clearOutput()
        {
            txtOutput.Clear();
        }
    
    }
}
          




    

