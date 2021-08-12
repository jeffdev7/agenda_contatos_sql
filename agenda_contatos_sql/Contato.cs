using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace agenda_contatos_sql
{
    class Contato
    {
        private int codcontato;
        private string nome;

        private string celular;
        private string email;

        public int Codcontato { get => codcontato; set => codcontato = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
    }
}

