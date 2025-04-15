using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application["VisitCount"] = (int)Application["VisitCount"] + 1;
            VisitCount.InnerHtml="מספר הכניסות לאתר: " + Application["VisitCount"].ToString();



            if (!(bool)Session["Login"])
            {
                bar1.Style.Add("display", "none");
              
                bar3.Style.Add("display", "none");
                bar4.Style.Add("display", "none"); 
                bar11.Style.Add("display", "none");
                bar12.Style.Add("display", "none");
            }
            else
            {
                bar1.Style.Add("display", "block");
               
                bar3.Style.Add("display", "block");
                bar4.Style.Add("display", "block");
                bar12.Style.Add("display", "block");
            }
            String str = Session["Admin"].ToString();
            if (!(bool)Session["Admin"])
            {
                bar10.Style.Add("display", "none");
            }
            else
            {
                bar10.Style.Add("display", "block");
            }





            if (Session["UnauthorizedMessage"] != null)
            {
                lblMessage.Text = Session["UnauthorizedMessage"].ToString();
                Session["UnauthorizedMessage"] = null; // נקה את ההודעה אחרי ההצגה
            }
        }
    }
}