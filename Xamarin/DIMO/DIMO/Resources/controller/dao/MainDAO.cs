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
using Android.Graphics;
using Newtonsoft.Json;
using System.IO;

namespace DIMO.Resources.controller.dao
{
    class MainDAO
    {
        static string arquivoSave = System.IO.Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, "dados.txt");

        public static void SalvarTudo()
        {
            SalvarTudo(AlunoController.ObtemAlunos(), TurmaController.ObtemTurmas(), AulaController.ObtemAulas());
        }

        public static void SalvarTudo(List<Aluno> alunos, List<Turma> turmas, List<Aula> aulas)
        {
            Dados tudo = new Dados()
            {
                Alunos = alunos,
                Turmas = turmas,
                Aulas = aulas
            };

            if (!File.Exists(arquivoSave))
            {
                File.Create(arquivoSave);
            }
            string dados = JsonConvert.SerializeObject(tudo);

            StreamWriter escritor = new StreamWriter(arquivoSave, false);
            escritor.Write(dados);
            escritor.Close();
        }

        public static void CarregarTudo()
        {
            if (File.Exists(arquivoSave))
            {
                StreamReader leitor = new StreamReader(arquivoSave);
                string jsonInteiro = leitor.ReadToEnd();
                leitor.Close();

                if (jsonInteiro.Trim() != string.Empty)
                {
                    Dados tudo = JsonConvert.DeserializeObject<Dados>(jsonInteiro);

                    if (tudo != null)
                    {

                        AlunoController.InicializaAlunos(tudo.Alunos);
                        TurmaController.InicializaTurmas(tudo.Turmas);
                        AulaController.InicializaAulas(tudo.Aulas);
                    }
                }
            }
        }
    }

    class Dados
    {
        List<Aluno> alunos;
        List<Turma> turmas;
        List<Aula> aulas;

        public List<Aluno> Alunos
        {
            get { return alunos; }
            set { alunos = value; }
        }

        public List<Turma> Turmas
        {
            get { return turmas; }
            set { turmas = value; }
        }

        public List<Aula> Aulas
        {
            get { return aulas; }
            set { aulas = value; }
        }
    }
}