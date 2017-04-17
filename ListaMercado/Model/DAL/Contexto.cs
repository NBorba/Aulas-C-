using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Model.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ListaCompra> Listas { get; set; }
        public DbSet<ProdutosLista> ProdutosLista { get; set; }
    }
}
