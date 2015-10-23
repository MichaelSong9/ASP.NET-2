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

public class Crystal
{
    public static TableLogOnInfos ConectaCrystal()
    {
        TableLogOnInfos Infos = new TableLogOnInfos();
        TableLogOnInfo Info = new TableLogOnInfo();
        ConnectionInfo cn = new ConnectionInfo();
        cn.ServerName = "CCLSQL";
        cn.DatabaseName = "materia_prima";
        cn.UserID = "matprima";
        cn.Password = "lilian";
        cn.Type = ConnectionInfoType.SQL;
        cn.IntegratedSecurity = false;
        Info.ConnectionInfo = cn;
        Infos.Add(Info);
        return Infos;
    }
}