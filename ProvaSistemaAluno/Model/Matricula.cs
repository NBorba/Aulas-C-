using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Matricula
    {
        public Matricula() {}

        private int idMatricula { get; set; }
        private int idAluno { get; set; }
        private int idCurso { get; set; }
        private DateTime data { get; set; }
    }
}
