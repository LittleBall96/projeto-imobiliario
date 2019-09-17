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
    public partial class TipoImovel : System.Web.UI.Page
    {
        Tipo_ImovelBll tipoBll = new Tipo_ImovelBll();
        ModeloTipoImovel tipo = new ModeloTipoImovel();

        protected void Page_Load(object sender, EventArgs e)
        {
            Configuracoes();
        }

        protected void btnInserir_Click1(object sender, EventArgs e)
        {
            tipo.Descricao = txtDesc.Text;
            tipo.Condominio = txtCondominio.Text;
   
            tipoBll.Inserir(tipo);
            gvTipo.DataBind();
        }

        protected void btnCancelar_Click1(object sender, EventArgs e)
        {
            txtDesc.Text = "";
            txtCondominio.Text = "";
           
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