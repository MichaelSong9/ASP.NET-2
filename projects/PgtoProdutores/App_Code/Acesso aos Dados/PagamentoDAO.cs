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

using CrystalDecisions.Web;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

public class PagamentoDAO
{
    #region"Relatorio de Pagamento de Produtores"
    public ReportDocument GerarRelatorioPgtoProdutores(Pagamento pgto, String strPathreport)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        DataSet ds = new DataSet();
        CrystalReportSource crpt = new CrystalReportSource();
        ReportDocument rpt = new ReportDocument();
        SqlCommand cmd = new SqlCommand("PR_REL_PGTO_PRODUTORES", cn);

        cmd.CommandType = CommandType.StoredProcedure;
        
        cmd.Parameters.AddWithValue("@ID_REGIAO", pgto.Id_regiao);
        cmd.Parameters.AddWithValue("@ID_COOPERATIVA", pgto.Id_cooperativa);
        cmd.Parameters.AddWithValue("@ID_PROPRIED", pgto.Id_propriedade);
        cmd.Parameters.AddWithValue("@DT_INICIO", pgto.Dt_inicio);
        cmd.Parameters.AddWithValue("@DT_FIM", pgto.Dt_fim);
        cmd.Parameters.AddWithValue("@TP_RELATORIO", pgto.Tp_relatorio);

        try
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataTable dataTable = ds.Tables[0];
                rpt.Load(strPathreport);
                rpt.SetDataSource(dataTable);
            }
            else
            {
                throw new Exception("Não há coleta cadastrada para o período informado!");
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
        return rpt;
    }

    #endregion

    #region "Liberar Pagamentos"
    public bool LiberarPagamento(Pagamento pgto, String usuario)
    {
        // Verifica se há pagamento para os produtores
        DataSet ds = new DataSet();
        ds = ListarColetas(pgto);

        //Se houver pagamento, libera o pagamento e grava o log
        if (ds != null && ds.Tables[0].Rows.Count > 0)
        {
            try
            {
                LiberarPagto(pgto);
                GravarLogExportacao(usuario);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no servidor nro." + ex.Number);
                //return false;
            }
        }
        else
        {
            throw new Exception("Não há pagamentos para o produtor selecionado!");
            //return false;
        }
    }
    #endregion

    #region"Listar coletas que serão pagas"
    private DataSet ListarColetas(Pagamento pgto)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand("PR_REL_PGTO_PRODUTORES", cn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ID_REGIAO", pgto.Id_regiao);
        cmd.Parameters.AddWithValue("@ID_COOPERATIVA", pgto.Id_cooperativa);
        cmd.Parameters.AddWithValue("@ID_PROPRIED", pgto.Id_propriedade);
        cmd.Parameters.AddWithValue("@DT_INICIO", pgto.Dt_inicio);
        cmd.Parameters.AddWithValue("@DT_FIM", pgto.Dt_fim);
        cmd.Parameters.AddWithValue("@TP_RELATORIO", "A");

        try
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro no servidor nro." + ex.Number);
        }
        finally
        {
            cn.Close();
        }
        return ds;
    }
    #endregion

    #region "Liberar pagamento no MK"
    private void LiberarPagto(Pagamento pgto)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand("PR_INTEG_PAGTO_PROPRIED", cn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@REGIAO", pgto.Id_regiao);
        cmd.Parameters.AddWithValue("@COOPERATIVA", pgto.Id_cooperativa);
        cmd.Parameters.AddWithValue("@PROPRIEDADE", pgto.Id_propriedade);
        cmd.Parameters.AddWithValue("@DTINI", pgto.Dt_inicio);
        cmd.Parameters.AddWithValue("@DTFIM", pgto.Dt_fim);

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
    #endregion

    #region "Gravar log de exportação do arquivo"
    private void GravarLogExportacao(String usuario)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand("PR_IN_TB_LOG_EXP_ARQ", cn);
        cmd.CommandType = CommandType.StoredProcedure;

        UsuarioDAO u = new UsuarioDAO();
        String cd_usuario = u.ObterCodigoUsuario(usuario);

        Int32 sequencia = this.ObterultimoRegistro();
        String nomeArquivo = ("icoleta." + Convert.ToString(sequencia));

        cmd.Parameters.AddWithValue("@ID_SEQUENCIAL", Convert.ToString(sequencia));
        cmd.Parameters.AddWithValue("@NOM_ARQUIV0", nomeArquivo);
        cmd.Parameters.AddWithValue("@CD_USUARIO", cd_usuario);
        cmd.Parameters.AddWithValue("@CD_OPERACAO", Convert.ToString(1));
        cmd.Parameters.AddWithValue("@CD_SISTEMA", Convert.ToString(1));

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
    #endregion

    #region "Função para obter o último registro na tabela de Arquivos"
    private Int32 ObterultimoRegistro()
    {
        Int32 sequencia = 0;
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = @"SELECT ISNULL(MAX(ID_SEQUENCIAL),0) FROM  TB_LOG_EXP_ARQ WHERE CD_OPERACAO = 1 AND CD_SISTEMA = 1";

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                sequencia = Convert.ToInt32(dr[0]);
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Ocorreu o seguinte erro: " + ex.Number);
        }

        finally
        {
            cn.Close();
        }

        return sequencia;
    }
    #endregion
}