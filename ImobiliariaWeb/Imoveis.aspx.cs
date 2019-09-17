using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CM_Imobiliaria.BLL;
using CM_Imobiliaria.Modelos;

namespace ImobiliariaWeb
{
    public partial class Imoveis : System.Web.UI.Page
    {
        ModeloImoveis imovel = new ModeloImoveis();
        ImoveisBll objImovelBll = new ImoveisBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            Configuracoes();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            imovel.Nome_imovel = txtNome.Text;
            imovel.Endereco = txtEndereco.Text;
            imovel.Bairro = txtBairro.Text;
            imovel.Zona_cidade = txtZona.Text;
            imovel.Cep = txtCep.Text;
            imovel.Ponto_referencia = txtPonto.Text;
            imovel.Memorial_descritivo = txtMemorial.Text;
            imovel.Requisitos_inquilino = txtRequisitos.Text;
            imovel.Obs = txtObs.Text;
            imovel.Dormitorios = int.Parse(txtDormitorios.Text);
            imovel.Banheiros = int.Parse(txtBanheiros.Text);
            imovel.Suites = int.Parse(txtSuites.Text);
            imovel.Vagas_garagem = int.Parse(txtVagas.Text);
            imovel.Metragem = double.Parse(txtMetragem.Text);
            imovel.Valor_aluguel_sugerido = double.Parse(txtAluguel.Text);
            imovel.Valor_iptu = double.Parse(txtIptu.Text);


            objImovelBll.Inserir(imovel);
           
            gvImovel.DataBind();
        }

        public void Configuracoes()
        {
            pnlProdutos.Visible = false;
            btnExibir.Visible = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "" ;
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtZona.Text = "";
            txtCep.Text = "";
            txtPonto.Text = "";
            txtMemorial.Text = "";
            txtRequisitos.Text = "";
            txtObs.Text = "";
            txtDormitorios.Text = "";
            txtBanheiros.Text = "";
            txtSuites.Text = "";
            txtVagas.Text = "";
            txtMetragem.Text = "";
            txtAluguel.Text = "";
            txtIptu.Text = "";
            pnlProdutos.Visible = false;
            btnExibir.Visible = true;
        }

        protected void btnExibir_Click(object sender, EventArgs e)
        {
            pnlProdutos.Visible = true;
            btnExibir.Visible = false;
        }
    }
}