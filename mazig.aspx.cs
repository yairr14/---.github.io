using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class mazig : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!(bool)Session["Login"])
            {

                Session["UnauthorizedMessage"] = "ניסית להיכנס לדף לא מורשה.";
                Response.Redirect("homepage.aspx");
            }
            if (!IsPostBack)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|Users.mdf"";Integrated Security=True";

                string SQLStr = $"SELECT * FROM userstbl Where Id ={Session["tempid"]}";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(SQLStr, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "users");
                DataRow dr = ds.Tables["users"].Rows[0];
                firstName.InnerHtml= dr["firstName"].ToString();
                lastName.InnerHtml = dr["lastName"].ToString();
                username.InnerHtml = dr["username"].ToString();
                password2.InnerHtml = dr["password2"].ToString();
                email.InnerHtml = dr["email"].ToString();
                phone.InnerHtml = dr["phone"].ToString();
                guitarExperience.InnerHtml = dr["guitarExperience"].ToString();
                howHeard.InnerHtml = dr["howHeard"].ToString();
                Admin.InnerHtml = dr["Admin"].ToString();
            }


        }
    }
} 