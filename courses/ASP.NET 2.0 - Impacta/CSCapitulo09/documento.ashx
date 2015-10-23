<%@ WebHandler Language="C#" Class="documento" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Data;



public class documento : IHttpHandler {

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/xml";
        context.Response.Write("<dados>");
        context.Response.Write("<nome>");
        context.Response.Write("maria");
        context.Response.Write("</nome>");
        context.Response.Write("</dados>");

    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}