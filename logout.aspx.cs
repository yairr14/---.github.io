using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["Login"])
            {
                Session["Login"] = false;
                Session["Admin"] = false;
                Response.Redirect("דף בית.aspx");
            }

            else
            {
                Response.Redirect("Shgia.aspx");
            }
        }
    }
}