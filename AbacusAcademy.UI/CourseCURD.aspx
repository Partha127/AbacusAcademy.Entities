<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CourseCURD.aspx.cs" Inherits="AbacusAcademy.UI.CourseCURD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" style="width: 49%; height: 373px">
        <tr>
            <td style="width: 257px">CourseId</td>
            <td>
                <asp:TextBox ID="CourseId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 257px">CourseName</td>
            <td>
                <asp:TextBox ID="txtCourseName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 257px">CourseDescription</td>
            <td>
                <asp:TextBox ID="txtCourseDescription" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 257px">CourseDuration</td>
            <td>
                <asp:TextBox ID="txtCourseDuration" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 257px">InstituteId</td>
            <td>
                <asp:TextBox ID="InstituteId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 257px">&nbsp;</td>
            <td>
                <asp:Button ID="AddBtn" runat="server" Text="Add" OnClick="AddCourse" />
                <asp:Button ID="SearchBtn" runat="server" Text="Search" OnClick="SearchCourse" />
                <asp:Button ID="EditBtn" runat="server" Text="Edit" OnClick="EditCourse" />
                <asp:Button ID="DeleteBtn" runat="server" Text="Delete" OnClick="DeleteCourse" />
            </td>
        </tr>
        <tr>
            <td style="width: 257px">&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" Height="17px" style="margin-right: 5px" Width="285px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 257px">&nbsp;</td>
            <td>
                <asp:Label ID="LblErrMsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
