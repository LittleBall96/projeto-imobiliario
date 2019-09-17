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
    public partial class Clientes : System.Web.UI.Page
    {
        ClientesBll objClientesBll = new ClientesBll();
        ModeloClientes cliente = new ModeloClientes();

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
            cliente.Nome_cliente = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Rg = txtRg.Text;
            cliente.Endereco_completo = txtEndereco.Text;
            cliente.Cep = txtCep.Text;
            cliente.Tel = txtTelefone.Text;
            cliente.Tel2 = txtTel2.Text;
            cliente.Email = txtEmail.Text;
            cliente.Data_nasc = DateTime.Parse(txtData.Text);
            objClientesBll.incluir(cliente);
            gvClientes.DataBind();
        }

        protected void btnCancelar_Click1(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtCpf.Text = "";
            pnlClientes.Visible = false;
            btnExibir.Visible = true;
        }
    }
}