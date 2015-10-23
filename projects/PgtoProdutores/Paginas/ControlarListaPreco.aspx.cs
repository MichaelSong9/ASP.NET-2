using System;
using System.Data;
using System.Data.Sql;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

public partial class ControlarListaPreco : System.Web.UI.Page
{
    ListaPreco lstExcluir = new ListaPreco();

    #region "ViewState ListaPreco"
    //É necessario definir a classe ListaPreco como [Serializable]
    private List<ListaPreco> lstAuxiliar
    {
        get
        {
            if (ViewState["ListaPreco"] == null)
                ViewState["ListaPreco"] = new ListaPreco();
            return (List<ListaPreco>)ViewState["ListaPreco"];
        }
        set
        {
            ViewState["ListaPreco"] = value;
        }
    }
    #endregion

    #region "Carregar Pagina"
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Page.Title = "Pgto de Produtores - Lista de Preços";

        if (IsPostBack == false)
        {
            PreencherPeriodo();
            CarregarRegioesComColeta();
        }
    }
    #endregion

    #region "Inserir"
    protected void btnInserir_Click(object sender, EventArgs e)
    {
        try
        {
            ListaPreco lst = new ListaPreco();
            ListaPrecosBLL obj = new ListaPrecosBLL();

            if (txtDataInicial.Text == string.Empty || txtDataFinal.Text == string.Empty)
            {
                throw new Exception("Preencha a data inicial e a data final");
            }

            lst.Id_regiao = Convert.ToInt32(ddlRegiao.SelectedValue);
            lst.Id_cooperat = Convert.ToInt32(ddlCooperativa.SelectedValue);
            lst.Id_propried = Convert.ToInt32(ddlPropriedade.SelectedValue);
            lst.Id_produtor = Convert.ToInt32(ddlProdutor.SelectedValue);
            lst.Dt_inicio = Convert.ToDateTime(txtDataInicial.Text);
            lst.Dt_fim = Convert.ToDateTime(txtDataFinal.Text);
            lst.Id_tipo_leite = Convert.ToChar(ddlTipoLeite.SelectedValue);
            lst.Id_vol_ini = Convert.ToDecimal(txtVolInicial.Text);
            lst.Id_vol_fim = Convert.ToDecimal(txtVolFinal.Text);
            lst.Id_valor_unit = Convert.ToDecimal(txtValUnitario.Text);
            lst.Login = Session["LOGIN"].ToString();

            obj.Incluir(lst);

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('Lista inserida com sucesso!');</script>");

            txtVolInicial.Text = String.Empty;
            txtVolFinal.Text = String.Empty;
            txtValUnitario.Text = String.Empty;

        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('" + ex.Message.ToString() + "');</script>");
        }
    }

    #endregion

    #region "Atualizar"
    protected void btnAtualizar_Click(object sender, EventArgs e)
    {
        try
        {
            ListaPreco lstValorNovo = new ListaPreco();
            ListaPreco lstValorAntigo = new ListaPreco();
            ListaPrecosBLL obj = new ListaPrecosBLL();

            lstValorAntigo.Id_regiao = Convert.ToInt32(Session["ID_REGIAO"].ToString());
            lstValorAntigo.Id_cooperat = Convert.ToInt32(Session["ID_COOPERAT"].ToString());
            lstValorAntigo.Ds_cooperat = Convert.ToString(Session["DS_COOPERAT"]);
            lstValorAntigo.Id_propried = Convert.ToInt32(Session["ID_PROPRIED"].ToString());
            lstValorAntigo.Ds_propried = Convert.ToString(Session["DS_PROPRIED"]);
            lstValorAntigo.Id_produtor = Convert.ToInt32(Session["ID_PRODUTOR"].ToString());
            lstValorAntigo.Ds_produtor = Convert.ToString(Session["DS_PRODUTOR"]);
            lstValorAntigo.Dt_inicio = Convert.ToDateTime(Session["DT_INICIO"].ToString());
            lstValorAntigo.Dt_fim = Convert.ToDateTime(Session["DT_FIM"].ToString());
            lstValorAntigo.Id_tipo_leite = Convert.ToChar(Session["ID_TIPO_LEITE"].ToString());
            lstValorAntigo.Id_vol_ini = Convert.ToDecimal(Session["ID_VOL_INI"].ToString());
            lstValorAntigo.Id_vol_fim = Convert.ToDecimal(Session["ID_VOL_FIM"].ToString());
            lstValorAntigo.Id_valor_unit = Convert.ToDecimal(Session["ID_VALOR_UNIT"].ToString());

            lstValorNovo.Id_regiao = Convert.ToInt32(ddlRegiao.SelectedValue);
            lstValorNovo.Id_cooperat = Convert.ToInt32(ddlCooperativa.SelectedValue);
            lstValorNovo.Ds_cooperat = Convert.ToString(ddlCooperativa.SelectedItem.ToString());
            lstValorNovo.Id_propried = Convert.ToInt32(ddlPropriedade.SelectedValue);
            lstValorNovo.Ds_propried = Convert.ToString(ddlPropriedade.SelectedItem.ToString());
            lstValorNovo.Id_produtor = Convert.ToInt32(ddlProdutor.SelectedValue);
            lstValorNovo.Ds_produtor = Convert.ToString(ddlProdutor.SelectedItem.ToString());
            lstValorNovo.Dt_inicio = Convert.ToDateTime(txtDataInicial.Text);
            lstValorNovo.Dt_fim = Convert.ToDateTime(txtDataFinal.Text);
            lstValorNovo.Id_tipo_leite = Convert.ToChar(ddlTipoLeite.SelectedValue);
            lstValorNovo.Id_vol_ini = Convert.ToDecimal(txtVolInicial.Text);
            lstValorNovo.Id_vol_fim = Convert.ToDecimal(txtVolFinal.Text);
            lstValorNovo.Id_valor_unit = Convert.ToDecimal(txtValUnitario.Text);
            lstValorNovo.Login = Convert.ToString(Session["LOGIN"]);

            obj.Alterar(lstValorNovo, lstValorAntigo);

            String mensagem = "A lista de entregas foi alterada com sucesso!";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('" + mensagem + "');</script>");

            gvListaPreco.DataSource = obj.Listagem();
            gvListaPreco.DataBind();
            btnAtualizar.Enabled = false;
            LimparCampos();

            btnInserir.Enabled = true;
            ddlRegiao.Enabled = true;
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('" + ex.Message.ToString() + "');</script>");
        }
    }
    #endregion

    #region "Pesquisar Lista de Preco"
    protected void btnPesquisar2_Click(object sender, EventArgs e)
    {
        ListaPrecosBLL obj = new ListaPrecosBLL();
        List<ListaPreco> lista = new List<ListaPreco>();
        ListaPreco l = new ListaPreco();

        // As datas recebem esse valor inicialmente para serem identificadas como não preenchidas
        DateTime dt_inicial = Convert.ToDateTime("01/01/1900");
        DateTime dt_final = Convert.ToDateTime("01/01/1900");

        if (txtDataInicialPesq.Text != string.Empty)
            dt_inicial = Convert.ToDateTime(txtDataInicialPesq.Text);
        if (txtDataFinalPesq.Text != string.Empty)
            dt_final = Convert.ToDateTime(txtDataFinalPesq.Text);

        try
        {
            l.Id_regiao = Convert.ToInt32(ddlRegiaoPesq.SelectedValue);
            l.Id_cooperat = Convert.ToInt32(ddlCooperativaPesq.SelectedValue);
            l.Id_propried = Convert.ToInt32(ddlPropriedPesq.SelectedValue);
            l.Id_produtor = Convert.ToInt32(ddlProdutorPesq.SelectedValue);
            l.Dt_inicio = dt_inicial;
            l.Dt_fim = dt_final;
            l.Id_tipo_leite = Convert.ToChar(ddlTipoLeitePesq.SelectedValue);

            lista = obj.Pesquisar(l);

            if (lista.Count == 0)
                throw new Exception("Não há dados para a pesquisa realizada");

            lblMensagem.Text = string.Empty;

            //Preenche a lista auxiliar para a paginação do GridView
            lstAuxiliar = lista;
            gvListaPreco.DataSource = lista;
            gvListaPreco.DataBind();
            //Inicia a exibição do GridView sempre pela 1ª pagina
            gvListaPreco.PageIndex = 0;
            //Não traz nenhum ítem selecionado
            gvListaPreco.SelectedIndex = -1;
            ModalPopupExtenderListaPreco.Show();
        }
        catch (Exception ex)
        {
            lblMensagem.Text = ex.Message.ToString();
        }
    }
    #endregion

    #region "Chamar ModalPopup Pesquisar
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        ddlRegiaoPesq.Items.Clear();

        List<Regiao> lista = new List<Regiao>();
        RegiaoBLL obj = new RegiaoBLL();

        ddlRegiaoPesq.Items.Add("TODAS");
        ddlRegiaoPesq.Items[0].Value = "0";

        lista = obj.Selecionar();

        foreach (Regiao r in lista)
        {
            String regiao = r.Id_regiao.ToString() + " | " + r.Ds_regiao.ToString();
            ListItem li = new ListItem(regiao, r.Id_regiao.ToString());
            ddlRegiaoPesq.Items.Add(li);
        }

        ddlRegiaoPesq.DataBind();

        ModalPopupExtenderPesquisar.Show();
        LimparCamposPesquisa();

        LimparCampos();
        CarregarRegioesComColeta();
    }
    #endregion

    #region "Excluir/Selecionar ítem do GridView"
    protected void gvListaPreco_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton Excluir = (LinkButton)e.Row.FindControl("lnkExcluir");
            Excluir.CommandArgument = e.Row.RowIndex.ToString(); // envia o numero da linha selecionada para excluir
            Excluir.Attributes.Add("onclick", "javascript:return confirm('Confirma a exclusão da lista de preço da região " +
            DataBinder.Eval(e.Row.DataItem, "ID_REGIAO") + "?')");

            // Gerar PostBack para o botão Selecionar -> necessario por causa do UpdatePanel
            LinkButton Selecionar = (LinkButton)e.Row.FindControl("lnkSelecionar");
            Selecionar.CommandArgument = e.Row.RowIndex.ToString();
            ScriptManager.GetCurrent(this).RegisterPostBackControl(Selecionar);

            //Formatação das colunas
            //e.Row.Cells[6].Text = string.Format("{0:c}", "BIND('ID_VOL_INI')"); 

            // Alinhamento dos campos texto à esquerda
            e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Left;
            e.Row.Cells[3].HorizontalAlign = HorizontalAlign.Left;
            e.Row.Cells[4].HorizontalAlign = HorizontalAlign.Left;

            // Alinhamento dos campos numericos à direita
            e.Row.Cells[8].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[9].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[10].HorizontalAlign = HorizontalAlign.Right;
        }
    }

    protected void gvListaPreco_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        ListaPrecosBLL obj = new ListaPrecosBLL();
        int index;

        if (e.CommandName == "Delete")
        {
            index = Convert.ToInt32(e.CommandArgument); // recupera a linha selecionada para excluir
            GridViewRow row = gvListaPreco.Rows[index];
            DataKey keys = this.gvListaPreco.DataKeys[Convert.ToInt32(index)];

            foreach (DictionaryEntry d in keys.Values)
            {
                if (d.Key.ToString() == "ID_REGIAO")
                    lstExcluir.Id_regiao = Convert.ToInt32(d.Value.ToString());
                else if (d.Key.ToString() == "ID_COOPERAT")
                    lstExcluir.Id_cooperat = Convert.ToInt32(d.Value.ToString());
                else if (d.Key.ToString() == "DS_COOPERAT")
                    lstExcluir.Ds_cooperat = d.Value.ToString();
                else if (d.Key.ToString() == "ID_PROPRIED")
                    lstExcluir.Id_propried = Convert.ToInt32(d.Value.ToString());
                else if (d.Key.ToString() == "DS_PROPRIED")
                    lstExcluir.Ds_propried = d.Value.ToString();
                else if (d.Key.ToString() == "ID_PRODUTOR")
                    lstExcluir.Id_produtor = Convert.ToInt32(d.Value.ToString());
                else if (d.Key.ToString() == "DS_PRODUTOR")
                    lstExcluir.Ds_produtor = Convert.ToString(d.Value);
                else if (d.Key.ToString() == "DS_PROPRIED")
                    lstExcluir.Ds_produtor = d.Value.ToString();
                else if (d.Key.ToString() == "DT_INICIO")
                    lstExcluir.Dt_inicio = Convert.ToDateTime(d.Value.ToString());
                else if (d.Key.ToString() == "DT_FIM")
                    lstExcluir.Dt_fim = Convert.ToDateTime(d.Value.ToString());
                else if (d.Key.ToString() == "ID_TIPO_LEITE")
                    lstExcluir.Id_tipo_leite = Convert.ToChar(d.Value.ToString());
                else if (d.Key.ToString() == "ID_VOL_INI")
                    lstExcluir.Id_vol_ini = Convert.ToDecimal(d.Value.ToString());
                else if (d.Key.ToString() == "ID_VOL_FIM")
                    lstExcluir.Id_vol_fim = Convert.ToDecimal(d.Value.ToString());
                else if (d.Key.ToString() == "ID_VALOR_UNIT")
                    lstExcluir.Id_valor_unit = Convert.ToDecimal(d.Value.ToString());
            }
        }

        // Recupera o valor da linha selecionada e preenche os TextBoxes
        if (e.CommandName == "Select")
        {
            index = Convert.ToInt32(e.CommandArgument); // recupera a linha selecionada para excluir
            GridViewRow row = gvListaPreco.Rows[index];
            DataKey keys = this.gvListaPreco.DataKeys[Convert.ToInt32(index)];

            ddlRegiao.Enabled = false;
            btnInserir.Enabled = false;

            foreach (DictionaryEntry d in keys.Values)
            {
                if (d.Key.ToString() == "ID_REGIAO")
                {
                    List<Regiao> lista = new List<Regiao>();
                    RegiaoBLL objRegiao = new RegiaoBLL();

                    lista = objRegiao.Selecionar();

                    foreach (Regiao r in lista)
                    {
                        String regiao = r.Id_regiao.ToString() + " | " + r.Ds_regiao.ToString();
                        ListItem li = new ListItem(regiao, r.Id_regiao.ToString());
                        ddlRegiao.Items.Add(li);
                    }
                    ddlRegiao.SelectedValue = d.Value.ToString();
                    Session["ID_REGIAO"] = d.Value.ToString();
                }
                else if (d.Key.ToString() == "DT_INICIO")
                {
                    txtDataInicial.Text = d.Value.ToString();
                    Session["DT_INICIO"] = d.Value.ToString();

                    DateTime data = Convert.ToDateTime(d.Value.ToString());
                    ddlPeriodo.SelectedIndex = Convert.ToInt16(data.Month - 1);
                }
                else if (d.Key.ToString() == "DT_FIM")
                {
                    txtDataFinal.Text = d.Value.ToString();
                    Session["DT_FIM"] = d.Value.ToString();
                }
                else if (d.Key.ToString() == "ID_COOPERAT")
                {
                    //Cooperativa será carregada no dropdownlist da tela inicial
                    CooperativaBLL objCoop = new CooperativaBLL();
                    List<Cooperativa> lista = new List<Cooperativa>();
                    Cooperativa cooperativa = new Cooperativa();

                    ddlCooperativa.Items.Clear();
                    ddlCooperativa.Items.Add("(SELECIONE)");
                    ddlCooperativa.Items[0].Value = "0";

                    ddlPropriedade.Items.Clear();
                    ddlPropriedade.Items.Add("(SELECIONE)");
                    ddlPropriedade.Items[0].Value = "0";

                    ddlProdutor.Items.Clear();
                    ddlProdutor.Items.Add("(SELECIONE)");
                    ddlProdutor.Items[0].Value = "0";

                    cooperativa.Regiao = Convert.ToString(Session["ID_REGIAO"]);

                    lista = objCoop.CarregarCooperativas(cooperativa);

                    foreach (Cooperativa c in lista)
                    {
                        String cooperativa_concatenada = c.Id_cooperativa.ToString() + " | " + c.Ds_cooperat.ToString();
                        ListItem li = new ListItem(cooperativa_concatenada, c.Id_cooperativa.ToString());
                        ddlCooperativa.Items.Add(li);
                    }

                    ddlCooperativa.DataBind();
                    ddlCooperativa.SelectedValue = d.Value.ToString();
                    Session["ID_COOPERAT"] = d.Value.ToString();
                }
                else if (d.Key.ToString() == "DS_COOPERAT")
                {
                    Session["DS_COOPERAT"] = d.Value.ToString();
                }
                else if (d.Key.ToString() == "ID_PROPRIED")
                {
                    // Propriedade será carregado no dropdownlist da tela inicial
                    PropriedadeBLL objProp = new PropriedadeBLL();
                    List<Propriedade> lista = new List<Propriedade>();
                    Regiao regiao = new Regiao();
                    Cooperativa cooperativa = new Cooperativa();

                    ddlPropriedade.Items.Clear();
                    ddlPropriedade.Items.Add("(SELECIONE)");
                    ddlPropriedade.Items[0].Value = "0";

                    ddlProdutor.Items.Clear();
                    ddlProdutor.Items.Add("(SELECIONE)");
                    ddlProdutor.Items[0].Value = "0";

                    regiao.Id_regiao = Convert.ToInt32(Session["ID_REGIAO"]);
                    cooperativa.Id_cooperativa = Convert.ToString(Session["ID_COOPERAT"]);
                    regiao.Dt_inicio = Convert.ToDateTime(Session["DT_INICIO"]);
                    regiao.Dt_fim = Convert.ToDateTime(Session["DT_FIM"]);

                    lista = objProp.SelecionarPropriedadesComColeta(regiao, cooperativa);

                    foreach (Propriedade p in lista)
                    {
                        String prop = p.Codigo.ToString() + " | " + p.Nome.ToString();
                        ListItem li = new ListItem(prop, p.Codigo.ToString());
                        ddlPropriedade.Items.Add(li);
                    }

                    ddlPropriedade.DataBind();
                    ddlPropriedade.SelectedValue = d.Value.ToString();
                    Session["ID_PROPRIED"] = d.Value.ToString();
                }
                else if (d.Key.ToString() == "DS_PROPRIED")
                {
                    Session["DS_PROPRIED"] = d.Value.ToString();
                }
                else if (d.Key.ToString() == "ID_PRODUTOR")
                {
                    // Produtor será carregado no dropdownlist da tela inicial
                    ProdutorBLL objProdutor = new ProdutorBLL();
                    List<Produtor> lista = new List<Produtor>();
                    Regiao regiao = new Regiao();
                    Cooperativa cooperativa = new Cooperativa();
                    Propriedade propriedade = new Propriedade();

                    ddlProdutor.Items.Clear();
                    ddlProdutor.Items.Add("(SELECIONE)");
                    ddlProdutor.Items[0].Value = "0";

                    ddlTipoLeite.Items.Clear();

                    regiao.Id_regiao = Convert.ToInt32(Session["ID_REGIAO"]);
                    cooperativa.Id_cooperativa = Convert.ToString(Session["ID_COOPERAT"]);
                    propriedade.Codigo = Convert.ToString(Session["ID_PROPRIED"]);
                    cooperativa.Dt_inicio = Convert.ToDateTime(Session["DT_INICIO"]);
                    cooperativa.Dt_fim = Convert.ToDateTime(Session["DT_FIM"]);

                    lista = objProdutor.SelecionarProdutoresComColeta(regiao, cooperativa, propriedade);

                    foreach (Produtor prd in lista)
                    {
                        String produtor_concatenado = prd.Cod_produtor + " | " + prd.Id_produtor_coop + " | " + prd.Ds_produtor;
                        ListItem li = new ListItem(produtor_concatenado, prd.Cod_produtor);
                        ddlProdutor.Items.Add(li);
                    }
                    ddlProdutor.DataBind();
                    ddlProdutor.SelectedValue = d.Value.ToString();
                    Session["ID_PRODUTOR"] = d.Value.ToString();
                }
                else if (d.Key.ToString() == "DS_PRODUTOR")
                {
                    Session["DS_PRODUTOR"] = d.Value.ToString();
                }
                
                else if (d.Key.ToString() == "ID_TIPO_LEITE")
                {
                    ddlTipoLeite.Items.Clear();
                    ListItem liLeite = new ListItem(d.Value.ToString(), d.Value.ToString());
                    ddlTipoLeite.Items.Add(liLeite);
                    ddlTipoLeite.SelectedValue = d.Value.ToString();
                    Session["ID_TIPO_LEITE"] = d.Value.ToString();
                }
                else if (d.Key.ToString() == "ID_VOL_INI")
                {
                    Decimal valor = Convert.ToDecimal(d.Value.ToString());
                    txtVolInicial.Text = string.Format("{0:f}", valor);
                    Session["ID_VOL_INI"] = d.Value.ToString();
                }
                else if (d.Key.ToString() == "ID_VOL_FIM")
                {
                    Decimal valor = Convert.ToDecimal(d.Value.ToString());
                    txtVolFinal.Text = string.Format("{0:f}", valor);
                    Session["ID_VOL_FIM"] = d.Value.ToString();
                }
                else if (d.Key.ToString() == "ID_VALOR_UNIT")
                {
                    Decimal valor = Convert.ToDecimal(d.Value.ToString());
                    txtValUnitario.Text = string.Format("{0:f}", valor);
                    Session["ID_VALOR_UNIT"] = d.Value.ToString();
                }
            }
        }
    }

    protected void gvListaPreco_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        ListaPrecosBLL obj = new ListaPrecosBLL();

        //Remove o item excluido do ViewState List<ListaPreco> para a paginação do GridView
        lstAuxiliar.RemoveAll(delegate(ListaPreco l)
        {
            return l.Id_regiao == lstExcluir.Id_regiao &&
                   l.Id_cooperat == lstExcluir.Id_cooperat &&
                   l.Ds_cooperat == lstExcluir.Ds_cooperat &&
                   l.Id_propried == lstExcluir.Id_propried &&
                   l.Ds_propried == lstExcluir.Ds_propried &&
                   l.Id_produtor == lstExcluir.Id_produtor &&
                   l.Ds_produtor == lstExcluir.Ds_produtor &&
                   l.Dt_inicio == lstExcluir.Dt_inicio &&
                   l.Dt_fim == lstExcluir.Dt_fim &&
                   l.Id_tipo_leite == lstExcluir.Id_tipo_leite &&
                   l.Id_vol_ini == lstExcluir.Id_vol_ini &&
                   l.Id_vol_fim == lstExcluir.Id_vol_fim &&
                   l.Id_valor_unit == lstExcluir.Id_valor_unit;
        });

        obj.Excluir(lstExcluir);
        gvListaPreco.DataSource = lstAuxiliar;
        gvListaPreco.DataBind();
    }
    #endregion

    #region "Paginar o GridView"
    protected void gvListaPreco_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        List<ListaPreco> listagem = new List<ListaPreco>();
        listagem = lstAuxiliar;

        gvListaPreco.PageIndex = e.NewPageIndex;
        PreencherGridView(listagem);
        ModalPopupExtenderListaPreco.Show();
    }
    #endregion

    #region "Ordenação do GridView"
    protected void gvListaPreco_Sorting(object sender, GridViewSortEventArgs e)
    {
        // A ordenação não funciona se o SortExpression estiver em maiusculo
        //<asp:TemplateField HeaderText="Propriedade" SortExpression="Ds_propried">

        lstAuxiliar.Sort(new Ordenar<ListaPreco>(e.SortExpression, true));
        gvListaPreco.DataSource = lstAuxiliar;
        gvListaPreco.DataBind();
    }
    #endregion

    #region "DropDownLists de Regiões que carregam as Cooperativas com Coletas"
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

    protected void ddlRegiaoPesq_SelectedIndexChanged(object sender, EventArgs e)
    {
        CooperativaBLL obj = new CooperativaBLL();
        List<Cooperativa> lista = new List<Cooperativa>();
        Cooperativa coop = new Cooperativa();

        LimparCamposPesquisa();

        coop.Regiao = Convert.ToString(ddlRegiaoPesq.SelectedValue);

        lista = obj.CarregarCooperativas(coop);

        foreach (Cooperativa c in lista)
        {
            String cooperativa = c.Id_cooperativa.ToString() + " | " + c.Ds_cooperat.ToString();
            ListItem li = new ListItem(cooperativa, c.Id_cooperativa.ToString());
            ddlCooperativaPesq.Items.Add(li);
        }

        ddlCooperativaPesq.DataBind();
        ModalPopupExtenderPesquisar.Show();
    }
    #endregion

    #region "DropDownList de Períodos que carregam as Regiões com Coleta"
    protected void ddlPeriodo_SelectedIndexChanged(object sender, EventArgs e)
    {
        CarregarRegioesComColeta();
    }
    #endregion

    #region "DropDownLists de Cooperativas que carregam as Propriedades"
    protected void ddlCooperativa_SelectedIndexChanged(object sender, EventArgs e)
    {
        List<Propriedade> lista = new List<Propriedade>();
        PropriedadeBLL obj = new PropriedadeBLL();
        Regiao r = new Regiao();
        Cooperativa c = new Cooperativa();

        ddlPropriedade.Items.Clear();
        ddlPropriedade.Items.Add("(SELECIONE)");
        ddlPropriedade.Items[0].Value = "0";

        ddlProdutor.Items.Clear();
        ddlProdutor.Items.Add("(SELECIONE)");
        ddlProdutor.Items[0].Value = "0";

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
    }

    protected void ddlCooperativaPesq_SelectedIndexChanged(object sender, EventArgs e)
    {
        List<Propriedade> lista = new List<Propriedade>();
        PropriedadeBLL obj = new PropriedadeBLL();
        Regiao r = new Regiao();
        Cooperativa c = new Cooperativa();

        ddlPropriedPesq.Items.Clear();
        ddlPropriedPesq.Items.Add("TODAS");
        ddlPropriedPesq.Items[0].Value = "0";

        ddlProdutorPesq.Items.Clear();
        ddlProdutorPesq.Items.Add("TODAS");
        ddlProdutorPesq.Items[0].Value = "0";

        r.Id_regiao = Convert.ToInt32(ddlRegiaoPesq.SelectedValue);
        c.Id_cooperativa = Convert.ToString(ddlCooperativaPesq.SelectedValue);

        lista = obj.Selecionar(r, c);

        foreach (Propriedade p in lista)
        {
            String propriedade = p.Codigo.ToString() + " | " + p.Nome.ToString();
            ListItem li = new ListItem(propriedade, p.Codigo.ToString());
            ddlPropriedPesq.Items.Add(li);
        }

        ddlPropriedPesq.DataBind();
        ModalPopupExtenderPesquisar.Show();
    }
    #endregion

    #region "DropDownList de Propriedades que carregam os Produtores com Coletas"
    protected void ddlPropriedade_SelectedIndexChanged(object sender, EventArgs e)
    {
        ProdutorBLL obj = new ProdutorBLL();
        List<Produtor> lista = new List<Produtor>();
        Regiao regiao = new Regiao();
        Cooperativa cooperativa = new Cooperativa();
        Propriedade propriedade = new Propriedade();

        ddlProdutor.Items.Clear();
        ddlProdutor.Items.Add("(SELECIONE)");
        ddlProdutor.Items[0].Value = "0";

        ddlTipoLeite.Items.Clear();

        int mes = Convert.ToUInt16(ddlPeriodo.SelectedValue.ToString());
        DateTime dataInicialSelecionada = DateTime.Parse("01/" + mes.ToString() + "/" + DateTime.Now.Year);
        DateTime dataFinalSelecionada = dataInicialSelecionada.AddMonths(1).AddDays(-1);

        regiao.Id_regiao = Convert.ToInt32(ddlRegiao.SelectedValue);
        cooperativa.Id_cooperativa = Convert.ToString(ddlCooperativa.SelectedValue);
        propriedade.Codigo = Convert.ToString(ddlPropriedade.SelectedValue);
        cooperativa.Dt_inicio = dataInicialSelecionada;
        cooperativa.Dt_fim = dataFinalSelecionada;

        lista = obj.SelecionarProdutoresComColeta(regiao, cooperativa, propriedade);

        foreach (Produtor prd in lista)
        {
            String produtor_concatenado = prd.Cod_produtor + " | " + prd.Id_produtor_coop + " | " + prd.Ds_produtor;
            ListItem li = new ListItem(produtor_concatenado, prd.Cod_produtor);
            ddlProdutor.Items.Add(li);
        }

        ddlProdutor.DataBind();
    }

    protected void ddlPropriedPesq_SelectedIndexChanged(object sender, EventArgs e)
    {
        ProdutorBLL obj = new ProdutorBLL();
        List<Produtor> lista = new List<Produtor>();
        Regiao regiao = new Regiao();
        Cooperativa cooperativa = new Cooperativa();
        Propriedade propriedade = new Propriedade();

        ddlProdutorPesq.Items.Clear();
        ddlProdutorPesq.Items.Add("TODOS");
        ddlProdutorPesq.Items[0].Value = "0";

        regiao.Id_regiao = Convert.ToInt32(ddlRegiaoPesq.SelectedValue);
        cooperativa.Id_cooperativa = Convert.ToString(ddlCooperativaPesq.SelectedValue);
        propriedade.Codigo = Convert.ToString(ddlPropriedPesq.SelectedValue);

        lista = obj.CarregarProdutores(regiao, cooperativa, propriedade);

        foreach (Produtor prd in lista)
        {
            String produtor_concatenado = prd.Cod_produtor + " | " + prd.Id_produtor_coop + " | " + prd.Ds_produtor;
            ListItem li = new ListItem(produtor_concatenado, prd.Cod_produtor);
            ddlProdutorPesq.Items.Add(li);
        }

        ddlProdutorPesq.DataBind();
        ModalPopupExtenderPesquisar.Show();
    }
    #endregion

    #region "DropDownList de Produtor altera o tipo de leite de acordo com os tipos coletados"
    protected void ddlProdutor_SelectedIndexChanged(object sender, EventArgs e)
    {
        ProdutorBLL obj = new ProdutorBLL();
        List<Produtor> lista = new List<Produtor>();
        Regiao regiao = new Regiao();
        Cooperativa cooperativa = new Cooperativa();
        Propriedade propriedade = new Propriedade();
        Produtor produtor = new Produtor();
        
        ddlTipoLeite.Items.Clear();

        int mes = Convert.ToUInt16(ddlPeriodo.SelectedValue.ToString());
        DateTime dataInicialSelecionada = DateTime.Parse("01/" + mes.ToString() + "/" + DateTime.Now.Year);
        DateTime dataFinalSelecionada = dataInicialSelecionada.AddMonths(1).AddDays(-1);

        regiao.Id_regiao = Convert.ToInt32(ddlRegiao.SelectedValue);
        cooperativa.Id_cooperativa = Convert.ToString(ddlCooperativa.SelectedValue);
        propriedade.Codigo = Convert.ToString(ddlPropriedade.SelectedValue);
        produtor.Cod_produtor = Convert.ToString(ddlProdutor.SelectedValue);
        cooperativa.Dt_inicio = dataInicialSelecionada;
        cooperativa.Dt_fim = dataFinalSelecionada;

        lista = obj.SelecionarTipoLeiteColetado(regiao, cooperativa, propriedade, produtor);

        foreach (Produtor prd in lista)
        {
            ListItem liLeite = new ListItem(prd.Id_tipo_leite, prd.Id_tipo_leite);
            ddlTipoLeite.Items.Add(liLeite);
        }

        // Verifica se o produtor tem leite B e C cadastrado. Se tiver, carrega opção de 'TODOS'
        if (lista.Count > 1)
        {
            ListItem liLeite = new ListItem("TODOS", "T");
            ddlTipoLeite.Items.Add(liLeite);
            ddlTipoLeite.SelectedIndex = lista.Count;
        }
        else
        {
            ddlTipoLeite.SelectedIndex = 0;
        }

        String dtInicial = dataInicialSelecionada.ToString("dd/MM/yyyy");
        String dtFinal = dataInicialSelecionada.AddDays(14).ToString("dd/MM/yyyy");

        txtDataInicial.Text = dtInicial;
        txtDataFinal.Text = dtFinal;
    }

    #endregion

    #region "Habilitar botão atualizar"
    protected void lnkSelecionar_Click(object sender, EventArgs e)
    {
        btnAtualizar.Enabled = true;
        LimparCamposPesquisa();
    }
    #endregion

    #region "Botão Voltar - ModalPopupGridView"
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        ddlTipoLeitePesq.SelectedIndex = 0;
        ddlRegiaoPesq.SelectedIndex = 0;
        ModalPopupExtenderPesquisar.Show();
        gvListaPreco.PageIndex = 0;
        LimparCamposPesquisa();
    }
    #endregion

    #region "Limpar Campos"
    protected void btnLimpar_Click(object sender, EventArgs e)
    {
        LimparCampos();
        CarregarRegioesComColeta();
    }

    protected void imbSairPesq_Click(object sender, ImageClickEventArgs e)
    {
        ddlTipoLeitePesq.SelectedIndex = 0;
        ddlRegiaoPesq.SelectedIndex = 0;
        LimparCamposPesquisa();
        gvListaPreco.PageIndex = 0;
    }

    protected void btnSair_Click(object sender, ImageClickEventArgs e)
    {
        ddlTipoLeitePesq.SelectedIndex = 0;
        ddlRegiaoPesq.SelectedIndex = 0;
        LimparCamposPesquisa();
        gvListaPreco.PageIndex = 0;
    }

    public void LimparCampos()
    {
        txtDataInicial.Text = string.Empty;
        txtDataFinal.Text = string.Empty;
        txtVolInicial.Text = string.Empty;
        txtVolFinal.Text = string.Empty;
        txtValUnitario.Text = string.Empty;

        ddlTipoLeite.Items.Clear();

        ddlCooperativa.Items.Clear();
        ddlCooperativa.Items.Add("(SELECIONE)");
        ddlCooperativa.Items[0].Value = "0";

        ddlPropriedade.Items.Clear();
        ddlPropriedade.Items.Add("(SELECIONE)");
        ddlPropriedade.Items[0].Value = "0";

        ddlProdutor.Items.Clear();
        ddlProdutor.Items.Add("(SELECIONE)");
        ddlProdutor.Items[0].Value = "0";

        btnAtualizar.Enabled = false;
        btnInserir.Enabled = true;
        ddlRegiao.Enabled = true;
    }

    public void LimparCamposPesquisa()
    {
        txtDataInicialPesq.Text = string.Empty;
        txtDataFinalPesq.Text = string.Empty;
        lblMensagem.Text = string.Empty;

        ddlCooperativaPesq.Items.Clear();
        ddlCooperativaPesq.Items.Add("TODAS");
        ddlCooperativaPesq.Items[0].Value = "0";

        ddlPropriedPesq.Items.Clear();
        ddlPropriedPesq.Items.Add("TODAS");
        ddlPropriedPesq.Items[0].Value = "0";

        ddlProdutorPesq.Items.Clear();
        ddlProdutorPesq.Items.Add("TODOS");
        ddlProdutorPesq.Items[0].Value = "0";
    }
    #endregion

    #region "Metodo - Preencher GridView"
    protected void PreencherGridView(List<ListaPreco> lista)
    {
        gvListaPreco.DataSource = lista;
        gvListaPreco.DataBind();
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

            ddlProdutor.Items.Clear();
            ddlProdutor.Items.Add("(NÃO HÁ COLETA PARA O PERÍODO)");
            ddlProdutor.Items[0].Value = "0";

            btnInserir.Enabled = false;
        }
        else
        {
            ddlCooperativa.Items.Clear();
            ddlCooperativa.Items.Add("(SELECIONE)");
            ddlCooperativa.Items[0].Value = "0";

            ddlPropriedade.Items.Clear();
            ddlPropriedade.Items.Add("(SELECIONE)");
            ddlPropriedade.Items[0].Value = "0";

            ddlProdutor.Items.Clear();
            ddlProdutor.Items.Add("(SELECIONE)");
            ddlProdutor.Items[0].Value = "0";

            btnInserir.Enabled = true;
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

    #region "Metodo Carregar Regiões"
    protected void PreencherRegioes()
    {
        List<Regiao> lista = new List<Regiao>();
        RegiaoBLL obj = new RegiaoBLL();

        lista = obj.Selecionar();

        ddlRegiaoPesq.Items.Add("TODAS");
        ddlRegiaoPesq.Items[0].Value = "0";

        ddlCooperativa.Items.Add("SELECIONE");
        ddlCooperativa.Items[0].Value = "0";

        ddlCooperativaPesq.Items.Add("TODAS");
        ddlCooperativaPesq.Items[0].Value = "0";

        ddlPropriedade.Items.Add("SELECIONE");
        ddlPropriedade.Items[0].Value = "0";

        ddlProdutor.Items.Add("SELECIONE");
        ddlProdutor.Items[0].Value = "0";

        ddlProdutorPesq.Items.Add("TODOS");
        ddlProdutorPesq.Items[0].Value = "0";

        ddlPropriedPesq.Items.Add("SELECIONE");
        ddlPropriedPesq.Items[0].Value = "0";

        foreach (Regiao r in lista)
        {
            String regiao = r.Id_regiao.ToString() + " | " + r.Ds_regiao.ToString();
            ListItem li = new ListItem(regiao, r.Id_regiao.ToString());
            ddlRegiao.Items.Add(li);
            ddlRegiaoPesq.Items.Add(li);
        }

        ddlRegiao.DataBind();
        ddlRegiaoPesq.DataBind();
    }
    #endregion
}