using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Oficina.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace Oficina.DAL
{
    public class VeiculoDAL
    {
        public void Incluir(VeiculoInfo veiculo)
        {
            //Estabelecer a conexão
            SqlConnection cn = new SqlConnection();
            //            cn.ConnectionString = 
            //                            @"Integrated Security=SSPI;Persist Security Info=False;
            //                            Initial Catalog=Oficina;Data Source=.\sqlexpress";

            cn.ConnectionString = Dados.StringDeConexao();

            //Definir o comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "spVeiculo_Ins";

            //*** É NECESSÁRIO ACRESCENTAR A DIRETIVA using System.Data ***
            cmd.CommandType = CommandType.StoredProcedure;

            //Passando os parâmetros para o comando
            cmd.Parameters.AddWithValue("@placa", veiculo.Placa);
            cmd.Parameters.AddWithValue("@modelo", veiculo.Modelo);
            cmd.Parameters.AddWithValue("@cor", veiculo.Cor);
            cmd.Parameters.AddWithValue("@ano", veiculo.Ano);

            //Executar
            try
            {
                //Abrir a conexão
                cn.Open();

                //Executar o comando
                cmd.ExecuteNonQuery();

                //Fechar a conexão
                cn.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na Conexão - nº " + ex.Number);
            }
        }

        //Este método retorna um DataReader
        public SqlDataReader PesquisarPorPlaca(string placa)
        {
            //Outra forma de instanciar o objeto cn
            SqlConnection cn = new SqlConnection(Dados.StringDeConexao());

            //Outra forma de instanciar o objeto cmd
            SqlCommand cmd = new SqlCommand("spVeiculo_SelPlaca", cn);

            //Necessita da diretiva using System.Data;
            cmd.CommandType = CommandType.StoredProcedure;

            //Passando os parâmetros da stored procedure
            cmd.Parameters.AddWithValue("@placa", placa);

            //Abrir a conexão
            cn.Open();

            //CommandBehavior.CloseConnection atribui ao cmd o comportamento de FECHAR 
            //a conexão após ter concluído a atribuição do DataReader
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            //Retorna os dados
            return dr;
        }

        public void Alterar(VeiculoInfo veiculo)
        {
            //Outra forma de instanciar o objeto cn
            using (SqlConnection cn = new SqlConnection(Dados.StringDeConexao()))
            {
                //Outra forma de instanciar o objeto cmd
                using (SqlCommand cmd = new SqlCommand("spVeiculo_Upd", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@placa",veiculo.Placa);
                    cmd.Parameters.AddWithValue("@modelo",veiculo.Modelo);
                    cmd.Parameters.AddWithValue("@cor",veiculo.Cor);
                    cmd.Parameters.AddWithValue("@ano",veiculo.Ano);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Erro na Conexão - nº " + ex.Number);
                    }
                }
            }
        }

        public void Excluir(VeiculoInfo veiculo)
        {
            //Outra forma de instanciar o objeto cn
            using (SqlConnection cn = new SqlConnection(Dados.StringDeConexao()))
            {
                //Outra forma de instanciar o objeto cmd
                using (SqlCommand cmd = new SqlCommand("spVeiculo_Del", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@placa", veiculo.Placa);
                    
                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Erro na Conexão - nº " + ex.Number);
                    }
                }
            }
        }

    }
}
