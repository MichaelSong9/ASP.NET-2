using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using clsCrystal;
using SQLServer.ConexaoSQL;
using System.Data.SqlClient;
using System.Configuration;


namespace RelCaptacao
{
	/// <summary>
	/// Summary description for Relatorio_Conferencia_Linha.
	/// </summary>
	public class Relatorio_Conferencia_Linha : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList ddlRegiao;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Button btRelatorio;
		protected System.Web.UI.WebControls.Label Label1;
		public string Parametro,cdUsuario,cdTipoUsuario;
		protected System.Web.UI.WebControls.DropDownList ddlLinha;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.DropDownList ddlLinhaDe;
		protected System.Web.UI.WebControls.DropDownList ddlLinhaAte;
		public string strConn = ConfigurationSettings.AppSettings["StringConnDB"].ToString();

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			string Parametro = Request["Parametro"];

			string [] Fields = {"@RANDON"};
			string [] Param = {Parametro};
			

			clsSQLServer sql = new clsSQLServer();
			SqlDataReader dr =  sql.ExecutarOperacao(strConn,"SP_DE_VALIDATION",Fields,Param);
			
			while (dr.Read())
			{
				cdUsuario = dr[0].ToString();
				cdTipoUsuario = dr[1].ToString();
			}

			dr.Close();
		
			if (!Page.IsPostBack)
			{
				
				CarregaRegiao();

			}

		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.ddlRegiao.SelectedIndexChanged += new System.EventHandler(this.ddlRegiao_SelectedIndexChanged);
			this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
			this.ddlLinhaAte.SelectedIndexChanged += new System.EventHandler(this.DropDownList2_SelectedIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

	
		public void CarregaRegiao()
		{
			string id_regiao = ddlLinha.SelectedValue.ToString() ;
			string [] Fields = {"@id_regiao","@id_usuario"};
			string [] Param = {id_regiao,cdUsuario};
			string ds_regiao;

			
			clsSQLServer sql = new clsSQLServer();
			SqlDataReader dr =  sql.ExecutarOperacao(strConn,"SP_SEL_REGIAO_USUARIO",Fields,Param);

			while (dr.Read())
			{
				id_regiao = dr[0].ToString();
				ds_regiao = dr[1].ToString();
				ddlRegiao.Items.Add(new ListItem(id_regiao + "-" + ds_regiao,id_regiao));
			}

			dr.Close();
			
		}

		public void CarregaLinhaDe(string Regiao)
		{

			string id_linha = ddlLinhaDe.SelectedValue.ToString();
			string [] Fields = {"@CodRegiao","@CodLinha"};
			string [] Param = {Regiao,id_linha};
			string ds_linha;
			
			clsSQLServer sql = new clsSQLServer();
			SqlDataReader dr =  sql.ExecutarOperacao(strConn,"SP_SEL_LINHA_REGIAO",Fields,Param);
			ddlLinha.Items.Clear();

			while (dr.Read())
			{
				id_linha = dr[0].ToString();
				ds_linha = dr[1].ToString();
				ddlLinhaDe.Items.Add(new ListItem(id_linha + "-" + ds_linha,id_linha));
			}

			dr.Close();

		}

		public void CarregaLinhaAte(string Regiao)
		{

			string id_linha = ddlLinhaAte.SelectedValue.ToString();
			string [] Fields = {"@CodRegiao","@CodLinha"};
			string [] Param = {Regiao,id_linha};
			string ds_linha;
			
			clsSQLServer sql = new clsSQLServer();
			SqlDataReader dr =  sql.ExecutarOperacao(strConn,"SP_SEL_LINHA_REGIAO",Fields,Param);
			ddlLinha.Items.Clear();

			while (dr.Read())
			{
				id_linha = dr[0].ToString();
				ds_linha = dr[1].ToString();
				ddlLinhaAte.Items.Add(new ListItem(id_linha + "-" + ds_linha,id_linha));
			}

			dr.Close();

		}

		private void ddlRegiao_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			CarregaLinhaDe(ddlRegiao.SelectedValue.ToString());
            CarregaLinhaAte(ddlRegiao.SelectedValue.ToString());
		}

		private void btRelatorio_Click(object sender, System.EventArgs e)
		{
			string [] Fields = {"@CodRegiao","@LinhaDe","@LinhaAte"};
			string [] Param = {ddlRegiao.SelectedValue.ToString(),ddlLinhaDe.SelectedValue.ToString(), ddlLinhaAte.SelectedValue.ToString()};
			string sPathLocal = HttpContext.Current.Server.MapPath("Relatorio").ToString();
			string FilePath = sPathLocal + "\\REL_CONF_LINHA.pdf"; //@"F:\Dif\emerson\Teste.pdf";
			//string FilePath = @"c:\RelWal.pdf";
			
			clsCrystal.clsCrystal crt = new clsCrystal.clsCrystal();
			crt.ReportCrystal("PR_REL_CONFERENCIA_LINHA",strConn,Fields,Param,FilePath);
			

			HttpContext.Current.Response.Redirect("http://200.187.137.92/Relcaptacao/Relatorio/REL_CONF_LINHA.pdf");
			//HttpContext.Current.Response.Redirect("http://cclteste/Relcaptacao/Relatorio/REL_CONF_LINHA.pdf");

		}

		private void DropDownList2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

	
	}
}



