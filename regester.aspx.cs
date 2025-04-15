using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

namespace WebApplication5
{
    public partial class regester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (IsPostBack)
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|Users.mdf"";Integrated Security=True";
                    SqlConnection con = new SqlConnection(connectionString);
                    string SQLStr = $"SELECT * FROM userstbl WHERE 0 = 1"; 
                    SqlCommand cmd = new SqlCommand(SQLStr, con);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds, "users");
                    DataRow dr = ds.Tables["users"].NewRow();
                   
                    dr["firstName"] = Request.Form["firstName"];
                    dr["lastName"] = Request.Form["lastName"];
                    dr["userName"] = Request.Form["userName"];
                    dr["password2"] = Request.Form["password"];
                    dr["email"]= Request.Form["email"];
                    dr["phone"] = Request.Form["phone"];
                    dr["guitarExperience"] =  Request.Form["guitarExperience"];
                    dr["howHeard"] = Request.Form["howHeard"];
                    dr["Admin"] = false;
                    ds.Tables["users"].Rows.Add(dr);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetInsertCommand();
                    adapter.Update(ds, "users");
                    Session["Login"] = true;
                    Response.Redirect("דף בית.aspx");
                    
                }
            }
        }
    }
}