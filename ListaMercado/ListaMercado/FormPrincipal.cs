using Controller;
using ListaMercado.Lista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaMercado
{
    public partial class FormPrincipal : Form
    {
        CategoriaController categoriaController = new CategoriaController();
        ProdutoController produtoController = new ProdutoController();

        public FormPrincipal()
        {
            InitializeComponent();

            categoriaController.AdicionarCategoriasIniciais("Carnes"); //1
            categoriaController.AdicionarCategoriasIniciais("Graos"); //2
            categoriaController.AdicionarCategoriasIniciais("Produtos de higiene"); //3
            categoriaController.AdicionarCategoriasIniciais("Laticinios"); //4
            categoriaController.AdicionarCategoriasIniciais("Oleos"); //5
            categoriaController.AdicionarCategoriasIniciais("Massas"); //6
            categoriaController.AdicionarCategoriasIniciais("Molhos"); //7
            categoriaController.AdicionarCategoriasIniciais("Chocolates"); //8
            categoriaController.AdicionarCategoriasIniciais("Farinhas"); //9

            produtoController.AdicionarProdutoBanco("Arroz", 2);
            produtoController.AdicionarProdutoBanco("Sabao em po", 3);
            produtoController.AdicionarProdutoBanco("Macarrao", 6);
            produtoController.AdicionarProdutoBanco("Feijao", 2);
            produtoController.AdicionarProdutoBanco("Pasta de Dente", 3);
            produtoController.AdicionarProdutoBanco("Nescau", 8);
            produtoController.AdicionarProdutoBanco("Azeite", 5);
            produtoController.AdicionarProdutoBanco("Leite condensado", 4);
            produtoController.AdicionarProdutoBanco("Margarina", 4);
            produtoController.AdicionarProdutoBanco("Requeijao", 4);
            produtoController.AdicionarProdutoBanco("Leite", 4);
            produtoController.AdicionarProdutoBanco("Molho de tomate", 7);
            produtoController.AdicionarProdutoBanco("Farinha de trigo", 9);
            produtoController.AdicionarProdutoBanco("Pao", 4);
            produtoController.AdicionarProdutoBanco("Creme de leite", 4);
            produtoController.AdicionarProdutoBanco("Oleo", 5);
            produtoController.AdicionarProdutoBanco("Papel higienico", 3);
            produtoController.AdicionarProdutoBanco("Sabonete", 3);
            produtoController.AdicionarProdutoBanco("Escova de dente", 3);
            produtoController.AdicionarProdutoBanco("Carne", 1);
            produtoController.AdicionarProdutoBanco("Frango", 1);
            produtoController.AdicionarProdutoBanco("Peixe", 1);
            produtoController.AdicionarProdutoBanco("Hamburguer", 1);
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroLista formCadastroLista = new FormCadastroLista();
            formCadastroLista.MdiParent = this;
            formCadastroLista.Show();
        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListagemListas formListagemListas = new FormListagemListas();
            formListagemListas.MdiParent = this;
            formListagemListas.Show();
        }
    }
}
