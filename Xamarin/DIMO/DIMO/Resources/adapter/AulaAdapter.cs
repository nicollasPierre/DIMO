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

namespace DIMO.Resources.adapter
{
    class AulaAdapter : BaseAdapter<Aula>
    {
        private List<Aula> aulas;
        private Context contexto;

        public AulaAdapter(List<Aula> aulas, Context contexto)
        {
            this.aulas = aulas;
            this.contexto = contexto;
        }

        public override Aula this[int position]
        {
            get
            {
                return aulas[position];
            }
        }

        public override int Count
        {
            get
            {
                return aulas.Count();
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View linha, ViewGroup parent)
        {
            if (linha == null)
            {
                linha = LayoutInflater.From(contexto).Inflate(Resource.Layout.HistoricoAulaItens, null, false);
            }

            //buscar widgets da linha
            TextView lblTurmaAula = linha.FindViewById<TextView>(Resource.Id.lblTurmaAulaListar);
            TextView lblDiaDeAulaAula = linha.FindViewById<TextView>(Resource.Id.lblDiaDeAulaAulaListar);
            Button btnEditarFrequencias = linha.FindViewById<Button>(Resource.Id.btnEditarAulaListar);
            Button btnExcluirAula = linha.FindViewById<Button>(Resource.Id.btnExcluirAulaListar);

            lblTurmaAula.Text = aulas[position].Turma.Materia;
            lblDiaDeAulaAula.Text = string.Format("{0:dd/MM/yyyy}", aulas[position].DiaDeAula);

            btnEditarFrequencias.Click += delegate
            {
                AulaController.AulaEditando = aulas[position];
                contexto.StartActivity(typeof(activity.RegistrarFrequenciaAlunosActivity));
            };

            btnExcluirAula.Click += delegate
            {
                bool excluir = true;

                if (excluir == true)
                {
                    AulaController.RemoveAula(aulas[position]);
                    //this.alunos.Remove(alunos[position]);
                    linha.Visibility = ViewStates.Invisible;
                }
            };

            return linha;
        }
    }
}