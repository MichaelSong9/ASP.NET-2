using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Lab.Cap06
{
    public partial class frmCAP6 : Form
    {
        public frmCAP6()
        {
            InitializeComponent();
        }

        private void LimparTela()
        {
            txtPlaca.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtAno.Clear();

            txtPlaca.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"INTEGRATED SECURITY = SSPI; PERSIST SECURITY INFO = FALSE; INITIAL CATALOG = OFICINA; DATA SOURCE = .\SQLEXPRESS";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            string instrucaoSQL = string.Format("INSERT VEICULO VALUES ('{0}', '{1}', '{2}', '{3}')", txtPlaca.Text,
                                                                                                      txtModelo.Text,
                                                                                                      txtCor.Text,
                                                                                                      txtAno.Text);
            cmd.CommandText = instrucaoSQL;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                LimparTela();
                MessageBox.Show("Operação concluída com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro - " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"INTEGRATED SECURITY = SSPI; PERSIST SECURITY INFO = FALSE; INITIAL CATALOG = OFICINA; DATA SOURCE = .\SQLEXPRESS";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            string instrucaoSQL = string.Format("UPDATE VEICULO SET MODELO = '{0}' , COR = '{1}' , ANO = '{2}' WHERE PLACA = '{3}'",
                                                                                                      txtModelo.Text,
                                                                                                      txtCor.Text,
                                                                                                      txtAno.Text,
                                                                                                      txtPlaca.Text);
            cmd.CommandText = instrucaoSQL;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                LimparTela();
                MessageBox.Show("Operação concluída com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro - " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este veículo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"INTEGRATED SECURITY = SSPI; PERSIST SECURITY INFO = FALSE; INITIAL CATALOG = OFICINA; DATA SOURCE = .\SQLEXPRESS";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                string instrucaoSQL = string.Format("DELETE VEICULO WHERE PLACA = '{0}'", txtPlaca.Text);

                cmd.CommandText = instrucaoSQL;

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    LimparTela();
                    MessageBox.Show("Operação concluída com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Alerta de Erro - " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"INTEGRATED SECURITY = SSPI;PERSIST SECURITY INFO=FALSE; INITIAL CATALOG=OFICINA; DATA SOURCE = .\SQLEXPRESS";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            string instrucaoSQL = string.Format("SELECT * FROM VEICULO WHERE PLACA = '{0}'", txtPlaca.Text);
            
            cmd.CommandText= instrucaoSQL;

            SqlDataReader dr;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtPlaca.Text = dr["placa"].ToString();
                    txtModelo.Text = dr["modelo"].ToString();
                    txtCor.Text = dr["cor"].ToString();
                    txtAno.Text = dr["ano"].ToString();

                    txtPlaca.Focus();
                    txtPlaca.SelectAll();


                    MessageBox.Show("Operação concluída com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Veículo não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro - " + ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
