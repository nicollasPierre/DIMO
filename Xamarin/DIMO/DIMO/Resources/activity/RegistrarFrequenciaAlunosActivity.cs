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
using DIMO.Resources.adapter;

namespace DIMO.Resources.activity
{
    [Activity(Label = "Registrar Frequencia dos Alunos")]
    public class RegistrarFrequenciaAlunosActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.RegistrarFrequenciaAlunos);

            AlunoAulaAdapter alunoAulaAdapter = new AlunoAulaAdapter(AulaController.AulaEditando.Alunos, this);
            ListView listaAlunosFrequencia = FindViewById<ListView>(Resource.Id.lstListarAlunosRegistrarFrequencia);
            listaAlunosFrequencia.Adapter = alunoAulaAdapter;

            Button btnSalvarVoltar = FindViewById<Button>(Resource.Id.btnSalvarAlunosRegistrarFrequencia);

            btnSalvarVoltar.Click += delegate
            {
                this.Finish();
            };
        }
    }
}