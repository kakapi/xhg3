<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="/css/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <div class="rowContent cf">
        <div class="notice">
            <div class="noticeHeader cf">
                <span>公告栏</span><img  src="/img/arrow.png" />  </div>
                <asp:Repeater runat="server" ID="rptNotice">
                <HeaderTemplate><ul></HeaderTemplate>
                <FooterTemplate></ul></FooterTemplate>
                <ItemTemplate>
                <li><%#Eval("Title") %></li>
                </ItemTemplate>
                </asp:Repeater>
               
          
        </div>
        <div class="imageswitch">
        <img src="/img/switch1.jpg" alt="" />
        </div>
    </div>
   <div class="rowContent cf">

     <div class="column c1">
     
        <a href="#"> 散客采购</a>
     </div>
      <div class="column c2">
        <a href="#"> 会员选购</a>
      </div>
      <div class="column c3">
        <a href="#"> 会员套餐</a>
      </div>
   </div>
</asp:Content>
