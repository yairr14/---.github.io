using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // יצירת שאילתת SQL
                string SQLStr = $"SELECT * FROM userstbl WHERE userName='{Request.Form["userName"]}' AND password2='{Request.Form["password"]}'";

                // קריאה לפונקציה RetrieveUsersTable כדי לקבל את הנתונים
                DataSet ds = RetrieveUsersTable(SQLStr);

                // אם נמצאו נתונים בטבלה
                if (ds.Tables[0].Rows.Count > 0) //שבעצם יש שורות עם הנתונים האלו של הדאתה סט אחרי השאילתה
                {
                  Session["tempid"]=ds.Tables[0].Rows[0]["Id"];
                    // שמירת פרטי המשתמש בשיחה
                    Session["userName"] = Request.Form["userName"];
                    Session["Login"] = true;
                   
                    Session["Admin"] = ds.Tables[0].Rows[0]["Admin"];
                    String rrt = Session["Admin"].ToString();

                    // הצגת הודעת הצלחה
                    message.InnerHtml = "";

                    // הפניית המשתמש לעמוד הראשי
                    Response.Redirect("דף בית.aspx");
                }
                else
                {
                    // אם לא נמצא משתמש עם פרטי הזיהוי
                    Session["userName"] = "Visitor";
                    Session["Login"] = false;
                    Session["Admin"] = false;

                    // הצגת הודעת שגיאה
                    message.InnerHtml = "Unknown user name or password";
                }
            }
        }
        public static DataSet RetrieveUsersTable(string SQLStr)// או בקיצור נותנן גישה להשתמש בדאתה בייס דרך דרך דאתה סט מקבל אובייקט של משתמש ומחזיר את הדאתה סט של המשתמש אחרי השאילתהו 
        {
         /*מכין סטרינג שמתאר גישה לדאתה בייס*/ string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|Users.mdf"";Integrated Security=True";
         /* מבצע חיבור לנתונים שך הדאתה בייס */  SqlConnection con = new SqlConnection(connectionString);
         /*כאן נבנה אובייקט שאחרי לשלוח את השאילתה למסד נתונים*/   SqlCommand cmd = new SqlCommand();
         /*פה מגדירים את השאילתה שאנחנו רוצים לבצע*/ cmd.CommandText = SQLStr;
            /*מקשר את אובייקט cmd עם חיבור למסד הנתונים  con שהגדרנו כבר*/ cmd.Connection = con;
            /*  יוצרים אדאפטר שמבצע את הבקשה להעביר את הנתונים מהמסד נתונים לדאתה סט ומקבת את השאילתה  cmd*/SqlDataAdapter ad = new SqlDataAdapter(cmd);
           /*כאן נוצר אובייקט דאתה סט חדש שיכול להכיל את התוצאות מהשאילתות*/ DataSet ds = new DataSet();
           /* כאן יש זימון לפונקצייה שמקבלת דאתה סט ואת שם הטבלה שנרצה לשמור בה את התוצאות*/ ad.Fill(ds, "users");
         /* הפונקצייה מחזירה את הדאתה סט שמכיל את השאילתה*/return ds;
        }

    }
}



