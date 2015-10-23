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

public class ListaPrecosDAO
{
    #region "Metodo Selecionar"
    public List<ListaPreco> Selecionar()
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "SELECT * FROM TBMPLSTPRC";

        List<ListaPreco> lista = new List<ListaPreco>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListaPreco item = new ListaPreco();

                item.Id_regiao = Convert.ToInt32(dr["ID_REGIAO"]);
                item.Id_cooperat = Convert.ToInt32(dr["ID_COOPERAT"]);
                item.Id_propried = Convert.ToInt32(dr["ID_PROPRIED"]);
                item.Id_produtor = Convert.ToInt32(dr["ID_PRODUTOR"]);
                item.Dt_inicio = Convert.ToDateTime(dr["DT_INICIO"]);
                item.Dt_fim = Convert.ToDateTime(dr["DT_FIM"]);
                item.Id_tipo_leite = Convert.ToChar(dr["ID_TIPO_LEITE"]);
                item.Id_vol_ini = Convert.ToDecimal(dr["ID_VOL_INI"]);
                item.Id_vol_fim = Convert.ToDecimal(dr["ID_VOL_FIM"]);
                item.Id_valor_unit = Convert.ToDecimal(dr["ID_VALOR_UNIT"]);
                item.Login = Convert.ToString(dr["LOGIN"]);

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

    #region "Metodo Incluir"
    public void Incluir(ListaPreco lst)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = cn;
        cmd.CommandText = @"INSERT INTO TBMPLSTPRC (ID_REGIAO, ID_COOPERAT, ID_PROPRIED, ID_PRODUTOR, DT_INICIO, DT_FIM, ID_TIPO_LEITE, ID_VOL_INI, ID_VOL_FIM, ID_VALOR_UNIT, LOGIN) 
                                            VALUES (@ID_REGIAO, @ID_COOPERAT, @ID_PROPRIED, @ID_PRODUTOR, @DT_INICIO, @DT_FIM, @ID_TIPO_LEITE, @ID_VOL_INI, @ID_VOL_FIM, @ID_VALOR_UNIT, @LOGIN)";

        cmd.Parameters.AddWithValue("@ID_REGIAO", lst.Id_regiao);
        cmd.Parameters.AddWithValue("@ID_COOPERAT", lst.Id_cooperat);
        cmd.Parameters.AddWithValue("@ID_PROPRIED", lst.Id_propried);
        cmd.Parameters.AddWithValue("@ID_PRODUTOR", lst.Id_produtor);
        cmd.Parameters.AddWithValue("@DT_INICIO", lst.Dt_inicio);
        cmd.Parameters.AddWithValue("@DT_FIM", lst.Dt_fim);
        cmd.Parameters.AddWithValue("@ID_VOL_INI", lst.Id_vol_ini);
        cmd.Parameters.AddWithValue("@ID_VOL_FIM", lst.Id_vol_fim);
        cmd.Parameters.AddWithValue("@ID_VALOR_UNIT", lst.Id_valor_unit);
        cmd.Parameters.AddWithValue("@LOGIN", lst.Login);

