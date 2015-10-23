using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Loja.Modelos;
using Loja.BLL;

namespace Loja.UI.Intranet
{
    public partial class ProdutosForm : Form
    {
        public ProdutosForm()
        {
            InitializeComponent();
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new ProdutoInfo();
                p.Codigo = Convert.ToInt32(codigoTextBox.Text);
                p.Nome = nomeTextBox.Text;
                p.Preco = Convert.ToDecimal(precoTextBox.Text);
                p.Estoque = Convert.ToInt32(estoqueTextBox.Text);

                //Codigo para incluir....
                var obj = new ProdutoBLL();
                obj.Incluir(p);
                MessageBox.Show("O produto foi incluido com sucesso");

                dataGridView1.DataSource = obj.Listagem();
                tabControl1.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", 
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ProdutosForm_Load(object sender, EventArgs e)
        {
            var obj = new ProdutoBLL();
            dataGridView1.DataSource = obj.Listagem();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            foreach (Control c in tabPage2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
            incluirButton.Visible = true;
            alterarGravarButton.Visible = false;
            codigoTextBox.Focus();

        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            int linha = dataGridView1.CurrentRow.Index;
            codigoTextBox.Text = dataGridView1["Codigo", linha].Value.ToString();
            nomeTextBox.Text = dataGridView1["Nome", linha].Value.ToString();
            precoTextBox.Text = dataGridView1["Preco", linha].Value.ToString();
            estoqueTextBox.Text = dataGridView1["Estoque", linha].Value.ToString();
            tabControl1.SelectedIndex = 1;
            alterarGravarButton.Visible = true;
            incluirButton.Visible = false;
            nomeTextBox.Focus();
        }

        private void alterarGravarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new ProdutoInfo();
                p.Codigo = Convert.ToInt32(codigoTextBox.Text);
                p.Nome = nomeTextBox.Text;
                p.Preco = Convert.ToDecimal(precoTextBox.Text);
                p.Estoque = Convert.ToInt32(estoqueTextBox.Text);
                var obj = new ProdutoBLL();
                obj.Alterar(p);
                MessageBox.Show("O produto foi alterado com sucesso");
                dataGridView1.DataSource = obj.Listagem();
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void excluirButton_Click(object sender, EventArgs e)
        {
            int linha = dataGridView1.CurrentRow.Index;
            int codigo= Convert.ToInt32(dataGridView1["Codigo", linha].Value);
            if (MessageBox.Show("Confirma a exclusão?", "Excluir",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var obj = new ProdutoBLL();
                var p = new ProdutoInfo();
                p.Codigo = codigo;
                obj.Excluir(p);
                MessageBox.Show("O registro foi excluido com sucesso");
                dataGridView1.DataSource = obj.Listagem();
            }
        }
    }
}
