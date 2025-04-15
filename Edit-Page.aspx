<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Edit-Page.aspx.cs" Inherits="WebApplication5.Edit_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="regestercss.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" method="post" runat="server">
        <table>
            <tr>
                <td><label for="firstName">First Name:</label></td>
                <td><input type="text" id="firstName" name="firstName" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="lastName">Last Name:</label></td>
                <td><input type="text" id="lastName" name="lastName" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="username">Username:</label></td>
                <td><input type="text" id="username" name="username" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="password">Password:</label></td>
                <td><input type="text" id="password2" name="password" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="email">Email:</label></td>
                <td><input type="email" id="email" name="email" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="phone">Phone:</label></td>
                <td><input type="text" id="phone" name="phone" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="guitarExperience">age:</label></td>
                <td><input type="text" id="guitarExperience" name="guitarExperience" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="howHeard">How You Heard About Us:</label></td>
                <td><input type="text" id="howHeard" name="howHeard" value="" runat="server" /></td>
            </tr>
            <tr>
                <td><label for="Admin">Admin:</label></td>
                <td><input type="text" id="Admin" name="Admin" value="" runat="server" /></td>
            </tr>
            
            </table>
         <button runat="server" onserverclick="updateUser" type="button" id="tblupdateUser" >שינוי משתמש</button>
         </form>




</asp:Content>
