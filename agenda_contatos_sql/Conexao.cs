using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace agenda_contatos_sql
{
    class Conexao
    {
        public MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3306;database=agenda;User=root;Pwd=password");

        public string conectar()
        {
            try
            {
                con.Open();
                
                return ("Conexão realizada com sucesso");
            }
            catch (MySqlException e)
            {
                //return ("erro de conexão!)
                return (e.ToString());
            }
        }

        public string desconectar()
        {
            try
            {
                con.Close();
                return ("conexão encerrada!");
            }
            catch (MySqlException e)
            {
                //return ("erro de conexão!)
                return (e.ToString());
            }
        }
    }
}
