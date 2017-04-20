using System.Data.Entity;

namespace Model.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            Database.SetInitializer<Contexto>(new ContextoInicializador());
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ListaCompra> Listas { get; set; }
        public DbSet<ProdutosLista> ProdutosLista { get; set; }
        public DbSet<Mercado> Mercados { get; set; }
        public DbSet<MercadoProduto> MercadoProduto { get; set; }
        public DbSet<Moeda> Moeda { get; set; }
    }
}
