using Android.App;
using Android.Widget;
using Android.OS;

namespace DIMO
{
    [Activity(Label = "DIMO", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.MenuPrincipal);

            Button btn_turmas = FindViewById<Button>(Resource.Id.btnTurmas);
            btn_turmas.Click += delegate
            {
                StartActivity(typeof(Resources.controler.TurmasActivity));
            };
            
        }
    }
}

