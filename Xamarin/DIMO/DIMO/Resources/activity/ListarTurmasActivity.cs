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
    [Activity(Label = "Listar Turmas")]
    public class ListarTurmasActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ListarTurmas);

            Button btnVoltar = FindViewById<Button>(Resource.Id.btnVoltarListarTurmas);

            List<Turma> turmas = TurmaController.ObtemTurmas();

            TurmaAdapter turmaAdapter = new TurmaAdapter(turmas, this);
            ListView listaAlunos = FindViewById<ListView>(Resource.Id.lstListarTurmas);
            listaAlunos.Adapter = turmaAdapter;

            btnVoltar.Click += delegate
            {
                this.Finish();
            };
            
        }
    }
}