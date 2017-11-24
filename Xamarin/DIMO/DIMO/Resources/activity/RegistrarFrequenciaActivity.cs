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
using Java.Util;
using Com.Wdullaer.Materialdatetimepicker.Date;
using DIMO.Resources.controller.dao;

namespace DIMO.Resources.activity
{
    [Activity(Label = "Registrar Frequencia")]
    public class RegistrarFrequenciaActivity : Activity, Com.Wdullaer.Materialdatetimepicker.Date.DatePickerDialog.IOnDateSetListener
    {
        TextView lblDataAula;

        public void OnDateSet(Com.Wdullaer.Materialdatetimepicker.Date.DatePickerDialog p0, int year, int month, int day)
        {
            lblDataAula.Text = string.Format("{0:dd/MM/yyyy}", new DateTime(year, month, day));
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.RegistrarFrequencia);

            Button btnVoltar = FindViewById<Button>(Resource.Id.btnVoltarRegistrarFrequencia);

            btnVoltar.Click += delegate
            {
                this.Finish();
            };
                        
            Spinner spnTurmas = FindViewById<Spinner>(Resource.Id.spnTurmasRegistrarFrequencia);

            List<Turma> todasTurmas = TurmaController.ObtemTurmas();
            List<string> materiasTurmas = new List<string>();

            foreach (Turma turma in todasTurmas)
            {
                materiasTurmas.Add(turma.Materia);
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, materiasTurmas);
            spnTurmas.Adapter = adapter;

            lblDataAula = FindViewById<TextView>(Resource.Id.lblDataRegistrarFrequencia);

            lblDataAula.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now);

            lblDataAula.Click += delegate
            {
                Calendar now = Calendar.Instance;
                Com.Wdullaer.Materialdatetimepicker.Date.DatePickerDialog datePicker = Com.Wdullaer.Materialdatetimepicker.Date.DatePickerDialog.NewInstance(
                    this, now.Get(CalendarField.Year), now.Get(CalendarField.Month), now.Get(CalendarField.DayOfMonth));
                datePicker.SetTitle("Escolha Data");
                datePicker.Show(FragmentManager, "Escolha Data");
            };

            Button btnRegistrarFrequenciaAlunos = FindViewById<Button>(Resource.Id.btnRegistrarFrequenciaAlunos);

            btnRegistrarFrequenciaAlunos.Click += delegate
            {
                if (spnTurmas.SelectedItemPosition > -1 && AulaController.AulaEditando.Turma != todasTurmas[spnTurmas.SelectedItemPosition])
                {
                    AulaController.AulaEditando.Turma = todasTurmas[spnTurmas.SelectedItemPosition];
                }

                if (AulaController.AulaEditando.Alunos == null)
                {
                    AulaController.AulaEditando.Alunos = AulaController.AlunosAulaPorTurma(AulaController.AulaEditando.Turma);
                }
                StartActivity(typeof(RegistrarFrequenciaAlunosActivity));
            };

            AulaController.AulaEditando = new Aula()
            {
                Id = AulaController.GetProxId()
                
            };

            Button btnSalvarRegistrarFrequencia = FindViewById<Button>(Resource.Id.btnSalvarRegistrarFrequencia);

            btnSalvarRegistrarFrequencia.Click += delegate
            {
                if (spnTurmas.SelectedItemPosition == -1)
                {
                    Toast.MakeText(ApplicationContext, "Não foi selecionada uma turma.", ToastLength.Long).Show();
                }
                else if (AulaController.AulaEditando.DiaDeAula == null)
                {
                    Toast.MakeText(ApplicationContext, "Não foi selecionada uma data.", ToastLength.Long).Show();
                }
                else
                {
                    if (lblDataAula.Text != string.Empty)
                    {
                        AulaController.AulaEditando.DiaDeAula = DateTime.ParseExact(lblDataAula.Text, "dd/MM/yyyy",
                                                                System.Globalization.CultureInfo.InvariantCulture);
                    }

                    if (spnTurmas.SelectedItemPosition > -1)
                    {
                        AulaController.AulaEditando.Turma = (todasTurmas[spnTurmas.SelectedItemPosition]);
                    }

                    AulaController.AddAula(AulaController.AulaEditando);
                    AulaController.AulaEditando = null;
                    Toast.MakeText(ApplicationContext, "Aula salva com sucesso.", ToastLength.Long).Show();
                    MainDAO.SalvarTudo();
                    this.Finish();
                }

            };
        }
    }
}