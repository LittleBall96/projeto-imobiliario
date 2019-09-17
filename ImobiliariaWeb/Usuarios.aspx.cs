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
    public partial class Usuarios : System.Web.UI.Page
    {
        ModeloUsuario usuario = new ModeloUsuario();
        UsuarioBll objUsuariosBll = new UsuarioBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            Configuracoes();
        }

        protected void btnExibir_Click(object sender, EventArgs e)
        {
            Painel.Visible = true;
            btnExibir.Visible = false;
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Tipo = ddlTipo.Text;
            objUsuariosBll.Inserir(usuario);
            AtualizaGrid();

        }

        protected void AtualizaGrid()
        {
            //Atualiza grid gvUsuarios
            gvUsuarios.DataBind();

            //Ocultando o painel
            Painel.Visible = false;

            //Exibir o botão btnInserir 
            btnExibir.Visible = true;
        }

        protected void Configuracoes()
        {
           
            //Ocultando o painel
            Painel.Visible = false;

            //Exibir o botão btnInserir 
            btnExibir.Visible = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpando os campos
            txtNome.Text = "";
            txtSenha.Text = "";
            Configuracoes();
        }
    }
}