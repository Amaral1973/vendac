using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmJogos_Load(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            List<Produto> prod = produto.listaprodutos();
            dgvProdutos.DataSource = prod;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            this.txtNome.Focus();
            txtPlataforma.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            if (produto.RegistroRepetido(txtNome.Text, txtDesenvolvedora.Text) == true)
            {
                MessageBox.Show("Este produto já existe em nossa base de dados!");
                txtNome.Text = "";
                cbxTipo.Text = "";
                txtDesenvolvedora.Text = "";
                txtPlataforma.Text = "";
                txtValor.Text = "";
                txtQuantidade.Text = "";
                this.txtNome.Focus();
            }
            else
            {
                int quantidade = Convert.ToInt32(txtQuantidade.Text);
                produto.Inserir(txtNome.Text, cbxTipo.Text, txtDesenvolvedora.Text, txtPlataforma.Text, quantidade, txtValor.Text);
                MessageBox.Show("Jogo cadastrado com sucesso!!");
                List<Produto> prod = produto.listaprodutos();
                dgvProdutos.DataSource = prod;
                txtNome.Text = "";
                cbxTipo.Text = "";
                txtDesenvolvedora.Text = "";
                txtPlataforma.Text = "";
                txtValor.Text = "";
                txtQuantidade.Text = "";
                this.txtNome.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            Produto produto = new Produto();
            produto.Atualizar(id, txtNome.Text, cbxTipo.Text, txtDesenvolvedora.Text, txtPlataforma.Text, quantidade, txtValor.Text);
            MessageBox.Show("Produto atualizado com sucesso!!");
            List<Produto> prod = produto.listaprodutos();
            dgvProdutos.DataSource = prod;
            txtNome.Text = "";
            cbxTipo.Text = "";
            txtDesenvolvedora.Text = "";
            txtPlataforma.Text = "";
            txtValor.Text = "";
            txtQuantidade.Text = "";
            this.txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Produto produto = new Produto();
            produto.Excluir(id);
            MessageBox.Show("Produto excluído com sucesso!!");
            List<Produto> prod = produto.listaprodutos();
            dgvProdutos.DataSource = prod;
            txtNome.Text = "";
            cbxTipo.Text = "";
            txtDesenvolvedora.Text = "";
            txtPlataforma.Text = "";
            txtValor.Text = "";
            txtQuantidade.Text = "";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt16(txtId.Text.Trim());
            if (txtNome.Text != null)
            {
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
            }
            Produto produto = new Produto();
            produto.Localiza(Id);
            txtId.Text = Convert.ToString(Id);
            txtNome.Text = produto.nome;
            cbxTipo.Text = produto.tipo;
            txtDesenvolvedora.Text = produto.fabricante;
            txtPlataforma.Text = produto.plataforma;
            txtValor.Text = produto.valor;
            txtQuantidade.Text = Convert.ToString(produto.quantidade);
        }

        private void dgvJogos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProdutos.Rows[e.RowIndex];
                this.dgvProdutos.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                cbxTipo.Text = row.Cells[2].Value.ToString();
                txtDesenvolvedora.Text = row.Cells[3].Value.ToString();
                txtPlataforma.Text = row.Cells[4].Value.ToString();
                txtValor.Text = row.Cells[5].Value.ToString();
                txtQuantidade.Text = row.Cells[6].Value.ToString();
            }
            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxTipo.SelectedIndex)
            {
                case 0:
                    label4.Text = "DESENVOLVEDORA";
                    txtPlataforma.Enabled = true;
                    break;
                case 1:
                    label4.Text = "FABRICANTE";
                    txtPlataforma.Enabled = false;
                    break;
            }
        }
    }
}
