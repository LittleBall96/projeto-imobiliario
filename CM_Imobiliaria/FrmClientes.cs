using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CM_Imobiliaria.Modelos;
using CM_Imobiliaria.BLL;


namespace CM_Imobiliaria
{
    public partial class FrmClientes : Form
    {
        ModeloClientes cliente = new ModeloClientes();
        ClientesBll objClientesBll = new ClientesBll();
        string mensagem;
        string filtro = "";

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void AtualizaGrid()
        {
            filtro = "";
            try
            {
                dgvClientes.DataSource = objClientesBll.listagem(filtro);//VERIFICAR ESSA LISTAGEM     
            }
            catch(Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void FormataGrid()
        {
            try
            {
                dgvClientes.Columns[0].HeaderText = "IdCliente";
                dgvClientes.Columns[0].Width = 80;
                dgvClientes.Columns[1].HeaderText = "Nome";
                dgvClientes.Columns[1].Width = 150;
                dgvClientes.Columns[2].HeaderText = "CPF";
                dgvClientes.Columns[2].Width = 100;
                dgvClientes.Columns[3].HeaderText = "RG";
                dgvClientes.Columns[3].Width = 100;
                dgvClientes.Columns[4].HeaderText = "Endereço";
                dgvClientes.Columns[4].Width = 80;
                dgvClientes.Columns[5].HeaderText = "CEP";
                dgvClientes.Columns[5].Width = 80;
                dgvClientes.Columns[6].HeaderText = "Tel1";
                dgvClientes.Columns[6].Width = 80;
                dgvClientes.Columns[7].HeaderText = "Tel2";
                dgvClientes.Columns[7].Width = 80;
                dgvClientes.Columns[8].HeaderText = "Email";
                dgvClientes.Columns[8].Width = 80;
                dgvClientes.Columns[9].HeaderText = "Data de Nasc";
                dgvClientes.Columns[9].Width = 80;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = (ex.Message);
            }
            finally
            {
                LimpaCliente();
            }
        }

        private void LimpaCliente()
        {
            lblIdCliente.Text = "";
            txtNome.Text = "";
            
            mskTelefone.Text = "";
           
            lblMensagem.Text = "";
            txtNome.Focus();
        }

        private void ReceberDados()
        {
            lblIdCliente.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
           
            mskTelefone.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)//Retorna ao MENU PRINCIPAL
        {
            
        }

       

       
     
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Nome_cliente = txtNome.Text;
                
                cliente.Tel = mskTelefone.Text;
                
                lblMensagem.Text = objClientesBll.incluir(cliente);
                lblIdCliente.Text = cliente.Id_clientes.ToString();
                AtualizaGrid();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Id_clientes = Convert.ToInt32(lblIdCliente.Text);
                cliente.Nome_cliente = txtNome.Text;
                
                cliente.Tel = mskTelefone.Text;
                
                lblMensagem.Text = objClientesBll.alterar(cliente);
               
                AtualizaGrid();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool resposta = false;

            if (lblIdCliente.Text == "")
            {
                lblMensagem.Text = "Por favor, selecione um cliente para excluí-lo.";
            }
            else
            {
                try
                {
                    cliente.Id_clientes = Convert.ToInt32(lblIdCliente.Text);
                    resposta = objClientesBll.excluir(cliente);
                    if (resposta)
                    {
                        lblMensagem.Text = objClientesBll.Mensagem;
                    }
                    else
                    {
                        lblMensagem.Text = objClientesBll.Mensagem;
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }
            AtualizaGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCliente();
            AtualizaGrid();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReceberDados();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            filtro = txtListarClientes.Text;
            try
            {
                dgvClientes.DataSource = objClientesBll.listagem(filtro);
                FormataGrid();
                ReceberDados();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}
