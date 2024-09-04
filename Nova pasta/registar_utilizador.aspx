<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="registar_utilizador.aspx.cs" Inherits="Site_Projeto.registar_utilizador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <h3>Resgrito</h3>
        <p>&nbsp;</p>

    <p>
    Utilizador:<asp:TextBox ID="tb_utilizador" runat="server"></asp:TextBox>
</p>
<p>
    Palavra-passe:<asp:TextBox ID="tb_tw" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;
    <asp:Label ID="lbl_mensagem2" runat="server" ForeColor="#FF3300"></asp:Label>
</p>
<p>
    <asp:Button ID="btn_registar" runat="server" OnClick="btn_registar_Click" Text="Registar" />
</p>
<asp:Label ID="lbl_mensagem" runat="server" style="text-align: left"></asp:Label>
        <br />
        <br />
        <%--<asp:Button ID="btn_senha" runat="server"  Text="Esqueceu Senha" />--%>
        <br />
</asp:Content>
