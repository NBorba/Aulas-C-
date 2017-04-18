using System.Collections.Generic;

namespace Model
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public int CategoriaId { get; set; }
        public string ProdutoNome { get; set; }
        
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<ProdutosLista> ProdutosLista { get; set; }
    }
}
