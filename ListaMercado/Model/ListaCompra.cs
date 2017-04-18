using System.Collections.Generic;

namespace Model
{
    public class ListaCompra
    {
        public int ListaCompraId { get; set; }
        public string ListaCompraNome { get; set; }

        public virtual ICollection<ProdutosLista> ProdutosLista { get; set; }
    }
}
