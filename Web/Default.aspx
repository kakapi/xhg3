<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <div class="rowContent cf">
        <div class="notice">
            <div class="noticeHeader">
                <span>公告栏</span><img src="/img/arrow.png" />
                <asp:Repeater runat="server" ID="rptNotice">
                <HeaderTemplate><ul></HeaderTemplate>
                <FooterTemplate></ul></FooterTemplate>
                <ItemTemplate>
                <li><%#Eval("Title") %></li>
                </ItemTemplate>
                </asp:Repeater>
               
            </div>
        </div>
        <div class="imageswitch">
        </div>
    </div>
</asp:Content>
