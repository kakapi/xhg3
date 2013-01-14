<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Category_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="pageTitle">
分类列表
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
<asp:Repeater runat="server" ID="rptCates">
<ItemTemplate>
<a href='Edit.aspx?id=<%#Eval("ID") %>'><%#Eval("Name") %></a>
</ItemTemplate>
</asp:Repeater>
</asp:Content>

