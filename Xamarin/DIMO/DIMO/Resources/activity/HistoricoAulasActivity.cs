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
using DIMO.Resources.adapter;
using DIMO.Resources.controller;

namespace DIMO.Resources.activity
{
    [Activity(Label = "Historico de Aulas")]
    public class HistoricoAulasActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.HistoricoAulas);

            Button btnVoltar = FindViewById<Button>(Resource.Id.btnVoltarHistoricoAulas);

            btnVoltar.Click += delegate
            {
                this.Finish();
            };

            AulaAdapter aulaAdapter = new AulaAdapter(AulaController.ObtemAulas(), this);
            ListView listaAlunos = FindViewById<ListView>(Resource.Id.lstHistoricoAulas);
            listaAlunos.Adapter = aulaAdapter;
        }
    }
}