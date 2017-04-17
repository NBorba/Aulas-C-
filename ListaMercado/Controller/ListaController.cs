using Model;
using Model.DAL;
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
        private static Contexto contexto = new Contexto();
        private static BindingList<Produto> ProdutosAdicionadosList = new BindingList<Produto>();
        private static BindingList<ProdutosLista> ProdutosAdicionadosQuantidadeList = new BindingList<ProdutosLista>();

        public void CadastrarListaBanco(string NomeLista, BindingList<ProdutosLista> Produtos)
        {
            ListaCompra lista = new ListaCompra();
            lista.NomeLista = NomeLista;
            contexto.Listas.Add(lista);

            foreach (ProdutosLista p in Produtos)
            {
                contexto.ProdutosLista.Add(p);
            }
            contexto.SaveChanges();
        }

        public List<ListaCompra> RetornarListasBanco()
        {
            return contexto.Listas.ToList();
        }

        public List<Produto> RetornaProdutosListaBanco(int idLista)
        {
            return (from produtoslista in contexto.ProdutosLista
                    join produtos in contexto.Produto on produtoslista.ProdutoId equals produtos.ProdutoId
                    where produtoslista.ListaCompraId.Equals(idLista)
                    select produtos).ToList<Produto>();
        }

        public void CadastrarProdutoLista(Produto produto)
        {
            bool existe = false;
            foreach(Produto p in ProdutosAdicionadosList)
            {
                if (p.ProdutoId == produto.ProdutoId)
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                ProdutosAdicionadosList.Add(produto);
            }
        }

        public BindingList<Produto> RetornaProdutosAdicionados()
        {
            return ProdutosAdicionadosList;
        }

        public void RemoverProdutoAdicionado(int IdProduto)
        {
            foreach (Produto p in ProdutosAdicionadosList)
            {
                if (p.ProdutoId == IdProduto)
                {
                    ProdutosAdicionadosList.Remove(p);
                    break;
                }
            }
        }

        public void CadastraProdutoEQuantidadeLista(ProdutosLista produto)
        {
            ProdutosAdicionadosQuantidadeList.Add(produto);
        }

        public BindingList<ProdutosLista> RetornarListaProdutoEQuantidade()
        {
            return ProdutosAdicionadosQuantidadeList;
        }
    }
}
