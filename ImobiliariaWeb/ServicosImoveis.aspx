<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ServicosImoveis.aspx.cs" Inherits="ImobiliariaWeb.ServicosImoveis" %>
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
    <strong>Cadastro de Serviços </strong>
</p>
<p>
    <asp:ObjectDataSource ID="odsServico" runat="server" DataObjectTypeName="CM_Imobiliaria.Modelos.ModeloServicos_imoveis" DeleteMethod="Excluir" InsertMethod="Inserir" SelectMethod="ListagemServico" TypeName="CM_Imobiliaria.BLL.Servicos_imoveisBll" UpdateMethod="Alterar">
        <SelectParameters>
            <asp:Parameter Name="filtro" Type="String" ConvertEmptyStringToNull ="false" DefaultValue ="" />
        </SelectParameters>
    </asp:ObjectDataSource>
</p>
<p>
</p>
    <asp:GridView ID="gvServico" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsServico" ForeColor="#333333" GridLines="None" Width="444px"  DataKeyNames="ID_TRABALHO">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id_trabalho" HeaderText="ID" SortExpression="Id_trabalho" />
            <asp:BoundField DataField="Data_servico" HeaderText="Data" SortExpression="Data_servico" />
            <asp:BoundField DataField="Valor_total" HeaderText="Valor" SortExpression="Valor_total" />
            <asp:BoundField DataField="Nota_fiscal" HeaderText="Nota FIscal" SortExpression="Nota_fiscal" />
            <asp:BoundField DataField="Obs" HeaderText="OBS" SortExpression="Obs" />
   



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
                    <asp:Label ID="Label1" runat="server" Text="Data Serviço:"></asp:Label>
                </td>
                <td style="height: 24px">
                    <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
                </td>
                <td style="height: 24px"></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Valor:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Nota Fiscal:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="OBS:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtObs" runat="server"></asp:TextBox>
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

