namespace Sistema_de_vendas_Cursos
{
    partial class form_produtos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_descricao_produto = new System.Windows.Forms.TextBox();
            this.tbprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_valor_produtos = new System.Windows.Forms.TextBox();
            this.combo_categorias_no_produtoform = new System.Windows.Forms.ComboBox();
            this.tb_categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_cadastrar_produto = new System.Windows.Forms.Button();
            this.btn_novo_produto = new System.Windows.Forms.Button();
            this.btn_excluir_produtos = new System.Windows.Forms.Button();
            this.btn_cancelar_produto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // Txt_descricao_produto
            // 
            this.Txt_descricao_produto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbprodutoBindingSource, "desc_produto", true));
            this.Txt_descricao_produto.Location = new System.Drawing.Point(71, 16);
            this.Txt_descricao_produto.Name = "Txt_descricao_produto";
            this.Txt_descricao_produto.Size = new System.Drawing.Size(152, 20);
            this.Txt_descricao_produto.TabIndex = 1;
            // 
            // tbprodutoBindingSource
            // 
            this.tbprodutoBindingSource.DataSource = typeof(Vendas.DAL.tb_produto);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            // 
            // txt_valor_produtos
            // 
            this.txt_valor_produtos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbprodutoBindingSource, "valor", true));
            this.txt_valor_produtos.Location = new System.Drawing.Point(296, 16);
            this.txt_valor_produtos.Name = "txt_valor_produtos";
            this.txt_valor_produtos.Size = new System.Drawing.Size(118, 20);
            this.txt_valor_produtos.TabIndex = 5;
            // 
            // combo_categorias_no_produtoform
            // 
            this.combo_categorias_no_produtoform.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbprodutoBindingSource, "id_categoria", true));
            this.combo_categorias_no_produtoform.DataSource = this.tb_categoriaBindingSource;
            this.combo_categorias_no_produtoform.DisplayMember = "desc_categoria";
            this.combo_categorias_no_produtoform.FormattingEnabled = true;
            this.combo_categorias_no_produtoform.Location = new System.Drawing.Point(478, 16);
            this.combo_categorias_no_produtoform.Name = "combo_categorias_no_produtoform";
            this.combo_categorias_no_produtoform.Size = new System.Drawing.Size(121, 21);
            this.combo_categorias_no_produtoform.TabIndex = 6;
            this.combo_categorias_no_produtoform.ValueMember = "id_categoria";
            this.combo_categorias_no_produtoform.SelectedIndexChanged += new System.EventHandler(this.Combo_categorias_no_produtoform_SelectedIndexChanged);
            // 
            // tb_categoriaBindingSource
            // 
            this.tb_categoriaBindingSource.DataSource = typeof(Vendas.DAL.tb_categoria);
            // 
            // btn_cadastrar_produto
            // 
            this.btn_cadastrar_produto.Location = new System.Drawing.Point(225, 52);
            this.btn_cadastrar_produto.Name = "btn_cadastrar_produto";
            this.btn_cadastrar_produto.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar_produto.TabIndex = 7;
            this.btn_cadastrar_produto.Text = "Cadastrar";
            this.btn_cadastrar_produto.UseVisualStyleBackColor = true;
            this.btn_cadastrar_produto.Click += new System.EventHandler(this.Btn_cadastrar_produto_Click);
            // 
            // btn_novo_produto
            // 
            this.btn_novo_produto.Location = new System.Drawing.Point(124, 52);
            this.btn_novo_produto.Name = "btn_novo_produto";
            this.btn_novo_produto.Size = new System.Drawing.Size(75, 23);
            this.btn_novo_produto.TabIndex = 8;
            this.btn_novo_produto.Text = "Novo";
            this.btn_novo_produto.UseVisualStyleBackColor = true;
            this.btn_novo_produto.Click += new System.EventHandler(this.Btn_novo_produto_Click);
            // 
            // btn_excluir_produtos
            // 
            this.btn_excluir_produtos.Location = new System.Drawing.Point(317, 52);
            this.btn_excluir_produtos.Name = "btn_excluir_produtos";
            this.btn_excluir_produtos.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_produtos.TabIndex = 9;
            this.btn_excluir_produtos.Text = "Excluir";
            this.btn_excluir_produtos.UseVisualStyleBackColor = true;
            this.btn_excluir_produtos.Click += new System.EventHandler(this.Btn_excluir_produtos_Click);
            // 
            // btn_cancelar_produto
            // 
            this.btn_cancelar_produto.Location = new System.Drawing.Point(420, 52);
            this.btn_cancelar_produto.Name = "btn_cancelar_produto";
            this.btn_cancelar_produto.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_produto.TabIndex = 10;
            this.btn_cancelar_produto.Text = "Cancelar";
            this.btn_cancelar_produto.UseVisualStyleBackColor = true;
            this.btn_cancelar_produto.Click += new System.EventHandler(this.Btn_cancelar_produto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.tbprodutoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 200);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_produto";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "desc_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "desc_produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tb_categoria";
            this.dataGridViewTextBoxColumn5.HeaderText = "tb_categoria";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // form_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 344);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancelar_produto);
            this.Controls.Add(this.btn_excluir_produtos);
            this.Controls.Add(this.btn_novo_produto);
            this.Controls.Add(this.btn_cadastrar_produto);
            this.Controls.Add(this.combo_categorias_no_produtoform);
            this.Controls.Add(this.txt_valor_produtos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_descricao_produto);
            this.Controls.Add(this.label1);
            this.Name = "form_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "produtos";
            this.Load += new System.EventHandler(this.Form_produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_descricao_produto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_valor_produtos;
        private System.Windows.Forms.ComboBox combo_categorias_no_produtoform;
        private System.Windows.Forms.Button btn_cadastrar_produto;
        private System.Windows.Forms.Button btn_novo_produto;
        private System.Windows.Forms.Button btn_excluir_produtos;
        private System.Windows.Forms.Button btn_cancelar_produto; 
        private System.Windows.Forms.BindingSource tbprodutoBindingSource;
        private System.Windows.Forms.BindingSource tb_categoriaBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}