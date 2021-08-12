using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace agenda_contatos_sql
{
    class Controle_contato
    {
        Conexao c = new Conexao();
        Contato cont = new Contato();

        public string cadastrar(Contato cont)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO contato (nome, celular, email)" +
                    "VALUES ('" + cont.Nome + "', '" + cont.Celular + "', '" + cont.Email + "')", c.con);

                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return ("cadastro realizado com sucesso!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string alterar(Contato cont)
        {
            try
            {
                string sql = "update contato set nome = '" + cont.Nome + "'," + "celular='" + cont.Celular + "', " + "email ='" + cont.Email +
                    "'where codcontato = " + cont.Codcontato + ";";



                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return ("Dados alterados com sucesso.");

            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string excluir(Contato cont)
        {
            try
            {
                string sql = "delete from contato where codcontato = " + cont.Codcontato + ";" ;


                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return ("Dados deletados com sucesso.");

            }
            catch (MySqlException e)
            {
                return (e.ToString());

            }
        }

        public Contato busca(int codigo)
        {
            

            try
            {

                string sql = "select * from contato where codcontato = " + codigo + ";";
                MySqlCommand cmd = new MySqlCommand(sql, c.con);

                c.conectar();

                MySqlDataReader objDados = cmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    return null;
                }
                else
                {
                    objDados.Read();
                    cont.Codcontato = Convert.ToInt32(objDados["codcontato"]);
                    cont.Nome = objDados["nome"].ToString();
                    cont.Celular = objDados["celular"].ToString();
                    cont.Email = objDados["email"].ToString();

                    objDados.Close();
                    return cont;

                }

            }
            catch (MySqlException e)
            {
                throw (e);
            }
            finally
            {
                c.desconectar();
            }


        }
        public DataTable pesquisaCodigo (int codigo)
        {
            string sql = "select codcontato as 'Código', nome as Nome, celular as Celular,"
                 + "email as Email from contato where codcontato =" + codigo + ";";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
                da.Fill(contato);
            c.desconectar();
            return contato;
        }
       
        //Nesse método usamos string por se referir a um objeto cujo valor é um texto. 
        //Para pesquisarmos no banco de dados usamos o comando select junto com "like", pois assim poderemos
        //pesquisar por letras também, caso não lembramos do nome exato ou caso lembramos apenas do primeiro nome ou sobrenome.
        public DataTable pesquisnome(string nome)
        {
            string sql = "select codcontato as 'Código', nome as Nome, celular as Celular, email as Email,"
                 + " nome as Nome from contato where nome like '%" + nome + "%'";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;

        }
        public DataTable pesquisaCelular(string celular)
        {
            string sql = "select codcontato as 'Código', nome as Nome, email as Email, " +
                "celular as Celular from contato where celular like '%" + celular + "%'";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;

        }
        public DataTable pesquisaEmail(string email)
        {
            string sql = "select codcontato as 'Código', nome as Nome, celular as Celular, " 
                + " email as Email from contato where email like '%" + email + "%'";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;

        }
        
        
        public DataTable PreencherTodos()
        {
            string sql = "select codcontato as 'Código', nome as Nome, celular as Celular," +
                "" + "email as Email from contato; ";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);

            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public string Backup (string Caminho)
        {
            string dataAtual = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string CaminhoBackup = Caminho + "\\BACKUP" + dataAtual + ".sql";

            try
            {
                MySqlCommand cmd = new MySqlCommand(CaminhoBackup, c.con);
                MySqlBackup mb = new MySqlBackup(cmd);
                c.conectar();
                mb.ExportToFile(CaminhoBackup);
                c.desconectar();
                return ("Backup do bancdo de dados realizado com sucesso!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }


        public string Restore(string Caminho)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(Caminho, c.con);
                MySqlBackup mb = new MySqlBackup(cmd);
                c.conectar();
                mb.ImportFromFile(Caminho);
                c.desconectar();
                return ("Banco de dados restaurado com sucesso!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }


    }





}
