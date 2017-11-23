using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIMO.Resources.model
{
    class Aluno
    {
        private int id;
        private string nome;
        private string endereco;
        private string telefone;
        private string cpf;
        private string rg;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }

        public string ToString()
        {
            return "\"Aluno\"{" +
                    "\"ID\":" + id +
                    ", \"nome\":\"" + nome + '\"' +
                    ", \"endereco\":\"" + endereco + '\"' +
                    ", \"telefone\":\"" + telefone + '\"' +
                    ", \"CPF\":\"" + cpf + '\"' +
                    ", \"RG\":\"" + rg + '\"' +
                    '}';
        }

    }
}