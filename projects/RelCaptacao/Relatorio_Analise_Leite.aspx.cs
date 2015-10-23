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
using System.IO;

namespace RelCaptacao
{
	/// <summary>
	/// Summary description for Relatorio_Cadastro_de_Produtores.
	/// </summary>

	public class Relatorio_Analise_Leite : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label lblRegiao;
		protected System.Web.UI.WebControls.Label lblCoop;
		protected System.Web.UI.WebControls.Label lblOrdProd;
		protected System.Web.UI.WebControls.Label lblProd;
		protected System.Web.UI.WebControls.Label lblDtIni;
		protected System.Web.UI.WebControls.Label lblDtFim;
		protected System.Web.UI.WebControls.DropDownList ddlRegiao;
		protected System.Web.UI.WebControls.DropDownList ddlCoop;
		protected System.Web.UI.WebControls.DropDownList ddlProd;
		protected System.Web.UI.WebControls.DropDownList ddlDtIni;
		protected System.Web.UI.WebControls.DropDownList ddlDtFim;
		protected System.Web.UI.WebControls.Button btRelatorio;
		public string strConn = ConfigurationSettings.AppSettings["StringConnDB"].ToString();
		public string Parametro,cdUsuario,cdTipoUsuario;
		public string id_produtor,dt_ano_coleta,dt_mes_coleta,nr_coleta,id_analise,ds_analise,dt_coleta,nr_bol_ccl,lim_qttivo_inf,lim_qttivo_sup,result_qttivo,padrao_qltivo,result_qltivo,tp_ordem;
		protected System.Web.UI.WebControls.Label lblMsn;
		protected System.Web.UI.WebControls.RadioButton rdNome;
		protected System.Web.UI.WebControls.RadioButton rdMK;
		protected System.Web.UI.WebControls.RadioButton rdCap;
		protected System.Web.UI.WebControls.Button btAtuaAnal;
		protected System.Web.UI.WebControls.DropDownList ddlMes;
		protected System.Web.UI.WebControls.DropDownList ddlAno;			
		protected SqlDataReader dr;	
			
					
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		
			// Meu código de carregar as combos iniciam aqui LILIAN !!!

			//string Parametro = "11"; 
			
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
			
			string dir  = Context.Server.MapPath(@"\captacao\Analise\analise.txt");
		
			if(File.Exists(dir))
			{
				btAtuaAnal.Visible = true;
				btRelatorio.Visible = false;
				ddlRegiao.Enabled = false;
			}
			else
			{
				//lblMsn.Text = dir;
				lblMsn.Visible = true;
				btAtuaAnal.Visible = false;
				btRelatorio.Visible = true;
				ddlRegiao.Enabled = true;
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
			this.rdNome.CheckedChanged += new System.EventHandler(this.rdNome_CheckedChanged);
			this.rdMK.CheckedChanged += new System.EventHandler(this.rdMK_CheckedChanged);
			this.rdCap.CheckedChanged += new System.EventHandler(this.rdCap_CheckedChanged);
			this.btAtuaAnal.Click += new System.EventHandler(this.btAtuaAnal_Click);
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
			ddlRegiao.Items.Clear();
			ddlRegiao.Items.Add(new ListItem("Selecione","null"));

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

			ddlCoop.Items.Add(new ListItem("Selecione","null"));

			while (dr.Read())
			{
				id_coop = dr[2].ToString();
				ds_coop = dr[3].ToString();
				ddlCoop.Items.Add(new ListItem(id_coop + "-" + ds_coop,id_coop));
			}

			dr.Close();

			
			if (cdTipoUsuario == "M")
			{
				rdCap.Visible = true;
				rdMK.Visible = true;
				rdNome.Visible = true;
			}

			
			if (cdTipoUsuario == "P")
			{
				CarregaProdUsu();
			}



		}


		// Carregar Produtor !!!
		public void CarregaProd()
		{

			#region comboProd

			string ds_prod,id_prod,id_prod_coop;

			string [] Fields = {"@CodCoop","@CodProdutor","@tp_ordem"};
			string [] Param = {ddlCoop.SelectedValue.ToString(),null,tp_ordem.ToString()};
									
			clsSQLServer sql = new clsSQLServer();
			
			SqlDataReader dr =  sql.ExecutarOperacao(strConn,"PR_SEL_PRODUTOR_COOP",Fields,Param);
			
			ddlProd.Items.Clear();

			ddlProd.Items.Add(new ListItem("Todos","null"));

			while (dr.Read())
			{
				id_prod_coop = dr[0].ToString();
				id_prod = dr[1].ToString();
				ds_prod = dr[2].ToString();
		
				ddlProd.Items.Add(new ListItem(id_prod + "  |  " + id_prod_coop + "  |  " + ds_prod,id_prod));
			}

			dr.Close();
          
		}

