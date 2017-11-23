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

namespace DIMO.Resources.activity
{
    [Activity(Label = "Turmas")]
    public class TurmasActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Turmas);

            Button btnCadastrarTurmas = FindViewById<Button>(Resource.Id.btnCadastrarTurma);
            Button btnListarTurmas = FindViewById<Button>(Resource.Id.btnListarTurmas);
            Button btnVoltar = FindViewById<Button>(Resource.Id.btnVoltarTurmas);

            btnCadastrarTurmas.Click += delegate
            {
                StartActivity(typeof(CadastrarTurmasActivity));
            };

            btnListarTurmas.Click += delegate
            {
                StartActivity(typeof(ListarTurmasActivity));
            };

            btnVoltar.Click += delegate
            {
                this.Finish();
            };
        }
    }
}