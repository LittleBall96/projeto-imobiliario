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
    public partial class Profissionais : System.Web.UI.Page
    {
        ProfissionaisBll proBll = new ProfissionaisBll();
        ModeloProfissionais profissionais = new ModeloProfissionais();
        protected void Page_Load(object sender, EventArgs e)
        {
            Configuracoes();
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

        protected void btnInserir_Click1(object sender, EventArgs e)
        {
            profissionais.Nome = txtNome.Text;
            profissionais.Profissao = txtProfissao.Text;
            profissionais.Tel = txtTelefone.Text;
            profissionais.Tel2 = txtTel2.Text;
            profissionais.Obs = txtObs.Text;
            profissionais.Valor_hora = Double.Parse(txtValor.Text);
            proBll.Inserir(profissionais);
            gvProfissional.DataBind();
        }

        protected void btnCancelar_Click1(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtProfissao.Text = "";
            txtTelefone.Text = "";
            txtTel2.Text = "";
            txtObs.Text = "";
            txtValor.Text = "";
            pnlClientes.Visible = false;
            btnExibir.Visible = true;
        }
    }
}