using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula0803_WF
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnNumClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            txtDisplay.Text += btn.Text;

            if (btn.Text == "+" || btn.Text == "-" || btn.Text == "x" || btn.Text == "÷")
            {
                btnOpClick(btn.Text);
            }

        }

        private void btnOpClick(string op)
        {
            var operation = op;   
        }

    }
}
