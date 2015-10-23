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

public partial class Cadastrar_Abreviadas : System.Web.UI.Page
{
    private String strConn = ConfigurationManager.ConnectionStrings["intranetConnectionString"].ToString();

    #region "Carregar conteúdo do GridView"
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "Abreviadas";
        String selecionar = ("SELECT * FROM ABREVIADAS WHERE TELEFONE LIKE '%" + txtPesqTelefone.Text + "%' AND NOME LIKE '%" + txtPesqNome.Text + "%' AND CODIGO LIKE '%" + txtPesqCodigo.Text + "%' ORDER BY CODIGO");
        String selecionar_tudo = ("SELECT * FROM ABREVIADAS ORDER BY CODIGO");
        Session["selecionar_tudo"] = selecionar_tudo;
        Session["selecionar"] = selecionar;
        executarSQL(selecionar);
    }
    #endregion

    #region "Selecionar conteúdo da linha do GridView"
    //primeiro é necessário criar o DataKeyNames, após isso:
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        String depto = GridView1.SelectedDataKey[0].ToString();

        Session["nome"] = GridView1.SelectedDataKey[0].ToString();
        Session["telefone"] = GridView1.SelectedDataKey[1].ToString();
        Session["codigo"] = GridView1.SelectedDataKey[2].ToString();

        lblNome.Text = Session["nome"].ToString();
        lblTelefone.Text = Session["telefone"].ToString();
        lblCodigo.Text = Session["codigo"].ToString();

        txtNome.Text = Session["nome"].ToString();
        txtTelefone.Text = Session["telefone"].ToString();
        txtCodigo.Text = Session["codigo"].ToString();

        PaginarGridView(false);
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

    #region "Inserir novo usuario"
    protected void btnNovo_Click(object sender, EventArgs e)
    {
        pnlVisualizar.Visible = true;
        pnlPesquisar.Visible = false;

        txtNome.Visible = true;
        txtTelefone.Visible = true;
        txtCodigo.Visible = true;

        lnkCancelar.Visible = true;
        lnkSalvarNovoUsuario.Visible = true;
        lnkEditar.Visible = false;
    }

    protected void lnkSalvarNovoUsuario_Click(object sender, EventArgs e)
    {
        String novoNome = txtNome.Text;
        String novoTelefone = txtTelefone.Text;
        String novoCodigo = txtCodigo.Text;

        if (novoTelefone == String.Empty || novoCodigo == String.Empty)
        {
            Page.RegisterStartupScript("Alert", "<script language='JavaScript'>alert('Digite o telefone ou o código!'); </script>");
        }

        else
        {
            String adicionar = "INSERT INTO ABREVIADAS (TELEFONE, FAX, NOME, CODIGO) VALUES ('" + novoTelefone + "', '" + "', '" + String.Empty + "', '" + novoNome + "', '" + novoNome + "', '" + novoCodigo + "')";
            String selecionar = "SELECT * FROM ABREVIADAS WHERE (TELEFONE  LIKE '%" + novoTelefone + "%') AND NOME LIKE '%" + novoNome + "%')";

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
            String selecionar_tudo = Session["selecionar_tudo"].ToString();

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
            Label nome = (Label)e.Row.FindControl("lblGridNome");
            Label telefone = (Label)e.Row.FindControl("lblGridTelefone");
            Label codigo = (Label)e.Row.FindControl("lblGridCodigo");

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
        String selecionar_tudo = Session["selecionar_tudo"].ToString();

        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM ABREVIADAS WHERE TELEFONE = '" + telefone + "' AND NOME = '" + nome + "' AND CODIGO = '" + codigo + "'";
            cmd.ExecuteNonQuery();

            Page.RegisterStartupScript("Alert", "<script language='JavaScript'>alert('Usuário excluído com sucesso!'); </script>");

            txtPesqNome.Text = String.Empty;
            txtPesqCodigo.Text = String.Empty;

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
        txtTelefone.Visible = true;
        txtCodigo.Visible = true;

        lblNome.Visible = false;
        lblTelefone.Visible = false;
        lblCodigo.Visible = false;

        lnkCancelar.Visible = true;
        lnkSalvar.Visible = true;
        lnkEditar.Visible = false;

        Session["antigoNome"] = txtNome.Text;
        Session["antigoTelefone"] = txtTelefone.Text;
        Session["antigoCodigo"] = txtCodigo.Text;
    }
    #endregion

    #region "Atualizar informações do usuario selecionado"
    protected void lnkSelecionar_Click(object sender, EventArgs e)
    {
        pnlVisualizar.Visible = true;
        lnkEditar.Visible = true;
        lnkSalvarNovoUsuario.Visible = false;
        txtNome.Visible = false;
        txtTelefone.Visible = false;
        txtCodigo.Visible = false;
    }

    protected void lnkSalvar_Click(object sender, EventArgs e)
    {
        String novoNome = txtNome.Text;
        String novoTelefone = txtTelefone.Text;
        String novoCodigo = txtCodigo.Text;

        String antigoNome = Session["antigoNome"].ToString();
        String antigoTelefone = Session["antigoTelefone"].ToString();
        String antigoCodigo = Session["antigoCodigo"].ToString();

        String selecionar_tudo = Session["selecionar_tudo"].ToString();

        lblNome.Text = novoNome;
        lblTelefone.Text = novoTelefone;
        lblCodigo.Text = novoCodigo;

        Exibir();

        String atualizar = "UPDATE ABREVIADAS SET TELEFONE = '" + novoTelefone + "', NOME = '" + novoNome + "', CODIGO = '" + novoCodigo + "' WHERE TELEFONE = '" + antigoTelefone + "' and NOME = '" + antigoNome + "' and CODIGO = '" + antigoCodigo + "'";

        Response.Write(selecionar_tudo);

        executarSQL(atualizar);
        pnlVisualizar.Visible = false;
        executarSQL(selecionar_tudo);
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
        txtTelefone.Visible = false;
        txtCodigo.Visible = false;

        lblNome.Visible = true;
        lblTelefone.Visible = true;
        lblCodigo.Visible = true;

        lnkCancelar.Visible = false;
        lnkSalvar.Visible = false;
        lnkEditar.Visible = true;
    }

    public void Inibir()
    {
        pnlVisualizar.Visible = false;

        txtNome.Visible = false;
        txtTelefone.Visible = false;
        txtCodigo.Visible = false;

        lblNome.Visible = true;
        lblTelefone.Visible = true;
        lblCodigo.Visible = true;

        lnkCancelar.Visible = false;
        lnkSalvar.Visible = false;
        lnkEditar.Visible = true;
    }
    #endregion
}