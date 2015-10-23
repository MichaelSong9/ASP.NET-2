using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loja.Modelos;
using System.Data.SqlClient;

namespace Loja.DAL
{
    public class ProdutoDAL
    {
        public void Incluir(ProdutoInfo produto )
        { 
            //Definir a conexao
            var cn = new SqlConnection(Dados.Conexao);

            //Definir o comando
            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText=@"insert into produtos(codigo,nome,preco,estoque)
                                            values(@codigo,@nome,@preco,@estoque)";
            //Definir os parametros
            DefinirParametros(produto, cmd);
            ExecutarComando(cn,cmd);
        }

        public void Alterar(ProdutoInfo produto)
        {
            var cn = new SqlConnection(Dados.Conexao);
            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = 
                            @"update produtos 
                            set nome=@nome, preco=@preco, estoque=@estoque 
                            where codigo=@codigo";

            DefinirParametros(produto, cmd);
            ExecutarComando(cn, cmd);

        }

        public void Excluir(ProdutoInfo produto)
        {
            var cn = new SqlConnection(Dados.Conexao);
            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText =@"delete from produtos  where codigo=@codigo";
            cmd.Parameters.AddWithValue("@codigo", produto.Codigo);
            ExecutarComando(cn, cmd);
        }

        public List<ProdutoInfo> Listagem()
        {
            var cn = new SqlConnection(Dados.Conexao);
            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Select * from Produtos";
            var lista = new List<ProdutoInfo>();
            try
            {
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var p = new ProdutoInfo();
                    p.Codigo = Convert.ToInt32(dr["Codigo"]);
                    p.Nome = Convert.ToString(dr["Nome"]);
                    p.Preco = Convert.ToDecimal(dr["Preco"]);
                    p.Estoque = Convert.ToInt32(dr["Estoque"]);
                    lista.Add(p);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no servidor:" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
           return lista;
        }

        private static void DefinirParametros(ProdutoInfo produto, SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@codigo", produto.Codigo);
            cmd.Parameters.AddWithValue("@nome", produto.Nome);
            cmd.Parameters.AddWithValue("@preco", produto.Preco);
            cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
        }

        private static void ExecutarComando(SqlConnection cn, SqlCommand cmd)
        {
            //Executar
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no servidor. Número " + ex.Number);
            }
            finally
            {
                cn.Close();
            }
        }



    }
}
