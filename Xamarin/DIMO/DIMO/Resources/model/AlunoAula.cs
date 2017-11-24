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

namespace DIMO.Resources.model
{
    class AlunoAula
    {
        int id;
        Aluno aluno;
        bool presente;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Aluno Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }

        public bool Presente
        {
            get { return presente; }
            set { presente = value; }
        }
    }
}