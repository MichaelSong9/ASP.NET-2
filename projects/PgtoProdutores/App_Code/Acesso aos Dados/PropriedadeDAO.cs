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

public class PropriedadeDAO
{
    public List<Propriedade> Selecionar(Regiao r, Cooperativa c)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "SELECT * FROM TBMPPROPRIED WHERE ID_REGIAO =" + r.Id_regiao + "AND ID_COOPERAT =" + c.Id_cooperativa + "";

        List<Propriedade> lista = new List<Propriedade>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Propriedade lst = new Propriedade();

                lst.Codigo = Convert.ToString(dr["ID_PROPRIED"]);
                lst.Nome = Convert.ToString(dr["DS_PROPRIED"]);

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

    public List<Propriedade> SelecionarPropriedadesComColeta(Regiao r, Cooperativa c)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand("PR_PESQUISAR_PROPRIEDADES_COM_COLETA", cn);
        cmd.CommandType = CommandType.StoredProcedure;

        String data_inicial = r.Dt_inicio.ToString("dd/MM/yyyy");
        String data_final = r.Dt_fim.ToString("dd/MM/yyyy");

        cmd.Parameters.AddWithValue("@ID_REGIAO", r.Id_regiao);
        cmd.Parameters.AddWithValue("@ID_COOPERATIVA", c.Id_cooperativa);
        cmd.Parameters.AddWithValue("@DT_INICIO", data_inicial);
        cmd.Parameters.AddWithValue("@DT_FIM", data_final);

        List<Propriedade> lista = new List<Propriedade>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Propriedade item = new Propriedade();

                item.Codigo = Convert.ToString(dr["ID_PROPRIED"]);
                item.Nome = Convert.ToString(dr["DS_PROPRIED"]);

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