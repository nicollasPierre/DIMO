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
    class TurmaController
    {
        private static List<Turma> turmas = new List<Turma>();
        private static Turma turmaEditando;

        public static int GetProxId()
        {
            int proxId = 0;
            foreach (Turma turma in turmas)
            {
                if (turma.Id > proxId)
                {
                    proxId = turma.Id + 1;
                }
            }
            return proxId;
        }

        public static void InicializaTurmas(List<Turma> turmasIni)
        {
            turmas = turmasIni;
        }

        public static void AddTurma(Turma turma)
        {
            turmas.Add(turma);
        }

        public static void RemoveTurma(Turma turma)
        {
            turmas.Remove(turma);
        }

        public static void SalvarTurmas()
        {
            //Chama AlunoDAO.SalvarAlunos
        }

        public static void CarregarTurmas()
        {
            //Chama AlunoDAO.CarregarAlunos
        }

        public static List<Turma> ObtemTurmas() { return turmas; }

        public static Turma TurmaEditando
        {
            get { return turmaEditando; }
            set { turmaEditando = value; }
        }
    }
}