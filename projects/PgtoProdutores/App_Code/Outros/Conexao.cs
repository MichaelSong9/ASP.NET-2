using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using CrystalDecisions.Shared;

static class Conexao
{
    public static string SQL
    {
        get
        {
            return "Data Source=CCLSQL;Persist Security Info=True;User ID=matprima;Password=lilian";
        }
    }
}