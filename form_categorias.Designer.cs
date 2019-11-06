namespace Sistema_de_vendas_Cursos
{
    partial class form_categorias
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_cancelar_Categoria = new System.Windows.Forms.Button();
            this.btn_excluir_Categoria = new System.Windows.Forms.Button();
            this.btn_nova_categoria = new System.Windows.Forms.Button();
            this.btn_cadastrar_Categoria = new System.Windows.Forms.Button();
            this.Txt_categorias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desccategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcategoriaDataGridViewTextBoxColumn,
            this.desccategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbcategoriaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(610, 246);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btn_cancelar_Categoria
            // 
            this.btn_cancelar_Categoria.Location = new System.Drawing.Point(429, 48);
            this.btn_cancelar_Categoria.Name = "btn_cancelar_Categoria";
            this.btn_cancelar_Categoria.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_Categoria.TabIndex = 21;
            this.btn_cancelar_Categoria.Text = "Cancelar";
            this.btn_cancelar_Categoria.UseVisualStyleBackColor = true;
            this.btn_cancelar_Categoria.Click += new System.EventHandler(this.Btn_cancelar_Categoria_Click);
            // 
            // btn_excluir_Categoria
            // 
            this.btn_excluir_Categoria.Location = new System.Drawing.Point(326, 48);
            this.btn_excluir_Categoria.Name = "btn_excluir_Categoria";
            this.btn_excluir_Categoria.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_Categoria.TabIndex = 20;
            this.btn_excluir_Categoria.Text = "Excluir";
            this.btn_excluir_Categoria.UseVisualStyleBackColor = true;
            this.btn_excluir_Categoria.Click += new System.EventHandler(this.Btn_excluir_Categoria_Click);
            // 
            // btn_nova_categoria
            // 
            this.btn_nova_categoria.Location = new System.Drawing.Point(133, 48);
            this.btn_nova_categoria.Name = "btn_nova_categoria";
            this.btn_nova_categoria.Size = new System.Drawing.Size(75, 23);
            this.btn_nova_categoria.TabIndex = 19;
            this.btn_nova_categoria.Text = "Novo";
            this.btn_nova_categoria.UseVisualStyleBackColor = true;
            this.btn_nova_categoria.Click += new System.EventHandler(this.Btn_nova_categoria_Click);
            // 
            // btn_cadastrar_Categoria
            // 
            this.btn_cadastrar_Categoria.Location = new System.Drawing.Point(234, 48);
            this.btn_cadastrar_Categoria.Name = "btn_cadastrar_Categoria";
            this.btn_cadastrar_Categoria.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar_Categoria.TabIndex = 18;
            this.btn_cadastrar_Categoria.Text = "Cadastrar";
            this.btn_cadastrar_Categoria.UseVisualStyleBackColor = true;
            this.btn_cadastrar_Categoria.Click += new System.EventHandler(this.Btn_cadastrar_Categoria_Click);
            // 
            // Txt_categorias
            // 
            this.Txt_categorias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcategoriaBindingSource, "desc_categoria", true));
            this.Txt_categorias.Location = new System.Drawing.Point(184, 24);
            this.Txt_categorias.Name = "Txt_categorias";
            this.Txt_categorias.Size = new System.Drawing.Size(228, 20);
            this.Txt_categorias.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Categorias";
            // 
            // idcategoriaDataGridViewTextBoxColumn
            // 
            this.idcategoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idcategoriaDataGridViewTextBoxColumn.DataPropertyName = "id_categoria";
            this.idcategoriaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idcategoriaDataGridViewTextBoxColumn.Name = "idcategoriaDataGridViewTextBoxColumn";
            this.idcategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // desccategoriaDataGridViewTextBoxColumn
            // 
            this.desccategoriaDataGridViewTextBoxColumn.DataPropertyName = "desc_categoria";
            this.desccategoriaDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.desccategoriaDataGridViewTextBoxColumn.Name = "desccategoriaDataGridViewTextBoxColumn";
            this.desccategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.desccategoriaDataGridViewTextBoxColumn.Width = 450;
            // 
            // tbcategoriaBindingSource
            // 
            this.tbcategoriaBindingSource.DataSource = typeof(Vendas.DAL.tb_categoria);
            // 
            // form_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 335);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancelar_Categoria);
            this.Controls.Add(this.btn_excluir_Categoria);
            this.Controls.Add(this.btn_nova_categoria);
            this.Controls.Add(this.btn_cadastrar_Categoria);
            this.Controls.Add(this.Txt_categorias);
            this.Controls.Add(this.label1);
            this.Name = "form_categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_categorias";
            this.Load += new System.EventHandler(this.Form_categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_cancelar_Categoria;
        private System.Windows.Forms.Button btn_excluir_Categoria;
        private System.Windows.Forms.Button btn_nova_categoria;
        private System.Windows.Forms.Button btn_cadastrar_Categoria;
        private System.Windows.Forms.TextBox Txt_categorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desccategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbcategoriaBindingSource;
    }
}