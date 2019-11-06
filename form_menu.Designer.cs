namespace Sistema_de_vendas_Cursos
{
    partial class form_menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cadastrar_produtos = new System.Windows.Forms.Button();
            this.btn_cadastrar_categorias = new System.Windows.Forms.Button();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.BackgroundImage = global::Sistema_de_vendas_Cursos.Properties.Resources.photo_1523821741446_edb2b68bb7a0;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(431, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.ProdutosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.CategoriasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosCategoriaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // produtosCategoriaToolStripMenuItem
            // 
            this.produtosCategoriaToolStripMenuItem.Name = "produtosCategoriaToolStripMenuItem";
            this.produtosCategoriaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.produtosCategoriaToolStripMenuItem.Text = "Produtos / Categoria";
            this.produtosCategoriaToolStripMenuItem.Click += new System.EventHandler(this.ProdutosCategoriaToolStripMenuItem_Click);
            // 
            // btn_cadastrar_produtos
            // 
            this.btn_cadastrar_produtos.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar_produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cadastrar_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_cadastrar_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar_produtos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cadastrar_produtos.Image = global::Sistema_de_vendas_Cursos.Properties.Resources.purse;
            this.btn_cadastrar_produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrar_produtos.Location = new System.Drawing.Point(12, 38);
            this.btn_cadastrar_produtos.Name = "btn_cadastrar_produtos";
            this.btn_cadastrar_produtos.Size = new System.Drawing.Size(79, 98);
            this.btn_cadastrar_produtos.TabIndex = 2;
            this.btn_cadastrar_produtos.Text = "Cadastrar produtos";
            this.btn_cadastrar_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastrar_produtos.UseVisualStyleBackColor = false;
            this.btn_cadastrar_produtos.Click += new System.EventHandler(this.Btn_cadastrar_produtos_Click);
            // 
            // btn_cadastrar_categorias
            // 
            this.btn_cadastrar_categorias.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar_categorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cadastrar_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar_categorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_cadastrar_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar_categorias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cadastrar_categorias.Image = global::Sistema_de_vendas_Cursos.Properties.Resources.basket;
            this.btn_cadastrar_categorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrar_categorias.Location = new System.Drawing.Point(109, 38);
            this.btn_cadastrar_categorias.Name = "btn_cadastrar_categorias";
            this.btn_cadastrar_categorias.Size = new System.Drawing.Size(79, 98);
            this.btn_cadastrar_categorias.TabIndex = 3;
            this.btn_cadastrar_categorias.Text = "Cadastrar categorias";
            this.btn_cadastrar_categorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastrar_categorias.UseVisualStyleBackColor = false;
            this.btn_cadastrar_categorias.Click += new System.EventHandler(this.Btn_cadastrar_categorias_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem1});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            this.vendasToolStripMenuItem1.Click += new System.EventHandler(this.VendasToolStripMenuItem1_Click);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Sistema_de_vendas_Cursos.Properties.Resources.textura_papel_arrugado_1100_12;
            this.ClientSize = new System.Drawing.Size(431, 251);
            this.Controls.Add(this.btn_cadastrar_categorias);
            this.Controls.Add(this.btn_cadastrar_produtos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btn_cadastrar_produtos;
        private System.Windows.Forms.Button btn_cadastrar_categorias;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
    }
}

