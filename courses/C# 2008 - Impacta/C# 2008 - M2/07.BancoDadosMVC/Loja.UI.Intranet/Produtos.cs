using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Loja.Modelo;
using Loja.BLL;

namespace Loja.UI.Intranet
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoInfo produto = new ProdutoInfo();
                produto.Codigo = Convert.ToInt32(txtCodigo.Text);
                produto.Nome = txtNome.Text;
                produto.Preco = Convert.ToDecimal(txtPreco.Text);
                produto.Estoque = Convert.ToInt32(txtEstoque.Text);

                ProdutoBLL obj = new ProdutoBLL();
                obj.Incluir(produto);
                MessageBox.Show("Produto inserido");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            ProdutoBLL produto = new ProdutoBLL();
            dataGridView1.DataSource = produto.Listagem();
        }

        private void btnNovaLista_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            foreach (Control c in tabPage2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
            btnIncluir.Visible = true;
            btnAlterar.Visible = false;
            txtCodigo.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linha = dataGridView1.CurrentRow.Index;
            txtCodigo.Text = dataGridView1["Codigo", linha].Value.ToString();
            txtNome.Text = dataGridView1["Nome", linha].Value.ToString();
            txtPreco.Text = dataGridView1["Preco", linha].Value.ToString();
            txtEstoque.Text = dataGridView1["Estoque", linha].Value.ToString();
            tabControl1.SelectedIndex = 1;

            btnAlterarGravar.Visible = true;
            btnIncluir.Visible = false;
            txtNome.Focus();
        }

        private void btnAlterarGravar_Click(object sender, EventArgs e)
        {

        }

        private void bnExcluir_Click(object sender, EventArgs e)
        {
            int linha = dataGridView1.CurrentRow.Index;
            int codigo = Convert.ToInt32(dataGridView1["Codigo", linha].Value);

            if (MessageBox.Show("Confirma a exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var obj = new ProdutoBLL();
                var p = new ProdutoInfo();
                p.Codigo = codigo;
                obj.Excluir(p);
                MessageBox.Show("O registro foi excluido com sucesso!");
                dataGridView1.DataSource = obj.Listagem();
            }
        }
    }
}
