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

            if (categoriaController.RetornaCategoriasBanco().Count == 0)
            {
                categoriaController.AdicionarCategoriasIniciais("Carnes"); // Id 1
                categoriaController.AdicionarCategoriasIniciais("Grãos"); // Id 2
                categoriaController.AdicionarCategoriasIniciais("Produtos de higiene e limpeza"); // Id 3
                categoriaController.AdicionarCategoriasIniciais("Laticínios"); // Id 4
                categoriaController.AdicionarCategoriasIniciais("Óleos"); // Id 5
                categoriaController.AdicionarCategoriasIniciais("Massas"); // Id 6
                categoriaController.AdicionarCategoriasIniciais("Molhos"); // Id 7
                categoriaController.AdicionarCategoriasIniciais("Doces"); // Id 8
                categoriaController.AdicionarCategoriasIniciais("Farinhas"); // Id 9
                categoriaController.AdicionarCategoriasIniciais("Adoçantes"); // Id 10
            }

            if (produtoController.RetornarTodosProdutosBanco().Count == 0)
            {
                // Carnes
                produtoController.AdicionarProdutoBanco("Carne 1Kg", 1);
                produtoController.AdicionarProdutoBanco("Frango 1Kg", 1);
                produtoController.AdicionarProdutoBanco("Peixe 1Kg", 1);
                produtoController.AdicionarProdutoBanco("Hamburguer 1Kg", 1);

                // Grãos
                produtoController.AdicionarProdutoBanco("Arroz 1Kg", 2);
                produtoController.AdicionarProdutoBanco("Feijão 1Kg", 2);
                produtoController.AdicionarProdutoBanco("Sal 1Kg", 2);

                // Produtos de higiene e limpeza
                produtoController.AdicionarProdutoBanco("Sabão em pó", 3);
                produtoController.AdicionarProdutoBanco("Pasta de Dente", 3);
                produtoController.AdicionarProdutoBanco("Papel higienico", 3);
                produtoController.AdicionarProdutoBanco("Sabonete", 3);
                produtoController.AdicionarProdutoBanco("Escova de dente", 3);
                produtoController.AdicionarProdutoBanco("Detergente", 3);
                produtoController.AdicionarProdutoBanco("Água sanitaria", 3);
                produtoController.AdicionarProdutoBanco("Shampoo", 3);
                produtoController.AdicionarProdutoBanco("Desodorante", 3);

                // Laticinios
                produtoController.AdicionarProdutoBanco("Leite condensado", 4);
                produtoController.AdicionarProdutoBanco("Margarina", 4);
                produtoController.AdicionarProdutoBanco("Requeijão", 4);
                produtoController.AdicionarProdutoBanco("Leite", 4);
                produtoController.AdicionarProdutoBanco("Pão", 4);
                produtoController.AdicionarProdutoBanco("Creme de leite", 4);

                // Óleos
                produtoController.AdicionarProdutoBanco("Óleo", 5);
                produtoController.AdicionarProdutoBanco("Azeite", 5);

                // Massas
                produtoController.AdicionarProdutoBanco("Macarrão", 6);
                produtoController.AdicionarProdutoBanco("Massa de lasanha", 6);

                // Molhos
                produtoController.AdicionarProdutoBanco("Molho de tomate", 7);

                // Doces
                produtoController.AdicionarProdutoBanco("Chocolate em pó", 8);
                produtoController.AdicionarProdutoBanco("Chocolate ao Leite 100g", 8);

                // Farinhas
                produtoController.AdicionarProdutoBanco("Farinha de trigo", 9);

                // Adoçantes
                produtoController.AdicionarProdutoBanco("Açucar", 10);
                produtoController.AdicionarProdutoBanco("Adoçante", 10);
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroLista formCadastroLista = new FormCadastroLista();
            formCadastroLista.MdiParent = this;
            formCadastroLista.Show();
            formCadastroLista.WindowState = FormWindowState.Maximized;
        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListagemListas formListagemListas = new FormListagemListas();
            formListagemListas.MdiParent = this;
            formListagemListas.Show();
            formListagemListas.WindowState = FormWindowState.Maximized;
        }
    }
}
