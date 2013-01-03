<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="/css/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <div class="rowContent cf">
        <div class="leftColumn">
            <div class="listHeader cf">
                <span>公告栏</span>
            </div>
            <asp:Repeater runat="server" ID="rptNotice">
                <HeaderTemplate>
                    <ul class="noticeItem">
                </HeaderTemplate>
                <FooterTemplate>
                    </ul></FooterTemplate>
                <ItemTemplate>
                    <li>
                      <a href='/Notice/?id=<%#Eval("Id") %>'> <%#Eval("Title") %></a> </li>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="imageswitch">
            <img src="/img/switch1.jpg" alt="" />
        </div>
    </div>
    <div class="rowContent cf">
        <div class="column sanke">
            <a href="#">散客采购</a>
            <img src="img/sanke.jpg" />
            <div>
                本网所有菜品报价均比超市采购优惠8折,请尽情选购.</div>
        </div>
        <div class="column huiyuan">
            <a href="#">会员选购</a>
            <img src="img/sanke.jpg" />
            <ul>
                <li>享受本网九折优惠</li>
                <li>自由选择组合需要的产品</li>
                <li>满60元免去邮资</li>
                <li>投票制定种植或者养殖的菜品</li>
                <li>参加农场活动的资格</li>
                <li>走进自然,参与种植活动</li>
            </ul>
        </div>
        <div class="column taocan">
            <a href="#">会员套餐</a>
            <img src="img/sanke.jpg" />
            <ul>
                <li>享受本网八折优惠</li>
                <li>供菜不足时优先满足</li>
                <li>满60元免去邮资</li>
                <li>投票制定种植或者养殖的菜品</li>
                <li>参加农场活动的资格</li>
                <li>走进自然,参与种植活动</li>
            </ul>
        </div>
    </div>
    <div class="rowContent cf">
    <div class="column2"> <div class="peisong"></div>
    <div class="chengweihuiyuan"></div>
    </div>
    <div class="weihe">
    
    </div>
   
     </div>
</asp:Content>
