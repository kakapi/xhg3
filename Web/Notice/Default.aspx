<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Notice_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
<div style="text-align:center; min-height:400px; margin-bottom:15px;">
    <h1>
        <%=Notice.Title %></h1>
    <h3>
        <%=Notice.LastUpdateTime %>
    </h3>
    <p style="text-align:left; text-indent:40px;">
        <%=Notice.Content %>
    </p></div>
</asp:Content>
