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
using Model;


namespace ProvaSistemaAluno.Alunos
{
    public partial class frmAluno : Form
    {
        Enum acaoUser = null;
        int? idUser = null;
        AlunoController alunoController = new AlunoController();

        public frmAluno(Enum acao, int? id)
        {
            InitializeComponent();

            // Deixa disponível para os outros métodos os objetos que o usuário passou via parâmetro
            acaoUser = acao;
            idUser = id;

            // Ajusta controles dependendo da ação do usuário    
            ajustaControles(acaoUser);
        }

        private void ajustaControles(Enum acao)
        {
            if (acao.Equals(AcaoEnum.Acao.Cadastrar))
            {
                // Cadastro muda somente o título
                lblTitulo.Text = "Cadastro de aluno";

                btnAcao.Text = "Cadastrar";
            }
            else if (acao.Equals(AcaoEnum.Acao.Editar))
            {
                lblTitulo.Text = "Edição de aluno";
                Aluno aluno = alunoController.listarItem(idUser);

                // Mostra os dados do curso que está sendo editado
                txtNome.Text = aluno.nome;
                txtCPF.Text = aluno.cpf;

                btnAcao.Text = "Editar";
            }
            else if (acao.Equals(AcaoEnum.Acao.Excluir))
            {
                lblTitulo.Text = "Excluir aluno";
                Aluno aluno = alunoController.listarItem(idUser);

                // Mostra os dados do curso que está sendo excluído
                txtNome.Text = aluno.nome;
                txtCPF.Text = aluno.cpf;

                // Bloqueia edição de campos
                txtNome.Enabled = false;
                txtCPF.Enabled = false;

                btnAcao.Text = "Excluir";
            }
            else
            {
                lblTitulo.Text = "Visualizar aluno";
                Aluno aluno = alunoController.listarItem(idUser);

                // Mostra os dados do curso que está sendo visualizado
                txtNome.Text = aluno.nome;
                txtCPF.Text = aluno.cpf;

                // Bloqueia edição de campos
                txtNome.Enabled = false;
                txtCPF.Enabled = false;
                btnAcao.Enabled = false;
                btnAcao.Visible = false;

                btnCancelar.Text = "Voltar";
            }
        }

        private void buttonAcao_Click(object sender, EventArgs e)
        {
            if (acaoUser.Equals(AcaoEnum.Acao.Cadastrar))
            {
                if (validaCampos())
                {
                    // Valida o cpf
                    if (Util.Validadores.validarCPF(txtCPF.Text))
                    {
                        alunoController.adicionar(txtNome.Text.Trim(), txtCPF.Text);
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
            else if (acaoUser.Equals(AcaoEnum.Acao.Editar))
            {
                if (validaCampos())
                {
                    // Valida o cpf
                    if (Validadores.validarCPF(txtCPF.Text))
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
            else if (acaoUser.Equals(AcaoEnum.Acao.Excluir))
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
