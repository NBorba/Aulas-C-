using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class ProdutosLista
    {
        [Key]
        public int ProdutosListaID { get; set; }

        public int ListaCompraId { get; set; }
        public int ProdutoId { get; set; }

        public virtual ListaCompra Lista { get; set; }
        public virtual Produto Produto { get; set; }
        
        public int Quantidade { get; set; }

    }
}
