using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase3Section3_6
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["PageCountOnSession"] == null)
            {
                this.Session["PageCountOnSession"] = 1;
            }
            else
            {
                var value = (int)this.Session["PageCountOnSession"];
                this.Session["PageCountOnSession"] = value + 1;

            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://maps.google.com");
        }

        protected void FileUpload1_Load(object sender, EventArgs e)
        {
        }

        private void upload()
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}