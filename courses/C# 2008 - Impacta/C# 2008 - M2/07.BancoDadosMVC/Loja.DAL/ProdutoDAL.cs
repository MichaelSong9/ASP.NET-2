using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using Loja.Modelo;

namespace Loja.DAL
{
    public class ProdutoDAL
    {
        public void Incluir(ProdutoInfo produto)
        {
            SqlConnection cn = new SqlConnection(Dados.Conexao);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandText = @"INSERT INTO PRODUTOS (CODIGO, NOME, PRECO, ESTOQUE) VALUES (@CODIGO, @NOME, @PRECO, @ESTOQUE)";

            DefinirParametro(produto, cmd);
            ExecutarComando(cn, cmd);
        }

        public void Alterar(ProdutoInfo produto)
        {
            SqlConnection cn = new SqlConnection(Dados.Conexao);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandText = @"UPDATE PRODUTOS SET NOME=@nome, PRECO=@preco, ESTOQUE=@estoque WHERE CODIGO=@codigo";
         
            DefinirParametro(produto, cmd);
            ExecutarComando(cn, cmd);
        }

        public void Excluir(ProdutoInfo produto)
        {
            SqlConnection cn = new SqlConnection(Dados.Conexao);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandText = @"DELETE FROM PRODUTOS WHERE CODIGO = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", produto.Codigo);
            ExecutarComando(cn, cmd);
        }

        public List<ProdutoInfo> Listagem()
        {
            var cn = new SqlConnection(Dados.Conexao);
            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM PRODUTOS";

            var lista = new List<ProdutoInfo>();

            try
            {
                cn.Open();
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var produto = new ProdutoInfo();

                    produto.Codigo = Convert.ToInt32(dr["Codigo"]);
                    produto.Nome = Convert.ToString(dr["Nome"]);
                    produto.Preco = Convert.ToDecimal(dr["Preco"]);
                    produto.Estoque = Convert.ToInt32(dr["Estoque"]);

                    lista.Add(produto);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no servidor nro." + ex.Number);
            }

            finally
            {
                cn.Close();
            }
            return lista;
        }

        private static void DefinirParametro(ProdutoInfo produto, SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@CODIGO", produto.Codigo);
            cmd.Parameters.AddWithValue("@NOME", produto.Nome);
            cmd.Parameters.AddWithValue("@PRECO", produto.Preco);
            cmd.Parameters.AddWithValue("@ESTOQUE", produto.Estoque);
        }

        private static void ExecutarComando(SqlConnection cn, SqlCommand cmd)
        {
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no servidor nro." + ex.Number);
            }

            finally
            {
                cn.Close();
            }
        }
    }
}