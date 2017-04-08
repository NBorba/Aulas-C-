using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Model.DAL
{
    public class Context : DbContext 
    {
        public Context() : base("strConn") 
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
    }
}
