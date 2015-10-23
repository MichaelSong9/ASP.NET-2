using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Oficina.Modelos;
using System.Data;
namespace Oficina.DAL
{
	public class VeiculoDAL
	{
        public DataTable Lista()
        {
            var da = new SqlDataAdapter("Select * from Veiculo", Dados.StringDeConexao());
            var tabela = new DataTable();
            da.Fill(tabela);  //Abre a conexao, Cria as colunas, Preenche a tabela e fecha a conexao
            return tabela;
        }

        public List<VeiculoInfo> Listagem()
        {
            var cn = new SqlConnection(Dados.StringDeConexao());
            var cmd = new SqlCommand("Select * from Veiculo", cn);
            cn.Open();
            var dr = cmd.ExecuteReader();
            var lista = new List<VeiculoInfo>();
            while (dr.Read())
            {
                var veiculo = new VeiculoInfo();
                veiculo.Ano = Convert.ToInt16(dr["Ano"]);
                veiculo.Cor = Convert.ToString(dr["Cor"]);
                veiculo.Modelo = Convert.ToString(dr["Modelo"]);
                veiculo.Placa = Convert.ToString(dr["Placa"]);
                lista.Add(veiculo);
            }
            dr.Close();
            cn.Close();
            return lista;
        }


        public void Incluir(VeiculoInfo veiculo)
        {
            //Estabelecer a conexao
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Dados.StringDeConexao();

            //Definir o Comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            //Definir a expressão sql
            cmd.CommandText = "Veiculo_Incluir";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@placa", veiculo.Placa);
            cmd.Parameters.AddWithValue("@modelo", veiculo.Modelo);
            cmd.Parameters.AddWithValue("@cor", veiculo.Cor);
            cmd.Parameters.AddWithValue("@ano", veiculo.Ano);

            //Executar
            try
            {
                //Abrir a conexao
                cn.Open();

                //Executar o comando
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na conexão:" + ex.Number);

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

	}
}
