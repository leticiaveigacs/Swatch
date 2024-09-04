<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="gestao_utilizadores.aspx.cs" Inherits="Site_Projeto.gestao_utilizadores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <h3 class="text-center">Gestão do Usuário</h3>
        <p class="text-center">&nbsp;</p>
    <asp:GridView ID="gw_utlizador" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" PageSize="5" ForeColor="#333333" GridLines="None" Width="584px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="utilizador" HeaderText="Nome Utilizador" SortExpression="utilizador" />
            <asp:CommandField ButtonType="Image" CancelImageUrl="~/icons/cancelar.png" DeleteImageUrl="~/icons/excluir.png" EditImageUrl="~/icons/editar-texto.png" ShowDeleteButton="True" ShowEditButton="True" UpdateImageUrl="~/icons/confirme.png" />
        </Columns>
        <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle ForeColor="#333333" BackColor="#FFFBD6" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:swatchConnectionString %>" DeleteCommand="DELETE FROM [utilizadores] WHERE [id] = @id" InsertCommand="INSERT INTO [utilizadores] ([utilizador]) VALUES (@utilizador)" SelectCommand="SELECT [id], [utilizador] FROM [utilizadores]" UpdateCommand="UPDATE [utilizadores] SET [utilizador] = @utilizador WHERE [id] = @id">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="utilizador" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="utilizador" Type="String" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
