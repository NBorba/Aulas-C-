﻿using Controller;
using ListaMercado.Lista;
using System;
using System.Windows.Forms;

namespace ListaMercado
{
    public partial class FormPrincipal : Form
    {
        CategoriaController categoriaController = new CategoriaController();
        ProdutoController produtoController = new ProdutoController();
        MercadoController mercadoController = new MercadoController();

        public FormPrincipal()
        {
            InitializeComponent();

            MercadoController.BuscaECadastraProduto("Pao", 21);

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
                categoriaController.AdicionarCategoriasIniciais("Bebidas"); // Id 11
            }

            if (produtoController.RetornarTodosProdutosBanco().Count == 0)
            {
                // Carnes
                produtoController.AdicionarProdutoBanco("Carne 1Kg", 1); // Id 1
                produtoController.AdicionarProdutoBanco("Frango 1Kg", 1); // Id 2
                produtoController.AdicionarProdutoBanco("Peixe 1Kg", 1); // Id 3
                produtoController.AdicionarProdutoBanco("Hamburguer 1Kg", 1); // Id 4

                // Grãos
                produtoController.AdicionarProdutoBanco("Arroz 1Kg", 2); // Id 5
                produtoController.AdicionarProdutoBanco("Feijão 1Kg", 2); // Id 6
                produtoController.AdicionarProdutoBanco("Sal 1Kg", 2); // Id 7

                // Produtos de higiene e limpeza
                produtoController.AdicionarProdutoBanco("Sabão em pó", 3); // Id 8
                produtoController.AdicionarProdutoBanco("Pasta de Dente", 3); // Id 9
                produtoController.AdicionarProdutoBanco("Papel higienico", 3); // Id 10
                produtoController.AdicionarProdutoBanco("Sabonete", 3); // Id 11
                produtoController.AdicionarProdutoBanco("Escova de dente", 3); // Id 12
                produtoController.AdicionarProdutoBanco("Detergente", 3); // Id 13 
                produtoController.AdicionarProdutoBanco("Água sanitaria", 3); // Id 14
                produtoController.AdicionarProdutoBanco("Shampoo", 3); // Id 15
                produtoController.AdicionarProdutoBanco("Desodorante", 3); // Id 16

                // Laticinios
                produtoController.AdicionarProdutoBanco("Leite condensado", 4); // Id 17
                produtoController.AdicionarProdutoBanco("Margarina", 4); // Id 18
                produtoController.AdicionarProdutoBanco("Requeijão", 4); // Id 19 
                produtoController.AdicionarProdutoBanco("Leite", 4); // Id 20
                produtoController.AdicionarProdutoBanco("Pão", 4); // Id 21
                produtoController.AdicionarProdutoBanco("Creme de leite", 4); // Id 22

                // Óleos
                produtoController.AdicionarProdutoBanco("Óleo", 5); // Id 23
                produtoController.AdicionarProdutoBanco("Azeite", 5); // Id 24

                // Massas
                produtoController.AdicionarProdutoBanco("Macarrão", 6); // Id 25
                produtoController.AdicionarProdutoBanco("Massa de lasanha", 6); // Id 26

                // Molhos
                produtoController.AdicionarProdutoBanco("Molho de tomate", 7); // Id 27

                // Doces
                produtoController.AdicionarProdutoBanco("Chocolate em pó", 8); // Id 28
                produtoController.AdicionarProdutoBanco("Chocolate ao Leite 100g", 8); // Id 29

                // Farinhas
                produtoController.AdicionarProdutoBanco("Farinha de trigo", 9); // Id 30

                // Adoçantes
                produtoController.AdicionarProdutoBanco("Açucar", 10); // Id 31
                produtoController.AdicionarProdutoBanco("Adoçante", 10); // Id 32

                // Bebidas
                produtoController.AdicionarProdutoBanco("Refrigerante", 11); // Id 33
                produtoController.AdicionarProdutoBanco("Suco", 11); // Id 34
                produtoController.AdicionarProdutoBanco("Água", 11); // Id 35
                produtoController.AdicionarProdutoBanco("Cerveja", 11); // Id 36
            }

            if (mercadoController.RetornaMercadosCadastradosBanco().Count == 0)
            {
                mercadoController.CadastrarMercadoBanco("Jumbo"); // 1
                mercadoController.CadastrarMercadoBanco("Continente"); // 2 
                mercadoController.CadastrarMercadoBanco("Intermarche"); // 3 
                mercadoController.CadastrarMercadoBanco("Pingo"); // 4 
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
