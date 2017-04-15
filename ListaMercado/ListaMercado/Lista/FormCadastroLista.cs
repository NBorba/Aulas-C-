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
        public FormCadastroLista()
        {
            InitializeComponent();

            produtoController.adicionarProduto("Arroz");
            produtoController.adicionarProduto("Sabao em po");
            produtoController.adicionarProduto("Macarrao");
            produtoController.adicionarProduto("Feijao");
            produtoController.adicionarProduto("Pasta de Dente");
            produtoController.adicionarProduto("Nescau");
            produtoController.adicionarProduto("Azeite");
            produtoController.adicionarProduto("Leite condensado");
            produtoController.adicionarProduto("Margarina");
            produtoController.adicionarProduto("Requeijao");
            produtoController.adicionarProduto("Leite");
            produtoController.adicionarProduto("Molho de tomate");
            produtoController.adicionarProduto("Farinha de trigo");
            produtoController.adicionarProduto("Pao");
            produtoController.adicionarProduto("Creme de leite");
            produtoController.adicionarProduto("Oleo");
            produtoController.adicionarProduto("Papel higienico");
            produtoController.adicionarProduto("Sabonete");
            produtoController.adicionarProduto("Escova de dente");
            produtoController.adicionarProduto("Carne");
            produtoController.adicionarProduto("Frango");
            produtoController.adicionarProduto("Peixe");
            produtoController.adicionarProduto("Hamburguer");

            listProdutos.DataSource = produtoController.retornarLista1();
            listProdutos.DisplayMember = "NomeProduto";

            listAdicionados.DataSource = produtoController.retornarLista2();
            listAdicionados.DisplayMember = "IdProduto";
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)listProdutos.SelectedItem;
            produtoController.adicionarProdutoLista(produto);
        }
    }
}
