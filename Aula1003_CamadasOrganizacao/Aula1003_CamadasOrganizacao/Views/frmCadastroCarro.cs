using Aula1003_CamadasOrganizacao.Controllers;
using Aula1003_CamadasOrganizacao.Models;
using System;
using System.Windows.Forms;

namespace Aula1003_CamadasOrganizacao.Views
{
    public partial class frmCadastroCarro : Form
    {
        public frmCadastroCarro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();

            c.Nome = txtNome.Text;
            c.Ano = Convert.ToInt32(txtAno.Text);

            CarroController carroController = new CarroController();

            carroController.SalvarCarro(c);
        }
    }
}
