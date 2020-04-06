<%@ Page Title="" Language="C#" MasterPageFile="~/Master/LoginPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Project.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="item1" runat="server">
    <a href="../Index.aspx">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/logo.png" /></a>

    <table class="table">
        <tr>
            <th>
                <asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label></th>
        </tr>
        <tr>
            <td>
                <br />
                <br />
                <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label><br />
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label><br />
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <br />
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <br />

        </tr>
    </table>
    <h1>
        <asp:Label ID="lblisLogin" runat="server" Text=""></asp:Label></h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="item2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="item3" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="body1" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="body2" runat="server">
</asp:Content>
