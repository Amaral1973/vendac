namespace Revisao
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxClientes = new System.Windows.Forms.PictureBox();
            this.pbxProdutos = new System.Windows.Forms.PictureBox();
            this.pbxVendas = new System.Windows.Forms.PictureBox();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.jogosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // jogosToolStripMenuItem
            // 
            this.jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
            this.jogosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.jogosToolStripMenuItem.Text = "Produtos";
            this.jogosToolStripMenuItem.Click += new System.EventHandler(this.jogosToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pbxClientes
            // 
            this.pbxClientes.Image = global::Revisao.Properties.Resources.cliente;
            this.pbxClientes.Location = new System.Drawing.Point(29, 65);
            this.pbxClientes.Name = "pbxClientes";
            this.pbxClientes.Size = new System.Drawing.Size(196, 204);
            this.pbxClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClientes.TabIndex = 1;
            this.pbxClientes.TabStop = false;
            this.pbxClientes.Click += new System.EventHandler(this.pbxClientes_Click);
            // 
            // pbxProdutos
            // 
            this.pbxProdutos.Image = global::Revisao.Properties.Resources.jogos;
            this.pbxProdutos.Location = new System.Drawing.Point(253, 65);
            this.pbxProdutos.Name = "pbxProdutos";
            this.pbxProdutos.Size = new System.Drawing.Size(196, 204);
            this.pbxProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProdutos.TabIndex = 3;
            this.pbxProdutos.TabStop = false;
            this.pbxProdutos.Click += new System.EventHandler(this.pbxGames_Click);
            // 
            // pbxVendas
            // 
            this.pbxVendas.Image = global::Revisao.Properties.Resources.venda;
            this.pbxVendas.Location = new System.Drawing.Point(489, 65);
            this.pbxVendas.Name = "pbxVendas";
            this.pbxVendas.Size = new System.Drawing.Size(196, 204);
            this.pbxVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVendas.TabIndex = 4;
            this.pbxVendas.TabStop = false;
            this.pbxVendas.Click += new System.EventHandler(this.pbxVendas_Click);
            // 
            // pbxSair
            // 
            this.pbxSair.Image = global::Revisao.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(737, 65);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(196, 204);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 5;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(59, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "CLIENTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(279, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "PRODUTOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(545, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "VENDAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(815, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "SAIR";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 594);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.pbxVendas);
            this.Controls.Add(this.pbxProdutos);
            this.Controls.Add(this.pbxClientes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Games";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbxClientes;
        private System.Windows.Forms.PictureBox pbxProdutos;
        private System.Windows.Forms.PictureBox pbxVendas;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

