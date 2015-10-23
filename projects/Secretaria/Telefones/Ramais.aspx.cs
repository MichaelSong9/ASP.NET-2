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
using System.Data.SqlClient;

public partial class Cadastrar_Ramais : System.Web.UI.Page
{
    private String strConn = ConfigurationManager.ConnectionStrings["intranetConnectionString"].ToString();

    #region "Carregar conteúdo do GridView"
    protected void Page_Load(object sender, EventArgs e)
    {
        String selecionar = ("SELECT * FROM RAMAIS WHERE DEPTO LIKE '%" + ddlDepto.SelectedValue.ToString() + "%' AND RAMAL LIKE '%" + txtPesqRamal.Text + "%' AND NOME LIKE '%" + txtPesqNome.Text + "%' AND CARGO LIKE '%" + txtPesqCargo.Text + "%' ORDER BY RAMAL");
        String selecionar_tudo = ("SELECT * FROM RAMAIS ORDER BY RAMAL");
        String depto = ("SELECT DEPTO, DESCRICAO FROM DEPTO ORDER BY DESCRICAO");
        
        Session["selecionar"] = selecionar;
        Session["selecionar_tudo"] = selecionar_tudo;

        DataSet dsDropDown = new DataSet();
        DataSet dsGridView = new DataSet();
        SqlConnection conn = new SqlConnection(strConn);
        SqlDataAdapter daDropDown = new SqlDataAdapter(depto, conn);
        SqlDataAdapter daGridView = new SqlDataAdapter(selecionar_tudo, conn);
        conn.Open();
        daDropDown.Fill(dsDropDown);
        daGridView.Fill(dsGridView);

        ddlDepto.DataSource = dsDropDown;
        GridView1.DataSource = dsGridView;

        ddlDepto.DataTextField = "DESCRICAO";
        ddlDepto.DataValueField = "DEPTO";

        ddlDepto.DataBind();
        GridView1.DataBind();
        conn.Close();
    }
    #endregion

    #region "Pesquisar Usuario ou Ramal"
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(strConn);
        String selecionar = Convert.ToString(Session["selecionar"]);
        String selecionar_tudo = Convert.ToString(Session["selecionar_tudo"]);
        SqlDataAdapter da = new SqlDataAdapter(selecionar, conn);
        DataSet ds = new DataSet();

        conn.Open();
        da.Fill(ds);
        conn.Close();

        pnlVisualizar.Visible = false;

        if (ds.Tables.Count > 0)
        {
            Session["ds1"] = ds;
        }
        else
        {
            executarSQL(selecionar_tudo);
        }

