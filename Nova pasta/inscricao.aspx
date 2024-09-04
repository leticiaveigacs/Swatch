<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="inscricao.aspx.cs" Inherits="Site_Projeto.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Inscrição</h3>
    <p>
        <b>Nome:</b>
        <asp:TextBox ID="tb_nome" runat="server" Width="337px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tb_nome" ErrorMessage="Nome Obrigatório." ForeColor="Red">*</asp:RequiredFieldValidator>
    </p>
    <p>
         <b>Morada: </b>
        <asp:TextBox ID="tb_morada" runat="server" Height="76px" TextMode="MultiLine" Width="321px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Morada Obrigatória" ControlToValidate="tb_morada" ForeColor="Red">*</asp:RequiredFieldValidator>
    </p>
    <p>
         <b>Regime: </b>
        <asp:DropDownList ID="ddl_regime" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_regime_SelectedIndexChanged" Width="86px">
            <asp:ListItem>-------</asp:ListItem>
            <asp:ListItem>Diurno</asp:ListItem>
            <asp:ListItem>Noturno</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
         <b>Curso: </b><asp:DropDownList ID="ddl_cursos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_cursos_SelectedIndexChanged">
            <asp:ListItem>Relógios mecânicos complicados</asp:ListItem>
            <asp:ListItem>Contadores e cronógrafos mecânicos</asp:ListItem>
            <asp:ListItem>Adereço dos relógios de uso pessoal</asp:ListItem>
            <asp:ListItem>Relógios electrónicos analógicos</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
         <b>Gênero: </b>
        <asp:RadioButtonList ID="rbl_genero" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="rbl_genero_SelectedIndexChanged">
            <asp:ListItem>Feminino</asp:ListItem>
            <asp:ListItem>Masculino</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
         <b>Hobbies: </b>
        <asp:CheckBoxList ID="cbl_hobbies" runat="server" OnSelectedIndexChanged="cbl_hobbies_SelectedIndexChanged" >
            <asp:ListItem>Leitura</asp:ListItem>
            <asp:ListItem>Corrida</asp:ListItem>
            <asp:ListItem>Ciclismo</asp:ListItem>
            <asp:ListItem>Padel</asp:ListItem>
            <asp:ListItem>Natação</asp:ListItem>
            <asp:ListItem>Vídeo Jogos</asp:ListItem>
            <asp:ListItem>Pesca</asp:ListItem>
            <asp:ListItem>Lutas</asp:ListItem>
        </asp:CheckBoxList>
    </p>
    <p>
         <b>E-mail: </b><asp:TextBox ID="tb_email" runat="server" Width="344px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="E-mail Obrigatório" ForeColor="Red" ControlToValidate="tb_email">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tb_email" ErrorMessage="E-mail Inválido" ForeColor="Lime" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
    </p>
    <p>
        </p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    <p>
        <asp:Button ID="btn_submeter" runat="server" Text="Submeter" OnClick="btn_submeter_Click" />
    </p>
    <p>
        &nbsp;</p>
    <%--asp:Button ID="btn_excel" runat="server" Text="Excel" />--%>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <%--<asp:Button ID="btn_word" runat="server" Text="Word" />--%>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <%--<asp:Button ID="btn_pdf" runat="server" Text="PDF" />--%>
&nbsp;<br />
    <br />
    <%--De:<asp:TextBox ID="tb_de" runat="server"></asp:TextBox>--%>
    <br />
    <br />
    <%--Para:<asp:TextBox ID="tb_para" runat="server"></asp:TextBox>--%>
    <br />
    <br />
    <%--Asssunto:<asp:TextBox ID="tb_assunto" runat="server"></asp:TextBox>--%>
    <br />
    <br />
    <%--Mesnagem:<asp:TextBox ID="tb_mensagem" runat="server"></asp:TextBox>--%>
    <br />
    <br />
    <p>
       <%-- <asp:Button ID="btn_enviar" runat="server" Text="Enviar E-mail" />--%>
    </p>
    <p>
        &nbsp;</p>
    <p>
       <%-- Anexo:<asp:FileUpload ID="FileUpload1" runat="server" />--%>
    </p>
</asp:Content>
