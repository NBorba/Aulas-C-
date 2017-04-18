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

            listaController.ApagaProdutosAdicionados();

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

            comboBoxCategoriaProdutos.DataSource = categoriaController.RetornaCategoriasBanco();
            comboBoxCategoriaProdutos.DisplayMember = "CategoriaNome";

            dgvAdicionados.DataSource = listaController.RetornaProdutosAdicionados();
            dgvAdicionados.Columns.Add(comboBoxQuantidade);

            dgvAdicionados.Columns[1].Visible = true; // Id Produto
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
            if (String.IsNullOrEmpty(txtNomeLista.Text.Trim()))
            {
                MessageBox.Show("O nome da lista não pode ser vazio");
            }
            else if (listaController.RetornaProdutosAdicionados().Count == 0)
            {
                MessageBox.Show("Você deve adicionar pelo menos um produto na lista de compras!");
            }
            else
            {
                for (int i = 0; i < listaController.RetornaProdutosAdicionados().Count; i++)
                {
                    ProdutosLista produtosLista = new ProdutosLista();
                    produtosLista.ProdutoId = Convert.ToInt32(dgvAdicionados.Rows[i].Cells[2].Value);
                    // Se estiver no valor nulo, muda de 0 pra 1
                    if (Convert.ToInt32(dgvAdicionados.Rows[i].Cells[1].Value) == 0)
                    {
                        produtosLista.Quantidade = 1;
                    }
                    else
                    {
                        produtosLista.Quantidade = Convert.ToInt32(dgvAdicionados.Rows[i].Cells[1].Value);
                    }
                    listaController.CadastraProdutoEQuantidadeLista(produtosLista);
                }

                listaController.CadastrarListaBanco(txtNomeLista.Text.Trim(), listaController.RetornarListaProdutoEQuantidade());
                MessageBox.Show("Lista cadastrada com sucesso!");
                this.Close();
            }
        }
    }
}
