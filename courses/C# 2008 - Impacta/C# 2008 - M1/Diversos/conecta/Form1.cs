using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace conecta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AcessaDados()
        {
            string conexao, instrucaoSQL;

            conexao = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=.\\SqlExpress";
            instrucaoSQL = sqlTextBox.Text.Trim() + ";" + sql2TextBox.Text.Trim();

            SqlDataAdapter da = new SqlDataAdapter(instrucaoSQL, conexao);

            DataSet ds =new DataSet();
            da.Fill(ds);

            dgv.DataSource=ds.Tables[0];
            dgv2.DataSource = ds.Tables[1];

        }

        private void CarregaButton_Click(object sender, EventArgs e)
        {
            AcessaDados();
        }
    }
}