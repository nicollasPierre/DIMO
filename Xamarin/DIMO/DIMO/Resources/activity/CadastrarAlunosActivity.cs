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
using DIMO.Resources.controller.dao;

namespace DIMO.Resources.activity
{
    [Activity(Label = "Cadastrar Aluno")]
    public class CadastrarAlunosActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CadastrarAlunos);

            Button btnVoltar = FindViewById<Button>(Resource.Id.btnVoltarCadastraAluno);
            Button btnSalvar = FindViewById<Button>(Resource.Id.btnSalvarAluno);

            EditText txtNome = FindViewById<EditText>(Resource.Id.txtAlunoNome);
            EditText txtEndereco = FindViewById<EditText>(Resource.Id.txtEnderecoAluno);
            EditText txtCPF = FindViewById<EditText>(Resource.Id.txtCPFAluno);
            EditText txtRG = FindViewById<EditText>(Resource.Id.txtRGAluno);

            if (AlunoController.AlunoEditando != null)
            {
                txtNome.Text = AlunoController.AlunoEditando.Nome;
                txtEndereco.Text = AlunoController.AlunoEditando.Endereco;
                txtCPF.Text = AlunoController.AlunoEditando.CPF;
                txtRG.Text = AlunoController.AlunoEditando.RG;
            }

            btnVoltar.Click += delegate
            {
                this.Finish();
            };

            btnSalvar.Click += delegate
            {
                if (txtNome.Text.Trim() == string.Empty)
                {
                    Toast.MakeText(ApplicationContext, "Campo Nome é obrigatório.", ToastLength.Long).Show();
                }
                else
                {
                    if (AlunoController.AlunoEditando == null)
                    {
                        Aluno novo = new Aluno()
                        {
                            Id = AlunoController.GetProxId(),
                            Nome = txtNome.Text,
                            Endereco = txtEndereco.Text,
                            CPF = txtCPF.Text,
                            RG = txtRG.Text
                        };
                        AlunoController.AddAluno(novo);
                        Toast.MakeText(ApplicationContext, "Cadastrado Aluno com sucesso.", ToastLength.Long).Show();
                    }
                    else
                    {
                        AlunoController.AlunoEditando.Nome = txtNome.Text;
                        AlunoController.AlunoEditando.Endereco = txtEndereco.Text;
                        AlunoController.AlunoEditando.CPF = txtCPF.Text;
                        AlunoController.AlunoEditando.RG = txtRG.Text;
                        AlunoController.AlunoEditando = null;
                    }

                    MainDAO.SalvarTudo();
                    this.Finish();
                }
            };
        }
    }
}