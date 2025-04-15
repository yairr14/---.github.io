<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication5.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="regestercss.css" rel="stylesheet" />
    <script src="loginjs.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-container">
        <h2>טופס כניסה</h2>
        <form runat="server" id="login" onsubmit="return validateForm()">
            <label for="username">שם משתמש:</label>
            <input type="text" id="username" name="username" required>
            <div id="usernameError" class="error"></div>

            <label for="password">סיסמה:</label>
            <input type="password" id="password" name="password" required>
            <div id="passwordError" class="error"></div>
            <div id="message" runat="server" style="color:red"></div>
            <input type="submit" value="שלח">
            <a href="regester.aspx">אין לי משתמש</a>
        </form>
    </div>

     <img src="https://s3.prog.co.il/data/xfmg/thumbnail/104/104617-7e485c86f89091f23e1a5da649dcc733.jpg?1659009954" alt="תמונה שזזה שמאלה ימינה " class="moving-image">
        
</asp:Content>
