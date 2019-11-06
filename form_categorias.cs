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
    public partial class form_categorias : Form
    {
        public form_categorias()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_categorias_Load(object sender, EventArgs e)
        {
            this.tbcategoriaBindingSource.DataSource = DataContextFactory.ContextData.tb_categorias;
        }

        private void Btn_nova_categoria_Click(object sender, EventArgs e)
        {
            this.tbcategoriaBindingSource.AddNew();
        }

        private void Btn_cadastrar_Categoria_Click(object sender, EventArgs e)
        {
            if (this.Validacao())
            {
                this.tbcategoriaBindingSource.EndEdit();
                DataContextFactory.ContextData.SubmitChanges();

                MessageBox.Show("Categoria inserida com sucesso");
            }


        }

        private void Btn_excluir_Categoria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que quer deletar", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (this.TemProdutos(categoriaAtual))
                {
                    MessageBox.Show("Categoria possui produtos");
                }
                else
                {
                    this.tbcategoriaBindingSource.RemoveCurrent();
                    DataContextFactory.ContextData.SubmitChanges();
                    MessageBox.Show("Categoria removida com sucesso");

                }
            }
        }

        private void Btn_cancelar_Categoria_Click(object sender, EventArgs e)
        {
            this.tbcategoriaBindingSource.CancelEdit();
            this.Close();
        }

        private bool Validacao()
        {
            if (Txt_categorias.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo de categoria é obrigatório");
                Txt_categorias.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public tb_categoria categoriaAtual
        {
            get
            {
                return (tb_categoria)this.tbcategoriaBindingSource.Current;
            }
        }

        public bool TemProdutos(tb_categoria tb_Categoria)
        {
            var produtos = DataContextFactory.ContextData.tb_produtos.Where(x => x.id_categoria == tb_Categoria.id_categoria);
            if (produtos.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
