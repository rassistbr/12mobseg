<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_12mob._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <p class="lead">Usuário:</p>
        <asp:TextBox ID="TextBoxusername" runat="server"></asp:TextBox>
        <br>
        <p class="lead">Senha: </p><asp:TextBox ID="TextBoxpassword" runat="server"></asp:TextBox>
        <asp:Button ID="Buttonlogin" class="btn btn-primary btn-lg" runat="server" onclick="Buttonlogin_Click" Text="Login" />
        <br>
    </div>
    <div class="jumbotron">
        <p class="lead"><asp:Label ID="Labelinfo" runat="server" Text=""></asp:Label></p>
    </div>
</asp:Content>
