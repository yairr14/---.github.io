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
    public partial class shihzor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|Users.mdf"";Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                string SQLStr = $"SELECT * FROM userstbl WHERE username='{Request.Form["username"]}' AND email='{Request.Form["email"]}'";
                SqlCommand cmd = new SqlCommand(SQLStr, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Users");

                // אם נמצאו נתונים בטבלה
                if (ds.Tables[0].Rows.Count > 0) //שבעצם יש שורות עם הנתונים האלו של הדאתה סט אחרי השאילתה
                {
                    password.InnerHtml = "הסיסמא שלך נמצאה  : " + ds.Tables["Users"].Rows[0]["password2"].ToString();
                }
                else
                {
                    password.InnerHtml = " הסיסמא שלך לא נמצא";
                }
            }
        }
    }
}
 
