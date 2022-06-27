<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InstituteCURD.aspx.cs" Inherits="AbacusAcademy.UI.InstituteCURD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" style="width: 65%; height: 388px">
        <tr>
            <td class="modal-sm" style="width: 368px">InstituteId</td>
            <td>
                <asp:TextBox ID="InstituteId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 368px">EmailId</td>
            <td>
                <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 368px">InstituteName</td>
            <td>
                <asp:TextBox ID="txtInstituteName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 368px">InstituteDescription</td>
            <td>
                <asp:TextBox ID="txtInstituteDescription" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 368px">Address</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 368px">Mobile</td>
            <td>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 368px">&nbsp;</td>
            <td>
                <asp:Button ID="AddBtn" runat="server" Text="Add" OnClick="AddInstitute"/>
                <asp:Button ID="SearchBtn" runat="server" Text="Search" OnClick="SearchInstitute"/>
                <asp:Button ID="EditBtn" runat="server" Text="Edit" OnClick="EditInstitute" />
                <asp:Button ID="DeleteBtn" runat="server" Text="Delete" OnClick="DeleteInstitute"/>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 368px">&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" Height="121px" Width="256px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 368px">&nbsp;</td>
            <td>
                <asp:Label ID="LblErrMsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
