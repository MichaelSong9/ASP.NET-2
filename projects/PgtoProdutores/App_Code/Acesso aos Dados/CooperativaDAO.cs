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

public class CooperativaDAO
{
    public List<Cooperativa> CarregarCooperativas(Cooperativa c)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand("PR_COOP_REGIAO", cn);

        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ID_REGIAO", c.Regiao);

        List<Cooperativa> lista = new List<Cooperativa>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cooperativa lst = new Cooperativa();

                lst.Regiao = Convert.ToString(dr["ID_REGIAO"]);
                lst.Id_cooperativa = Convert.ToString(dr["ID_COOPERAT"]);
                lst.Ds_cooperat = Convert.ToString(dr["DS_COOPERAT"]);

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

    public List<Cooperativa> SelecionarCooperativasComColeta(Cooperativa c)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand("PR_PESQUISAR_COOPERATIVAS_COM_COLETA", cn);
        cmd.CommandType = CommandType.StoredProcedure;

        String data_inicial = c.Dt_inicio.ToString("dd/MM/yyyy");
        String data_final = c.Dt_fim.ToString("dd/MM/yyyy");

        cmd.Parameters.AddWithValue("@ID_REGIAO", c.Regiao);
        cmd.Parameters.AddWithValue("@DT_INICIO", data_inicial);
        cmd.Parameters.AddWithValue("@DT_FIM", data_final);

        List<Cooperativa> lista = new List<Cooperativa>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cooperativa item = new Cooperativa();

                item.Id_cooperativa = Convert.ToString(dr["ID_COOPERAT"]);
                item.Ds_cooperat = Convert.ToString(dr["DS_COOPERAT"]);

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