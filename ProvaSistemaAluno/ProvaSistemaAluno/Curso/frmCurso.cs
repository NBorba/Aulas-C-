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

namespace ProvaSistemaAluno
{
    public partial class frmCurso : Form
    {
        Enum acaoUser = null;
        int? idUser = null;
        CursoController cursoController = new CursoController();

        public frmCurso(Enum acao, int? id)
        {
            InitializeComponent();

            acaoUser = acao;
            idUser = id;

            ajustaControles(acaoUser);
        }

        // Ajusta controles dependendo da ação do usuário
        private void ajustaControles(Enum acao)
        {
            if (acao.Equals(Views.AcaoEnum.Acao.Cadastrar))
            {
                // Cadastro muda somente o título
                lblTitulo.Text = "Cadastro de curso";

                btnAcao.Text = "Cadastrar";
            }
            else if (acao.Equals(Views.AcaoEnum.Acao.Editar))
            {
                lblTitulo.Text = "Edição de curso";
                Model.Curso curso = cursoController.listarItem(idUser);

                // Mostra os dados do curso que está sendo editado
                txtCod.Text = curso.codigo.ToString();
                txtNome.Text = curso.nome;
                txtDesc.Text = curso.descricao;

                btnAcao.Text = "Editar";
            }
            else if (acao.Equals(Views.AcaoEnum.Acao.Excluir))
            {
                lblTitulo.Text = "Excluir curso";
                Model.Curso curso = cursoController.listarItem(idUser);

                // Mostra os dados do curso que está sendo excluido
                txtCod.Text = curso.codigo.ToString();
                txtNome.Text = curso.nome;
                txtDesc.Text = curso.descricao;

                // Bloqueia edição de campos
                txtCod.Enabled = false;
                txtNome.Enabled = false;
                txtDesc.Enabled = false;

                btnAcao.Text = "Excluir";
            }
            else
            {
                lblTitulo.Text = "Visualizar curso";
                Model.Curso curso = cursoController.listarItem(idUser);

                // Mostra os dados do curso que está sendo visualizado
                txtCod.Text = curso.codigo.ToString();
                txtNome.Text = curso.nome;
                txtDesc.Text = curso.descricao;

                // Bloqueia edição de campos
                txtCod.Enabled = false;
                txtNome.Enabled = false;
                txtDesc.Enabled = false;
                btnAcao.Enabled = false;

                btnCancelar.Text = "Voltar";
            }
        }

        private void buttonAcao_Click(object sender, EventArgs e)
        {
            // Baseado no comando do usuário, realiza a ação específica
            if (acaoUser.Equals(Views.AcaoEnum.Acao.Cadastrar))
            {
                if (validaCampos())
                {
                    cursoController.adicionar(Convert.ToInt32(txtCod.Text), txtNome.Text, txtDesc.Text);
                    MessageBox.Show("Curso cadastrado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum campo pode ser vazio!");
                }
            }
            else if (acaoUser.Equals(Views.AcaoEnum.Acao.Editar))
            {
                if (validaCampos())
                {
                    cursoController.editar(idUser, Convert.ToInt32(txtCod.Text), txtNome.Text, txtDesc.Text);
                    MessageBox.Show("Curso alterado com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum campo pode ser vazio!");
                }
            }
            else if (acaoUser.Equals(Views.AcaoEnum.Acao.Excluir))
            {
                cursoController.remover(idUser);
                MessageBox.Show("Curso excluido com sucesso!");
                this.Close();
            }
        }

        // Verifica se algum dos campos está vazio
        private bool validaCampos()
        {
            return !String.IsNullOrEmpty(txtCod.Text.Trim()) && !String.IsNullOrEmpty(txtNome.Text.Trim()) && !String.IsNullOrEmpty(txtDesc.Text.Trim());
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

