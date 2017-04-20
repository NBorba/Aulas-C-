using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Moeda 
    {
        public int MoedaId { get; set; }
        public string NomeMoeda { get; set; }
        public float Valor { get; set; }
        public string DataAtualizacao { get; set; }
    }
}
