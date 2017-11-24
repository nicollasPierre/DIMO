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

namespace DIMO.Resources.adapter
{
    class AlunoAulaAdapter : BaseAdapter<AlunoAula>
    {
        private List<AlunoAula> alunosDaAula;
        private Context contexto;

        public AlunoAulaAdapter(List<AlunoAula> alunosDaAula, Context contexto)
        {
            this.alunosDaAula = alunosDaAula;
            this.contexto = contexto;
        }

        public override AlunoAula this[int position]
        {
            get
            {
                return alunosDaAula[position];
            }
        }

        public override int Count
        {
            get
            {
                return alunosDaAula.Count();
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
                linha = LayoutInflater.From(contexto).Inflate(Resource.Layout.RegistrarFrequenciaAlunosItens, null, false);
            }

            //buscar widgets da linha
            TextView txtNomeAluno = linha.FindViewById<TextView>(Resource.Id.lblNomeAlunoRegistrarFrequencia);
            Switch chkPresencaAluno = linha.FindViewById<Switch>(Resource.Id.chkPresenteAlunoRegistrarFrequencia);

            txtNomeAluno.Text = alunosDaAula[position].Aluno.Nome;
            chkPresencaAluno.Checked = alunosDaAula[position].Presente;

            chkPresencaAluno.CheckedChange += delegate
            {
                alunosDaAula[position].Presente = chkPresencaAluno.Checked;
            };

            return linha;
        }
    }
}