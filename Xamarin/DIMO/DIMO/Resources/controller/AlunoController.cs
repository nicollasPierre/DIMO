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
    class AlunoController
    {
        private static List<Aluno> alunos = new List<Aluno>();
        private static Aluno alunoEditando;

        public static int GetProxId()
        {
            int proxId = 0;
            foreach (Aluno aluno in alunos)
            {
                if(aluno.Id > proxId)
                {
                    proxId = aluno.Id + 1;
                }
            }
            return proxId;
        }

        public static List<Aluno> ObtemAlunos()
        {
            return alunos;
        }

        public static void AddAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public static void RemoveAluno(Aluno aluno)
        {
            alunos.Remove(aluno);
        }

        public static void SalvarAlunos()
        {
            //Chama AlunoDAO.SalvarAlunos
        }

        public static void CarregarAlunos()
        {
            //Chama AlunoDAO.CarregarAlunos
        }

        public static Aluno AlunoEditando
        {
            get { return alunoEditando; }
            set { alunoEditando = value; }
        }
    }
}