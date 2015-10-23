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

public partial class Cadastrar_Fax : System.Web.UI.Page
{
    private String strConn = ConfigurationManager.ConnectionStrings["intranetConnectionString"].ToString();

    #region "Carregar conteúdo do GridView"
    protected void Page_Load(object sender, EventArgs e)
    {
        String selecionar = "SELECT * FROM FAX WHERE (FAX LIKE '%" + txtFax.Text + "%') AND" + " (NOME LIKE '%" + txtNome.Text + "%') ORDER BY FAX";
        String selecionar_tudo = ("SELECT * FROM FAX ORDER BY FAX");
        Session["selecionar"] = selecionar;
        Session["selecionar_tudo"] = selecionar_tudo;
        executarSQL(selecionar);
    }
    #endregion

    #region "Selecionar conteúdo da linha do GridView"
    //primeiro é necessário criar o DataKeyNames, após isso:
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["nome"] = GridView1.SelectedDataKey[0].ToString();
        Session["destino"] = GridView1.SelectedDataKey[1].ToString();
        Session["fax"] = GridView1.SelectedDataKey[2].ToString();

        lblNome.Text = Session["nome"].ToString();
        lblDestino.Text = Session["destino"].ToString();
        lblFax.Text = Session["fax"].ToString();

        txtNome.Text = Session["nome"].ToString();
        txtDestino.Text = Session["destino"].ToString();
        txtFax.Text = Session["fax"].ToString();

        PaginarGridView(false);
    }
    #endregion

    #region "Pesquisar Usuario ou fax"
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

    #region "Inserir novo fax"
    protected void btnNovo_Click(object sender, EventArgs e)
    {
        pnlVisualizar.Visible = true;
        pnlPesquisar.Visible = false;

        txtNome.Visible = true;
        txtDestino.Visible = true;
        txtFax.Visible = true;

        lnkCancelar.Visible = true;
        lnkSalvarNovoUsuario.Visible = true;
        lnkEditar.Visible = false;
    }

    protected void lnkSalvarNovoUsuario_Click(object sender, EventArgs e)
    {

        String novoNome = txtNome.Text;
        String novoDestino = txtDestino.Text;
        String novoFax = txtFax.Text;

        if (novoNome == String.Empty || novoFax == String.Empty)
        {
            Page.RegisterStartupScript("Alert", "<script language='JavaScript'>alert('Digite o nome ou o fax!'); </script>");
        }

        else
        {
            String adicionar = "INSERT INTO FAX (DESTINO, NOME, FAX) VALUES ('" + novoDestino + "', '" + novoNome + "', '" + novoFax + "')";
            String selecionar = "SELECT * FROM FAX WHERE (NOME ='" + novoNome + "') AND" + " (FAX = '" + novoFax + "')";

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
                executarSQL("SELECT * FROM FAX WHERE FAX LIKE '%" + String.Empty + "%' AND" + " NOME LIKE '%" + String.Empty + "%'");
            }
        }
    }
    #endregion

    #region "Confirmar Exclusão de Fax no GridView"
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label destino = (Label)e.Row.FindControl("lblGridDestino");
            Label nome = (Label)e.Row.FindControl("lblGridNome");
            Label fax = (Label)e.Row.FindControl("lblGridFax");

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

        String nome = Convert.ToString(Session["nome"]);
        String destino = Convert.ToString(Session["destino"]);
        String fax = Convert.ToString(Session["fax"]);

        String selecionar_tudo = Convert.ToString(Session["selecionar_tudo"]);

        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM FAX WHERE DESTINO = '" + destino + "' AND NOME = '" + nome + "' AND FAX = '" + fax + "'";
            cmd.ExecuteNonQuery();

            Page.RegisterStartupScript("Alert", "<script language='JavaScript'>alert('Usuário excluído com sucesso!'); </script>");

            txtPesqNome.Text = String.Empty;
            txtPesqFax.Text = String.Empty;

            executarSQL(selecionar_tudo);
        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
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
        txtNome.Visible = true;
        txtDestino.Visible = true;
        txtFax.Visible = true;

        lblNome.Visible = false;
        lblDestino.Visible = false;
        lblFax.Visible = false;

        lnkCancelar.Visible = true;
        lnkSalvar.Visible = true;
        lnkEditar.Visible = false;

        Session["antigoNome"] = txtNome.Text;
        Session["antigoDestino"] = txtDestino.Text;
        Session["antigoFax"] = txtFax.Text;
    }
    #endregion

    #region "Atualizar informações do fax selecionado"
    protected void lnkSelecionar_Click(object sender, EventArgs e)
    {
        pnlVisualizar.Visible = true;
        lnkEditar.Visible = true;
        lnkSalvarNovoUsuario.Visible = false;
        txtDestino.Visible = false;
        txtNome.Visible = false;
        txtFax.Visible = false;
    }

    protected void lnkSalvar_Click(object sender, EventArgs e)
    {

        String novoNome = txtNome.Text;
        String novoDestino = txtDestino.Text;
        String novoFax = txtFax.Text;

        String antigoNome = Session["antigoNome"].ToString();
        String antigoDestino = Session["antigoDestino"].ToString();
        String antigoFax = Session["antigoFax"].ToString();

        lblNome.Text = novoNome;
        lblDestino.Text = novoDestino;
        lblFax.Text = novoFax;

        Exibir();

        String atualizar = "UPDATE FAX SET DESTINO = '" + novoDestino + "', NOME = '" + novoNome + "', FAX = '" + novoFax + "' WHERE DESTINO = '" + antigoDestino + "' and NOME = '" + antigoNome + "' AND FAX = '" + antigoFax + "'";
        String selecionar = "SELECT * FROM FAX WHERE (DESTINO ='" + novoDestino + "') AND" + " (NOME = '" + novoNome + "')";

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
        txtNome.Visible = false;
        txtDestino.Visible = false;
        txtFax.Visible = false;

        lblDestino.Visible = true;
        lblNome.Visible = true;
        lblFax.Visible = true;

        lnkCancelar.Visible = false;
        lnkSalvar.Visible = false;
        lnkEditar.Visible = true;
    }

    public void Inibir()
    {
        pnlVisualizar.Visible = false;

        txtNome.Visible = false;
        txtDestino.Visible = false;
        txtFax.Visible = false;

        lblNome.Visible = true;
        lblDestino.Visible = true;
        lblFax.Visible = true;

        lnkCancelar.Visible = false;
        lnkSalvar.Visible = false;
        lnkEditar.Visible = true;
    }
    #endregion
}