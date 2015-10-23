using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Conexao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //conecta com o server local
            string conexao = "server=localhost;Trusted_Connection=yes; database=Loja";
            //string conexao = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Loja;Data Source=.";
            
            //carrega os dados
            string escolheDados = "Select 'Cliente' as tipo,* from Cliente order by 2;Select 'Fornecedor' as tipo,* from fornecedor order by 2";

            //cria o DataAdapter - conecta
            SqlDataAdapter DataAdapter = new SqlDataAdapter(escolheDados, conexao);

           
            DataSet Dados = new DataSet();

            //preenche o dataset
            DataAdapter.Fill(Dados);

             //cria a variável de dados
            DataTable tabela = Dados.Tables[0];

            listBox1.Items.Clear();
            foreach (DataRow registro in tabela.Rows)
            {
                listBox1.Items.Add(registro["tipo"] + "  - " +registro["Nome"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}