using System;
using System.Windows.Forms;
using Controllers;

namespace Views
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNome.Text) && !string.IsNullOrEmpty(txtCpf.Text))
                {
                    ClientesController cliController = new ClientesController();
                    cliController.Adicionar(txtNome.Text, txtCpf.Text);

                    MessageBox.Show("Cliente cadastrado com sucesso");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Todos campos são obrigatórios");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }
        }
    }
}
