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
using System.IO;

public partial class Celulares : System.Web.UI.Page
{
    private String strConn = ConfigurationManager.ConnectionStrings["intranetConnectionString"].ToString();

    #region "Carregar Pagina"
    protected void Page_Load(object sender, EventArgs e)
    {
        String selecionar = ("SELECT * FROM CELULARES WHERE (TELEFONE LIKE '%" + txtTelefone.Text + "%') AND" + " (NOME LIKE '%" + txtNome.Text + "%') ORDER BY DEPTO");
        String selecionar_tudo = ("SELECT * FROM CELULARES ORDER BY DEPTO");
        Session["selecionar"] = selecionar;
        Session["selecionar_tudo"] = selecionar_tudo;

        executarSQL(selecionar);
    }
    #endregion

    #region "Pesquisar Usuario ou Ramal"
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(strConn);
        String selecionar = Convert.ToString(Session["selecionar"]);
        String selecionar_tudo = Convert.ToString(Session["selecionar_tudo"]);
        String strSQL = (selecionar);
        SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
        DataSet ds = new DataSet();

        conn.Open();
        da.Fill(ds);
        conn.Close();

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

    #region "Paginar GridView"
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        PaginarGridView(true);
    }
   
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CODID"] = GridView1.SelectedDataKey[0].ToString();
        PaginarGridView(false);
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
            Label codid = (Label)e.Row.FindControl("lblCodId");
            Label nome = (Label)e.Row.FindControl("lblNome");

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

        String selecionar_tudo = Convert.ToString(Session["selecionar_tudo"]);
        String codid = Convert.ToString(Session["codid"]);

        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM CELULARES WHERE CODID = '" + codid + "'";
            cmd.ExecuteNonQuery();

            Page.RegisterStartupScript("Alert", "<script language='JavaScript'>alert('Usuário excluído com sucesso!'); </script>");

            txtNome.Text = String.Empty;
            txtTelefone.Text = String.Empty;

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
            Response.Write(ex.ToString());
        }
    }
    #endregion

    protected void lnkSelecionar_Click(object sender, EventArgs e)
    {
        GridView1.PageSize = 4;
    }
   
}