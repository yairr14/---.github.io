<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin-Page.aspx.cs" Inherits="WebApplication5.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="regestercss.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <form method="post" runat="server" id="Adminform" >
       
    <div id="tableDiv" runat="server"></div>
        <button runat="server" onserverclick="Delete" type="button" name="btnDelete" value="Delete" id="btnDelete">מחק משתמשים</button>
        <button runat="server" onserverclick="Edit" type="button" name="btnEdit" value="Edit" id="btnEdit">לשנות משתמשים</button>
        <div id ="message" runat="server"></div>
    </form>
</asp:Content>
