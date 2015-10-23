using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

public class ProdutorDAO
{
    public List<Produtor> CarregarProdutores(Regiao regiao, Cooperativa cooperativa, Propriedade propriedade)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand("PR_LISTAR_PRODUTORES", cn);

        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ID_REGIAO", regiao.Id_regiao);
        cmd.Parameters.AddWithValue("@ID_COOPERATIVA", cooperativa.Id_cooperativa);
        cmd.Parameters.AddWithValue("@ID_PROPRIEDADE", propriedade.Codigo);

        List<Produtor> lista = new List<Produtor>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Produtor lst = new Produtor();
                lst.Id_produtor_coop = Convert.ToString(dr["ID_PRODUTOR_COOP"]);
                lst.Cod_produtor = Convert.ToString(dr["ID_PRODUTOR"]);
                lst.Ds_produtor = Convert.ToString(dr["DS_PRODUTOR"]);

                lista.Add(lst);
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

    public List<Produtor> SelecionarProdutoresComColeta(Regiao regiao, Cooperativa cooperativa, Propriedade propriedade)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand("PR_PESQUISAR_PRODUTORES_COM_COLETA", cn);
        cmd.CommandType = CommandType.StoredProcedure;

        String data_inicial = cooperativa.Dt_inicio.ToString("dd/MM/yyyy");
        String data_final = cooperativa.Dt_fim.ToString("dd/MM/yyyy");

        cmd.Parameters.AddWithValue("@ID_REGIAO", regiao.Id_regiao);
        cmd.Parameters.AddWithValue("@ID_COOPERATIVA", cooperativa.Id_cooperativa);
        cmd.Parameters.AddWithValue("@ID_PROPRIEDADE", propriedade.Codigo);
        cmd.Parameters.AddWithValue("@DT_INICIO", data_inicial);
        cmd.Parameters.AddWithValue("@DT_FIM", data_final);

        List<Produtor> lista = new List<Produtor>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Produtor item = new Produtor();

                item.Id_produtor_coop = Convert.ToString(dr["ID_PRODUTOR_COOP"]);
                item.Cod_produtor = Convert.ToString(dr["ID_PRODUTOR"]);
                item.Ds_produtor = Convert.ToString(dr["DS_PRODUTOR"]);
                item.Id_tipo_leite = Convert.ToString(dr["ID_TIPO_LEITE"]);

                lista.Add(item);
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


    public List<Produtor> SelecionarTipoLeiteColetado(Regiao regiao, Cooperativa cooperativa, Propriedade propriedade, Produtor produtor)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand("PR_PESQUISAR_PRODUTORES_TP_LEITE", cn);
        cmd.CommandType = CommandType.StoredProcedure;

        String data_inicial = cooperativa.Dt_inicio.ToString("dd/MM/yyyy");
        String data_final = cooperativa.Dt_fim.ToString("dd/MM/yyyy");

        cmd.Parameters.AddWithValue("@ID_REGIAO", regiao.Id_regiao);
        cmd.Parameters.AddWithValue("@ID_COOPERATIVA", cooperativa.Id_cooperativa);
        cmd.Parameters.AddWithValue("@ID_PROPRIEDADE", propriedade.Codigo);
        cmd.Parameters.AddWithValue("@ID_PRODUTOR", produtor.Cod_produtor);
        cmd.Parameters.AddWithValue("@DT_INICIO", data_inicial);
        cmd.Parameters.AddWithValue("@DT_FIM", data_final);

        List<Produtor> lista = new List<Produtor>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Produtor item = new Produtor();

                item.Id_produtor_coop = Convert.ToString(dr["ID_PRODUTOR_COOP"]);
                item.Cod_produtor = Convert.ToString(dr["ID_PRODUTOR"]);
                item.Ds_produtor = Convert.ToString(dr["DS_PRODUTOR"]);
                item.Id_tipo_leite = Convert.ToString(dr["ID_TIPO_LEITE"]);

                lista.Add(item);
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

}