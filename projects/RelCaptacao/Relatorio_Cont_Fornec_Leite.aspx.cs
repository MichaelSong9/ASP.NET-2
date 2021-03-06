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
	/// Summary description for Relatorio_Cont_Fornec_Leite.
	/// </summary>
	public class Relatorio_Cont_Fornec_Leite : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label1;
		public string Parametro,cdUsuario,cdTipoUsuario;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Label Label7;
		protected System.Web.UI.WebControls.DropDownList ddlRegiao;
		protected System.Web.UI.WebControls.DropDownList ddlLinha;
		protected System.Web.UI.WebControls.DropDownList ddlMes;
		protected System.Web.UI.WebControls.DropDownList ddlAno;
		protected System.Web.UI.WebControls.Button btRelatorio;
		public string strConn = ConfigurationSettings.AppSettings["StringConnDB"].ToString();

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			//string Parametro = "590010516"; 
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

	
		public void CarregaRegiao()
		{
			string id_regiao;
			string [] Fields = {"@id_regiao","@id_usuario"};
			string [] Param = {null,cdUsuario};
			string ds_regiao;

			
			clsSQLServer sql = new clsSQLServer();
			
			//Alterei a procedure por determinação do Sr. Edson em 28/12 ...
			//SqlDataReader dr =  sql.ExecutarOperacao(strConn,"PR_SEL_REG_USU",Fields,Param);
            
			SqlDataReader dr =  sql.ExecutarOperacao(strConn,"SP_SEL_REGIAO_USUARIO",Fields,Param);
			while (dr.Read())
			{
				id_regiao = dr[0].ToString();
				ds_regiao = dr[1].ToString();
				ddlRegiao.Items.Add(new ListItem(id_regiao + "-" + ds_regiao,id_regiao));
			}

			dr.Close();
			
		}

		public void CarregaLinha1(string Regiao)
		{

			string id_linha ;
			string [] Fields = {"@CodRegiao","@CodLinha"};
			string [] Param = {Regiao,null};
			string ds_linha;
			
			clsSQLServer sql = new clsSQLServer();
			SqlDataReader dr =  sql.ExecutarOperacao(strConn,"SP_SEL_LINHA_REGIAO",Fields,Param);
			ddlLinha.Items.Clear();

			while (dr.Read())
			{
				id_linha = dr[0].ToString();
				ds_linha = dr[1].ToString();
				ddlLinha.Items.Add(new ListItem(id_linha + "-" + ds_linha,id_linha));
			}

			dr.Close();

		}

		
		private void ddlRegiao_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			CarregaLinha1(ddlRegiao.SelectedValue.ToString());
		}

		private void btRelatorio_Click(object sender, System.EventArgs e)
		{
			string [] Fields = {"@CodRegiao","@Linha", "@Mes", "@Ano"};
		    //string [] Param = {"3513", "1", "10", "2004"};
			string [] Param = {ddlRegiao.SelectedValue.ToString(), ddlLinha.SelectedValue.ToString(),ddlMes.SelectedValue.ToString(), ddlAno.SelectedValue.ToString()};
			string sPathLocal = HttpContext.Current.Server.MapPath("Relatorio").ToString();
			string FilePath = sPathLocal + "\\REL_CONT_FORNEC_LEITE.pdf"; //@"F:\Dif\emerson\Teste.pdf";
	    	//string FilePath = @"c:\RelLeite.pdf";
			
			clsCrystal.clsCrystal crt = new clsCrystal.clsCrystal();
			crt.ReportCrystal("PR_REL_CONT_FORNEC_LEITE",strConn,Fields,Param,FilePath);
			HttpContext.Current.Response.Redirect("http://200.187.137.92/Relcaptacao/Relatorio/REL_CONT_FORNEC_LEITE.pdf");
			//HttpContext.Current.Response.Redirect("http://cclteste/Relcaptacao/Relatorio/REL_CONT_FORNEC_LEITE.pdf");
			

		}

		

		

		

	
	}
}



