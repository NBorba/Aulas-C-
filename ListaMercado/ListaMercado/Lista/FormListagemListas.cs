using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ListaMercado.Lista
{
    public partial class FormListagemListas : Form
    {
        private ListaController listaController = new ListaController();
        private FormPrincipal formPrincipalReferencia;

        public FormListagemListas(FormPrincipal formPrincipal)
        {
            InitializeComponent();

            var list = new List<ListaCompra>(listaController.RetornarListasBanco());
            var bindinglist = new BindingList<ListaCompra>(list);
            formPrincipalReferencia = formPrincipal;

            dgvListas.DataSource = bindinglist;
            dgvListas.Columns[3].Visible = false;
            dgvListas.Columns[5].Visible = false;
        }

        private void dgvListas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value);

                switch (e.ColumnIndex)
                {
                    // Ver Lista
                    case 0:
                        FormVisualizarLista formVisualizarLista = new FormVisualizarLista(idSelecionado, EnumAcao.Visualizar, formPrincipalReferencia);
                        formVisualizarLista.WindowState = FormWindowState.Maximized;
                        formVisualizarLista.MdiParent = FormPrincipal.ActiveForm;
                        formVisualizarLista.Show();
                        break;
                    case 1:
                        listaController.ApagarListaBanco(idSelecionado);
                        dgvListas.Refresh();
                        break;
                    case 2:
                        FormVisualizarLista formCompararLista = new FormVisualizarLista(idSelecionado, EnumAcao.CompararPreco, formPrincipalReferencia);
                        formCompararLista.WindowState = FormWindowState.Maximized;
                        formCompararLista.Show();
                        break;
                }
            }
            
        }
    }
}
