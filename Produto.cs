using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.ConstrainedExecution;

namespace Revisao
{
    class Produto
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public string fabricante { get; set; }
        public string plataforma { get; set; }
        public int quantidade { get; set; }
        public string valor { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Revisao\\DbTop.mdf;Integrated Security=True");

        public List<Produto> listaprodutos()
        {
            List<Produto> li = new List<Produto>();
            string sql = "SELECT * FROM Produtos";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Produto prod = new Produto();
                prod.Id = (int)dr["Id"];
                prod.nome = dr["nome"].ToString();
                prod.tipo = dr["tipo"].ToString();
                prod.fabricante = dr["fabricante"].ToString();
                prod.plataforma = dr["plataforma"].ToString();
                prod.quantidade = (int)dr["quantidade"];
                prod.valor = dr["valor"].ToString();
                li.Add(prod);
            }
            return li;
        }

        public void Inserir(string nome, string tipo, string desenvolvedora, string plataforma, int quantidade, string valor)
        {
            string sql = "INSERT INTO Produtos(nome, tipo, fabricante, plataforma, quantidade, valor) VALUES ('" + nome + "','" + tipo + "','" + desenvolvedora + "','" + plataforma + "', '" + quantidade + "', '"+valor+"')";
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
            string sql = "SELECT * FROM Produtos WHERE Id = '" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                tipo = dr["tipo"].ToString();
                fabricante = dr["fabricante"].ToString();
                plataforma = dr["plataforma"].ToString();
                quantidade = (int)dr["quantidade"];
                valor = dr["valor"].ToString();
            }
            con.Close();
        }

        public void Atualizar(int Id, string nome, string tipo, string desenvolvedora, string plataforma, int quantidade, string valor)
        {
            string sql = "UPDATE Produtos SET nome='" + nome + "', tipo='" + tipo + "', fabricante='" + desenvolvedora + "', plataforma='" + plataforma + "', quantidade='" + quantidade + "', valor='"+valor+"' WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Produtos WHERE Id = '" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public bool RegistroRepetido(string nome, string desenvolvedora)
        {
            string sql = "SELECT * FROM Produtos WHERE nome='" + nome + "' AND fabricante='" + desenvolvedora + "'";
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
