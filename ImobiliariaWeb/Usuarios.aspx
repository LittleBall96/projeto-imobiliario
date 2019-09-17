<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ImobiliariaWeb.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <strong>Cadastro de Funcionarios </strong>
    <br />
    <asp:ObjectDataSource ID="odsUsuarios" runat="server" DataObjectTypeName="CM_Imobiliaria.Modelos.ModeloUsuario" DeleteMethod="Excluir" InsertMethod="Inserir" SelectMethod="ListagemProdutos" TypeName="CM_Imobiliaria.BLL.UsuarioBll" UpdateMethod="Alterar">
        <SelectParameters>
            <asp:Parameter Name="filtro" Type="String" ConvertEmptyStringToNull ="false" DefaultValue ="" />
        </SelectParameters>
    </asp:ObjectDataSource>
</p>
    <asp:GridView ID="gvUsuarios" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsUsuarios" ForeColor="#333333" GridLines="None" DataKeyNames="ID" Width="467px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Senha" HeaderText="Senha" SortExpression="Senha" />
            <asp:BoundField DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
<p>
    <asp:Button ID="btnExibir" runat="server" style="margin-top: 10px" Text="Exibir Painel de Inserção de Dados" OnClick="btnExibir_Click" />
</p>
    <p>
</p>
    <asp:Panel ID="Painel" runat="server" Height="144px" Width="330px">
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
                    <asp:TextBox ID="txtNome" runat="server" style="margin-left: 25px" Width="156px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Senha"></asp:Label>
                    <asp:TextBox ID="txtSenha" runat="server" style="margin-left: 21px" Width="156px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 6px">
                    <asp:Label ID="Label4" runat="server" Text="Tipo"></asp:Label>
                    <asp:DropDownList ID="ddlTipo" runat="server" style="margin-left: 36px" Width="160px">
                        <asp:ListItem>Administrador</asp:ListItem>
                        <asp:ListItem>Usuário</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="height: 6px"></td>
                <td style="height: 6px"></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnInserir" runat="server" style="margin-left: 11" Text="Inserir" Width="80px" OnClick="btnInserir_Click" />
                    <asp:Button ID="btnCancelar" runat="server" style="margin-left: 20px" Text="Cancelar" Width="84px" OnClick="btnCancelar_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
</p>
</asp:Content>
