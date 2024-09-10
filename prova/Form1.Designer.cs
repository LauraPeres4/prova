namespace prova
{
    partial class Form1
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
            this.Venda = new System.Windows.Forms.Label();
            this.lblproduto = new System.Windows.Forms.Label();
            this.lblQtnd = new System.Windows.Forms.Label();
            this.lblValoruni = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtqtnd = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtalterar = new System.Windows.Forms.TextBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblvenda = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // Venda
            // 
            this.Venda.AutoSize = true;
            this.Venda.Location = new System.Drawing.Point(37, 13);
            this.Venda.Name = "Venda";
            this.Venda.Size = new System.Drawing.Size(38, 13);
            this.Venda.TabIndex = 0;
            this.Venda.Text = "Venda";
            this.Venda.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.Location = new System.Drawing.Point(37, 44);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(44, 13);
            this.lblproduto.TabIndex = 1;
            this.lblproduto.Text = "Produto";
            this.lblproduto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblQtnd
            // 
            this.lblQtnd.AutoSize = true;
            this.lblQtnd.Location = new System.Drawing.Point(37, 88);
            this.lblQtnd.Name = "lblQtnd";
            this.lblQtnd.Size = new System.Drawing.Size(62, 13);
            this.lblQtnd.TabIndex = 2;
            this.lblQtnd.Text = "Quantidade";
            this.lblQtnd.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblValoruni
            // 
            this.lblValoruni.AutoSize = true;
            this.lblValoruni.Location = new System.Drawing.Point(37, 125);
            this.lblValoruni.Name = "lblValoruni";
            this.lblValoruni.Size = new System.Drawing.Size(70, 13);
            this.lblValoruni.TabIndex = 3;
            this.lblValoruni.Text = "Valor Unitário";
            this.lblValoruni.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(377, 89);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(137, 61);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(543, 89);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(135, 61);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Column1,
            this.Column2});
            this.dgvProdutos.Location = new System.Drawing.Point(67, 182);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(611, 169);
            this.dgvProdutos.TabIndex = 6;
            this.dgvProdutos.CellBorderStyleChanged += new System.EventHandler(this.dgvProdutos_CellBorderStyleChanged);
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Alterar quantidade do item seleciondao: ";
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(113, 41);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(565, 20);
            this.txtproduto.TabIndex = 8;
            // 
            // txtqtnd
            // 
            this.txtqtnd.Location = new System.Drawing.Point(113, 85);
            this.txtqtnd.Name = "txtqtnd";
            this.txtqtnd.Size = new System.Drawing.Size(212, 20);
            this.txtqtnd.TabIndex = 9;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(113, 122);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(212, 20);
            this.txtvalor.TabIndex = 10;
            this.txtvalor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtalterar
            // 
            this.txtalterar.Location = new System.Drawing.Point(278, 403);
            this.txtalterar.Name = "txtalterar";
            this.txtalterar.Size = new System.Drawing.Size(246, 20);
            this.txtalterar.TabIndex = 11;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(530, 389);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(122, 46);
            this.btnalterar.TabIndex = 12;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total da venda:";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(116, 512);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(147, 78);
            this.btnGravar.TabIndex = 14;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(311, 512);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 78);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar Venda";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(495, 512);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(137, 78);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "Finalizar Sistema";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblvenda
            // 
            this.lblvenda.AutoSize = true;
            this.lblvenda.Location = new System.Drawing.Point(113, 13);
            this.lblvenda.Name = "lblvenda";
            this.lblvenda.Size = new System.Drawing.Size(13, 13);
            this.lblvenda.TabIndex = 17;
            this.lblvenda.Text = "0";
            this.lblvenda.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(164, 466);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "0";
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 69;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Quantidade";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 87;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "V Unitário";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 78;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblvenda);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.txtalterar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtqtnd);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblValoruni);
            this.Controls.Add(this.lblQtnd);
            this.Controls.Add(this.lblproduto);
            this.Controls.Add(this.Venda);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Venda;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.Label lblQtnd;
        private System.Windows.Forms.Label lblValoruni;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtqtnd;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtalterar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblvenda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

