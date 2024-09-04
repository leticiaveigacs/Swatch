<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="gestao_senha.aspx.cs" Inherits="Site_Projeto.gestão_senha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <b>Recuperaçao de Senha</b></p>
    <p>
        Usuário:<asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
    </p>
    <p>
        Senha:<asp:Label ID="tb_tw" runat="server" ForeColor="White"></asp:Label>
    </p>
    <p>
        <br/>
       <b> Envio por E-mail da senha:</b></p>
    <p>
        De:<asp:TextBox ID="tb_de2" runat="server" Height="28px" Width="198px"></asp:TextBox>
    </p>
    <p>
        Para:<asp:TextBox ID="tb_para2" runat="server" Height="29px" Width="186px" ></asp:TextBox>
    </p>
    <p>
        Assunto:<asp:TextBox ID="tb_assunto2" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_recuperar" runat="server" Text="Recuperar Senha" OnClick="btn_recuperar_Click" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
