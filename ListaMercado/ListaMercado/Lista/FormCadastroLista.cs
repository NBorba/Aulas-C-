using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace ListaMercado.Lista
{
    public partial class FormCadastroLista : Form
    {
        ProdutoController produtoController = new ProdutoController();
        CategoriaController categoriaController = new CategoriaController();
        ListaController listaController = new ListaController();

        public FormCadastroLista()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn comboBoxQuantidade = new DataGridViewComboBoxColumn();
            comboBoxQuantidade.HeaderText = "Quantidade";
            comboBoxQuantidade.Name = "comboBoxQuantidade";

            comboBoxQuantidade.Items.Add("1");
            comboBoxQuantidade.Items.Add("2");
            comboBoxQuantidade.Items.Add("3");
            comboBoxQuantidade.Items.Add("4");
            comboBoxQuantidade.Items.Add("5");
            comboBoxQuantidade.Items.Add("6");
            comboBoxQuantidade.Items.Add("7");
            comboBoxQuantidade.Items.Add("8");
            comboBoxQuantidade.Items.Add("9");
            comboBoxQuantidade.Items.Add("10");
            comboBoxQuantidade.Items.Add("11");
            comboBoxQuantidade.Items.Add("12");
            comboBoxQuantidade.Items.Add("13");
            comboBoxQuantidade.Items.Add("14");
            comboBoxQuantidade.Items.Add("15");
            comboBoxQuantidade.Items.Add("16");
            comboBoxQuantidade.Items.Add("17");
            comboBoxQuantidade.Items.Add("18");
            comboBoxQuantidade.Items.Add("19");
            comboBoxQuantidade.Items.Add("20");
            comboBoxQuantidade.Items.Add("21");
            comboBoxQuantidade.Items.Add("22");
            comboBoxQuantidade.Items.Add("23");
            comboBoxQuantidade.Items.Add("24");
            comboBoxQuantidade.Items.Add("25");

            comboBoxCategoriaProdutos.DataSource = categoriaController.RetornarTodos();
            comboBoxCategoriaProdutos.DisplayMember = "CategoriaNome";

            dgvAdicionados.DataSource = listaController.RetornaProdutosAdicionados();
            dgvAdicionados.Columns.Add(comboBoxQuantidade);

            dgvAdicionados.Columns[1].Visible = false; // Id Produto
            dgvAdicionados.Columns[2].Visible = false; // Id Categoria 
            dgvAdicionados.Columns[3].ReadOnly = true; // Nome do produto
            dgvAdicionados.Columns[4].Visible = false; // Nome da Categoria 
            dgvAdicionados.Columns[5].Visible = false; // Produtos lista Virtual
            dgvAdicionados.Columns[6].DefaultCellStyle.NullValue = "1";
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)listProdutos.SelectedItem;
            listaController.CadastrarProdutoLista(produto);
        }   

        private void comboBoxCategoriaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)comboBoxCategoriaProdutos.SelectedItem;
            listProdutos.DataSource = produtoController.RetornarProdutosEspecificosBanco(categoria.CategoriaId);
            listProdutos.DisplayMember = "ProdutoNome";
        }

        private void dgvAdicionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    // Botao remover
                    case 0:
                        int IdSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value);
                        listaController.RemoverProdutoAdicionado(IdSelecionado);
                        break;
                }
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Nome da lista vazio
            if (String.IsNullOrEmpty(txtNomeLista.Text.Trim()))
            {
                MessageBox.Show("O nome da lista não pode ser vazio");
            }
            // Se não tem nenhum produto
            else if (listaController.RetornaProdutosAdicionados().Count == 0)
            {
                MessageBox.Show("Você deve adicionar pelo menos um produto na lista de compras!");
            }
            else
            {
                // Conta o número de produtos da lista local
                for (int i = 0; i < listaController.RetornaProdutosAdicionados().Count; i++)
                {
                    ProdutosLista produtosLista = new ProdutosLista();
                    produtosLista.ProdutoId = Convert.ToInt32(dgvAdicionados.Rows[i].Cells[2].Value);

                    // Se quantidade estiver no valor nulo, muda de 0 pra 1
                    if (Convert.ToInt32(dgvAdicionados.Rows[i].Cells[1].Value) == 0)
                    {
                        produtosLista.Quantidade = 1;
                    }
                    // Se não pega quantidade do campo
                    else
                    {
                        produtosLista.Quantidade = Convert.ToInt32(dgvAdicionados.Rows[i].Cells[1].Value);
                    }
                    // Cadastra o produto
                    listaController.CadastraProdutoEQuantidadeLista(produtosLista);
                }

                listaController.AdicionarLista(txtNomeLista.Text.Trim(), listaController.RetornarListaLocalProdQuant());

                // Apaga produtos da lista local já que os dados já foram cadastrados no banco.
                listaController.ApagaProdutosAdicionados();

                MessageBox.Show("Lista cadastrada com sucesso!");
                this.Close();
            }
        }
    }
}
