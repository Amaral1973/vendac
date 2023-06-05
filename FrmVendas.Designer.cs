namespace Revisao
{
    partial class FrmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxProdutos = new System.Windows.Forms.ComboBox();
            this.btnInserirItem = new System.Windows.Forms.Button();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnExcluirVenda = new System.Windows.Forms.Button();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(748, 153);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(257, 66);
            this.btnSair.TabIndex = 30;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.BackColor = System.Drawing.Color.Maroon;
            this.btnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(748, 82);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(257, 66);
            this.btnFinalizarVenda.TabIndex = 29;
            this.btnFinalizarVenda.Text = "FINALIZAR VENDA";
            this.btnFinalizarVenda.UseVisualStyleBackColor = false;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNovaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaVenda.ForeColor = System.Drawing.Color.White;
            this.btnNovaVenda.Location = new System.Drawing.Point(748, 12);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(257, 66);
            this.btnNovaVenda.TabIndex = 27;
            this.btnNovaVenda.Text = "ABRIR VENDA";
            this.btnNovaVenda.UseVisualStyleBackColor = false;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(16, 338);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.RowHeadersWidth = 62;
            this.dgvVenda.RowTemplate.Height = 28;
            this.dgvVenda.Size = new System.Drawing.Size(988, 229);
            this.dgvVenda.TabIndex = 61;
            this.dgvVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellClick);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(12, 280);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(278, 26);
            this.txtQuantidade.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "QUANTIDADE";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 218);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(278, 26);
            this.txtValor.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "VALOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "PRODUTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "CLIENTE";
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.Location = new System.Drawing.Point(722, 573);
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.Size = new System.Drawing.Size(278, 26);
            this.txtTotalGeral.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "TOTAL";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(17, 34);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(668, 28);
            this.cbxCliente.TabIndex = 64;
            // 
            // cbxProdutos
            // 
            this.cbxProdutos.FormattingEnabled = true;
            this.cbxProdutos.Location = new System.Drawing.Point(16, 95);
            this.cbxProdutos.Name = "cbxProdutos";
            this.cbxProdutos.Size = new System.Drawing.Size(669, 28);
            this.cbxProdutos.TabIndex = 65;
            this.cbxProdutos.SelectedIndexChanged += new System.EventHandler(this.cbxProdutos_SelectedIndexChanged);
            // 
            // btnInserirItem
            // 
            this.btnInserirItem.BackColor = System.Drawing.Color.Teal;
            this.btnInserirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirItem.ForeColor = System.Drawing.Color.White;
            this.btnInserirItem.Location = new System.Drawing.Point(353, 133);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Size = new System.Drawing.Size(223, 48);
            this.btnInserirItem.TabIndex = 68;
            this.btnInserirItem.Text = "INSERIR ITEM";
            this.btnInserirItem.UseVisualStyleBackColor = false;
            this.btnInserirItem.Click += new System.EventHandler(this.btnInserirItem_Click);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarItem.ForeColor = System.Drawing.Color.White;
            this.btnEditarItem.Location = new System.Drawing.Point(352, 187);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(224, 48);
            this.btnEditarItem.TabIndex = 69;
            this.btnEditarItem.Text = "EDITAR ITEM";
            this.btnEditarItem.UseVisualStyleBackColor = false;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // btnExcluirVenda
            // 
            this.btnExcluirVenda.BackColor = System.Drawing.Color.Red;
            this.btnExcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirVenda.ForeColor = System.Drawing.Color.White;
            this.btnExcluirVenda.Location = new System.Drawing.Point(352, 241);
            this.btnExcluirVenda.Name = "btnExcluirVenda";
            this.btnExcluirVenda.Size = new System.Drawing.Size(224, 48);
            this.btnExcluirVenda.TabIndex = 70;
            this.btnExcluirVenda.Text = "EXCLUIR ITEM";
            this.btnExcluirVenda.UseVisualStyleBackColor = false;
            this.btnExcluirVenda.Click += new System.EventHandler(this.btnExcluirVenda_Click);
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(12, 155);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(278, 26);
            this.txtIdProduto.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "ID PRODUTO";
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 611);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluirVenda);
            this.Controls.Add(this.btnEditarItem);
            this.Controls.Add(this.btnInserirItem);
            this.Controls.Add(this.cbxProdutos);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.txtTotalGeral);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.btnNovaVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxProdutos;
        private System.Windows.Forms.Button btnInserirItem;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.Button btnExcluirVenda;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label4;
    }
}