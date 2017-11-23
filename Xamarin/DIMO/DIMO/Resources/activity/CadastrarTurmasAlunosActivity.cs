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
using DIMO.Resources.controller;
using DIMO.Resources.model;
using DIMO.Resources.adapter;

namespace DIMO.Resources.activity
{
    [Activity(Label = "Cadastrar Alunos da Turma")]
    public class CadastrarTurmasAlunosActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CadastrarTurmasAlunos);

            Spinner spnAlunos = FindViewById<Spinner>(Resource.Id.spnAlunos);

            List<Aluno> todosAlunos = AlunoController.ObtemAlunos();
            List<string> nomesAlunos = new List<string>();
            List<Aluno> alunosAdicionados = TurmaController.TurmaEditando.Alunos;

            foreach(Aluno aluno in todosAlunos)
            {
                nomesAlunos.Add(aluno.Nome);
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, nomesAlunos);

            spnAlunos.Adapter = adapter;

            Button btnAdicionarAluno = FindViewById<Button>(Resource.Id.btnAdicionarAluno);

            AlunoTurmaAdapter alunoTurma = new AlunoTurmaAdapter(alunosAdicionados, this);
            ListView listaAlunos = FindViewById<ListView>(Resource.Id.lstListarAlunosTurma);
            listaAlunos.Adapter = alunoTurma;

            btnAdicionarAluno.Click += delegate
            {
                if (spnAlunos.SelectedItemPosition != -1)
                {
                    if (alunosAdicionados.Contains(todosAlunos[spnAlunos.SelectedItemPosition]))
                    {
                        Toast.MakeText(ApplicationContext, "Este aluno já foi adicionado.", ToastLength.Long).Show();
                    }
                    else
                    {
                        alunosAdicionados.Add(todosAlunos[spnAlunos.SelectedItemPosition]);

                        alunoTurma = new AlunoTurmaAdapter(alunosAdicionados, this);
                        listaAlunos = FindViewById<ListView>(Resource.Id.lstListarAlunosTurma);
                        listaAlunos.Adapter = alunoTurma;
                    }
                }
            };

            Button btnSalvarVoltar = FindViewById<Button>(Resource.Id.btnSalvarTurmasAlunos);

            btnSalvarVoltar.Click += delegate
            {
                this.Finish();
            };
        }
    }
}