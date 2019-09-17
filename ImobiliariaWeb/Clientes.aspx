<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="ImobiliariaWeb.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <!-- Declaração de bibliotecas JQuery para máscaras -->
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/jquery.maskedinput.min.js"></script>
    <!--Função JQuery para configuração das máscaras -->

    <script type="text/javascript">
        jQuery(function ($) {
            $("#txtTelefone").mask("(99)99999-9999");
            $("#txtTel2").mask("(99)99999-9999");
            $("#txtCpf").mask("999.999.999-99");
            $("#txtRg").mask("99.999.999-9");
            $("#txtCep").mask("99.999-99");
            $("#txtData").mask("99/99/9999");

        });
    </script>
    <p>
    <br />
    <strong>Cadastro de Clientes </strong>
</p>
<p>
    <asp:ObjectDataSource ID="odsCliente" runat="server" DataObjectTypeName="CM_Imobiliaria.Modelos.ModeloClientes" DeleteMethod="excluir" InsertMethod="incluir" SelectMethod="listagem" TypeName="CM_Imobiliaria.BLL.ClientesBll" UpdateMethod="alterar">
        <SelectParameters>
            <asp:Parameter Name="filtro" Type="String" ConvertEmptyStringToNull ="false" DefaultValue ="" />
        </SelectParameters>
    </asp:ObjectDataSource>
</p>
<p>
</p>
    <asp:GridView ID="gvClientes" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsCliente" ForeColor="#333333" GridLines="None" Width="444px"  DataKeyNames="ID_CLIENTES">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id_clientes" HeaderText="Id_clientes" SortExpression="Id_clientes" />
            <asp:BoundField DataField="Nome_cliente" HeaderText="Nome_cliente" SortExpression="Nome_cliente" />
            <asp:BoundField DataField="Cpf" HeaderText="Cpf" SortExpression="Cpf" />
            <asp:BoundField DataField="Rg" HeaderText="Rg" SortExpression="Rg" />
            <asp:BoundField DataField="Endereco_completo" HeaderText="Endereco_completo" SortExpression="Endereco_completo" />                        
            <asp:BoundField DataField="Cep" HeaderText="Cep" SortExpression="Cep" />
            <asp:BoundField DataField="Tel" HeaderText="Tel" SortExpression="Tel" />
            <asp:BoundField DataField="Tel2" HeaderText="Tel2" SortExpression="Tel2" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Data_nasc" HeaderText="Data_nasc" SortExpression="Data_nasc" />


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
    <asp:Button ID="btnExibir" runat="server" Text="Exibir Painel de Inserção de Dados" OnClick="btnExibir_Click" />
</p>
    <p>
</p>
    <asp:Panel ID="pnlClientes" runat="server">
        <table style="width:41%; height: 104px;">
            <tr>
                <td style="height: 24px">
                    <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
                </td>
                <td style="height: 24px">
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                </td>
                <td style="height: 24px"></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Telefone:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTelefone" runat="server" ClientIDMode="Static"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="CPF:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCpf" runat="server" ClientIDMode="Static"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            </tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="RG:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRg" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            </tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Endereço:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEndereco" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            </tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="CEP:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCep" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            </tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Telefone 2:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTel2" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            </tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Data Nascimento:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtData" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <tr>
                <td>
                    <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click1" Text="Inserir" />
                </td>
                <td>
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click1" Text="Cancelar" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    <p>
        &nbsp;</p>
    <br />
</asp:Content>
