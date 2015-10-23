using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlobASPNet
{
    public partial class ExibeFoto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int fotoid = Convert.ToInt32(Request.QueryString["fotoid"]);

            if (fotoid > 0)
            {
                Foto foto = FotoDAL.getFotoPorCodigo(fotoid);
                try
                {
                    Response.Clear();
                    Response.ContentType = "image/pjpeg";
                    Response.BinaryWrite(foto.FotoDados);
                    Response.End();
                }
                catch
                {
                    lblmsg.Text = "Não foi possível exibir imagem";
                }
            }
        }
    }
}
