using Model;
using Model.DAL;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class CategoriaController
    {
        private static Contexto contexto = new Contexto();

        // Banco de dados
        public void AdicionarCategoriasIniciais(string NomeCategoria)
        {
            Categoria categoria = new Categoria();
            categoria.CategoriaNome = NomeCategoria;
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public ICollection<Categoria> RetornaCategoriasBanco()
        {
            return contexto.Categorias.ToList();
        }
    }
}
