using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using ProvaSistemaAluno.Aluno;

namespace ProvaSistemaAluno
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluno formCadastroAluno = new frmAluno(Views.AcaoEnum.Acao.Cadastrar, null);
            formCadastroAluno.MdiParent = this;

            formCadastroAluno.Show();

        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListagemAluno formListagemAluno = new frmListagemAluno();
            formListagemAluno.MdiParent = this;

            formListagemAluno.Show();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCurso formCadastroCurso = new frmCurso(Views.AcaoEnum.Acao.Cadastrar, null);
            formCadastroCurso.MdiParent = this;

            formCadastroCurso.Show();
        }

        private void listagemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListagemCurso formListagemCurso = new frmListagemCurso();
            formListagemCurso.MdiParent = this;

            formListagemCurso.Show();
        }
    }
}
