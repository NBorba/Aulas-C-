using Model;
using Model.DAL;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class ProdutoController
    {
        private static Contexto contexto = new Contexto();

        public void AdicionarProdutoBanco(string NomeProduto, int CategoriaID)
        {
            Produto Produto = new Produto();
            Produto.ProdutoNome = NomeProduto;
            Produto.CategoriaId = CategoriaID;
            contexto.Produto.Add(Produto);
            contexto.SaveChanges();
        }

        public List<Produto> RetornarProdutosEspecificosBanco(int CategoriaID)
        {
            List<Produto> produtosCategoriaUsuario = (from produto in contexto.Produto
                                where produto.CategoriaId.Equals(CategoriaID)
                                select produto).ToList<Produto>();
            return produtosCategoriaUsuario;
        }

        public ICollection<Produto> RetornarTodosProdutosBanco()
        {
            return contexto.Produto.ToList();
        }
    }
}
