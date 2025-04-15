<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="regester.aspx.cs" Inherits="WebApplication5.regester" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="regestercss.css" rel="stylesheet" />
<script src="registerjs.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="form-container">
    <h2>טופס הרשמה</h2>
   <form runat="server" id="login" onsubmit="return validateForm()">
        <label for="firstName">שם פרטי:</label>
        <input type="text" id="firstName" name="firstName" required>
        <div id="firstNameError" class="error"></div>

        <label for="lastName">שם משפחה:</label>
        <input type="text" id="lastName" name="lastName" required>
        <div id="lastNameError" class="error"></div>

        <label for="username">שם משתמש:</label>
        <input type="text" id="username" name="username" required>
        <div id="usernameError" class="error"></div>

        
        <label for="password">סיסמה:</label>
        <input type="password" id="password" name="password" required>
        <div id="passwordError" class="error"></div>

         <label for="email">אימייל:</label>
            <input type="email" id="email" name="email" required>
            <div id="emailError" class="error"></div>

            <label for="phone">מספר טלפון:</label>
            <input type="tel" id="phone" name="phone" required>
            <div id="phoneError" class="error"></div>

       <p>מה הגיל שלך?</p>
<input type="text" name="guitarExperience" placeholder="הזן גיל">

        <label for="howHeard">איך שמעת על האתר שלנו?</label>
        <select id="howHeard" name="howHeard" required>
            <option value="" disabled selected>בחר אפשרות</option>
            <option value="friend">מחבר</option>
            <option value="socialMedia">מרשת חברתית</option>
            <option value="family">ממשפחה</option>
            <option value="other">אחר</option>
        </select>


        <input type="submit" value="שלח">
        
    </form>
</div>
</asp:Content>
