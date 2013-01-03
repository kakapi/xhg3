<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true"
    CodeFile="Edit.aspx.cs" Inherits="Admin_Category_Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="pageTitle">
    编辑公告
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <table>
        <tr>
            <td>
                标题:
            </td>
            <td>
                <asp:TextBox runat="server" ID="tbxTitle"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                父类:
            </td>
            <td>
                <asp:RadioButtonList ID="rblParent" runat="server">
                
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <th>
                序号
            </th>
            <td>
                <asp:TextBox runat="server" ID="tbxOrder"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th>
                停用
            </th>
            <td>
               <asp:CheckBox runat="server" ID="cbxDisabled" />
            </td>
        </tr>
    </table>
    <div>
        <asp:Button runat="server" ID="btnSave" Text="保存" OnClick="btnSave_Click" />
        <asp:Label runat="server" ID="lblMsg"></asp:Label>
    </div>
</asp:Content>
