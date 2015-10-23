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
	/// Summary description for Relatorio_Coleta_Associada.
	/// </summary>
	public class Relatorio_Coleta_Associada : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList ddlRegiao;
		public string strConn = ConfigurationSettings.AppSettings["StringConnDB"].ToString();
		protected System.Web.UI.WebControls.DropDownList ddlCoop;
		protected System.Web.UI.WebControls.Label Label1;
		public string Parametro,cdUsuario,cdTipoUsuario;
		protected System.Web.UI.WebControls.TextBox txtDtIni;
		protected System.Web.UI.WebControls.TextBox txtDtFim;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Button btRelatorio;
	
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

		private void ddlRegiao_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			CarregaCoop(ddlRegiao.SelectedValue.ToString(),cdUsuario);
		}

		private void btRelatorio_Click(object sender, System.EventArgs e)
		{
 
			string [] Fields = {"@DatInicio","@DatFim","@CodRegiao","@CodCoop"};
			string [] Param = { txtDtIni.Text,txtDtFim.Text,ddlRegiao.SelectedValue.ToString(),ddlCoop.SelectedValue.ToString()};

			string sPathLocal = HttpContext.Current.Server.MapPath("Relatorio").ToString();
			string FilePath = sPathLocal + "\\COLETA_LEITE_ASSOCIADA.pdf"; //@"F:\Dif\emerson\Teste.pdf";  
			
			clsCrystal.clsCrystal crt = new clsCrystal.clsCrystal();
    		crt.ReportCrystal("SP_REL_COLETA_LEITE_ASSOCIADA",strConn,Fields,Param,FilePath);
				
			HttpContext.Current.Response.Redirect("http://200.187.137.92/RelCaptacao/Relatorio/COLETA_LEITE_ASSOCIADA.pdf");
			//HttpContext.Current.Response.Redirect("http://cclteste/RelCaptacao/Relatorio/COLETA_LEITE_ASSOCIADA.pdf");
			//HttpContext.Current.Response.Redirect("http://dif-1029/RelCaptacao/Relatorio/COLETA_LEITE_ASSOCIADA.pdf");

		}

		private void ddlCoop_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
		
	}
}
