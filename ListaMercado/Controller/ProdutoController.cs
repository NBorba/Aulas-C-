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
    public class ProdutoController
    {
        private static Contexto contexto = new Contexto();

        public void AdicionarProdutoBanco(string NomeProduto, int CategoriaID)
        {
            Produto Produto = new Produto();
            Produto.NomeProduto = NomeProduto;
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

        public List<Produto> RetornarTodosProdutosBanco()
        {
            return contexto.Produto.ToList();
        }
    }
}
