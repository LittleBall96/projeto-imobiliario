<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profissionais.aspx.cs" Inherits="ImobiliariaWeb.Profissionais" %>
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
    <asp:ObjectDataSource ID="odsProfissional" runat="server" DataObjectTypeName="CM_Imobiliaria.Modelos.ModeloProfissionais" DeleteMethod="Excluir" InsertMethod="Inserir" SelectMethod="ListagemProdutos" TypeName="CM_Imobiliaria.BLL.ProfissionaisBll" UpdateMethod="Alterar">
        <SelectParameters>
            <asp:Parameter Name="filtro" Type="String" ConvertEmptyStringToNull ="false" DefaultValue ="" />
        </SelectParameters>
    </asp:ObjectDataSource>
</p>
<p>
</p>
    <asp:GridView ID="gvProfissional" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsProfissional" ForeColor="#333333" GridLines="None" Width="444px"  DataKeyNames="ID_PROFISSIONAL">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id_profissional" HeaderText="ID" SortExpression="Id_profissional" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Profissao" HeaderText="Profissao" SortExpression="Profissao" />
            <asp:BoundField DataField="Tel" HeaderText="Tel1" SortExpression="Tel" />
            <asp:BoundField DataField="Tel2" HeaderText="Tel2" SortExpression="Tel2" />                        
            <asp:BoundField DataField="Valor_hora" HeaderText="Valor Hora" SortExpression="Valor_hora" />
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
                    <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
                </td>
                <td style="height: 24px">
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                </td>
                <td style="height: 24px"></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Profissao:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtProfissao" runat="server"></asp:TextBox>
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
                    <asp:Label ID="Label4" runat="server" Text="Telefone2:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTel2" runat="server" ClientIDMode="Static"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            </tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Valor Hora:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtValor" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            </tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Obs:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtObs" runat="server" ClientIDMode="Static"></asp:TextBox>
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
