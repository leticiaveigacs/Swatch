<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="app.aspx.cs" Inherits="Site_Projeto.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
         <b>Seja&nbsp; Bem-Vindo!</p> </b>
    <p>
        Ola,
        <b><asp:Label ID="lbl_utilizador" runat="server"></asp:Label> </b>
    </p>
    <asp:Button ID="btn_inscricao" runat="server" Text="Inscriçao" OnClick="btn_inscricao_Click" Width="147px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_gestao" runat="server" OnClick="btn_gestao_Click" Text="Gestão Ultilizadores" />
    <br />
    <br />
    </asp:Content>
