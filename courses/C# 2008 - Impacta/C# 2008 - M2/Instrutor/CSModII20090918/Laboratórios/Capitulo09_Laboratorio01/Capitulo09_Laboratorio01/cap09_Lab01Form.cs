using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace Capitulo09_Laboratorio01
{
    public partial class cap09_Lab01Form : Form
    {
        public cap09_Lab01Form()
        {
            InitializeComponent();
        }



        private void inserirButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private static void Inserir()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString =
                        @"Integrated Security=SSPI;Persist Security Info=False;
                        Initial Catalog=BackGround;Data Source=.\sqlexpress";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Insert Cliente values('NomeCliente')";
            cmd.CommandType = CommandType.Text;

            try
            {
                cn.Open();
                for (int i = 0; i <= 10000; i++)
                {
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao conectar");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Inserir();
        }

        private void mensagemButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BackgroundWorker");
        }

    }
}
