using Model;
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
        public static BindingList<CategoriaProduto> categoriaList = new BindingList<CategoriaProduto>();

        public void AdicionarCategoria(string name)
        {
            CategoriaProduto categoria = new CategoriaProduto();
            categoria.IdCategoria = categoriaList.Count + 1;
            categoria.NomeCategoria = name;
            categoriaList.Add(categoria);
        }

        public BindingList<CategoriaProduto> RetornaCategorias()
        {
            return categoriaList;
        }
    }
}
