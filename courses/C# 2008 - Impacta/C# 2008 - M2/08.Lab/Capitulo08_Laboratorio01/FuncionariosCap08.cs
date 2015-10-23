using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Capitulo08_Laboratorio01
{
    public partial class FuncionariosCap08 : UserControl
    {
        public FuncionariosCap08()
        {
            InitializeComponent();
        }

        private void FuncionariosCap08_Load(object sender, EventArgs e)
        {
            //Mantém a cor do UserControl igual a cor do formulário
            this.BackColor = this.ParentForm.BackColor;

            //Cria a ConnectionString
            string conexao = 
                    @"Integrated Security=SSPI;Persist Security Info=False;
                    Initial Catalog=NorthWind;Data Source=.\sqlexpress";

            //Cria a instrucaoSQL 
            string instrucaoSQL = 
                    @"Select Firstname + ' ' + LastName as Funcionario From employees Order By 1";

            SqlDataAdapter da = new SqlDataAdapter(instrucaoSQL, conexao);

            DataSet dados = new DataSet();

            da.Fill(dados);

            DataTable tabelaProduto = dados.Tables[0];

            funcionarioComboBox.Items.Clear();
            foreach (DataRow registro in tabelaProduto.Rows)
            {
                funcionarioComboBox.Items.Add(registro["Funcionario"]);
            }
        }

        private void funcionarioComboBox_SelectedIndexChanged(object sender, 
                                                                                            EventArgs e)
        {
            using (SqlConnection cn = 
                new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;
                                            Initial Catalog=NorthWind;Data Source=.\sqlexpress"))
            {
                using (SqlCommand cmd = 
                    new SqlCommand(@"Select * From Employees Where 
                                            Firstname + ' ' + LastName = '" + 
                                            funcionarioComboBox.Text + "'"))
                {
                    cmd.Connection = cn;
                    SqlDataReader dr;
                    try
                    {
                        cn.Open();
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            cargoTextBox.Text = dr["Title"].ToString();

                            admissaoTextBox.Text = 
                                dr["HireDate"].ToString().
                                Substring(0, dr["HireDate"].ToString().Length - 8);

                            nascimentoTextBox.Text = 
                                dr["BirthDate"].ToString().
                                Substring(0, dr["BirthDate"].ToString().Length - 8);

                            observacaoTextBox.Text = dr["Notes"].ToString();
                        }
                        cn.Close();
                    }
                    catch (SqlException)
                    {
                        throw new Exception("Erro ao tentar recuperar os dados");
                    }
                };
            };
        }

        #region ... Propriedades ...
        public string Funcionario
        {
            get {return funcionarioComboBox.Text;}
        }

        public string Cargo
        {
            get { return cargoTextBox.Text; }
        }

        public string Admissao
        {
            get { return admissaoTextBox.Text; }
        }

        public string Nascimento
        {
            get { return nascimentoTextBox.Text; }
        }

        public string Observacao
        {
            get { return observacaoTextBox.Text; }
        }
        #endregion

    }
}
