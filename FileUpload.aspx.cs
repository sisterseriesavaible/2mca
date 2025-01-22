using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2mca
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string fileName = FileUpload1.FileName;
            string path = Server.MapPath("~/FILES") + fileName;
            FileUpload1.SaveAs(path);
            //Label1.Text = "file Upload";

        }
    }
}