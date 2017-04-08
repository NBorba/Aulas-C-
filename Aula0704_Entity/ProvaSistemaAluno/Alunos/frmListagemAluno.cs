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

namespace ProvaSistemaAluno.Alunos
{
    public partial class frmListagemAluno : Form
    {
        AlunoController alunoController = new AlunoController();
        public frmListagemAluno()
        {
            InitializeComponent();
        }

        private void frmListagemAluno_Load(object sender, EventArgs e)
        {
            dgvAlunos.DataSource = alunoController.retornarLista();
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se não existem registros
            if (e.RowIndex >= 0)
            {
                int idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value);

                // Editar
                if (e.ColumnIndex == 0)
                {
                    frmAluno formEditarAluno = new frmAluno(AcaoEnum.Acao.Editar, idSelecionado);
                    formEditarAluno.ShowDialog();
                    dgvAlunos.Refresh();
                }
                // Excluir
                else if (e.ColumnIndex == 1)
                {
                    frmAluno formExcluirAluno = new frmAluno(AcaoEnum.Acao.Excluir, idSelecionado);
                    formExcluirAluno.ShowDialog();
                    dgvAlunos.Refresh();
                }
                // Visualizar
                else {
                    frmAluno formVisualizarAluno = new frmAluno(AcaoEnum.Acao.Visualizar, idSelecionado);
                    formVisualizarAluno.ShowDialog();
                    dgvAlunos.Refresh();
                }
            }
        }
    }
}
