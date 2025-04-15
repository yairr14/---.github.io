using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Policy;

namespace WebApplication5
{
    public partial class Edit_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(bool)Session["Admin"] && !(bool)Session["Login"])
            {

                Response.Redirect("Shgia.aspx");
            }
            if (!IsPostBack)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|Users.mdf"";Integrated Security=True";

             string SQLStr = $"SELECT * FROM userstbl Where Id ={ (int)Session["userToUpdate"]}";
             SqlConnection con = new SqlConnection(connectionString);
             SqlCommand cmd = new SqlCommand(SQLStr, con);
             DataSet ds = new DataSet();
             SqlDataAdapter adapter = new SqlDataAdapter(cmd);
             adapter.Fill(ds, "users");
             DataRow dr = ds.Tables["users"].Rows[0];
             firstName.Value = dr["firstName"].ToString();
             lastName.Value = dr["lastName"].ToString();
             username.Value = dr["username"].ToString();
                password2.Value = dr["password2"].ToString();
             email.Value = dr["email"].ToString();
             phone.Value = dr["phone"].ToString();
             guitarExperience.Value = dr["guitarExperience"].ToString();
             howHeard.Value = dr["howHeard"].ToString();
             Admin.Value = dr["Admin"].ToString();
            }
        }
        public void updateUser(object sender, EventArgs e)
        {
         string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|Users.mdf"";Integrated Security=True";
         string SQLStr = $"SELECT* FROM userstbl Where Id ={(int)Session["userToUpdate"]}";
         SqlConnection con = new SqlConnection(connectionString);
         SqlCommand cmd = new SqlCommand(SQLStr, con);
         DataSet ds = new DataSet();
         SqlDataAdapter adapter = new SqlDataAdapter(cmd);
         adapter.Fill(ds, "users");
         DataRow dr = ds.Tables["users"].Rows[0];
         dr["firstName"] = firstName.Value;
         dr["lastName"] = lastName.Value;
         dr["username"] = username.Value;
         dr["password2"] = password2.Value;
         dr["email"] = email.Value;
         dr["phone"] = phone.Value;
         dr["guitarExperience"] = guitarExperience.Value;
         dr["howHeard"] = howHeard.Value;
         dr["Admin"] = Admin.Value;
         SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
         adapter.UpdateCommand = builder.GetUpdateCommand();
         adapter.Update(ds, "users");
         Response.Redirect("Admin-Page.aspx");
        }


    }
}