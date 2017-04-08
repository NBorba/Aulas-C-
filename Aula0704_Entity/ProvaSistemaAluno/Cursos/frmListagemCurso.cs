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

namespace ProvaSistemaAluno.Cursos
{
    public partial class frmListagemCurso : Form
    {
        CursoController cursoController = new CursoController();
        public frmListagemCurso()
        {
            InitializeComponent();
        }

        private void frmListagemCurso_Load(object sender, EventArgs e)
        {
            dgvCurso.DataSource = cursoController.retornarLista();
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se não existem registros
            if (e.RowIndex >= 0)
            {
                int idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value);

                // Editar
                if (e.ColumnIndex == 0)
                {
                    frmCurso formEditarCurso = new frmCurso(AcaoEnum.Acao.Editar, idSelecionado);
                    formEditarCurso.ShowDialog();
                    dgvCurso.Refresh();
                }
                // Excluir
                else if (e.ColumnIndex == 1)
                {
                    frmCurso formExcluirCurso = new frmCurso(AcaoEnum.Acao.Excluir, idSelecionado);
                    formExcluirCurso.ShowDialog();
                    dgvCurso.Refresh();
                }
                // Visualizar
                else {
                    frmCurso formVisualizarCurso = new frmCurso(AcaoEnum.Acao.Visualizar, idSelecionado);
                    formVisualizarCurso.ShowDialog();
                    dgvCurso.Refresh();
                }
            }
        }
    }
}
