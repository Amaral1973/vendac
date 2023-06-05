using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Revisao
{
    public partial class FrmVendas : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Revisao\\DbTop.mdf;Integrated Security=True");

        public FrmVendas()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregaCbxCliente()
        {
            string cli = "SELECT Id,nome FROM Cliente";
            SqlCommand cmd = new SqlCommand(cli, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cli, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            cbxCliente.ValueMember = "Id";
            cbxCliente.DisplayMember = "nome";
            cbxCliente.DataSource = ds.Tables["cliente"];
            con.Close();
        }

        private void CarregaCbxProduto()
        {
            string prod = "SELECT Id, nome FROM Produtos";
            SqlCommand cmd = new SqlCommand(prod, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(prod, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "produto");
            cbxProdutos.ValueMember = "Id";
            cbxProdutos.DisplayMember = "nome";
            cbxProdutos.DataSource = ds.Tables["produto"];
            con.Close();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            cbxCliente.Enabled = false;
            cbxProdutos.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            btnInserirItem.Enabled = false;
            btnEditarItem.Enabled = false;
            btnExcluirVenda.Enabled = false;
            txtIdProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            cbxCliente.Enabled = true;
            CarregaCbxCliente();
            cbxProdutos.Enabled = true;
            CarregaCbxProduto();
            btnFinalizarVenda.Enabled = true;
            btnInserirItem.Enabled = true;
            btnEditarItem.Enabled = true;
            btnExcluirVenda.Enabled = true;
            txtIdProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;
            dgvVenda.Columns.Add("ID", "ID");
            dgvVenda.Columns.Add("Produto", "Produto");
            dgvVenda.Columns.Add("Quantidade", "Quantidade");
            dgvVenda.Columns.Add("Valor", "Valor");
            dgvVenda.Columns.Add("Total", "Total");
        }

        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Produtos WHERE Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", cbxProdutos.SelectedValue);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtValor.Text = dr["valor"].ToString();
                txtIdProduto.Text = dr["Id"].ToString();
                txtQuantidade.Focus();
                dr.Close();
            }
            con.Close();
        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            var repetido = false;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                if (txtIdProduto.Text == Convert.ToString(dr.Cells[0].Value))
                {
                    repetido = true;
                }
            }
            if (repetido == false)
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvVenda);
                item.Cells[0].Value = txtIdProduto.Text;
                item.Cells[1].Value = cbxProdutos.Text;
                item.Cells[2].Value = txtQuantidade.Text;
                item.Cells[3].Value = txtValor.Text;
                item.Cells[4].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                dgvVenda.Rows.Add(item);
                txtIdProduto.Text = "";
                cbxProdutos.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvVenda.Rows)
                {
                    soma += Convert.ToDecimal(dr.Cells[4].Value);
                    txtTotalGeral.Text = Convert.ToString(soma);
                }
            }
            else
            {
                MessageBox.Show("Produto já está inserido na venda!!");
            }
        }

        private void dgvVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvVenda.Rows[e.RowIndex];
            cbxProdutos.Text = row.Cells[1].Value.ToString();
            txtIdProduto.Text = row.Cells[0].Value.ToString();
            txtQuantidade.Text = row.Cells[2].Value.ToString();
            txtValor.Text = row.Cells[3].Value.ToString();
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            int linha = dgvVenda.CurrentRow.Index;
            dgvVenda.Rows[linha].Cells[0].Value = txtIdProduto.Text;
            dgvVenda.Rows[linha].Cells[1].Value = cbxProdutos.Text;
            dgvVenda.Rows[linha].Cells[2].Value = txtQuantidade.Text;
            dgvVenda.Rows[linha].Cells[3].Value = txtValor.Text;
            dgvVenda.Rows[linha].Cells[4].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
            txtIdProduto.Text = "";
            cbxProdutos.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                soma += Convert.ToDecimal(dr.Cells[4].Value);
                txtTotalGeral.Text = Convert.ToString(soma);
            }
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            int linha = dgvVenda.CurrentRow.Index;
            dgvVenda.Rows.RemoveAt(linha);
            dgvVenda.Refresh();
            txtIdProduto.Text = "";
            cbxProdutos.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                soma += Convert.ToDecimal(dr.Cells[4].Value);
                txtTotalGeral.Text = Convert.ToString(soma);
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("InserirVenda", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcliente", SqlDbType.Int).Value = Convert.ToInt32(cbxCliente.SelectedValue);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.AddWithValue("@total", SqlDbType.NChar).Value = txtTotalGeral.Text;
            cmd.ExecuteNonQuery();
            string idvenda = "SELECT IDENT_CURRENT('Venda') AS id_venda";
            SqlCommand cmd2 = new SqlCommand(idvenda, con);
            Int32 idvenda2 = Convert.ToInt32(cmd2.ExecuteScalar());
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                SqlCommand cmditens = new SqlCommand("InserirItensVendidos", con);
                cmditens.CommandType = CommandType.StoredProcedure;
                cmditens.Parameters.AddWithValue("@idvenda", SqlDbType.Int).Value = idvenda2;
                cmditens.Parameters.AddWithValue("@idproduto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                cmditens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                cmditens.Parameters.AddWithValue("@valorunitario", SqlDbType.NChar).Value = Convert.ToString(dr.Cells[3].Value);
                cmditens.Parameters.AddWithValue("@total", SqlDbType.NChar).Value = Convert.ToString(dr.Cells[4].Value);
                cmditens.ExecuteNonQuery();
            }
            con.Close();
            dgvVenda.Rows.Clear();
            dgvVenda.Refresh();
            txtTotalGeral.Text = "";
            MessageBox.Show("Venda realizada com sucesso!");
        }
    }
}
