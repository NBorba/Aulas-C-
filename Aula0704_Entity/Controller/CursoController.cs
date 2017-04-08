using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CursoController
    {
        public static BindingList<Curso> cursoList = new BindingList<Curso>();

        public CursoController() {}

        public void adicionar(int cod, string nome, string desc) {
            Curso curso = new Curso();
            curso.id = cursoList.Count + 1;
            curso.codigo = cod;
            curso.nome = nome;
            curso.descricao = desc;

            cursoList.Add(curso);
        }

        public void editar(int? id, int cod, string nome, string desc) {
            Curso curso = buscarCurso(id);

            if (curso != null) {
                curso.id = id;
                curso.codigo = cod;
                curso.nome = nome;
                curso.descricao = desc;
            }  
        }

        public void remover(int? id) {
            foreach (Curso curso in cursoList) {
                if (curso.id == id) {
                    cursoList.Remove(curso);
                    break;
                }
            }
        }

        public BindingList<Curso> retornarLista()
        {
            return cursoList;
        }

        public Curso listarItem(int? id) {
            return buscarCurso(id);
        }

        private Curso buscarCurso(int? id) {
            foreach (Curso curso in cursoList) {
                if (curso.id == id) {
                    return curso;
                }
            }
            return null;
        }
    }
}
