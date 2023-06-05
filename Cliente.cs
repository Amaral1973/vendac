using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Revisao
{
    class Cliente
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string complemento { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Revisao\\DbTop.mdf;Integrated Security=True");

        public List<Cliente> listacliente()
        {
            List<Cliente> li = new List<Cliente>();
            string sql = "SELECT * FROM Cliente";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente cli = new Cliente();
                cli.Id = (int)dr["Id"];
                cli.nome = dr["nome"].ToString();
                cli.celular = dr["celular"].ToString();
                cli.email = dr["email"].ToString();
                cli.cep = dr["cep"].ToString();
                cli.endereco = dr["endereco"].ToString();
                cli.cidade = dr["cidade"].ToString();
                cli.complemento = dr["complemento"].ToString();
                li.Add(cli);
            }
            return li;
        }

        public void Inserir(string nome, string celular, string email, string cep, string endereco, string cidade, string complemento)
        {
            string sql = "INSERT INTO Cliente(nome, celular, email, cep, endereco, cidade, complemento) VALUES ('" + nome + "','" + celular + "','" + email + "','" + cep + "', '"+endereco+"', '"+cidade+"', '"+complemento+"')";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Localiza(int Id)
        {
            string sql = "SELECT * FROM Cliente WHERE Id = '" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                celular = dr["celular"].ToString();
                email = dr["email"].ToString();
                cep = dr["cep"].ToString();
                endereco = dr["endereco"].ToString();
                cidade = dr["cidade"].ToString();
                complemento = dr["complemento"].ToString();
            }
            con.Close();
        }

        public void Atualizar(int Id, string nome, string celular, string email, string cep, string endereco, string cidade, string complemento)
        {
            string sql = "UPDATE Cliente SET nome='" + nome + "', celular='" + celular + "', email='" + email + "', cep='" + cep + "', endereco='"+endereco+"', cidade='"+cidade+"', complemento='"+complemento+"' WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Cliente WHERE Id = '" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public bool RegistroRepetido(string nome, string email)
        {
            string sql = "SELECT * FROM Cliente WHERE nome='" + nome + "' AND email='" + email + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return (int)result > 0;
            }
            con.Close();
            return false;
        }
    }
}
