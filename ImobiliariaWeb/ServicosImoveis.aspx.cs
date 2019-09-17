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
    public partial class ServicosImoveis : System.Web.UI.Page
    {
        Servicos_imoveisBll serBll = new Servicos_imoveisBll();
        ModeloServicos_imoveis servico = new ModeloServicos_imoveis();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnInserir_Click1(object sender, EventArgs e)
        {
            servico.Data_servico = DateTime.Parse(txtData.Text);
            servico.Valor_total = Double.Parse(txtValor.Text);
            servico.Nota_fiscal = txtNota.Text;
            servico.Obs = txtObs.Text;


            serBll.Inserir(servico);
            gvServico.DataBind();
        }

        protected void btnCancelar_Click1(object sender, EventArgs e)
        {
            txtData.Text = "";
            txtNota.Text = "";
            txtNota.Text = "";
            txtObs.Text = "";


            pnlClientes.Visible = false;
            btnExibir.Visible = true;
        }

        protected void btnExibir_Click(object sender, EventArgs e)
        {
            pnlClientes.Visible = true;
            btnExibir.Visible = false;
        }

        public void Configuracoes()
        {
            pnlClientes.Visible = false;
            btnExibir.Visible = true;
        }
    }
}