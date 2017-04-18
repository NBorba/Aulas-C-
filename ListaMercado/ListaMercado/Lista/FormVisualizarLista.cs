using Controller;
using System.Windows.Forms;

namespace ListaMercado.Lista
{
    public partial class FormVisualizarLista : Form
    {
        private int idLista;
        private ListaController listaController = new ListaController();

        public FormVisualizarLista(int id)
        {
            idLista = id;
            InitializeComponent();

            lblTitulo.Text = listaController.RetornaListaEspecifica(idLista).ListaCompraNome.ToString();
            dgvProdutos.DataSource = listaController.RetornaProdutosListaBanco(idLista);
        }
    }
}
