<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserCURD.aspx.cs" Inherits="AbacusAcademy.UI.UserCURD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table align="center" style="width: 50%; height: 419px">
        <tr>
            <td style="height: 32px">UserId</td>
            <td style="width: 571px; height: 32px;">
                <asp:TextBox ID="UserId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>UserName</td>
            <td style="width: 571px">
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>EmailId</td>
            <td style="width: 571px">
                <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td style="width: 571px">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Mobile</td>
            <td style="width: 571px">
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>UserRole</td>
            <td style="width: 571px">
                <asp:DropDownList ID="ddlRole" runat="server" Height="31px" Width="88px">
                    <asp:ListItem>User</asp:ListItem>
                    <asp:ListItem>Admin</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 571px">
                <asp:Button ID="AddBtn" runat="server" Text="Add" Width="70px" OnClick="AddUser" />
                <asp:Button ID="SearchBtn" runat="server" Text="Search" Width="70px" OnClick="SearchUser" />
                <asp:Button ID="EditBtn" runat="server" Text="Edit" Width="70px" OnClick="EditUser" />
                <asp:Button ID="DeleteBtn" runat="server" Text="Delete" Width="70px" Onclick="DeleteUser" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 571px">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td></td>
            <td style="width: 571px">
                <asp:Label ID="LblErrMsg" runat="server" Text=" "></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
