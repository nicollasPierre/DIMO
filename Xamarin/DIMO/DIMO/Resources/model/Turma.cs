using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIMO.Resources.model
{
    class Turma
    {
        private int id;
        private string materia;
		List<Aluno> alunos = new List<Aluno>();

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
		
		public List<Aluno> Alunos
        {
            get { return alunos; }
            set { alunos = value; }
        }

        public void AddAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public bool RemoveAlunoById(int idAluno)
        {
            //List<Aluno> listAlunoRemover = alunos.Where(x => x.Id == idAluno).ToList<Aluno>();

            //if (listAlunoRemover.Count == 0) return false;
            //else alunos.Remove(listAlunoRemover[0]);

            //return true;

            Aluno alunoRemover = null;

            foreach (Aluno aluno in alunos)
            {
                if (aluno.Id == idAluno)
                {
                    alunoRemover = aluno;
                    break;
                }
            }

            if (alunoRemover == null) return false;
            else alunos.Remove(alunoRemover);

            return true;
        }
    }
}