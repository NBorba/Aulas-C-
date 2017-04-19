using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class MercadoProduto
    {
        public MercadoProduto()
        {
            string DataAtualizacao = "";
        }

        [Key]
        public int MercadoProdutoId { get; set; } // Criado somente para EF conseguir criar a tabela...

        [ForeignKey("Mercado")]
        public int MercadoId { get; set; }
        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }

        public virtual Mercado Mercado { get; set; }
        public virtual Produto Produto { get; set; }

        public float Preco { get; set; }
        public string DataAtualizacao { get; set; }
    }
}