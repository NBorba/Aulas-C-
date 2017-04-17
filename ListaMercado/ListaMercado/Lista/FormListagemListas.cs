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

namespace ListaMercado.Lista
{
    public partial class FormListagemListas : Form
    {
        ListaController listaController = new ListaController();

        public FormListagemListas()
        {
            InitializeComponent();

            dgvListas.DataSource = listaController.RetornarListasBanco();
            dgvListas.Columns[2].Visible = false;
            dgvListas.Columns[4].Visible = false;
        }

        private void dgvListas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value);

                switch (e.ColumnIndex)
                {
                    // Ver Lista
                    case 0:
                        FormVisualizarLista formVisualizarLista = new FormVisualizarLista(idSelecionado);
                        formVisualizarLista.MdiParent = FormPrincipal.ActiveForm;
                        formVisualizarLista.Show();
                        break;

                    case 1:
                        listaController.ApagarLista(idSelecionado);
                        break;
                }
            }
            
        }
    }
}
