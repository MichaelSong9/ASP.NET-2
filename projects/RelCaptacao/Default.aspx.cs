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
	public class _Default : System.Web.UI.Page
	{
		public string strConn = ConfigurationSettings.AppSettings["StringConnDB"].ToString();

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			string Parametro = Request["Parametro"];
			//string Parametro =	"3513;1031;4;4;01/01/2004;01/04/2004;99004;M";
			//string Parametros =	"3513;1031;;;;;99004;M";


			string [] split = null;
			string delim = ";";
			
			char [] del = delim.ToCharArray();
			
			int x = 8;

			split = Parametro.Split(del,x);
           
			string CodRegiao = split[0];
            string CodCoop   = split[1];
			string DataInicio = split[4];
			string DataFim = split[5];
			string CodProdutor = split[2];
			string CodPontoColeta = split[3];
			
			if (DataInicio == "") 
			{
				DataInicio = "01/01/1900" ;
			}

			if (DataFim == "") 
			{
				DataFim = "31/12/2100" ;
			}

			if (CodProdutor == "") 
			{
				CodProdutor = "0" ;
			}

			if (CodPontoColeta == "") 
			{
				CodPontoColeta = "0" ;
			}


			string [] Fields = {"@DatInicio","@DatFim", "@CodProdutor", "@CodRegiao", "@CodCoop", "@CodPontoColeta"};
            //string [] Param = {ddlRegiao.SelectedValue.ToString(),ddlLinhaDe.SelectedValue.ToString(), ddlLinhaAte.SelectedValue.ToString()};
			string [] Param = {DataInicio, DataFim, CodProdutor,  CodRegiao, CodCoop, CodPontoColeta};
			string sPathLocal = HttpContext.Current.Server.MapPath("Relatorio").ToString();
			string FilePath = sPathLocal + "\\" + "Rel_Boletim_Captacao.pdf";
			//string FilePath = @"c:\TesteBoletimOK.pdf";
		
			clsCrystal.clsCrystal crt = new clsCrystal.clsCrystal();
			crt.ReportCrystal("SP_REL_BOLETIM_COLETA_LEITE",strConn,Fields,Param,FilePath);
			HttpContext.Current.Response.Redirect("http://200.187.137.92/RelCaptacao/Relatorio/Rel_Boletim_Captacao.pdf");
			//HttpContext.Current.Response.Redirect("http://cclteste/RelCaptacao/Relatorio/Rel_Boletim_Captacao.pdf");

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
