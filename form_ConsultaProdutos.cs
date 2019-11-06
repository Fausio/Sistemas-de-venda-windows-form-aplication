using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.DAL;

namespace Sistema_de_vendas_Cursos
{
    public partial class form_ConsultaProdutos : Form
    {
        public form_ConsultaProdutos()
        {
            InitializeComponent();
        }

        private void Form_ConsultaProdutos_Load(object sender, EventArgs e)
        {
            this.tb_categoriaBindingSource.DataSource = DataContextFactory.ContextData.tb_categorias;
        }

        private void Btn_pesquisar_produto_Click(object sender, EventArgs e)
        {
            this.pesquisar(Convert.ToInt32(combo_produto_por_categoria.SelectedValue));
        }

        public void pesquisar(int codigoCategoria)
        {
            this.tbprodutoBindingSource.DataSource = DataContextFactory.ContextData.tb_produtos.Where(x => x.id_categoria == codigoCategoria);
        }
    }
}
