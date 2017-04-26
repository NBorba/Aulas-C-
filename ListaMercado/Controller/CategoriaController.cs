using Controller.Interface;
using Model;
using Model.DAL;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Controller
{
    public class CategoriaController : ICrud<Categoria>
    {
        public void AdicionarItem(Categoria categoria)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Categorias.Add(categoria);
                contexto.SaveChanges();
            }
        }

        public void RemoverItem(Categoria categoria)
        {
            using (Contexto contexto = new Contexto()) 
            {
                contexto.Entry(categoria).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public ICollection<Categoria> RetornarTodos()
        {
            using (Contexto contexto = new Contexto())
            {
                return contexto.Categorias.ToList();
            }
        }
    }
}
