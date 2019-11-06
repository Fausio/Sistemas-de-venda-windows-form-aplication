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
    public partial class form_venda : Form
    {
        public form_venda()
        {
            InitializeComponent();
        }

        private void Form_venda_Load(object sender, EventArgs e)
        {
            this.PessoaSource.DataSource = DataContextFactory.ContextData.tb_pessoas;
            this.ItensVendaSource.DataSource = DataContextFactory.ContextData.tb_itens_vendas;
            this.ProdutosSource.DataSource = DataContextFactory.ContextData.tb_produtos;
            this.ItensVendaSource.AddNew();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.ItensVendaSource.EndEdit();
            DataContextFactory.ContextData.SubmitChanges();
            this.groupBox1.Visible = true;
        }
    }
}
