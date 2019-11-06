using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_vendas_Cursos
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void Btn_cadastrar_produtos_Click(object sender, EventArgs e)
        {
            form_produtos formObject = new form_produtos();
            formObject.Show();
        }

        private void Btn_cadastrar_categorias_Click(object sender, EventArgs e)
        {
            form_categorias formObject = new form_categorias();
                formObject.Show();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_produtos formObject = new form_produtos();
            formObject.Show();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_categorias formObject = new form_categorias();
            formObject.Show();
        }

        private void ProdutosCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_ConsultaProdutos form = new form_ConsultaProdutos();
            form.Show();
        }

        private void VendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_venda form = new form_venda();
            form.Show();
        }
    }
}
