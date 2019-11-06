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
    public partial class form_produtos : Form
    {
        public form_produtos()
        {
            InitializeComponent();
        }

        private void Form_produtos_Load(object sender, EventArgs e)
        {
            this.tbprodutoBindingSource.DataSource = DataContextFactory.ContextData.tb_produtos;
            this.tb_categoriaBindingSource.DataSource = DataContextFactory.ContextData.tb_categorias;
        }

        private void Combo_categorias_no_produtoform_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_novo_produto_Click(object sender, EventArgs e)
        {
            this.tbprodutoBindingSource.AddNew();
        }

        private void Btn_cadastrar_produto_Click(object sender, EventArgs e)
        {
            if (this.Validacao())
            {
                if (this.validacao_do_valor())
                {
                    this.tbprodutoBindingSource.EndEdit();
                    DataContextFactory.ContextData.SubmitChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Produto inserido com sucesso");
                }

            }
        }


        private void Btn_excluir_produtos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que quer deletar", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                this.tbprodutoBindingSource.RemoveCurrent();
                DataContextFactory.ContextData.SubmitChanges();
                MessageBox.Show("produto removido com sucesso");


            }
        }

        private void Btn_cancelar_produto_Click(object sender, EventArgs e)
        {
            this.tbprodutoBindingSource.CancelEdit();
            this.Close();
        }

        private bool Validacao()
        {
            if (Txt_descricao_produto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo da descrião é obrigatório");
                Txt_descricao_produto.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validacao_do_valor()
        {
            if (Convert.ToInt32(txt_valor_produtos.Text) <= 0 || txt_valor_produtos.Text == "")
            {
                MessageBox.Show("o valor deve ser maio que zero");
                txt_valor_produtos.Focus();
                return false;

            }
            else
            {
                return true;

            }
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex ==3)
            {
                e.Value = ((tb_categoria)e.Value).desc_categoria;
            }
        }
    }
}
