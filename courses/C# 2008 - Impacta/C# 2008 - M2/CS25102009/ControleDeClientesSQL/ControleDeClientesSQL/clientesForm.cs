using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ControleDeClientesSQL
{
    public partial class clientesForm : Form
    {
        public clientesForm()
        {
            InitializeComponent();
        }

        private void procurarButton_Click(object sender, EventArgs e)
        {
            //1) Estabelecer a Conexão
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "server=.\\SQLEXPRESS;Initial Catalog=Oficina;Integrated Security=True;Pooling=False";
            cn.ConnectionString = Dados.StringDeConexao;

            //2) Definir o Comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            //cmd.CommandText = string.Format("select * from clientes where nome = '{0}'", nomeTextBox.Text);

            if (palavraChaveCheckBox.Checked)
            {
                cmd.CommandText = string.Format(
                "select * from clientes where nome like '%{0}%'", nomeTextBox.Text);
            }
            else
            {
                cmd.CommandText = string.Format(
                "select * from clientes where nome like '{0}%'", nomeTextBox.Text);
            }
            cmd.CommandType = CommandType.Text; //Opcional. O default é Text

            //3) Executar
            SqlDataReader dr;
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    codigoLabel.Text = dr["id"].ToString();
                    nomeTextBox.Text = dr["nome"].ToString();
                    emailTextBox.Text = dr["email"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                }
                dr.Close();
                cn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex.Message);
            }
        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {
            //this.Text = nomeTextBox.Text;
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            //1) Estabelecer a Conexão
            SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
            //cn.ConnectionString = Dados.StringDeConexao;

            //2) Definir o Comando
            SqlCommand cmd = new SqlCommand(
                string.Format(
                        "insert into clientes (nome, email) values ('{0}', '{1}')",
                        nomeTextBox.Text, emailTextBox.Text), cn);
            //cmd.Connection = cn;
            cmd.CommandType = CommandType.Text; //Opcional. O default é Text

            //3) Executar
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                
                codigoLabel.Text = "";
                nomeTextBox.Text = string.Empty;
                emailTextBox.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex.Message);
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
            SqlCommand cmd = new SqlCommand(
            string.Format(
           "update clientes set nome = '{0}', email = '{1}' where id = {2}",
                nomeTextBox.Text, emailTextBox.Text, codigoLabel.Text), cn);
            cmd.CommandType = CommandType.Text; //Opcional. O default é Text

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Alteração Ok");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex.Message);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Deseja excluir?",
                    "Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, 
                    MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
                SqlCommand cmd = new SqlCommand(
                    string.Format("delete clientes where id = {0}",
                    codigoLabel.Text), cn);
                cmd.CommandType = CommandType.Text; //Opcional. O default é Text

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    codigoLabel.Text = "";
                    nomeTextBox.Text = string.Empty;
                    emailTextBox.Clear();

                    MessageBox.Show("Exclusão Ok");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ocorreu o erro: " + ex.Message);
                }
                
            }
        }
    }
}
