<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="הזמנת אוכל.aspx.cs" Inherits="WebApplication5.planche" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>הזמנת אוכל לקייטרינג</title>
  <link href="StyleSheet_הזמנת_אוכל.css" rel="stylesheet" />
  <script src="JavaScript1000.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <h3>הזמנת אוכל לקייטרינג</ h3>

   
    
    <div class="form-container">
        <form id="myorders" method="get" onsubmit="return checkGender()">
        <label for="kosher">כשרות:</label>
        <select id="kosher" name="kosher">
            <option value="כשר" selected>כשר</option>
            <option value="לא כשר">לא כשר</option>
        </select>

        <label for="tiv">הזמנה טבעונית:</label> 
        <select id="tiv" name="tiv">
            <option value="כן" selected>כן</option>
            <option value="לא">לא</option>
        </select>

        <label for="גלוטן">בקשה ללא גלוטן:</label>
        <select id="גלוטן" name="גלוטן">
            <option value="כן" selected>כן</option>
            <option value="לא">לא</option>
        </select>
        <div class="gender-options">
            <label>מין:</label>
            <label for="male">זכר</label> 
            <input type="radio" id="male" name="gender" value="male"> 
            <label for="female">נקבה</label> &nbsp;
            <input type="radio" id="female" name="gender" value="female"> 
             <div id="err_gender" class="error-message">נא לבחור מגדר</div>
        </div>
            
            <label for="kosher">הכנס איזה כשרות אתה רוצה</label>
            <select id="kosher" name="kosher">
                <option value="null" selected="selected"></option>
                  <option value="הרבנות הראשית לישראל">הרבנות הראשית לישראל</option>
                 <option value="מחפוד">מחפוד</option>
                 <option value="חלאל">חלאל</option>
                 <option value="עובדיה יוסף" >עובדיה יוסף</option>
                <option value="כשרות חבד">כשרות חבד</option>
                <option value="בן יהודה">בן יהודה</option>
                </select>




        <fieldset class="food-options">
            <legend>בחר מנות:</legend>
            <input type="checkbox" id="kugel-cake" name="food" value="עוגת קיגל">
            <label for="kugel-cake">עוגת קיגל</label>

            <input type="checkbox" id="cream-cake" name="food" value="עוגת שמנת">
            <label for="cream-cake">עוגת שמנת</label>

            <input type="checkbox" id="shepherd-pie" name="food" value="פאי רועים">
            <label for="shepherd-pie">פאי רועים</label>

            <input type="checkbox" id="choco-chip-cookies" name="food" value="עוגיות שוקולד צ'יפס">
            <label for="choco-chip-cookies">עוגיות שוקולד צ'יפס</label>

            <input type="checkbox" id="beef-patties" name="food" value="קציצות בקר">
            <label for="beef-patties">קציצות בקר</label>

            <input type="checkbox" id="muffins" name="food" value="מאפינס">
            <label for="muffins">מאפינס</label>

            <input type="checkbox" id="mexican-food" name="food" value="אוכל מקסיקני">
            <label for="mexican-food">אוכל מקסיקני</label>

            <input type="checkbox" id="sushi" name="food" value="סושי">
            <label for="sushi">סושי</label>
            <br />
            <input type="checkbox" id="choco-mousse" name="food" value="מוס שוקולד">
            <label for="choco-mousse">מוס שוקולד</label>
        </fieldset>
            

         <input type="submit" value="שלח" />
</form>
    </div>
</asp:Content>
