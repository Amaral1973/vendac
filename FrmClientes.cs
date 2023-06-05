using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxPesquisar_Click(object sender, EventArgs e)
        {
            BuscaCEP busca = new BuscaCEP(txtCEP.Text);
            txtCidade.Text = busca.cidade;
            txtEndereco.Text = busca.endereco;
            txtComplemento.Text = busca.complemento;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            List<Cliente> cli = cliente.listacliente();
            dgvClientes.DataSource = cli;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            this.txtNome.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (cliente.RegistroRepetido(txtNome.Text, txtEmail.Text) == true)
            {
                MessageBox.Show("Cliente já existe em nossa base de dados!");
                txtNome.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
                txtCidade.Text = "";
                txtId.Text = "";
                txtCEP.Text = "";
                txtComplemento.Text = "";
                txtEndereco.Text = "";
            }
            else
            {
                cliente.Inserir(txtNome.Text, txtCelular.Text, txtEmail.Text, txtCEP.Text, txtEndereco.Text, txtCidade.Text, txtComplemento.Text);
                MessageBox.Show("Cliente cadastrado com sucesso!!");
                List<Cliente> cli = cliente.listacliente();
                dgvClientes.DataSource = cli;
                txtNome.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
                txtCidade.Text = "";
                txtId.Text = "";
                txtCEP.Text = "";
                txtComplemento.Text = "";
                txtEndereco.Text = "";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt16(txtId.Text.Trim());
            Cliente cliente = new Cliente();
            cliente.Atualizar(Id, txtNome.Text, txtCelular.Text, txtEmail.Text, txtCEP.Text, txtEndereco.Text, txtCidade.Text, txtComplemento.Text);
            MessageBox.Show("Cliente atualizado com sucesso!!");
            List<Cliente> cli = cliente.listacliente();
            dgvClientes.DataSource = cli;
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtCidade.Text = "";
            txtId.Text = "";
            txtCEP.Text = "";
            txtComplemento.Text = "";
            txtEndereco.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text.Trim());
            Cliente cliente = new Cliente();
            cliente.Excluir(Id);
            MessageBox.Show("Cliente excluído com sucesso!!");
            List<Cliente> cli = cliente.listacliente();
            dgvClientes.DataSource = cli;
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtCidade.Text = "";
            txtId.Text = "";
            txtCEP.Text = "";
            txtComplemento.Text = "";
            txtEndereco.Text = "";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt16(txtId.Text.Trim());
            if (txtNome.Text != null)
            {
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
            }
            Cliente cliente = new Cliente();
            cliente.Localiza(Id);
            txtNome.Text = cliente.nome;
            txtCelular.Text = cliente.celular;
            txtEmail.Text = cliente.email;
            txtCidade.Text = cliente.cidade;
            txtId.Text = Convert.ToString(cliente.Id);
            txtCEP.Text = cliente.cep;
            txtComplemento.Text = cliente.complemento;
            txtEndereco.Text = cliente.endereco;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvClientes.Rows[e.RowIndex];
                this.dgvClientes.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCelular.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                txtCEP.Text = row.Cells[4].Value.ToString();
                txtEndereco.Text = row.Cells[5].Value.ToString();
                txtCidade.Text = row.Cells[6].Value.ToString();
                txtComplemento.Text = row.Cells[7].Value.ToString();
            }
            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
        }
    }
}
