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
    public class CategoriaController
    {
        private static Contexto contexto = new Contexto();

        // Banco de dados
        public void AdicionarCategoriasIniciais(string NomeCategoria)
        {
            Categoria categoria = new Categoria();
            categoria.NomeCategoria = NomeCategoria;
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public List<Categoria> RetornaCategoriasBanco()
        {
            return contexto.Categorias.ToList();
        }
    }
}
