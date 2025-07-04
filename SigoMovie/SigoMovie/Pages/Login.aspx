<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SigoMovie.Pages.Login" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>
    <asp:TextBox ID="txtUsuario" runat="server" Placeholder="Usuario"></asp:TextBox><br />
    <asp:TextBox ID="txtToken" runat="server" Placeholder="Token"></asp:TextBox><br />
    <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" OnClick="btnLogin_Click" />
</asp:Content>

