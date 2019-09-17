<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TipoImovel.aspx.cs" Inherits="ImobiliariaWeb.TipoImovel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <!-- Declaração de bibliotecas JQuery para máscaras -->
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/jquery.maskedinput.min.js"></script>
    <!--Função JQuery para configuração das máscaras -->

    <script type="text/javascript">
        jQuery(function ($) {
            $("#txtTelefone").mask("(99)99999-9999");
            $("#txtTel2").mask("(99)99999-9999");
            

        });
    </script>
    <p>
    <br />
    <strong>Cadastro de Profissionais </strong>
</p>
<p>
    <asp:ObjectDataSource ID="odsTipo" runat="server" DataObjectTypeName="CM_Imobiliaria.Modelos.ModeloTipoImovel" DeleteMethod="Excluir" InsertMethod="Inserir" SelectMethod="ListagemServico" TypeName="CM_Imobiliaria.BLL.Tipo_ImovelBll" UpdateMethod="Alterar">
        <SelectParameters>
            <asp:Parameter Name="filtro" Type="String" ConvertEmptyStringToNull ="false" DefaultValue ="" />
        </SelectParameters>
    </asp:ObjectDataSource>
</p>
<p>
</p>
    <asp:GridView ID="gvTipo" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsTipo" ForeColor="#333333" GridLines="None" Width="444px"  DataKeyNames="ID_TIPO_IMOVEL">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id_tipo_imovel" HeaderText="ID" SortExpression="Id_tipo_imovel" />
            <asp:BoundField DataField="Descricao" HeaderText="Descrição" SortExpression="Descricao" />
            <asp:BoundField DataField="Condominio" HeaderText="Condominio" SortExpression="Condominio" />
   



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
                    <asp:Label ID="Label1" runat="server" Text="Descrição:"></asp:Label>
                </td>
                <td style="height: 24px">
                    <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                </td>
                <td style="height: 24px"></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Condominio:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCondominio" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            
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

