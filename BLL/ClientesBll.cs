using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CM_Imobiliaria.DAL;
using CM_Imobiliaria.Modelos;

namespace CM_Imobiliaria.BLL
{
    public class ClientesBll
    {
        private string mensagem;
        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }
        private bool resposta;
        public bool Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }

        ClientesDal objClientesDal = new ClientesDal();


        public string incluir(ModeloClientes cliente)
        {
            try
            {
                bool verifica = false;
                if (cliente.Nome_cliente.Trim().Length == 0)
                {
                    mensagem = "O nome do cliente é obrigatório";
                }
                else if (cliente.Nome_cliente.Length > 50)
                {
                    mensagem = "O cliente não pode ter mais que 50 caracteres!";
                }
                else if (cliente.Tel.Trim().Length == 0)
                {
                    mensagem = "O e-mail do cliente é obrigatório";
                }
                else if (cliente.Tel.Length > 50)
                {
                    mensagem = "O e-mail não pode ter mais que 50 caracteres!";
                }
                else
                {
                    cliente.Nome_cliente = cliente.Nome_cliente.ToLower();
                    cliente.Tel = cliente.Tel.ToLower();
                    
                }
                return mensagem;
            }
            catch
            {
                mensagem = "Não foi possível inserir o cliente!";
                throw new Exception(mensagem);
            }
        }

        public string alterar(ModeloClientes cliente)
        {
            try
            {
                bool verifica = false;
                if (cliente.Nome_cliente.Trim().Length == 0)
                {
                    mensagem = "O nome do cliente é obrigatório";
                }
                else if (cliente.Nome_cliente.Length > 50)
                {
                    mensagem = "O cliente não pode ter mais que 50 caracteres!";
                }
                else if (cliente.Tel.Trim().Length == 0)
                {
                    mensagem = "O e-mail do cliente é obrigatório";
                }
                else if (cliente.Tel.Length > 50)
                {
                    mensagem = "O e-mail não pode ter mais que 50 caracteres!";
                }
                else
                {
                    cliente.Nome_cliente = cliente.Nome_cliente.ToLower();
                    cliente.Tel = cliente.Tel.ToLower();

                }
                return mensagem;
            }
            catch
            {
                mensagem = "Não foi possível alterar o cliente!";
                throw new Exception(mensagem);
            }
        }

        public bool excluir(ModeloClientes cliente)
        {
            try
            {
                bool resposta = false;
                if (cliente.Id_clientes < 1)
                {
                    mensagem = "Selecione o cliente antes de excluí-lo";
                }
                else
                {
                    resposta = objClientesDal.Excluir(cliente);
                    mensagem = "Cliente excluído com sucesso!";
                }
                return resposta;
            }
            catch
            {
                mensagem = "Cliente não pode ser excluído!";
                throw new Exception(mensagem);
            }
        }

        public ListaClientes listagem(string filtro)
        {
            return objClientesDal.Listagem(filtro);
        }

        
        
    }
}

