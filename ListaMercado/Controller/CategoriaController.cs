using Model;
using Model.DAL;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class CategoriaController
    {
        private static Contexto contexto = new Contexto();

        public static ICollection<Categoria> RetornaCategoriasBanco()
        {
            return contexto.Categorias.ToList();
        }
    }
}
