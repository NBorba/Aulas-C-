using Model;
using Model.DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Controller
{
    public class ListaController
    {
        private static BindingList<Produto> ProdutosAdicionadosList = new BindingList<Produto>();
        private static BindingList<ProdutosLista> ProdutosQuantidadeList = new BindingList<ProdutosLista>();

        public void AdicionarLista(string NomeLista, BindingList<ProdutosLista> Produtos)
        {
            using (Contexto contexto = new Contexto())
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
        }

        public ICollection<ListaCompra> RetornarTodasListas()
        {
            using (Contexto contexto = new Contexto())
            {
                return contexto.Listas.ToList();
            }
        }

        public IEnumerable<dynamic> RetornaProdutosListaBanco(int IdLista)
        {
            return BuscaProdutoQuantidadeListaPorId(IdLista);
        }

        // Retorna produtos e suas quantidades definidas pelo usuário de uma lista de compra específica
        private IEnumerable<dynamic> BuscaProdutoQuantidadeListaPorId(int idLista)
        {
            using (Contexto contexto = new Contexto())
            {
                return (from produtoslista in contexto.ProdutosLista
                        join produtos in contexto.Produto on produtoslista.ProdutoId equals produtos.ProdutoId
                        where produtoslista.ListaCompraId.Equals(idLista)
                        select new
                        {
                            produtos.ProdutoNome,
                            produtoslista.Quantidade
                        }).ToList();
            }
        }

        public ListaCompra RetornaListaEspecifica(int IdLista)
        {
            return BuscarListaPorId(IdLista);
        }

        private ListaCompra BuscarListaPorId(int IdLista)
        {
            using (Contexto contexto = new Contexto())
            {
                return contexto.Listas.Find(IdLista);
            }
        }

        public void ApagarListaBanco(int IdLista)
        {
            using (Contexto contexto = new Contexto())
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
        }

        // Utilizado para achar a lista de todos os produtos de uma lista
        private ICollection<ProdutosLista> BuscaTodosProdutosListaPorId(int IdLista)
        {
            using (Contexto contexto = new Contexto())
            {
                return (from produtoslista in contexto.ProdutosLista
                        join produtos in contexto.Produto on produtoslista.ProdutoId equals produtos.ProdutoId
                        where produtoslista.ListaCompraId.Equals(IdLista)
                        select produtoslista).ToList();
            }
        }

        // Listas locais
        // Cadastra um produto na lista local de produtos
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

        // Remove um produto da lista local
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

        // Lista de produto e quantidade
        public void CadastraProdutoEQuantidadeLista(ProdutosLista produto)
        {
            ProdutosQuantidadeList.Add(produto);
        }

        public void ApagaProdutosAdicionados()
        {
            ProdutosAdicionadosList.Clear();
        }

        public BindingList<ProdutosLista> RetornarListaLocalProdQuant()
        {
            return ProdutosQuantidadeList;
        }
    }
}
