using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1003_Camadas
{
    public partial class ucEndereco : UserControl
    {
        public ucEndereco()
        {
            InitializeComponent();
        }
  
        public string nomeRua
        {
            get { return txtRua.Text; }
            set { txtRua.Text = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
