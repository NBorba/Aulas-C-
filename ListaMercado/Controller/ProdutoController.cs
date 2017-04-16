using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ProdutoController
    {

        public static BindingList<Produto> produtosList = new BindingList<Produto>();
        public static BindingList<Produto> produtosList2 = new BindingList<Produto>();

        public void AdicionarProduto(string Nome, int IdCategoria) 
        {
            Produto produto = new Produto();
            produto.IdProduto = produtosList.Count + 1;
            produto.NomeProduto = Nome;
            produto.IdCategoria = IdCategoria;
            produtosList.Add(produto);
        }

        public void AdicionarProdutoLista(Produto produto)
        {
            bool existe = false;

            if (produtosList2.Count <= 0)
            {
                produtosList2.Add(produto);
            }
            else
            { 
                foreach (Produto p in produtosList2)
                {
                    if (p.IdProduto.Equals(produto.IdProduto))
                    {
                        // TODO: Arrumar nao pode buscar por noe
                        existe = true;
                    }
                }

                if (!existe) {
                    produtosList2.Add(produto);
                }
            }
        }

        public void RemoverProdutoLista(int id)
        {
            Produto produto = AcharProdutoPorID(id);

            foreach (Produto p in produtosList2)
            {
                if (p.IdProduto == id)
                {
                    produtosList2.Remove(produto);
                    break;
                }
            }
        }

        public Produto AcharProdutoPorID(int id)
        {
            foreach (Produto p in produtosList2)
            {
                if (p.IdProduto == id)
                {
                    return p;
                }
            }
            return null;
        }

        public BindingList<Produto> RetornarLista1()
        {
            return produtosList;
        }

        public BindingList<Produto> RetornarLista2()
        {
            return produtosList2;
        }

        public BindingList<Produto> RetornarProdutosEspecificos(int CategoriaID)
        {
            BindingList<Produto> produtosCategoriaUsuario = new BindingList<Produto>();
            foreach (Produto p in produtosList)
            {
                if (p.IdCategoria == CategoriaID)
                {
                    produtosCategoriaUsuario.Add(p);
                }
            }
            return produtosCategoriaUsuario;
        }
    }
}
