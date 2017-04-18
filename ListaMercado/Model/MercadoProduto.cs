using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class MercadoProduto
    {
        // Chave estrangeira Mercado
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("Mercado")]
        public int MercadoId { get; set; }

        // Chave estrangeira Produto
        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }

        public virtual Mercado Mercado { get; set; }
        public virtual Produto Produto { get; set; }

        public float Preco { get; set; }
    }
}