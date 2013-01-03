<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true"
    CodeFile="Edit.aspx.cs" Inherits="Admin_Product_Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="/css/screen.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="pageTitle">
    产品列表
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <x:PageManager runat="server" />
    <table>
    <tr>
          <td>
                所属类别
            </td>
            <td>
               <x:DropDownList runat="server" DataTextField="Name" DataValueField="Id" ID="ddlCateTop" OnSelectedIndexChanged="ddlCateTop_SelectedIndexChanged" AutoPostBack="true"></x:DropDownList>
                   <x:DropDownList runat="server"  DataTextField="Name" DataValueField="Id"  ID="ddlCateSecond"></x:DropDownList>
            </td>
        </tr>
        <tr>
          <td>
                名称
            </td>
            <td>
                <asp:TextBox runat="server" ID="tbxName"></asp:TextBox>
            </td>
        </tr>
        <tr>
          <td>
                详情
            </td>
            <td>
                <asp:TextBox runat="server" ID="tbxDescription"></asp:TextBox>
            </td>
        </tr>
        <tr>
          <td>
                图片:
            </td>
            <td>
                <div>
                    <x:FileUpload runat="server" ID="fu">
                    </x:FileUpload>
                </div>
                <div>
                    <asp:Repeater runat="server" ID="rptImg">
                    </asp:Repeater>
                </div>
            </td>
        </tr>
    </table>
    <div>
        <asp:Button runat="server" ID="btnSave" Text="保存" OnClick="btnSave_Click" />
        <asp:Label runat="server" ID="lblMsg"></asp:Label>
    </div>
</asp:Content>
