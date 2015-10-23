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

public class RegiaoDAO
{
    public List<Regiao> Selecionar()
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "SELECT * FROM TBMPREGIAO";

        List<Regiao> lista = new List<Regiao>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Regiao lst = new Regiao();

                lst.Id_regiao = Convert.ToInt32(dr["ID_REGIAO"]);
                lst.Ds_regiao = Convert.ToString(dr["DS_REGIAO"]);

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

    #region "Metodo Selecionar Regiões com Coleta"
    public List<Regiao> SelecionarRegioesComColeta(Regiao reg)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand("PR_PESQUISAR_REGIOES_COM_COLETA", cn);
        cmd.CommandType = CommandType.StoredProcedure;

        String data_inicial = reg.Dt_inicio.ToString("dd/MM/yyyy");
        String data_final = reg.Dt_fim.ToString("dd/MM/yyyy");

        // Verifica se as datas não foram digitadas
        if (data_inicial == "01/01/1900")
            data_inicial = "null";
        if (data_final == "01/01/1900")
            data_final = "null";

        cmd.Parameters.AddWithValue("@DT_INICIO", data_inicial);
        cmd.Parameters.AddWithValue("@DT_FIM", data_final);

        List<Regiao> lista = new List<Regiao>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Regiao item = new Regiao();

                item.Id_regiao = Convert.ToInt32(dr["ID_REGIAO"]);
                item.Ds_regiao = Convert.ToString(dr["DS_REGIAO"]);

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
    #endregion


    public List<Regiao> SelecionarRegioesComProdutores()
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "SELECT ID_REGIAO, DS_REGIAO FROM TBMPREGIAO WHERE ID_REGIAO IN ( SELECT DISTINCT ID_REGIAO FROM TBMPCOOPPROD ) ORDER BY ID_REGIAO";

        List<Regiao> lista = new List<Regiao>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Regiao lst = new Regiao();

                lst.Id_regiao = Convert.ToInt32(dr["ID_REGIAO"]);
                lst.Ds_regiao = Convert.ToString(dr["DS_REGIAO"]);

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