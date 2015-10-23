using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace BancoDados
{
    public partial class frmBancoDados : Form
    {
        public frmBancoDados()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.Connection = cn;
            cn.ConnectionString = Dados.StringDeConexao;

            string tudo = string.Format("select * from clientes where nome like '%{0}%' ", txtNome.Text);
            string simples = string.Format("select * from clientes where nome like '{0}%' ", txtNome.Text);

            if (checkBox1.Checked)
            {
                cmd.CommandText = tudo;
            }
            else
            {
                cmd.CommandText = simples;
            }

            //por não ser uma proc. esse comando é opcional
            cmd.CommandType = CommandType.Text;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtCodigo.Text = dr["id_cliente"].ToString();
                    txtNome.Text = dr["nome"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado");
                }
                dr.Close();
                cn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex.ToString());
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO Clientes (Nome, Email) VALUES ('{0}', '{1}')", txtNome.Text, txtEmail.Text));

            cmd.Connection = cn;
            cn.ConnectionString = Dados.StringDeConexao;

            if (txtNome.Text != "" && txtEmail.Text != "")
            {
                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    txtCodigo.Text = "";
                    txtNome.Text = "";
                    txtEmail.Text = "";

                    cn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ocorreu o erro: " + ex.ToString());
                }    
            }
            else
            {
                MessageBox.Show("Preencha os dados para cadastrar o cliente");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE Clientes SET Nome = '{0}', Email = '{1}' WHERE (ID_Cliente = '{2}')",
                                                                                                                        txtNome.Text,
                                                                                                                        txtEmail.Text,
                                                                                                                        txtCodigo.Text));
            cmd.Connection = cn;
            cn.ConnectionString = Dados.StringDeConexao;

            if (txtCodigo.Text != "")
            {
                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario atualizado com sucesso!");

                    cn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ocorreu o erro: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Preencha os dados para fazer a atualização");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand(string.Format("DELETE FROM Clientes WHERE ID_Cliente = {0}", txtCodigo.Text));
            cmd.Connection = cn;
            cn.ConnectionString = Dados.StringDeConexao;

            if (txtCodigo.Text != "")
            {
                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario excluído com sucesso!");

                    cn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ocorreu o erro: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Preencha os dados para fazer a exclusão");
            }
        }
    }
}