        // Verifica se foi selecionada a opção de cadastrar para todos os tipos de leite
        if (lst.Id_tipo_leite == 'T')
        {
            cmd.Parameters.AddWithValue("@ID_TIPO_LEITE", "B");
            ExecutarComando(cn, cmd);

            cmd.CommandText = @"INSERT INTO TBMPLSTPRC (ID_REGIAO, ID_COOPERAT, ID_PROPRIED, ID_PRODUTOR, DT_INICIO, DT_FIM, ID_TIPO_LEITE, ID_VOL_INI, ID_VOL_FIM, ID_VALOR_UNIT, LOGIN) 
                                            VALUES (@ID_REGIAO, @ID_COOPERAT, @ID_PROPRIED, @ID_PRODUTOR, @DT_INICIO, @DT_FIM, @ID_TIPO_LEITE2, @ID_VOL_INI, @ID_VOL_FIM, @ID_VALOR_UNIT, @LOGIN)";

            // Necessário criar outra variavel, senão ocorre erro
            cmd.Parameters.AddWithValue("@ID_TIPO_LEITE2", "C");
            ExecutarComando(cn, cmd);
        }
        else
        {
            cmd.Parameters.AddWithValue("@ID_TIPO_LEITE", lst.Id_tipo_leite);
            ExecutarComando(cn, cmd);
        }
    }
    #endregion

    #region "Metodo Alterar"
    public void Alterar(ListaPreco lstValorNovo, ListaPreco lstValorAntigo)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = cn;
        cmd.CommandText = @"UPDATE TBMPLSTPRC SET ID_COOPERAT      = @ID_COOPERAT_NOVO,
                                                  ID_PROPRIED      = @ID_PROPRIED_NOVO,
                                                  ID_PRODUTOR      = @ID_PRODUTOR_NOVO,
                                                  DT_INICIO        = @DT_INICIO_NOVO,
                                                  DT_FIM           = @DT_FIM_NOVO,
                                                  ID_TIPO_LEITE    = @ID_TIPO_LEITE_NOVO,
                                                  ID_VOL_INI       = @ID_VOL_INI_NOVO,
                                                  ID_VOL_FIM       = @ID_VOL_FIM_NOVO,
                                                  ID_VALOR_UNIT    = @ID_VALOR_UNIT_NOVO,
                                                  LOGIN            = @LOGIN_NOVO
                                               WHERE ID_REGIAO     = @ID_REGIAO_ANTIGO
                                                 AND ID_COOPERAT   = @ID_COOPERAT_ANTIGO
                                                 AND ID_PROPRIED   = @ID_PROPRIED_ANTIGO
                                                 AND ID_PRODUTOR   = @ID_PRODUTOR_ANTIGO
                                                 AND DT_INICIO     = @DT_INICIO_ANTIGO
                                                 AND DT_FIM        = @DT_FIM_ANTIGO
                                                 AND ID_TIPO_LEITE = @ID_TIPO_LEITE_ANTIGO
                                                 AND ID_VOL_INI    = @ID_VOL_INI_ANTIGO
                                                 AND ID_VOL_FIM    = @ID_VOL_FIM_ANTIGO
                                                 AND ID_VALOR_UNIT = @ID_VALOR_UNIT_ANTIGO";

        //cmd.CommandText = @"UPDATE TBMPLSTPRC SET ID_VOL_FIM = '" + lstValorNovo.Id_vol_fim + "' WHERE ID_REGIAO = " + lstValorAntigo.Id_regiao + " AND ID_PROPRIED = " + lstValorAntigo.Id_propried + " AND DT_INICIO = Convert(SmallDateTime, '" + lstValorAntigo.Dt_inicio + "',103) AND DT_FIM = Convert(SmallDateTime, '" + lstValorAntigo.Dt_fim + "',103) AND ID_TIPO_LEITE = '" + lstValorAntigo.Id_tipo_leite + "' AND ID_VOL_INI = '" + lstValorAntigo.Id_vol_ini + "' AND ID_VOL_FIM = '" + lstValorAntigo.Id_vol_fim + "' AND ID_VALOR_UNIT = '" + lstValorAntigo.Id_valor_unit + "'";

        DefinirParametroAtualizar(lstValorNovo, lstValorAntigo, cmd);
        ExecutarComando(cn, cmd);
    }

    private static void DefinirParametroAtualizar(ListaPreco lstValorNovo, ListaPreco lstValorAntigo, SqlCommand cmd)
    {
        cmd.Parameters.AddWithValue("@ID_COOPERAT_NOVO", lstValorNovo.Id_cooperat);
        cmd.Parameters.AddWithValue("@ID_PROPRIED_NOVO", lstValorNovo.Id_propried);
        cmd.Parameters.AddWithValue("@ID_PRODUTOR_NOVO", lstValorNovo.Id_produtor);
        cmd.Parameters.AddWithValue("@DT_INICIO_NOVO", lstValorNovo.Dt_inicio);
        cmd.Parameters.AddWithValue("@DT_FIM_NOVO", lstValorNovo.Dt_fim);
        cmd.Parameters.AddWithValue("@ID_TIPO_LEITE_NOVO", lstValorNovo.Id_tipo_leite);
        cmd.Parameters.AddWithValue("@ID_VOL_INI_NOVO", lstValorNovo.Id_vol_ini);
        cmd.Parameters.AddWithValue("@ID_VOL_FIM_NOVO", lstValorNovo.Id_vol_fim);
        cmd.Parameters.AddWithValue("@ID_VALOR_UNIT_NOVO", lstValorNovo.Id_valor_unit);
        cmd.Parameters.AddWithValue("@LOGIN_NOVO", lstValorNovo.Login);

        cmd.Parameters.AddWithValue("@ID_REGIAO_ANTIGO", lstValorAntigo.Id_regiao);
        cmd.Parameters.AddWithValue("@ID_COOPERAT_ANTIGO", lstValorAntigo.Id_cooperat);
        cmd.Parameters.AddWithValue("@ID_PROPRIED_ANTIGO", lstValorAntigo.Id_propried);
        cmd.Parameters.AddWithValue("@ID_PRODUTOR_ANTIGO", lstValorAntigo.Id_produtor);
        cmd.Parameters.AddWithValue("@DT_INICIO_ANTIGO", lstValorAntigo.Dt_inicio);
        cmd.Parameters.AddWithValue("@DT_FIM_ANTIGO", lstValorAntigo.Dt_fim);
        cmd.Parameters.AddWithValue("@ID_TIPO_LEITE_ANTIGO", lstValorAntigo.Id_tipo_leite);
        cmd.Parameters.AddWithValue("@ID_VOL_INI_ANTIGO", lstValorAntigo.Id_vol_ini);
        cmd.Parameters.AddWithValue("@ID_VOL_FIM_ANTIGO", lstValorAntigo.Id_vol_fim);
        cmd.Parameters.AddWithValue("@ID_VALOR_UNIT_ANTIGO", lstValorAntigo.Id_valor_unit);
    }
    #endregion

    #region "Metodo Excluir"
    public void Excluir(ListaPreco lst)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = cn;
        cmd.CommandText = @"DELETE FROM TBMPLSTPRC WHERE ID_REGIAO     = @ID_REGIAO
                                                     AND ID_COOPERAT   = @ID_COOPERAT
                                                     AND ID_PROPRIED   = @ID_PROPRIED
                                                     AND ID_PRODUTOR   = @ID_PRODUTOR
                                                     AND DT_INICIO     = @DT_INICIO 
                                                     AND DT_FIM        = @DT_FIM 
                                                     AND ID_TIPO_LEITE = @ID_TIPO_LEITE
                                                     AND ID_VOL_INI    = @ID_VOL_INI
                                                     AND ID_VOL_FIM    = @ID_VOL_FIM
                                                     AND ID_VALOR_UNIT = @ID_VALOR_UNIT";

        cmd.Parameters.AddWithValue("@ID_REGIAO", lst.Id_regiao);
        cmd.Parameters.AddWithValue("@ID_COOPERAT", lst.Id_cooperat);
        cmd.Parameters.AddWithValue("@ID_PROPRIED", lst.Id_propried);
        cmd.Parameters.AddWithValue("@ID_PRODUTOR", lst.Id_produtor);
        cmd.Parameters.AddWithValue("@DT_INICIO", lst.Dt_inicio);
        cmd.Parameters.AddWithValue("@DT_FIM", lst.Dt_fim);
        cmd.Parameters.AddWithValue("@ID_TIPO_LEITE", lst.Id_tipo_leite);
        cmd.Parameters.AddWithValue("@ID_VOL_INI", lst.Id_vol_ini);
        cmd.Parameters.AddWithValue("@ID_VOL_FIM", lst.Id_vol_fim);
        cmd.Parameters.AddWithValue("@ID_VALOR_UNIT", lst.Id_valor_unit);

        ExecutarComando(cn, cmd);
    }
    #endregion

    #region "Metodo Pesquisar"
    public List<ListaPreco> Pesquisar(ListaPreco lst)
    {
        SqlConnection cn = new SqlConnection(Conexao.SQL);
        SqlCommand cmd = new SqlCommand("PR_PESQUISAR_LISTA_PRECO", cn);
        cmd.CommandType = CommandType.StoredProcedure;

        String data_inicial = lst.Dt_inicio.ToString("dd/MM/yyyy");
        String data_final = lst.Dt_fim.ToString("dd/MM/yyyy");

        // Verifica se as datas não foram digitadas
        if (data_inicial == "01/01/1900")
            data_inicial = "null";
        if (data_final == "01/01/1900")
            data_final = "null";

        cmd.Parameters.AddWithValue("@ID_REGIAO", lst.Id_regiao);
        cmd.Parameters.AddWithValue("@ID_COOPERATIVA", lst.Id_cooperat);
        cmd.Parameters.AddWithValue("@ID_PROPRIED", lst.Id_propried);
        cmd.Parameters.AddWithValue("@ID_PRODUTOR", lst.Id_produtor);
        cmd.Parameters.AddWithValue("@ID_TIPO_LEITE", lst.Id_tipo_leite);
        cmd.Parameters.AddWithValue("@DT_INICIO", data_inicial);
        cmd.Parameters.AddWithValue("@DT_FIM", data_final);

        List<ListaPreco> lista = new List<ListaPreco>();

        try
        {
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListaPreco item = new ListaPreco();

                item.Id_regiao = Convert.ToInt32(dr["ID_REGIAO"]);
                item.Id_cooperat = Convert.ToInt32(dr["ID_COOPERAT"]);
                item.Ds_cooperat = Convert.ToString(dr["DS_COOPERAT"]);
                item.Id_propried = Convert.ToInt32(dr["ID_PROPRIED"]);
                item.Ds_propried = Convert.ToString(dr["DS_PROPRIED"]);
                item.Id_produtor = Convert.ToInt32(dr["ID_PRODUTOR"]);
                item.Ds_produtor = Convert.ToString(dr["DS_PRODUTOR"]);
                item.Dt_inicio = Convert.ToDateTime(dr["DT_INICIO"]);
                item.Dt_fim = Convert.ToDateTime(dr["DT_FIM"]);
                item.Id_tipo_leite = Convert.ToChar(dr["ID_TIPO_LEITE"]);
                item.Id_vol_ini = Convert.ToDecimal(dr["ID_VOL_INI"]);
                item.Id_vol_fim = Convert.ToDecimal(dr["ID_VOL_FIM"]);
                item.Id_valor_unit = Convert.ToDecimal(dr["ID_VALOR_UNIT"]);
                item.Login = Convert.ToString(dr["LOGIN"]);

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

        // Validação caso não haja dados é feita no botão de pesquisa
        // Se deixar aqui, o método ValidarListaPreco não funciona
        // quando não tiver nenhuma lista cadastrada anteriormente para comparar

        return lista;
    }
    #endregion

    #region "Metodo Privado: ExecutarComando SQL"
    private static void ExecutarComando(SqlConnection cn, SqlCommand cmd)
    {
        try
        {
            cn.Open();
            cmd.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            if (ex.Number == 2627)
                throw new Exception("Não é possível inserir a mesma lista duas vezes! Tente atualiza-la");
            else
                throw new Exception("Ocorreu o seguinte erro: " + ex.Number);
        }

        finally
        {
            cn.Close();
        }
    }
    #endregion
}