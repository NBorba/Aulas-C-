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

        private ListaCompra BuscarPorId(int IdLista)
        {
            return contexto.Listas.Find(IdLista);
        }

        private IEnumerable<dynamic> BuscaProdutosListaPorId(int idLista)
        {
            return (from produtoslista in contexto.ProdutosLista
                    join produtos in contexto.Produto on produtoslista.ProdutoId equals produtos.ProdutoId
                    where produtoslista.ListaCompraId.Equals(idLista)
                    select new {
                        produtos.NomeProduto,
                        produtoslista.Quantidade
                    }).ToList();
        }

        private List<ProdutosLista> BuscaTodosProdutosListaPorId(int IdLista)
        {
            return (from produtoslista in contexto.ProdutosLista
                    join produtos in contexto.Produto on produtoslista.ProdutoId equals produtos.ProdutoId
                    where produtoslista.ListaCompraId.Equals(IdLista)
                    select produtoslista).ToList();
        }

        public IEnumerable<dynamic> RetornaProdutosListaBanco(int IdLista)
        {
            return BuscaProdutosListaPorId(IdLista);
        }
        

        public ListaCompra RetornaListaEspecifica(int IdLista)
        {
            return BuscarPorId(IdLista);
        }

        public void ApagarLista(int IdLista)
        {
            contexto.Entry(BuscarPorId(IdLista)).State = System.Data.Entity.EntityState.Deleted;
            foreach (ProdutosLista p in BuscaTodosProdutosListaPorId(IdLista))
            {
                contexto.Entry(p).State = System.Data.Entity.EntityState.Deleted;
            }
            
            contexto.SaveChanges();

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

        public void ApagaProdutosAdicionados()
        {
            ProdutosAdicionadosList.Clear();
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
