using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

public partial class Relatorio : System.Web.UI.Page
{
    #region "Carregar Pagina"
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Page.Title = "Pgto de Produtores - Relatório de Pagamentos de Produtor";


        if (IsPostBack == false)
        {
            PreencherPeriodo();
            CarregarRegioesComColeta();
        }
    }
    #endregion

    #region "Gerar Relatorio"
    protected void btnGerarRelatorio_Click(object sender, EventArgs e)
    {
        try
        {
            Session["ID_REGIAO"] = Convert.ToInt32(ddlRegiao.SelectedValue);
            Session["ID_COOPERATIVA"] = Convert.ToInt32(ddlCooperativa.SelectedValue);
            Session["ID_PROPRIEDADE"] = Convert.ToInt32(ddlPropriedade.SelectedValue);
            Session["DT_INICIO"] = txtDataInicial.Text;
            Session["DT_FIM"] = txtDataFinal.Text;
            Session["TP_RELATORIO"] = rbTipoRelatorio.SelectedValue.ToString();

            if (txtDataInicial.Text == string.Empty || txtDataFinal.Text == string.Empty)
                throw new Exception("Preencha a data inicial e a data final");
            if (rbTipoRelatorio.SelectedIndex == -1)
                throw new Exception("Selecione o tipo de relatório!");

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "JavaScript", "window.open('VisualizarRelatorio.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=818, height=695, left= 5, top=5');", true);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('" + ex.Message.ToString() + "');</script>");
        }
        finally
        {
            txtDataInicial.Text = string.Empty;
            txtDataFinal.Text = string.Empty;
            ddlRegiao.Items.Clear();
            ddlCooperativa.Items.Clear();
            ddlPropriedade.Items.Clear();

            CarregarRegioesComColeta();
        }
    }
    #endregion

    #region "Liberar Pagamento"
    protected void btnLiberarPgto_Click(object sender, EventArgs e)
    {
        try
        {
            Pagamento pgto = new Pagamento();
            PagamentoBLL obj = new PagamentoBLL();

            pgto.Id_regiao = Convert.ToInt32(ddlRegiao.SelectedValue);
            pgto.Id_cooperativa = Convert.ToInt32(ddlCooperativa.SelectedValue);
            pgto.Id_propriedade = Convert.ToInt32(ddlPropriedade.SelectedValue);
            pgto.Dt_inicio = txtDataInicial.Text;
            pgto.Dt_fim = txtDataFinal.Text;

            if (txtDataInicial.Text == string.Empty || txtDataFinal.Text == string.Empty)
                throw new Exception("Preencha a data inicial e a data final");
            if (pgto.Id_propriedade == 0)
                throw new Exception("Selecione apenas uma propriedade!");

            string login = Convert.ToString(Session["LOGIN"]);

            bool existePgto = obj.LiberarPagamento(pgto, login);

            if (existePgto == true)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('Pagamentos liberados!');</script>");
            }
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('" + ex.Message.ToString() + "');</script>");
        }
    }
    #endregion

    #region "Preencher DropDownList de Cooperativas"
    protected void ddlRegiao_SelectedIndexChanged(object sender, EventArgs e)
    {
        CooperativaBLL obj = new CooperativaBLL();
        List<Cooperativa> lista = new List<Cooperativa>();
        Cooperativa coop = new Cooperativa();

        LimparCampos();

        int mes = Convert.ToUInt16(ddlPeriodo.SelectedValue.ToString());
        DateTime dataInicialSelecionada = DateTime.Parse("01/" + mes.ToString() + "/" + DateTime.Now.Year);
        DateTime dataFinalSelecionada = dataInicialSelecionada.AddMonths(1).AddDays(-1);

        coop.Regiao = Convert.ToString(ddlRegiao.SelectedValue);
        coop.Dt_inicio = dataInicialSelecionada;
        coop.Dt_fim = dataFinalSelecionada;

        lista = obj.SelecionarCooperativasComColeta(coop);

        foreach (Cooperativa c in lista)
        {
            String cooperativa = c.Id_cooperativa.ToString() + " | " + c.Ds_cooperat.ToString();
            ListItem li = new ListItem(cooperativa, c.Id_cooperativa.ToString());
            ddlCooperativa.Items.Add(li);
        }

        ddlCooperativa.DataBind();
    }
    #endregion

    #region "Preencher DropDownList de Propriedades"
    protected void ddlCooperativa_SelectedIndexChanged(object sender, EventArgs e)
    {
        List<Propriedade> lista = new List<Propriedade>();
        PropriedadeBLL obj = new PropriedadeBLL();
        Regiao r = new Regiao();
        Cooperativa c = new Cooperativa();

        ddlPropriedade.Items.Clear();
        ddlPropriedade.Items.Add("(TODAS)");
        ddlPropriedade.Items[0].Value = "0";

        int mes = Convert.ToUInt16(ddlPeriodo.SelectedValue.ToString());
        DateTime dataInicialSelecionada = DateTime.Parse("01/" + mes.ToString() + "/" + DateTime.Now.Year);
        DateTime dataFinalSelecionada = dataInicialSelecionada.AddMonths(1).AddDays(-1);

        r.Id_regiao = Convert.ToInt32(ddlRegiao.SelectedValue);
        c.Id_cooperativa = Convert.ToString(ddlCooperativa.SelectedValue);
        r.Dt_inicio = dataInicialSelecionada;
        r.Dt_fim = dataFinalSelecionada;

        lista = obj.SelecionarPropriedadesComColeta(r, c);

        foreach (Propriedade p in lista)
        {
            String propriedade = p.Codigo.ToString() + " | " + p.Nome.ToString();
            ListItem li = new ListItem(propriedade, p.Codigo.ToString());
            ddlPropriedade.Items.Add(li);
        }

        ddlPropriedade.DataBind();

        String dtInicial = dataInicialSelecionada.ToString("dd/MM/yyyy");
        String dtFinal = dataFinalSelecionada.ToString("dd/MM/yyyy");

        txtDataInicial.Text = dtInicial;
        txtDataFinal.Text = dtFinal;
    }
    #endregion

    #region "DropDownList de Periodo"
    protected void ddlPeriodo_SelectedIndexChanged(object sender, EventArgs e)
    {
        CarregarRegioesComColeta();
    }
    #endregion

    #region "Metodo Carregar Regiões com Coletas"
    public void CarregarRegioesComColeta()
    {
        List<Regiao> lista = new List<Regiao>();
        Regiao reg = new Regiao();
        RegiaoBLL obj = new RegiaoBLL();

        int mes = Convert.ToUInt16(ddlPeriodo.SelectedValue.ToString());
        DateTime dataInicialSelecionada = DateTime.Parse("01/" + mes.ToString() + "/" + DateTime.Now.Year);
        DateTime dataFinalSelecionada = dataInicialSelecionada.AddMonths(1).AddDays(-1);

        reg.Dt_inicio = dataInicialSelecionada;
        reg.Dt_fim = dataFinalSelecionada;

        ddlRegiao.Items.Clear();
        lista = obj.SelecionarRegioesComColeta(reg);

        ddlRegiao.Items.Add("(SELECIONE)");
        ddlRegiao.Items[0].Value = "0";

        LimparCampos();

        foreach (Regiao r in lista)
        {
            String regiao = r.Id_regiao.ToString() + " | " + r.Ds_regiao.ToString();
            ListItem li = new ListItem(regiao, r.Id_regiao.ToString());
            ddlRegiao.Items.Add(li);
        }
        ddlRegiao.DataBind();

        ddlRegiao.SelectedIndex = 0;

        if (lista.Count == 0)
        {
            ddlRegiao.Items.Clear();
            ddlRegiao.Items.Add("(NÃO HÁ COLETA PARA O PERÍODO)");
            ddlRegiao.Items[0].Value = "0";

            ddlCooperativa.Items.Clear();
            ddlCooperativa.Items.Add("(NÃO HÁ COLETA PARA O PERÍODO)");
            ddlCooperativa.Items[0].Value = "0";

            ddlPropriedade.Items.Clear();
            ddlPropriedade.Items.Add("(NÃO HÁ COLETA PARA O PERÍODO)");
            ddlPropriedade.Items[0].Value = "0";
        }
        else
        {
            LimparCampos();
        }
    }
    #endregion

    #region "Metodo Carregar Período"
    public void PreencherPeriodo()
    {
        DateTime primeiroDiaAno = DateTime.Parse("01/01/" + DateTime.Now.Year);

        for (int contador = 0; contador <= 12; contador++)
        {
            ddlPeriodo.Items.Add(primeiroDiaAno.ToString("MMMM - yyyy"));
            ddlPeriodo.Items[contador].Value = primeiroDiaAno.Month.ToString();

            primeiroDiaAno = primeiroDiaAno.AddMonths(1);
        }

        ddlPeriodo.SelectedIndex = Convert.ToInt16(DateTime.Now.Month - 1);
    }
    #endregion

    #region "Limpar campos"
    public void LimparCampos()
    {
        txtDataInicial.Text = string.Empty;
        txtDataFinal.Text = string.Empty;

        ddlCooperativa.Items.Clear();
        ddlCooperativa.Items.Add("(SELECIONE)");
        ddlCooperativa.Items[0].Value = "0";

        ddlPropriedade.Items.Clear();
        ddlPropriedade.Items.Add("(SELECIONE)");
        ddlPropriedade.Items[0].Value = "0";
    }
    #endregion
}