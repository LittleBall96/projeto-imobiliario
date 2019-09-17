<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Imoveis.aspx.cs" Inherits="ImobiliariaWeb.Imoveis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--Declaracão de bibliotecas JQuery para mascaras -->
    <script src="Scripts/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.maskMoney.js" type="text/javascript"></script>
     <script src="Scripts/jquery.maskedinput.min.js"></script>
    <!--Função jQuery para mascaras -->
    <script type="text/javascript">
        $(function () {
            $("#txtAluguel").maskMoney({ symbol: 'R$ ', showSymbol: true, thousands: '.', decimal: ',', symbolStay: true });
            $("#txtIptu").maskMoney({ symbol: 'R$ ', showSymbol: true, thousands: '.', decimal: ',', symbolStay: true });
        })
    </script>
     <script type="text/javascript">
        jQuery(function ($) {
        
            $("#txtCep").mask("99.999-99");
           

        });
    </script>
    <p>
        <strong>
        <br />
        Cadastro de Produtos </strong>
    </p>
    <p>
        <asp:ObjectDataSource ID="odsImovel" runat="server" DataObjectTypeName="CM_Imobiliaria.Modelos.ModeloImoveis" DeleteMethod="Excluir" InsertMethod="Inserir" SelectMethod="ListagemProdutos" TypeName="CM_Imobiliaria.BLL.ImoveisBll" UpdateMethod="Alterar">
            <SelectParameters>
                <asp:Parameter Name="filtro" Type="String" ConvertEmptyStringToNull="false" DefaultValue="" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
    <p>
        <asp:GridView ID="gvImovel" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsImovel" ForeColor="#333333" GridLines="None" DataKeyNames="Id_imovel">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id_imovel" HeaderText="Id_imovel" SortExpression="Id_imovel" />
                <asp:BoundField DataField="Nome_imovel" HeaderText="Nome_imovel" SortExpression="Nome_imovel" />
                <asp:BoundField DataField="Endereco" HeaderText="Endereco" SortExpression="Endereco" />
                <asp:BoundField DataField="Bairro" HeaderText="Bairro" SortExpression="Bairro" />
                <asp:BoundField DataField="Zona_cidade" HeaderText="Zona_cidade" SortExpression="Zona_cidade" />
                <asp:BoundField DataField="Cep" HeaderText="Cep" SortExpression="Cep" />
                <asp:BoundField DataField="Ponto_referencia" HeaderText="Ponto_referencia" SortExpression="Ponto_referencia" />
                <asp:BoundField DataField="Metragem" HeaderText="Metragem" SortExpression="Metragem" />
                <asp:BoundField DataField="Dormitorios" HeaderText="Dormitorios" SortExpression="Dormitorios" />
                <asp:BoundField DataField="Banheiros" HeaderText="Banheiros" SortExpression="Banheiros" />
                <asp:BoundField DataField="Suites" HeaderText="Suites" SortExpression="Suites" />
                <asp:BoundField DataField="Vagas_garagem" HeaderText="Vagas_garagem" SortExpression="Vagas_garagem" />
                <asp:BoundField DataField="Valor_aluguel_sugerido" HeaderText="Valor_aluguel_sugerido" SortExpression="Valor_aluguel_sugerido" />
                <asp:BoundField DataField="Valor_iptu" HeaderText="Valor_iptu" SortExpression="Valor_iptu" />
                <asp:BoundField DataField="Memorial_descritivo" HeaderText="Memorial_descritivo" SortExpression="Memorial_descritivo" />
                <asp:BoundField DataField="Requisitos_inquilino" HeaderText="Requisitos_inquilino" SortExpression="Requisitos_inquilino" />
                <asp:BoundField DataField="Obs" HeaderText="Obs" SortExpression="Obs" />

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
    </p>
    <p>
        <asp:Button ID="btnExibir" runat="server" Text="Exibir Painel de Inserção de Dados" OnClick="btnExibir_Click" />
    </p>
    <p>
    </p>
    <asp:Panel ID="pnlProdutos" runat="server" Height="129px" Width="336px">
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server" Width="155px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Endereço:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Bairro:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBairro" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Zona Cidade:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtZona" runat="server" Width="81px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="CEP:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCep" runat="server" Width="81px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Ponto Referencia:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPonto" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Metragem:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMetragem" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Dormitorios:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDormitorios" runat="server" ></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Banheiros:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBanheiros" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Suites:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSuites" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Vagas Garagem:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtVagas" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="Valor Aluguel:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAluguel" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="IPTU:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIptu" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="Memorial Descritivo:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMemorial" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="Requisitos Inquilino:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRequisitos" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label16" runat="server" Text="OBS:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtObs" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
                </td>
                <td>
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
