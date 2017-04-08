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


        public int Id{ get; set; }

        public int idCurso { get; set; }
        public virtual Curso _Curso { get; set; }

        public int idAluno { get; set; }
        public virtual Aluno _Aluno { get; set; }

        public DateTime data { get; set; }
    }
}
