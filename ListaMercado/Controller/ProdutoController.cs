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

        public void adicionarProduto(string nome) 
        {
            Produto produto = new Produto();
            produto.IdProduto = produtosList.Count + 1;
            produto.NomeProduto = nome;
            produtosList.Add(produto);
        }

        public void adicionarProdutoLista(Produto produto)
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
                        existe = true;
                    }
                }

                if (!existe) {
                    produtosList2.Add(produto);
                }
            }
        }

        public BindingList<Produto> retornarLista1()
        {
            return produtosList;
        }

        public BindingList<Produto> retornarLista2()
        {
            return produtosList2;
        }
    }
}
