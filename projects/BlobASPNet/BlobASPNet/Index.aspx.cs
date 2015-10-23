using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlobASPNet
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();

                if (DetailsView1.Rows.Count == 0)
                {
                    DetailsView1.ChangeMode(DetailsViewMode.Insert);
                }
            }
        }

        protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
        {
            Foto foto = new Foto();

            TextBox titulo = (TextBox)DetailsView1.Rows[0].Cells[1].Controls[0];
            TextBox descricao = (TextBox)DetailsView1.Rows[1].Cells[1].Controls[1];
            FileUpload fu = (FileUpload)DetailsView1.Rows[2].Cells[1].Controls[1];

            foto.Titulo = titulo.Text;
            foto.Descricao = descricao.Text;
            System.IO.Stream imgdatastream = fu.PostedFile.InputStream;

            int imgdatalen = fu.PostedFile.ContentLength;
            byte[] imgdata = new byte[imgdatalen];
            int n = imgdatastream.Read(imgdata, 0, imgdatalen);

            foto.FotoDados = imgdata;
            FotoDAL.Create(foto);

            BindData();
        }

        protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
        {
            Foto foto = new Foto();

            TextBox titulo = (TextBox)DetailsView1.Rows[0].Cells[1].Controls[0];
            TextBox descricao = (TextBox)DetailsView1.Rows[1].Cells[1].Controls[1];
            FileUpload fu = (FileUpload)DetailsView1.Rows[2].Cells[1].Controls[1];

            foto.FotoID = Convert.ToInt32(DetailsView1.DataKey[0]);
            foto.Titulo = titulo.Text;
            foto.Descricao = descricao.Text;
            System.IO.Stream imgdatastream = fu.PostedFile.InputStream;

            int imgdatalen = fu.PostedFile.ContentLength;
            byte[] imgdata = new byte[imgdatalen];
            int n = imgdatastream.Read(imgdata, 0, imgdatalen);

            foto.FotoDados = imgdata;

            FotoDAL.Update(foto);

            BindData();
        }

        protected void DetailsView1_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
        {
            int fotoid = Convert.ToInt32(DetailsView1.DataKey[0]);
            FotoDAL.Delete(fotoid);
        }

        protected void DetailsView1_ModeChanging(object sender, DetailsViewModeEventArgs e)
        {
            DetailsView1.ChangeMode(e.NewMode);
            BindData();
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            DetailsView1.PageIndex = e.NewPageIndex;
            BindData();
        }

        private void BindData()
        {
            List<Foto> photos = FotoDAL.Read();

            DetailsView1.DataSource = photos;
            DetailsView1.DataBind();
        }
    }
}
