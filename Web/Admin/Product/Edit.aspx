<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true"
    CodeFile="Edit.aspx.cs" Inherits="Admin_Product_Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <div>
        <table>
            <tr>
                <th>
                    名称
                </th>
                <td>
                    <asp:TextBox runat="server" ID="tbxName"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>
                    详情
                </th>
                <td>
                    <asp:TextBox runat="server" ID="tbxDescription"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div>
            <asp:Button runat="server" ID="btnSave" Text="保存" OnClick="btnSave_Click" />
            <asp:Label runat="server" ID="lblMsg"></asp:Label>
            </div>
    </div>
</asp:Content>
