using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;


namespace ProvaSistemaAluno
{
    public partial class frmAluno : Form
    {
        Enum acaoUser = null;
        int? idUser = null;
        AlunoController alunoController = new AlunoController();

        public frmAluno(Enum acao, int? id)
        {
            InitializeComponent();

            acaoUser = acao;
            idUser = id;

            ajustaControles(acaoUser);
        }

        // Ajusta controles dependendo da ação do usuário
        private void ajustaControles(Enum acao)
        {
            if (acao.Equals(Model.Enum.Acao.Cadastrar))
            {
                // Cadastro muda somente o título
                lblTitulo.Text = "Cadastro de aluno";
            }
            else if (acao.Equals(Model.Enum.Acao.Editar))
            {
                lblTitulo.Text = "Edição de aluno";
                Model.Aluno aluno = alunoController.listarItem(idUser);

                // Mostra os dados do curso que está sendo editado
                txtNome.Text = aluno.nome;
                txtCPF.Text = aluno.cpf;
            }
            else if (acao.Equals(Model.Enum.Acao.Excluir))
            {
                lblTitulo.Text = "Excluir aluno";
                Model.Aluno aluno = alunoController.listarItem(idUser);

                // Mostra os dados do curso que está sendo excluído
                txtNome.Text = aluno.nome;
                txtCPF.Text = aluno.cpf;

                // Bloqueia edição de campos
                txtNome.Enabled = false;
                txtCPF.Enabled = false;
            }
            else
            {
                lblTitulo.Text = "Visualizar aluno";
                Model.Aluno aluno = alunoController.listarItem(idUser);

                // Mostra os dados do curso que está sendo visualizado
                txtNome.Text = aluno.nome;
                txtCPF.Text = aluno.cpf;

                // Bloqueia edição de campos
                txtNome.Enabled = false;
                txtCPF.Enabled = false;
                btnAcao.Enabled = false;
                btnCancelar.Text = "Voltar";
            }
        }

        private void buttonAcao_Click(object sender, EventArgs e)
        {
            if (acaoUser.Equals(Model.Enum.Acao.Cadastrar))
            {
                if (validaCampos())
                {
                    // Valida o cpf
                    if (Util.Util.validarCPF(txtCPF.Text))
                    {
                        alunoController.adicionar(txtNome.Text, txtCPF.Text);
                        MessageBox.Show("Aluno cadastrado com sucesso!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("CPF inválido!");
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum campo pode ser vazio!");
                }
            }
            else if (acaoUser.Equals(Model.Enum.Acao.Editar))
            {
                if (validaCampos())
                {
                    // Valida o cpf
                    if (Util.Util.validarCPF(txtCPF.Text))
                    {
                        alunoController.editar(idUser, txtNome.Text.Trim(), txtCPF.Text.Trim());
                        MessageBox.Show("Aluno alterado com sucesso");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("CPF inválido!");
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum campo pode ser vazio!");
                }
            }
            else if (acaoUser.Equals(Model.Enum.Acao.Excluir))
            {
                alunoController.remover(idUser);
                MessageBox.Show("Aluno excluido com sucesso!");
                this.Close();
            }
        }

        // Verifica se algum dos campos está vazio
        private bool validaCampos() {
            return !String.IsNullOrEmpty(txtCPF.Text.Trim()) && !String.IsNullOrEmpty(txtNome.Text.Trim());
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
