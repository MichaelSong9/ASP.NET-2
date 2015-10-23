using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Capitulo06_Laboratorio01
{
    public partial class Cap06_Lab01Form : Form
    {
        public Cap06_Lab01Form()
        {
            InitializeComponent();
        }

        private void LimparTela()
        {
            placaTextBox.Clear();
            modeloTextBox.Clear();
            corTextBox.Clear();
            anoTextBox.Clear();

            placaTextBox.Focus();
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            //Estabelecer a conexão
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString =
                        @"Integrated Security=SSPI;Persist Security Info=False;
                        Initial Catalog=Oficina;Data Source=.\sqlexpress";

            //Definir o comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            //Definir a instrução SQL
            string instrucaoSQL =
                string.Format("Insert veiculo values('{0}','{1}','{2}','{3}')",
                placaTextBox.Text, modeloTextBox.Text, corTextBox.Text,
                anoTextBox.Text);

            cmd.CommandText = instrucaoSQL;

            //Executar
            try
            {
                //Abrir a conexão
                cn.Open();

                //Executar o comando
                cmd.ExecuteNonQuery();

                //Limpar a tela
                LimparTela();

                //Confirmar a operação
                MessageBox.Show("Operação concluída com sucesso", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Fechar a conexão
                cn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro - " + ex.Number,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            //Estabelecer a conexão
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString =
                        @"Integrated Security=SSPI;Persist Security Info=False;
                        Initial Catalog=Oficina;Data Source=.\sqlexpress";

            //Definir o comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            //Definir a instrução SQL
            string instrucaoSQL =
                string.Format(@"Update veiculo set Modelo = '{0}', 
                Cor = '{1}', Ano = {2} Where Placa = '{3}'",
                modeloTextBox.Text, corTextBox.Text,
                anoTextBox.Text, placaTextBox.Text);

            cmd.CommandText = instrucaoSQL;

            //Executar
            try
            {
                //Abrir a conexão
                cn.Open();

                //Executar o comando
                cmd.ExecuteNonQuery();

                //Confirmar a operação
                MessageBox.Show("Operação concluída com sucesso", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Fechar a conexão
                cn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro - " + ex.Number,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este veículo?", "Alerta de Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //Estabelecer a conexão
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString =
                            @"Integrated Security=SSPI;Persist Security Info=False;
                        Initial Catalog=Oficina;Data Source=.\sqlexpress";

                //Definir o comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                //Definir a instrução SQL
                string instrucaoSQL =
                    string.Format("Delete veiculo Where Placa = '{0}'",
                    placaTextBox.Text);

                cmd.CommandText = instrucaoSQL;

                //Executar
                try
                {
                    //Abrir a conexão
                    cn.Open();

                    //Executar o comando
                    cmd.ExecuteNonQuery();

                    //Limpar Tela
                    LimparTela();

                    //Confirmar a operação
                    MessageBox.Show("Operação concluída com sucesso", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Fechar a conexão
                    cn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro - " + ex.Number,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void procurarButton_Click(object sender, EventArgs e)
        {
            //Estabelecer a conexão
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString =
                        @"Integrated Security=SSPI;Persist Security Info=False;
                        Initial Catalog=Oficina;Data Source=.\sqlexpress";

            //Definir o comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            //Definir a instrução SQL
            string instrucaoSQL =
                string.Format("Select * From Veiculo Where Placa = '{0}'",
                placaTextBox.Text);

            cmd.CommandText = instrucaoSQL;

            //Criar o DataReader
            SqlDataReader dr;

            //Executar
            try
            {
                //Abrir a conexão
                cn.Open();

                //Executar o comando
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    placaTextBox.Text = dr["placa"].ToString();
                    modeloTextBox.Text = dr["modelo"].ToString();
                    corTextBox.Text = dr["cor"].ToString();
                    anoTextBox.Text = dr["ano"].ToString();

                    placaTextBox.Focus();
                    placaTextBox.SelectAll();

                    //Confirmar a operação
                    MessageBox.Show("Operação concluída com sucesso", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Fechar a conexão
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Veículo não localizado", "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro - " + ex.Number,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
