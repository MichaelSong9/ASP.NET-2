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

namespace RelCaptacao
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.RadioButton rdbRelColAss;
		protected System.Web.UI.WebControls.RadioButton rdbRelConfLinha;
		protected System.Web.UI.WebControls.RadioButton rdbRelContFornLeite;
		protected System.Web.UI.WebControls.RadioButton rdbRelColLinha;
	
		
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
			this.rdbRelContFornLeite.CheckedChanged += new System.EventHandler(this.rdbRelContFornLeite_CheckedChanged);
			this.rdbRelConfLinha.CheckedChanged += new System.EventHandler(this.rdbRelConfLinha_CheckedChanged);
			this.rdbRelColAss.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
			this.rdbRelColLinha.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void RadioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
		
			string Parametro = Request["Parametro"];
			Server.Transfer("Relatorio_Coleta_Associada.aspx?Parametro=" + Parametro );
			
		}

		private void RadioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
		
			//string Parametro = "1"; //Request["Parametro"]; //"672006962";
			string Parametro =  Request["Parametro"]; //"672006962";
			Server.Transfer("Relatorio_Coleta_Linha.aspx?Parametro=" + Parametro );


		}

		private void rdbRelConfLinha_CheckedChanged(object sender, System.EventArgs e)
		{
			string Parametro = Request["Parametro"]; //"873921098";
			Server.Transfer("Relatorio_Conferencia_Linha.aspx?Parametro=" + Parametro );

		}

		private void rdbRelContFornLeite_CheckedChanged(object sender, System.EventArgs e)
		{
			string Parametro = Request["Parametro"]; //"873921098";
			Server.Transfer("Relatorio_Cont_Fornec_Leite.aspx?Parametro=" + Parametro );
		}

		

			
		
	}
}
