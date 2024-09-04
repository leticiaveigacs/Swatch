<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="dados.aspx.cs" Inherits="Site_Projeto.exemplo1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h3>Informações</h3>
    <p>
    <hr class="text-sm-center">
    <br />
    <b>Nome:</b><asp:Label ID="tb_nome" runat="server"></asp:Label>
    <br />
    <br />
    <b>Morada:</b><asp:Label ID="tb_morada" runat="server"></asp:Label>
    <br />
    <br />
    <b>E-mail:</b><asp:Label ID="tb_email" runat="server"></asp:Label>
    <br />
    <br />
    <b>Hobbies:</b><asp:Label ID="cbl_hobbies" runat="server"></asp:Label>
    <br />
    <br />
    <b>Genêro:</b>
    <asp:Label ID="rbl_genero" runat="server"></asp:Label>
    <br />
    <br />
    <b>Regime:</b>
    <asp:Label ID="ddl_regime" runat="server"></asp:Label>
    <br />
    <br />
    <b>Curso:</b>
    <asp:Label ID="ddl_cursos" runat="server"></asp:Label>
    <br />
    <br />
    <br />
    <hr>
    <b>Exportações:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;<br />
    <asp:Button ID="btn_excel2" runat="server" OnClick="btn_excel2_Click" Text="Excel" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_word2" runat="server" OnClick="btn_word2_Click" Text="Word" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_pdf2" runat="server" OnClick="btn_pdf2_Click" Text="PDF" />
    <br />
    <br />
    <hr>
    <b>Envio por E-mail:</b><br />
    <br />
    De:<asp:TextBox ID="tb_de" runat="server"></asp:TextBox>
    <br />
    <br />
    Para:<asp:TextBox ID="tb_para" runat="server"></asp:TextBox>
    <br />
    <br />
    Asssunto:<asp:TextBox ID="tb_assunto" runat="server"></asp:TextBox>
    <br />
    <br />
    Mesnagem:<asp:TextBox ID="tb_mensagem" runat="server"></asp:TextBox>
    <br />
    <br />
    <p>
        <asp:Button ID="btn_email2" runat="server" OnClick="btn_email2_Click" Text="E-mail" />
    </p>
    <p>
        &nbsp;</p>
    <p>
    <br />
</p>
</asp:Content>
