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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxClientes_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.Show();
        }

        private void pbxGames_Click(object sender, EventArgs e)
        {
            FrmProdutos prod = new FrmProdutos();
            prod.Show();
        }

        private void pbxVendas_Click(object sender, EventArgs e)
        {
            FrmVendas vendas = new FrmVendas();
            vendas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.Show();
        }

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos prod = new FrmProdutos();
            prod.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas vendas = new FrmVendas();
            vendas.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
