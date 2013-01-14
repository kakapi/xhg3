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
              <span>有机蔬菜类</span>
        </div>
        <div class="productList cf">
            <asp:Repeater ID="rptProducts" runat="server">
                <ItemTemplate>
                    <div class="product">
                        <img  src='<%#Eval("MainImage") %>' />
                        <div class="pname">
                            <span class="name"><%#Eval("Name") %></span><span class="pclass"><%#((decimal)Eval("Price")).ToString("0")%><span class="unit"> <%#Eval("Unit") %></span></span>
                           
                        </div>
                        <div class="pdesc">
                        <%#Eval("Description") %>
                        </div>
                        <div class="psel">
                        <asp:CheckBox runat="server" ID="cbxSel" /><span>查看评论</span>
                        </div>
                    </div>
                </ItemTemplate>
               
            </asp:Repeater>
        </div>

        <uc:AspNetPager  CssClass="pager" runat="server" ID="pager"></uc:AspNetPager>
    </div>
</asp:Content>
