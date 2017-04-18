using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class ProdutosLista
    {
        [Key, Column(Order = 0)]
        public int ListaCompraId { get; set; }
        [Key, Column(Order = 1)]
        public int ProdutoId { get; set; }

        public virtual ListaCompra Lista { get; set; }
        public virtual Produto Produto { get; set; }
        
        public int Quantidade { get; set; }

    }
}
