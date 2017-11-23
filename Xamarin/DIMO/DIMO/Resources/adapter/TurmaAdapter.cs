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
    class TurmaAdapter : BaseAdapter<Turma>
    {
        private List<Turma> turmas;
        private Context contexto;

        public TurmaAdapter(List<Turma> turmas, Context contexto)
        {
            this.turmas = turmas;
            this.contexto = contexto;
        }

        public override Turma this[int position]
        {
            get
            {
                return turmas[position];
            }
        }

        public override int Count
        {
            get
            {
                return turmas.Count();
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
                linha = LayoutInflater.From(contexto).Inflate(Resource.Layout.ListarTurmasItens, null, false);
            }

            //buscar widgets da linha
            TextView lblMateriaTurma = linha.FindViewById<TextView>(Resource.Id.lblMateriaTurmaListar);
            Button btnEditarTurma = linha.FindViewById<Button>(Resource.Id.btnEditarTurmaListar);
            Button btnExcluirTurma = linha.FindViewById<Button>(Resource.Id.btnExcluirTurmaListar);

            lblMateriaTurma.Text = turmas[position].Materia;
            btnEditarTurma.Click += delegate
            {
                if (TurmaController.TurmaEditando == null)
                {
                    TurmaController.TurmaEditando = turmas[position];
                    contexto.StartActivity(typeof(Resources.activity.CadastrarTurmasActivity));
                }
            };

            btnExcluirTurma.Click += delegate
            {
                bool excluir = true;

                if (excluir == true)
                {
                    TurmaController.RemoveTurma(turmas[position]);
                    //this.alunos.Remove(alunos[position]);
                    linha.Visibility = ViewStates.Invisible;
                }
            };

            return linha;
        }
    }
}