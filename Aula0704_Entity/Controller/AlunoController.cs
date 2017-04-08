using Model;
using Model.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AlunoController
    {
        private static Context context = new Context();
        public static BindingList<Aluno> alunoList = new BindingList<Aluno>();

        public AlunoController() { }

        /*Métodos Banco de dados*/
        public static void adicionar(Aluno aluno)
        {
            context.Alunos.Add(aluno);
            context.SaveChanges();
        }

        private static Aluno BuscarPorIdBanco(int id) 
        {
            return context.Alunos.Find(id);
        }

        public static void EditarBanco(Aluno aluno) {
            context.Entry(aluno).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void ExcluirBanco(int id) 
        {
            Aluno a = BuscarPorIdBanco(id);
            if (a != null) 
            {
                context.Entry(a).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public static List<Aluno> ListarTodosBanco() 
        {
            return context.Alunos.ToList();
        }
        /*Métodos Banco de dados*/


        public void editar(int id, string nome, string cpf)
        {
            Aluno aluno = buscarAluno(id);

            if (aluno != null)
            {
                aluno.id = id;
                aluno.nome = nome;
                aluno.cpf = cpf;
            }
        }

        public void remover(int id)
        {
            foreach (Aluno aluno in alunoList)
            {
                if (aluno.id == id)
                {
                    alunoList.Remove(aluno);
                    break;
                }
            }
        }

        public Aluno listarItem(int id)
        {
            return buscarAluno(id);
        }

        public BindingList<Aluno> retornarLista()
        {
            return alunoList;
        }

        private Aluno buscarAluno(int id)
        {
            foreach (Aluno aluno in alunoList)
            {
                if (aluno.id == id)
                {
                    return aluno;
                }
            }
            return null;
        }
    }
}

