<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="zorkesher.aspx.cs" Inherits="WebApplication5.zorkesher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="regestercss.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class="form-container">
       <form action="homepage.aspx" method="POST" onsubmit="validateForm(event)">
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

        <label for="number">גיל:</label>
<input type="number" id="number" name="number" required>
           <div>
           </div>
        <label for="gmail">אימל:</label>
<input type="text" id="gmail" name="gmail" required>
           <div>
           </div>
               <label for="place">כתובת:</label>
<input type="text" id="place" name="place" required>
    <div>
    </div>
     <label for="message">הערה:</label>
            <textarea id="message" name="message" rows="6" required></textarea>
           <div>
           </div>
            <input type="submit" value="שלח">
           </div> 
</asp:Content>