        ds = (DataSet)Session["ds1"];

        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else
        {
            btnPesquisar.Attributes.Add("onclick", "javascript:alert('O usuário ou ramal pesquisados não existe!')");
            executarSQL(selecionar_tudo);
        }
    }
    #endregion

    #region "Selecionar conteúdo da linha do GridView"
    //primeiro é necessário criar o DataKeyNames, após isso:
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["depto"] = GridView1.SelectedDataKey[0].ToString();
        Session["nome"] = GridView1.SelectedDataKey[1].ToString();
        Session["cargo"] = GridView1.SelectedDataKey[2].ToString();
        Session["ramal"] = GridView1.SelectedDataKey[3].ToString();

        lblDepto.Text = Session["depto"].ToString();
        lblNome.Text = Session["nome"].ToString();
        lblCargo.Text = Session["cargo"].ToString();
        lblRamal.Text = Session["ramal"].ToString();

        ddlDeptoEdit.SelectedValue = Session["depto"].ToString();
        txtNome.Text = Session["nome"].ToString();
        txtCargo.Text = Session["cargo"].ToString();
        txtRamal.Text = Session["ramal"].ToString();

        PaginarGridView(false);
    }
    #endregion

    #region "Inserir novo usuario"
    protected void btnNovo_Click(object sender, EventArgs e)
    {
        pnlVisualizar.Visible = true;
        pnlPesquisar.Visible = false;
        ddlDeptoEdit.Visible = true;
        txtNome.Visible = true;
        txtCargo.Visible = true;
        txtRamal.Visible = true;

        lnkCancelar.Visible = true;
        lnkSalvarNovoUsuario.Visible = true;
        lnkEditar.Visible = false;
    }

    protected void lnkSalvarNovoUsuario_Click(object sender, EventArgs e)
    {
        String novoDepto = ddlDeptoEdit.SelectedValue.ToString();
        String novoNome = txtNome.Text;
        String novoCargo = txtCargo.Text;
        String novoRamal = txtRamal.Text;

        if (novoDepto == String.Empty || novoRamal == String.Empty)
        {
            Page.RegisterStartupScript("Alert", "<script language='JavaScript'>alert('Digite o departamento ou o ramal!'); </script>");
        }

        else
        {
            String adicionar = "INSERT INTO RAMAIS (DEPTO, NOME, CARGO, RAMAL) VALUES ('" + novoDepto + "', '" + novoNome + "', '" + novoCargo + "', '" + novoRamal + "')";
            String selecionar = "SELECT * FROM RAMAIS WHERE (DEPTO ='" + novoDepto + "') AND" + " (NOME = '" + novoNome + "')";

            executarSQL(adicionar);
            executarSQL(selecionar);

            pnlVisualizar.Visible = false;
            pnlPesquisar.Visible = true;
        }
    }
    #endregion

    #region "Paginar GridView"
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        PaginarGridView(true);
    }

    private void PaginarGridView(bool condicao)
    {
        if (condicao)
        {
            SqlConnection conn = new SqlConnection(strConn);
            String selecionar = Session["selecionar"].ToString();
            String selecionar_tudo = Convert.ToString(Session["selecionar_tudo"]);
            SqlDataAdapter da = new SqlDataAdapter(selecionar, conn);
            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds);
            conn.Close();

            if (ds.Tables.Count > 0)
            {
                Session["ds1"] = ds;
            }

            ds = (DataSet)Session["ds1"];

            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                executarSQL(selecionar_tudo);
            }
        }
    }
    #endregion

    #region "Confirmar Exclusão de Usuario no GridView"
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label depto = (Label)e.Row.FindControl("lblGridDepto");
            Label nome = (Label)e.Row.FindControl("lblGridNome");
            Label cargo = (Label)e.Row.FindControl("lblGridCargo");
            Label ramal = (Label)e.Row.FindControl("lblGridRamal");

            LinkButton Excluir = (LinkButton)e.Row.FindControl("lnkExcluir");
            Excluir.Attributes.Add("onclick", "javascript:return confirm('Confirma a exclusão do usuário " + nome.Text + " ?')");
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Delete")
        {
            ExcluirUsuario();
        }
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        ExcluirUsuario();
    }

    private void ExcluirUsuario()
    {
        SqlConnection conn = new SqlConnection(strConn);
        SqlCommand cmd = new SqlCommand();

        String depto = Convert.ToString(Session["depto"]);
        String nome = Convert.ToString(Session["nome"]);
        String cargo = Convert.ToString(Session["cargo"]);
        String ramal = Convert.ToString(Session["ramal"]);

        String selecionar = Convert.ToString(Session["selecionar"]);

        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM RAMAIS WHERE DEPTO = '" + depto + "' AND NOME = '" + nome + "' AND CARGO = '" + cargo + "' AND RAMAL = '" + ramal + "'";
            cmd.ExecuteNonQuery();

            Page.RegisterStartupScript("Alert", "<script language='JavaScript'>alert('O usuário " + nome + " foi excluído com sucesso!'); </script>");

            txtPesqNome.Text = String.Empty;
            txtPesqRamal.Text = String.Empty;

            executarSQL(selecionar);
        }
        catch (Exception ex)
        {
            String erro = ex.ToString();
            Page.RegisterStartupScript("Alert", "<script language='JavaScript'>alert('Erro: " + erro + "'); </script>");
        }
        finally
        {
            conn.Close();
        }
    }
    #endregion

    #region "Editar dados"
    protected void lnkEditar_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection(strConn);
        String depto = ("SELECT DEPTO, DESCRICAO FROM DEPTO ORDER BY DESCRICAO");
        SqlDataAdapter da = new SqlDataAdapter(depto, conn);
        conn.Open();
        da.Fill(ds);
        ddlDeptoEdit.DataSource = ds;
        ddlDeptoEdit.DataTextField = "DESCRICAO";
        ddlDeptoEdit.DataValueField = "DEPTO";
        ddlDeptoEdit.DataBind();
        ddlDeptoEdit.SelectedValue = Session["depto"].ToString();
        conn.Close();

        ddlDeptoEdit.Visible = true;
        txtNome.Visible = true;
        txtCargo.Visible = true;
        txtRamal.Visible = true;

        lblDepto.Visible = false;
        lblNome.Visible = false;
        lblCargo.Visible = false;
        lblRamal.Visible = false;

        lnkCancelar.Visible = true;
        lnkSalvar.Visible = true;
        lnkEditar.Visible = false;

        Session["antigoDepto"] = ddlDeptoEdit.SelectedValue.ToString();
        Session["antigoNome"] = txtNome.Text;
        Session["antigoCargo"] = txtCargo.Text;
        Session["antigoRamal"] = txtRamal.Text;
    }
    #endregion

    #region "Atualizar informações do usuario selecionado"
    protected void lnkSelecionar_Click(object sender, EventArgs e)
    {
        pnlVisualizar.Visible = true;
        lnkEditar.Visible = true;
        lnkSalvarNovoUsuario.Visible = false;
        txtCargo.Visible = false;
        ddlDeptoEdit.Visible = false;
        txtNome.Visible = false;
        txtRamal.Visible = false;
    }

    protected void lnkSalvar_Click(object sender, EventArgs e)
    {
        String novoDepto = ddlDeptoEdit.SelectedValue.ToString();
        String novoNome = txtNome.Text;
        String novoCargo = txtCargo.Text;
        String novoRamal = txtRamal.Text;

        String antigoDepto = Session["antigoDepto"].ToString();
        String antigoNome = Session["antigoNome"].ToString();
        String antigoCargo = Session["antigoCargo"].ToString();
        String antigoRamal = Session["antigoRamal"].ToString();

        lblDepto.Text = novoDepto;
        lblNome.Text = novoNome;
        lblCargo.Text = novoCargo;
        lblRamal.Text = novoRamal;

        Exibir();

        String atualizar = "UPDATE RAMAIS SET DEPTO = '" + novoDepto + "', NOME = '" + novoNome + "', CARGO = '" + novoCargo + "', RAMAL = '" + novoRamal + "' WHERE DEPTO = '" + antigoDepto + "' and NOME = '" + antigoNome + "' and CARGO = '" + antigoCargo + "' and RAMAL = '" + antigoRamal + "'";
        String selecionar = "SELECT * FROM RAMAIS WHERE (DEPTO ='" + novoDepto + "') AND" + " (NOME = '" + novoNome + "')";

        executarSQL(atualizar);
        executarSQL(selecionar);
    }
    #endregion

    #region "Cancelar edição dos dados"
    protected void lnkCancelar_Click(object sender, EventArgs e)
    {
        Inibir();
        pnlPesquisar.Visible = true;
    }
    #endregion

    #region "Função: Executar comando SQL"
    private void executarSQL(String strSQL)
    {
        try
        {
            SqlConnection conn = new SqlConnection(strConn);
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            conn.Close();
        }
        catch (Exception ex)
        {
            //Response.Write(ex.ToString());
        }
    }
    #endregion

    #region "Função de exibição e inibição dos TextBoxes e Labels"
    public void Exibir()
    {
        ddlDeptoEdit.Visible = false;
        txtNome.Visible = false;
        txtCargo.Visible = false;
        txtRamal.Visible = false;

        lblDepto.Visible = true;
        lblNome.Visible = true;
        lblCargo.Visible = true;
        lblRamal.Visible = true;

        lnkCancelar.Visible = false;
        lnkSalvar.Visible = false;
        lnkEditar.Visible = true;
    }

    public void Inibir()
    {
        pnlVisualizar.Visible = false;

        ddlDeptoEdit.Visible = false;
        txtNome.Visible = false;
        txtCargo.Visible = false;
        txtRamal.Visible = false;

        lblDepto.Visible = true;
        lblNome.Visible = true;
        lblCargo.Visible = true;
        lblRamal.Visible = true;

        lnkCancelar.Visible = false;
        lnkSalvar.Visible = false;
        lnkEditar.Visible = true;
    }
    #endregion
}