using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.Services.Description;


namespace WebApplication5
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
               
            {
                string SQLStr = "SELECT * FROM userstbl";
                DataSet ds = WebApplication5.login.RetrieveUsersTable(SQLStr);
                DataTable dt = ds.Tables[0];
                string table = BuildUsersTable(dt);
                tableDiv.InnerHtml = table;
            }
        }
        public void Edit (object sender, EventArgs e)
        {
            for (int i = 1; i < Request.Form.Count; i++)
            {
                if (Request.Form.AllKeys[i].Contains("chk"))
                {
                    Session["userToUpdate"] = int.Parse(Request.Form.AllKeys[i].Remove(0, 3)); 
                    Response.Redirect("Edit-Page.aspx");
                }
            }
            message.InnerHtml = "No user was Selected";
        }

            public string BuildUsersTable(DataTable dt)
        {
            string str = "<table class='usersTable' style='border: solid black;' align='center' color: black;>";

            // כותרת הטבלה
            str += "<tr>";
            str += "<td style='border: solid black;'></td>"; // מקום לרדיו בוטון
            foreach (DataColumn column in dt.Columns)
            {
                str += "<td style='border: solid black; color: black;'>" + column.ColumnName + "</td>"; // כותרות עמודות
            }
            str += "</tr>";

            // שורות הנתונים
            foreach (DataRow row in dt.Rows)
            {
                str += "<tr style='border: solid black;'>";
                str += "<td style='border: solid black;'>" + CreateRadioBtn(row["Id"].ToString()) + "</td>"; // רדיו בוטון לכל שורה
                foreach (DataColumn column in dt.Columns)
                {
                    str += "<td style='border: solid black; color: black;'>" + row[column] + "</td>";
                }
                str += "</tr>";
            }

            str += "</table>"; // סגירת תגית ה-table
            return str;
        }


        public string CreateRadioBtn(string id)
        {
         return $"<input type='checkbox' name='chk{id}' id='chk{id}' runat='server' />";
        }
        public void Delete(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|Users.mdf"";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            string SQLStr = "SELECT* FROM userstbl";
            SqlCommand cmd = new SqlCommand(SQLStr, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tblUsers");
            for (int i = 1; i < Request.Form.Count; i++)
            {
                if (Request.Form.AllKeys[i].Contains("chk"))
                {
                    int userId = int.Parse(Request.Form.AllKeys[i].Remove(0, 3));
                    DataRow[] dr = ds.Tables["tblUsers"].Select($"Id = {userId}");
                        dr[0].Delete();
                }
            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetDeleteCommand();
            adapter.Update(ds, "tblUsers");
            string table = BuildUsersTable(ds.Tables["tblUsers"]);
            tableDiv.InnerHtml = table;
        }
        }
}