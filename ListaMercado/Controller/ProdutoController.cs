using Controller.Interface;
using Model;
using Model.DAL;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Controller
{
    public class ProdutoController : ICrud<Produto>
    {
        public void AdicionarItem(Produto produto)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Produto.Add(produto);
                contexto.SaveChanges();
            }
        }

        public void RemoverItem(Produto produto)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Entry(produto).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public ICollection<Produto> RetornarTodos()
        {
            using (Contexto contexto = new Contexto())
            {
                return contexto.Produto.ToList();
            }
        }

        // Retorna produtos de uma certa categoria
        public ICollection<Produto> RetornarProdutosEspecificosBanco(int CategoriaID)
        {
            using (Contexto contexto = new Contexto())
            {
                return (from produto in contexto.Produto
                        where produto.CategoriaId.Equals(CategoriaID)
                        select produto).ToList<Produto>();
            }
        }
    }
}