		public void CarregaProdUsu()
		{

			string ds_prod,id_prod,id_prod_coop;

			string [] Fields = {"@Cod_Usu"};
			string [] Param = {cdUsuario.ToString()};
									
			clsSQLServer sql = new clsSQLServer();
			
			SqlDataReader dr =  sql.ExecutarOperacao(strConn,"PR_SEL_PROD_COOP_USU",Fields,Param);
			
			ddlProd.Items.Clear();

			
			while (dr.Read())
			{
				id_prod_coop = dr[0].ToString();
				id_prod = dr[1].ToString();
				ds_prod = dr[2].ToString();
		
				ddlProd.Items.Add(new ListItem(id_prod + "  |  " + id_prod_coop + "  |  " + ds_prod,id_prod));
			}

			dr.Close();

			#endregion
            
		}

		
		private void ddlRegiao_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			CarregaCoop(ddlRegiao.SelectedValue.ToString(),cdUsuario);
		}

			
		private void btRelatorio_Click(object sender, System.EventArgs e)
		{
			//Consistência Região
			if (ddlRegiao.SelectedValue.ToString().Equals("null"))

			{

				Page.RegisterStartupScript("Alert","<script language='JavaScript'>alert('Selecione uma Região'); </script>");
				return;
			}

			//Consistência Cooperativa
			if (ddlCoop.SelectedValue.ToString().Equals("null"))

			{

				Page.RegisterStartupScript("Alert","<script language='JavaScript'>alert('Selecione uma Cooperativa'); </script>");
				return;

			}

			
			//Consistência Mês

			if (ddlMes.SelectedValue == "")
  		    {
			Page.RegisterStartupScript("Alert","<script language='JavaScript'>alert('Informe o Mês'); </script>");
				return;
			}
			
			
			
			//Consistência Ano

			if (ddlAno.SelectedValue == "")
  		    {
			Page.RegisterStartupScript("Alert","<script language='JavaScript'>alert('Informe o Ano'); </script>");
				return;
			}

				string [] Fields = {"@CodRegiao","@CodCoop","@CodProd","@Mes","@Ano"};
				string [] Param = { ddlRegiao.SelectedValue.ToString(),ddlCoop.SelectedValue.ToString(),ddlProd.SelectedValue.ToString(),ddlMes.SelectedValue.ToString(),ddlAno.SelectedValue.ToString()};
						
				string sPathLocal = HttpContext.Current.Server.MapPath("Relatorio").ToString();
				string FilePath = sPathLocal + "\\REL_ANALISE_LEITE.pdf"; 
			
				clsCrystal.clsCrystal crt = new clsCrystal.clsCrystal();
				crt.ReportCrystal("PR_REL_ANALISE_LEITE",strConn,Fields,Param,FilePath);
			
				
				HttpContext.Current.Response.Redirect("http://200.187.137.92/RelCaptacao/Relatorio/REL_ANALISE_LEITE.pdf");
				//HttpContext.Current.Response.Redirect("http://cclteste/RelCaptacao/Relatorio/REL_ANALISE_LEITE.pdf");
				//HttpContext.Current.Response.Redirect("http://dif-1029/RelCaptacao/Relatorio/REL_ANALISE_LEITE.pdf");

		}
	

		private void rdNome_CheckedChanged(object sender, System.EventArgs e)
		{
			tp_ordem = "N";
			rdMK.Checked = false;
			rdCap.Checked = false;
			
			//Consistência por tipo de usuário M e P
			CarregaProd();
		}

		private void rdCap_CheckedChanged(object sender, System.EventArgs e)
		{
			tp_ordem = "C";
			rdMK.Checked = false;
			rdNome.Checked = false;
			CarregaProd();
		}

		private void btAtuaAnal_Click(object sender, System.EventArgs e)
		{
		string dir  = Context.Server.MapPath(@"\captacao\Analise\analise.txt");
		string line;
		string [] Fields = {"@id_produtor","@dt_ano_coleta","@dt_mes_coleta","@nr_coleta","@id_analise","@ds_analise","@dt_coleta","@nr_bol_ccl","@lim_qttivo_inf","@lim_qttivo_sup","@result_qttivo","@padrao_qltivo","@result_qltivo"};
						
				try
				{
					FileStream fs = new FileStream(dir,FileMode.Open,FileAccess.Read);
					StreamReader sr = new StreamReader(fs);
					
					clsSQLServer sql = new clsSQLServer();
					
					line = sr.ReadLine();

					
					
					while(line != null)
					{

						id_produtor		= line.Substring(0,5); 
						dt_ano_coleta	= line.Substring(6,2);
						dt_mes_coleta	= line.Substring(9,2);
						nr_coleta		= line.Substring(12,2);
						id_analise		= line.Substring(15,2);
						ds_analise		= line.Substring(18,20);
						dt_coleta		= line.Substring(39,8);
						nr_bol_ccl		= line.Substring(48,8);
						lim_qttivo_inf	= line.Substring(57,10);
						lim_qttivo_sup	= line.Substring(68,10);
						result_qttivo	= line.Substring(79,10);
						padrao_qltivo	= line.Substring(90,10);
						result_qltivo	= line.Substring(101,10);
	
						string [] Param = {id_produtor,dt_ano_coleta,dt_mes_coleta,nr_coleta,id_analise,ds_analise,dt_coleta,nr_bol_ccl,lim_qttivo_inf,lim_qttivo_sup,result_qttivo,padrao_qltivo,result_qltivo};

						dr =  sql.ExecutarOperacao(strConn,"PR_IN_ANALISE_TBMPANALISE",Fields,Param);
						dr.Close();
						line = sr.ReadLine();
						
					}
					sr.Close();
					

					//lblMsn.Text = "Arquivo Processado";
					lblMsn.Visible = true;
					File.Delete(dir);

					btAtuaAnal.Visible = false;
					btRelatorio.Visible = true;
					ddlRegiao.Enabled = true;
					

			}	
			catch(IOException ei)
				{
					lblMsn.Text = ("Erro no processamento do arquivo" + ei.ToString()) ;
					lblMsn.Visible = true;
					return;
				
				}
			
		}

		private void rdMK_CheckedChanged(object sender, System.EventArgs e)
		{
			tp_ordem = "M";
			rdCap.Checked = false;
			rdNome.Checked = false;
			
			CarregaProd();
		}

		

	}
}