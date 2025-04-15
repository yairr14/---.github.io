<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="mazig.aspx.cs" Inherits="WebApplication5.mazig" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="homepagecss.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" method="post" runat="server">
   <table>
       <tr>
           <td>First Name:</td>
           <td><span runat="server" id="firstName"></span></td>
       </tr>
       <tr>
           <td>Last-Name:</td>
           <td><span id="lastName" runat="server" /></td>
       </tr>
       <tr>
           <td>Username:</td>
           <td><span id="username" runat="server" /></td>
       </tr>
       <tr>
           <td>Password:</td>
           <td><span id="password2" runat="server" /></td>
       </tr>
       <tr>
           <td>Email:</td>
           <td><span id="email" runat="server" /></td>
       </tr>
       <tr>
           <td>Phone:</td>
           <td><span id="phone" runat="server" /></td>
       </tr>
       <tr>
           <td>age:</td>
           <td><span id="guitarExperience" runat="server" /></td>
       </tr>
       <tr>
           <td>How You Heard About Us:</td>
           <td><span id="howHeard" runat="server" /></td>
       </tr>
       <tr>
           <td><label for="Admin">Admin:</label></td>
           <td><span id="Admin" runat="server" /></td>
       </tr>
       
       </table>
        </form>
</asp:Content>
