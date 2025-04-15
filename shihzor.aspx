<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="shihzor.aspx.cs" Inherits="WebApplication5.shihzor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="regestercss.css" rel="stylesheet" />
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-container">
        <form id="Shihzor" runat="server">
            <h1 style="color: #333">שחזור סיסמא</h1>
            <b style="color: #333">הזן שם משתמש</b>
            <input type="text" name="username" id="username" />
            <b style="color: #333">הזן איימל</b>
            <input type="text" name="email" id="email" />
            <input type="submit" value="לחץ לבדוק" />
            <div style="color: red" id="password" runat="server"></div>
        </form>
    </div>

    <img src="https://s3.prog.co.il/data/xfmg/thumbnail/104/104617-7e485c86f89091f23e1a5da649dcc733.jpg?1659009954" alt="תמונה שזזה שמאלה ימינה " class="moving-image">

</asp:Content>
