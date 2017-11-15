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
using System.IO;
using Mono.Data.Sqlite;

namespace DIMO.Resources.controler.dao
{
    static class CriarBD
    {
        #region dados BD
        private static string banco_dados;
        private static string path_dados;
        #endregion
        public static void criaBD()
        {
            path_dados = Path.Combine(Environment.ExternalStorageDirectory.AbsolutePath, "DIMO_BD");
            if (!Directory.Exists(path_dados))
            {
                Directory.CreateDirectory(path_dados);
            }

            banco_dados = Path.Combine(path_dados, "base_dados.db");

            if (!File.Exists(banco_dados))
            {
                SqliteConnection.CreateFile(banco_dados);

                SqliteConnection ligacao = new SqliteConnection("Data Source = " + banco_dados + "; Version = 3");
                ligacao.Open();

                SqliteCommand comando = new SqliteCommand(ligacao);

                comando.commandText = DIMO.Resources.controler.dao.AlunoContract.CREATE_TABLE_SQL;

                comando.ExecuteNonQuery();


                ligacao.Close();
                ligacao.Dispose();
            }

            
        }

        public string inserirDados(Aluno aluno)
        {
           

            if (resultado == -1)
            {
                return "Erro ao inserir registro na tabela Alunos";
            }
            else
            {
                return "Registro inserido com sucesso na tabela Alunos";
            }
        }

        public Object buscarDados(String where, String groupBy, String having, String orderBy, String limit)
        {
            
        }

        public void alterarDados(Aluno aluno)
        {
            
        }

        public int excluirDados(int id)
        {

        }


    }
}