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
        private static BindingList<ProdutosLista> ProdutosQuantidadeList = new BindingList<ProdutosLista>();

        public void CadastrarListaBanco(string NomeLista, BindingList<ProdutosLista> Produtos)
        {
            ListaCompra lista = new ListaCompra();
            lista.ListaCompraNome = NomeLista;
            contexto.Listas.Add(lista);

            // Atualiza o Id da lista na chave estrangeira
            foreach (var p in Produtos)
            {
                p.Lista = lista;
                p.ListaCompraId = lista.ListaCompraId;
            }

           contexto.ProdutosLista.AddRange(Produtos);
           contexto.SaveChanges();
        }

        public ICollection<ListaCompra> RetornarListasBanco()
        {
            return contexto.Listas.ToList();
        }

        private ListaCompra BuscarListaPorId(int IdLista)
        {
            return contexto.Listas.Find(IdLista);
        }

        private IEnumerable<dynamic> BuscaProdutosListaPorId(int idLista)
        {
            return (from produtoslista in contexto.ProdutosLista
                    join produtos in contexto.Produto on produtoslista.ProdutoId equals produtos.ProdutoId
                    where produtoslista.ListaCompraId.Equals(idLista)
                    select new {
                        produtos.ProdutoNome,
                        produtoslista.Quantidade
                    }).ToList();
        }

        private ICollection<ProdutosLista> BuscaTodosProdutosListaPorId(int IdLista)
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
            return BuscarListaPorId(IdLista);
        }

        public void ApagarListaBanco(int IdLista)
        {
            if (BuscarListaPorId(IdLista) != null)
            {
                contexto.Entry(BuscarListaPorId(IdLista)).State = System.Data.Entity.EntityState.Deleted;
                foreach (ProdutosLista p in BuscaTodosProdutosListaPorId(IdLista))
                {
                    contexto.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                }
                contexto.SaveChanges();
            }
        }

        // Listas locais
        public void CadastrarProdutoLista(Produto produto)
        {
            bool existe = false;
            foreach (Produto p in ProdutosAdicionadosList)
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

        public BindingList<Produto> RetornaProdutosAdicionados()
        {
            return ProdutosAdicionadosList;
        }

        public void ApagaProdutosAdicionados()
        {
            ProdutosAdicionadosList.Clear();
        }

        // Lista de produto e quantidade
        public void CadastraProdutoEQuantidadeLista(ProdutosLista produto)
        {
            ProdutosQuantidadeList.Add(produto);
        }

        public BindingList<ProdutosLista> RetornarListaProdutoEQuantidade()
        {
            return ProdutosQuantidadeList;
        }
    }
}
