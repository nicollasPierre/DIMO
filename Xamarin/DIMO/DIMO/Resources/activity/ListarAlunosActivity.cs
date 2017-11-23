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
using DIMO.Resources.controller;
using DIMO.Resources.adapter;

namespace DIMO.Resources.activity
{
    [Activity(Label = "Listar Alunos")]
    public class ListarAlunosActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ListarAlunos);

            AlunoController.AlunoEditando = null;
            List<Aluno> alunos = AlunoController.ObtemAlunos();

            Button btnVoltar = FindViewById<Button>(Resource.Id.btnVoltarListarAlunos);

            AlunoAdapter alunoAdapter = new AlunoAdapter(alunos, this);
            ListView listaAlunos = FindViewById<ListView>(Resource.Id.lstListarAlunos);
            listaAlunos.Adapter = alunoAdapter;

            btnVoltar.Click += delegate
            {
                this.Finish();
            };
        }
    }
}