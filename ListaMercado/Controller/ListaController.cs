using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ListaController
    {
        public static BindingList<ListaCompra> ListaComprasList = new BindingList<ListaCompra>();
        public static BindingList<ListaProduto> ListaProdutosList = new BindingList<ListaProduto>();
        ProdutoController produtoController = new ProdutoController();

        public void CadastrarLista(string nome)
        {
            ListaCompra lista = new ListaCompra();
            lista.IdLista = ListaComprasList.Count + 1;
            lista.NomeLista = nome;
            ListaComprasList.Add(lista);
        }

        public void CadastrarProdutosLista(int IdProduto, int Quantidade)
        {
            ListaProduto lista = new ListaProduto();
            lista.IdLista = ListaComprasList.Count;
            lista.IdProduto = IdProduto;
            lista.Quantidade = Quantidade;
            ListaProdutosList.Add(lista);
        }

        public BindingList<ProdutoQuantidade> RetornarProdutos(int IdLista)
        {
            BindingList<ProdutoQuantidade> produtoQuantidadeList = new BindingList<ProdutoQuantidade>();
            foreach (ListaProduto p in ListaProdutosList)
            {
                Produto produto = produtoController.AcharProdutoPorID(p.IdProduto);
                ProdutoQuantidade prod = new ProdutoQuantidade();
                prod.nomeProduto = produto.NomeProduto;
                prod.quantidade = p.Quantidade;
                produtoQuantidadeList.Add(prod);
            }
            return produtoQuantidadeList;
        }

        public BindingList<ListaCompra> RetornarListas()
        {
            return ListaComprasList;
        }

        private ListaCompra BuscaPorID(int id)
        {
            foreach (ListaCompra lc in ListaComprasList)
            {
                if (lc.IdLista == id)
                {
                    return lc;
                }
            }
            return null;
        }

    }
}
