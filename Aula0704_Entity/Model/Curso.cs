using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Curso
    {
        public Curso() {}

        public int? id { get; set; }
        public int codigo { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        public ICollection<Matricula> matriculas { get; set; }
    }
}
