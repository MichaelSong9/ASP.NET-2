using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

static class Conexao
{
    public static string SQL
    {
        get
        {
            return @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Thiago\Projects\BlobASPNet\BlobASPNet\App_Data\Blob.mdf;Integrated Security=True;User Instance=True";
        }
    }
}
