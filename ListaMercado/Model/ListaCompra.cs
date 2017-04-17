using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListaCompra
    {
        public int ListaCompraId { get; set; }
        public string NomeLista { get; set; }

        public virtual ICollection<ProdutosLista> ProdutosLista { get; set; }
    }
}
