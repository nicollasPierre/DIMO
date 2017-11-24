using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIMO.Resources.model
{
    class Aula
    {
        private int id;
        private DateTime diaDeAula;
        private Turma turma;
        List<AlunoAula> alunos;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DiaDeAula
        {
            get { return diaDeAula; }
            set { diaDeAula = value; }
        }

        public Turma Turma
        {
            get { return turma; }
            set { turma = value; }
        }

        public List<AlunoAula> Alunos
        {
            get { return alunos; }
            set { alunos = value; }
        }
    }
}