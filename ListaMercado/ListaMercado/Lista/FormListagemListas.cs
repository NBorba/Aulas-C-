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
            dgvListas.Columns[1].Visible = false;
        }

        private void dgvListas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        int idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value);
                        FormVisualizarLista formVisualizarLista = new FormVisualizarLista(idSelecionado);
                        formVisualizarLista.MdiParent = FormPrincipal.ActiveForm;
                        formVisualizarLista.Show();
                        break;
                }
            }
        }
    }
}
