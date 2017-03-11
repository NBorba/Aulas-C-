using Aula1003_CamadasOrganizacao.Views;
using System;
using System.Windows.Forms;

namespace Aula1003_CamadasOrganizacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            frmCadastroCarro cadCarro = new frmCadastroCarro();
            cadCarro.ShowDialog();
        }
    }
}
