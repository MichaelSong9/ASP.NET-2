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
using System.Configuration;
using System.Data.SqlClient;

namespace RelCaptacao
{
	/// <summary>
	/// Summary description for Relatorio_Cadastro_de_Produtores.
	/// </summary>

	public class Relatorio_Cadastro_de_Produtores : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label lblRegiao;
		protected System.Web.UI.WebControls.Label lblCoop;
		protected System.Web.UI.WebControls.Label lblAtiv;
		protected System.Web.UI.WebControls.Label lblOrd;
		protected System.Web.UI.WebControls.DropDownList ddlRegiao;
		protected System.Web.UI.WebControls.DropDownList ddlCoop;
		protected System.Web.UI.WebControls.DropDownList ddlAtiv;
		protected System.Web.UI.WebControls.DropDownList ddlOrd;
		protected System.Web.UI.WebControls.Button btRelatorio;
		public string strConn = ConfigurationSettings.AppSettings["StringConnDB"].ToString();
		public string Parametro,cdUsuario,cdTipoUsuario;
		
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		
			// Meu código de carregar as combos iniciam aqui !!!

			//string Parametro = "1"; //Request["Parametro"];
			
			string Parametro = Request["Parametro"];

			string [] Fields = {"@RANDON"};
			string [] Param = {Parametro};
			
			clsSQLServer sql = new clsSQLServer();
			SqlDataReader dr = sql.ExecutarOperacao(strConn,"SP_DE_VALIDATION",Fields,Param);

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
			this.ddlCoop.SelectedIndexChanged += new System.EventHandler(this.ddlCoop_SelectedIndexChanged);
			this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		// Carregar Região !!!
		public void CarregaRegiao()
		{

			string id_regiao = ddlRegiao.SelectedValue.ToString() ;
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
		
		// Carregar Cooperativa !!!
		public void CarregaCoop(string Regiao,string usuario)
		{

			string [] Fields = {"@id_regiao","@id_coop","@id_usuario"};
			string [] Param = {Regiao,ddlCoop.SelectedValue.ToString(),usuario};
			string ds_coop;
			string id_coop;
			
			clsSQLServer sql = new clsSQLServer();
			SqlDataReader dr =  sql.ExecutarOperacao(strConn,"SP_SEL_REGIAO_USUARIO_COOP",Fields,Param);
			ddlCoop.Items.Clear();

			ddlCoop.Items.Add(new ListItem("Todos","null"));

			while (dr.Read())
			{
				id_coop = dr[2].ToString();
				ds_coop = dr[3].ToString();
				ddlCoop.Items.Add(new ListItem(id_coop + "-" + ds_coop,id_coop));
			}

			dr.Close();

		}


		private void ddlRegiao_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			CarregaCoop(ddlRegiao.SelectedValue.ToString(),cdUsuario);
		}

		private void ddlCoop_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
		
		private void btRelatorio_Click(object sender, System.EventArgs e)
		{
 
			string [] Fields = {"@CodRegiao","@CodCoop","@CodAtiv","@CodOrd"};
			string [] Param = { ddlRegiao.SelectedValue.ToString(),ddlCoop.SelectedValue.ToString(),ddlAtiv.SelectedValue.ToString(),ddlOrd.SelectedValue.ToString()};
						
			string sPathLocal = HttpContext.Current.Server.MapPath("Relatorio").ToString();
			string FilePath = sPathLocal + "\\CAD_PRODUTORES.pdf"; //@"F:\Dif\emerson\Teste.pdf";  
			
			clsCrystal.clsCrystal crt = new clsCrystal.clsCrystal();
			crt.ReportCrystal("PR_SEL_CAD_PRODUTORES",strConn,Fields,Param,FilePath);
			//string FilePath = @"c:\CadProdutor.pdf";
				
			HttpContext.Current.Response.Redirect("http://200.187.137.92/RelCaptacao/Relatorio/CAD_PRODUTORES.pdf");
			//HttpContext.Current.Response.Redirect("http://cclteste/RelCaptacao/Relatorio/CAD_PRODUTORES.pdf");
			//HttpContext.Current.Response.Redirect("http://dif-1029/RelCaptacao/Relatorio/CAD_PRODUTORES.pdf");

		}

		

		
	}
}