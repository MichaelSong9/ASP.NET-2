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
using System.Configuration;


namespace RelCaptacao
{
	/// <summary>
	/// Summary description for _Default.
	/// </summary>
	public class _Relatorio_Coleta_Transporte : System.Web.UI.Page
	{
		public string strConn = ConfigurationSettings.AppSettings["StringConnDB"].ToString();

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			string Parametro = Request["Parametro"];
		    //string Parametro = "20/10/2004,20/10/2004,1058,3513";

			string [] split = null;
			string delim = ",";
			
			char [] del = delim.ToCharArray();
			
			int x = 8;

			split = Parametro.Split(del,x);
           
			string CodRegiao = split[3];
            string CodCoop   = split[2];
			string DataInicio = split[0];
			string DataFim = split[1];
			
						
			if (DataInicio == "") 
			{
				DataInicio = "01/01/1900" ;
			}

			if (DataFim == "") 
			{
				DataFim = "31/12/2100" ;
			}

		
			string [] Fields = {"@CodRegiao","@CodCoop", "@PeriodoDe", "@PeriodoAte"};
            //string [] Param = {ddlRegiao.SelectedValue.ToString(),ddlLinhaDe.SelectedValue.ToString(), ddlLinhaAte.SelectedValue.ToString()};
			string [] Param = {CodRegiao, CodCoop, DataInicio, DataFim};
			string sPathLocal = HttpContext.Current.Server.MapPath("Relatorio").ToString();
			string FilePath = sPathLocal + "\\" + "Rel_Coleta_Transporte.pdf";
			//string FilePath = @"c:\TestetransOK.pdf";
		
			clsCrystal.clsCrystal crt = new clsCrystal.clsCrystal();
			crt.ReportCrystal("PR_REL_COLETA_TRANSPORTE",strConn,Fields,Param,FilePath);
			HttpContext.Current.Response.Redirect("http://200.187.137.92/RelCaptacao/Relatorio/Rel_Coleta_Transporte.pdf");
			//HttpContext.Current.Response.Redirect("http://cclteste/RelCaptacao/Relatorio/Rel_Coleta_Transporte.pdf");


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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
