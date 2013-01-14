<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Product_Default" %>

<%-- 在此处添加内容控件 --%>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="pageTitle">
产品列表
</asp:Content>
<asp:Content ContentPlaceHolderID="content" runat="server">
<asp:GridView runat="server" ID="gv">
<Columns>
<asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="edit.aspx?id={0}"
 DataTextField="Name"
 />
</Columns>
</asp:GridView>
</asp:Content>
