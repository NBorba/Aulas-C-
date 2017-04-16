using Controller;
using Model;
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
    public partial class FormCadastroLista : Form
    {
        ProdutoController produtoController = new ProdutoController();
        CategoriaController categoriaController = new CategoriaController();
        ListaController listaController = new ListaController();

        public FormCadastroLista()
        {
            InitializeComponent();

            categoriaController.AdicionarCategoria("Carnes"); //1
            categoriaController.AdicionarCategoria("Graos"); //2
            categoriaController.AdicionarCategoria("Produtos de higiene"); //3
            categoriaController.AdicionarCategoria("Laticinios"); //4
            categoriaController.AdicionarCategoria("Oleos"); //5
            categoriaController.AdicionarCategoria("Massas"); //6
            categoriaController.AdicionarCategoria("Molhos"); //7
            categoriaController.AdicionarCategoria("Chocolates"); //8
            categoriaController.AdicionarCategoria("Farinhas"); //9

            produtoController.AdicionarProduto("Arroz", 2);
            produtoController.AdicionarProduto("Sabao em po", 3);
            produtoController.AdicionarProduto("Macarrao", 6);
            produtoController.AdicionarProduto("Feijao", 2);
            produtoController.AdicionarProduto("Pasta de Dente", 3);
            produtoController.AdicionarProduto("Nescau", 8);
            produtoController.AdicionarProduto("Azeite", 5);
            produtoController.AdicionarProduto("Leite condensado", 4);
            produtoController.AdicionarProduto("Margarina", 4);
            produtoController.AdicionarProduto("Requeijao", 4);
            produtoController.AdicionarProduto("Leite", 4);
            produtoController.AdicionarProduto("Molho de tomate", 7);
            produtoController.AdicionarProduto("Farinha de trigo", 9);
            produtoController.AdicionarProduto("Pao", 4);
            produtoController.AdicionarProduto("Creme de leite", 4);
            produtoController.AdicionarProduto("Oleo",5);
            produtoController.AdicionarProduto("Papel higienico",3);
            produtoController.AdicionarProduto("Sabonete", 3);
            produtoController.AdicionarProduto("Escova de dente", 3);
            produtoController.AdicionarProduto("Carne", 1);
            produtoController.AdicionarProduto("Frango", 1);
            produtoController.AdicionarProduto("Peixe", 1);
            produtoController.AdicionarProduto("Hamburguer", 1);

            DataGridViewComboBoxColumn comboBoxQuantidade = new DataGridViewComboBoxColumn();
            comboBoxQuantidade.HeaderText = "Quantidade";
            comboBoxQuantidade.Name = "Q";

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

            comboBoxCategoriaProdutos.DataSource = categoriaController.RetornaCategorias();
            comboBoxCategoriaProdutos.DisplayMember = "NomeCategoria";

            dgvAdicionados.DataSource = produtoController.RetornarLista2();
            dgvAdicionados.Columns.Add(comboBoxQuantidade);

            dgvAdicionados.Columns[1].Visible = false; // Id Produto
            dgvAdicionados.Columns[2].Visible = false; // Id 
            dgvAdicionados.Columns[3].ReadOnly = true; // Nome do produto
            dgvAdicionados.Columns[4].DefaultCellStyle.NullValue = "1";
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)listProdutos.SelectedItem;
            produtoController.AdicionarProdutoLista(produto);
        }   

        private void comboBoxCategoriaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoriaProduto categoria = (CategoriaProduto)comboBoxCategoriaProdutos.SelectedItem;
            listProdutos.DataSource = produtoController.RetornarProdutosEspecificos(categoria.IdCategoria);
            listProdutos.DisplayMember = "NomeProduto";
        }

        private void dgvAdicionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    // Botao remover
                    case 0:
                        int idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value);
                        produtoController.RemoverProdutoLista(idSelecionado);
                        break;
                }
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNomeLista.Text.Trim()))
            {
                MessageBox.Show("O nome da lista nao pode ser vazio");
            }
            else
            {
                listaController.CadastrarLista(txtNomeLista.Text.Trim());
                MessageBox.Show("Lista cadastrada com sucesso!");
                this.Close();
            }
        }
    }
}
