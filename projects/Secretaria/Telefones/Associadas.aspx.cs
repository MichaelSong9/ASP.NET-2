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

public partial class Associadas : System.Web.UI.Page
{
    private String strConn = ConfigurationManager.ConnectionStrings["intranetConnectionString"].ToString();
    
    #region "Carregar Pagina"
    protected void Page_Load(object sender, EventArgs e)
    {
        executarSQL("SELECT * FROM COOP WHERE (TELEFONE LIKE '%" + txtTelefone.Text + "%') AND" + " (NOME LIKE '%" + txtNome.Text + "%') ORDER BY TELEFONE");
    }
    #endregion

    #region "Pesquisar Usuario ou Ramal"
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(strConn);
        String strSQL = ("SELECT * FROM COOP WHERE (TELEFONE LIKE '%" + txtTelefone.Text + "%') AND" + " (NOME LIKE '%" + txtNome.Text + "%')");
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
            btnPesquisar.Attributes.Add("onclick", "javascript:alert('Mensagem1!')");
            executarSQL("SELECT * FROM COOP WHERE (TELEFONE LIKE '%" + String.Empty + "%') AND" + " (NOME LIKE '%" + String.Empty + "%')");
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
            executarSQL("SELECT * FROM COOP WHERE (TELEFONE LIKE '%" + String.Empty + "%') AND" + " (NOME LIKE '%" + String.Empty + "%')");
        }
    }
    #endregion

    #region "Paginar GridView"

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        PaginarGridView(true);
    }

    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {
        PaginarGridView(false);
    }

    private void PaginarGridView(bool condicao)
    {
        if (condicao)
        {
            SqlConnection conn = new SqlConnection(strConn);
            String strSQL = "SELECT * FROM COOP";
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
                Page.RegisterStartupScript("Alert", "<script language='JavaScript'>alert('Não existe usuário cadastrado!'); </script>");
                executarSQL("SELECT * FROM COOP WHERE (TELEFONE LIKE '%" + String.Empty + "%') AND" + " (NOME LIKE '%" + String.Empty + "%')");
            }

            ds = (DataSet)Session["ds1"];

            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                Page.RegisterStartupScript("Alert", "<script language='JavaScript'>alert('Não existe usuário cadastrado!'); </script>");
                executarSQL("SELECT * FROM COOP WHERE (TELEFONE LIKE '%" + String.Empty + "%') AND" + " (NOME LIKE '%" + String.Empty + "%')");
            }
        }
    }
    #endregion

    #region "Confirmar Exclusão de Usuario no GridView"
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label nome = (Label)e.Row.FindControl("lblNome");
            Label telefone = (Label)e.Row.FindControl("lblTelefone");
            Label codigo = (Label)e.Row.FindControl("lblCodigo");

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
        String telefone = Convert.ToString(Session["telefone"]);
        String codigo = Convert.ToString(Session["codigo"]);

        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM COOP WHERE TELEFONE = '" + telefone + "' AND NOME = '" + nome + "' AND CODIGO = '" + codigo + "'";
            cmd.ExecuteNonQuery();

            Page.RegisterStartupScript("Alert", "<script language='JavaScript'>alert('Usuário excluído com sucesso!'); </script>");

            txtNome.Text = String.Empty;
            txtTelefone.Text = String.Empty;

            executarSQL("SELECT * FROM COOP WHERE (TELEFONE LIKE '%" + txtTelefone.Text + "%') AND" + " (NOME LIKE '%" + txtNome.Text + "%')");
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
}
