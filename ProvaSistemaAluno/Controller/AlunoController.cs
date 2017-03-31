using Model;
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
        public static BindingList<Aluno> alunoList = new BindingList<Aluno>();

        public AlunoController() { }

        public void adicionar(string nome, string cpf)
        {
            Aluno aluno = new Aluno();
            aluno.id = alunoList.Count + 1;
            aluno.nome = nome;
            aluno.cpf = cpf;

            alunoList.Add(aluno);
        }

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

        public void listarItem(int id)
        {
            buscarAluno(id);
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

