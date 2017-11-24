using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DIMO.Resources.model;

namespace DIMO.Resources.controller
{
    class AulaController
    {
        private static List<Aula> aulas = new List<Aula>();
        private static Aula aulaEditando = null;

        public static int GetProxId()
        {
            int proxId = 0;
            foreach (Aula aula in aulas)
            {
                if (aula.Id > proxId)
                {
                    proxId = aula.Id + 1;
                }
            }
            return proxId;
        }

        public static void InicializaAulas(List<Aula> aulassIni)
        {
            aulas = aulassIni;
        }

        public static void AddAula(Aula aula)
        {
            aulas.Add(aula);
        }

        public static void RemoveAula(Aula aula)
        {
            aulas.Remove(aula);
        }

        public static List<AlunoAula> AlunosAulaPorTurma(Turma turma)
        {
            List<AlunoAula> alunos = new List<AlunoAula>();
            foreach (Aluno aluno in turma.Alunos)
            {
                AlunoAula alunoAula = new AlunoAula()
                {
                    Aluno = aluno,
                    Presente = false
                };
                alunos.Add(alunoAula);
            }

            return alunos;
        }

        public static void SalvarAulas()
        {
            //Chama AlunoDAO.SalvarAlunos
        }

        public static void CarregarAulas()
        {
            //Chama AlunoDAO.CarregarAlunos
        }

        public static List<Aula> ObtemAulas()
        {
            return aulas;
        }

        public static Aula AulaEditando
        {
            get { return aulaEditando; }
            set { aulaEditando = value; }
        }
    }
}