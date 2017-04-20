using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class ContextoInicializador : CreateDatabaseIfNotExists<Contexto>, IContexto
    {
        protected override void Seed(Contexto contexto)
        {
            base.Seed(contexto);

            CadastrarCategorias(contexto);
            CadastrarProdutos(contexto);
            CadastrarMercados(contexto);
        }

        public void CadastrarCategorias(Contexto contexto)
        {
            contexto.Categorias.Add(new Categoria() { CategoriaNome = "Carnes" }); // Id 1
            contexto.Categorias.Add(new Categoria() { CategoriaNome = "Grãos" }); // Id 2
            contexto.Categorias.Add(new Categoria() { CategoriaNome = "Produtos de higiene e limpeza" }); // Id 3
            contexto.Categorias.Add(new Categoria() { CategoriaNome = "Laticínios" }); // Id 4
            contexto.Categorias.Add(new Categoria() { CategoriaNome = "Óleos" }); // Id 5
            contexto.Categorias.Add(new Categoria() { CategoriaNome = "Massas" }); // Id 6
            contexto.Categorias.Add(new Categoria() { CategoriaNome = "Molhos" }); // Id 7
            contexto.Categorias.Add(new Categoria() { CategoriaNome = "Doces" }); // Id 8
            contexto.Categorias.Add(new Categoria() { CategoriaNome = "Farinhas" }); // Id 9
            contexto.Categorias.Add(new Categoria() { CategoriaNome = "Adoçantes" }); // Id 10
            contexto.Categorias.Add(new Categoria() { CategoriaNome = "Bebidas" }); // Id 11
        }

        public void CadastrarProdutos(Contexto contexto)
        {
            // Carnes
            contexto.Produto.Add(new Produto() { ProdutoNome = "Picanha 1Kg", CategoriaId = 1 }); // Id 1
            contexto.Produto.Add(new Produto() { ProdutoNome = "Frango 1Kg", CategoriaId = 1 }); // Id 2
            contexto.Produto.Add(new Produto() { ProdutoNome = "Peixe 1Kg", CategoriaId = 1 }); // Id 3
            contexto.Produto.Add(new Produto() { ProdutoNome = "Hamburguer 1Kg", CategoriaId = 1 }); // Id 4

            // Grãos
            contexto.Produto.Add(new Produto() { ProdutoNome = "Arroz 1Kg", CategoriaId = 2 }); // Id 5
            contexto.Produto.Add(new Produto() { ProdutoNome = "Feijão 1Kg", CategoriaId = 2 }); // Id 6
            contexto.Produto.Add(new Produto() { ProdutoNome = "Sal 1Kg", CategoriaId = 2 }); // Id 7

            // Produtos de higiene e limpeza
            contexto.Produto.Add(new Produto() { ProdutoNome = "Sabão em pó", CategoriaId = 3 }); // Id 8
            contexto.Produto.Add(new Produto() { ProdutoNome = "Pasta de Dente", CategoriaId = 3 }); // Id 9
            contexto.Produto.Add(new Produto() { ProdutoNome = "Papel higienico", CategoriaId = 3 }); // Id 10
            contexto.Produto.Add(new Produto() { ProdutoNome = "Sabonete", CategoriaId = 3 }); // Id 11
            contexto.Produto.Add(new Produto() { ProdutoNome = "Escova de dente", CategoriaId = 3 }); // Id 12
            contexto.Produto.Add(new Produto() { ProdutoNome = "Detergente", CategoriaId = 3 }); // Id 13 
            contexto.Produto.Add(new Produto() { ProdutoNome = "Água sanitaria", CategoriaId = 3 }); // Id 14
            contexto.Produto.Add(new Produto() { ProdutoNome = "Shampoo", CategoriaId = 3 }); // Id 15
            contexto.Produto.Add(new Produto() { ProdutoNome = "Desodorante", CategoriaId = 3 }); // Id 16

            // Laticinios
            contexto.Produto.Add(new Produto() { ProdutoNome = "Leite condensado", CategoriaId = 4 }); // Id 17
            contexto.Produto.Add(new Produto() { ProdutoNome = "Margarina", CategoriaId = 4 }); // Id 18
            contexto.Produto.Add(new Produto() { ProdutoNome = "Requeijão", CategoriaId = 4 }); // Id 19 
            contexto.Produto.Add(new Produto() { ProdutoNome = "Leite", CategoriaId = 4 }); // Id 20
            contexto.Produto.Add(new Produto() { ProdutoNome = "Pão", CategoriaId = 4 }); // Id 21
            contexto.Produto.Add(new Produto() { ProdutoNome = "Creme de leite", CategoriaId = 4 }); // Id 22

            // Óleos
            contexto.Produto.Add(new Produto() { ProdutoNome = "Óleo", CategoriaId = 5 }); // Id 23
            contexto.Produto.Add(new Produto() { ProdutoNome = "Azeite", CategoriaId = 5 }); // Id 24

            // Massas
            contexto.Produto.Add(new Produto() { ProdutoNome = "Macarrão", CategoriaId = 6 }); // Id 25
            contexto.Produto.Add(new Produto() { ProdutoNome = "Massa de lasanha", CategoriaId = 6 }); // Id 26

            // Molhos
            contexto.Produto.Add(new Produto() { ProdutoNome = "Molho de tomate", CategoriaId = 7 }); // Id 27

            // Doces
            contexto.Produto.Add(new Produto() { ProdutoNome = "Chocolate em pó", CategoriaId = 8 }); // Id 28
            contexto.Produto.Add(new Produto() { ProdutoNome = "Chocolate ao Leite 100g", CategoriaId = 8 }); // Id 29

            // Farinhas
            contexto.Produto.Add(new Produto() { ProdutoNome = "Farinha de trigo", CategoriaId = 9 }); // Id 30

            // Adoçantes
            contexto.Produto.Add(new Produto() { ProdutoNome = "Açucar", CategoriaId = 10 }); // Id 31
            contexto.Produto.Add(new Produto() { ProdutoNome = "Adoçante", CategoriaId = 10 }); // Id 32

            // Bebidas
            contexto.Produto.Add(new Produto() { ProdutoNome = "Refrigerante", CategoriaId = 11 }); // Id 33
            contexto.Produto.Add(new Produto() { ProdutoNome = "Suco", CategoriaId = 11 }); // Id 34
            contexto.Produto.Add(new Produto() { ProdutoNome = "Água", CategoriaId = 11 }); // Id 35
            contexto.Produto.Add(new Produto() { ProdutoNome = "Cerveja", CategoriaId = 11 }); // Id 36
        }

        public void CadastrarMercados(Contexto contexto)
        {
            contexto.Mercados.Add(new Mercado { MercadoNome = "Jumbo" }); // 1
            contexto.Mercados.Add(new Mercado { MercadoNome = "Continente" }); // 2 
            contexto.Mercados.Add(new Mercado { MercadoNome = "Intermarche" }); // 3 
            contexto.Mercados.Add(new Mercado { MercadoNome = "Pingo" }); // 4 
        }
    }
}

