<%@ Page Title="" Language="C#" MasterPageFile="~/Products/p.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Products_Default" %>

<%-- 在此处添加内容控件 --%>
<asp:Content ContentPlaceHolderID="main" runat="server">
    <div class="leftColumn">
        <div class="listHeader cf">
            <span>菜品选购</span>
        </div>
        <div class="listHeader cf">
            <span>菜品配送</span>
        </div>
        <div class="listHeader cf">
            <span>菜品配送</span>
        </div>
        <div class="listHeader cf">
            <span>菜品配送</span>
        </div>
        <div class="listHeader cf">
            <span>菜品配送</span>
        </div>
        <div class="listHeader cf">
            <span>菜品配送</span>
        </div>
    </div>
    <div class="rightColumn">
        <div class="topCate">
        </div>
        <div class="productList">
            <asp:Repeater ID="rptProducts" runat="server">
                <ItemTemplate>
                    <div class="product">
                        <img />
                        <div class="pname">
                            <span></span><span class="pclass"></span>
                        </div>
                        <div class="pdesc">
                        </div>
                        <div class="psel">
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <uc:AspNetPager runat="server" ID="pager"></uc:AspNetPager>
    </div>
</asp:Content>
