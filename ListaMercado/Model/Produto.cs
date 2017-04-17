using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public int CategoriaId { get; set; }
        public string NomeProduto { get; set; }
        
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<ProdutosLista> ProdutosLista { get; set; }
    }
}
