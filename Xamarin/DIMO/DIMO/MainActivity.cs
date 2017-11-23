using Android.App;
using Android.Widget;
using Android.OS;
using DIMO.Resources.controller.dao;

namespace DIMO
{
    [Activity(Label = "DIMO", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.MenuPrincipal);

            MainDAO.CarregarTudo();

            Button btnAlunos = FindViewById<Button>(Resource.Id.btnAlunos);
            Button btnTurmas = FindViewById<Button>(Resource.Id.btnTurmas);
            Button btnAulas = FindViewById<Button>(Resource.Id.btnAulas);

            btnAlunos.Click += delegate
            {
                StartActivity(typeof(Resources.activity.AlunosActivity));
            };

            btnTurmas.Click += delegate
            {
                StartActivity(typeof(Resources.activity.TurmasActivity));
            };

            btnAulas.Click += delegate
            {
                StartActivity(typeof(Resources.activity.AulasActivity));
            };

            
        }
    }
}

