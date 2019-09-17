using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using CM_Imobiliaria.Modelos;

namespace CM_Imobiliaria.DAL
{
    public class ClientesDal
    {
        // Esta Variavel indicara se a autenticação de login
        // foi feita ou não com sucesso;
        private bool resposta = false;

        // Exibição de mensagem de erro;
        private string mensagem;
        public string Mensagem
        {
            get
            {
                return mensagem;
            }

            set
            {
                mensagem = value;
            }
        }

        //Esse danando faz a conexão com o banco de dados;
        //Criação do objeto de acesso do banco de dados;
        //Instancia do Objeto Connection abre e fecha a conexão com o banco;
        MySqlConnection CONCLIENTE = new MySqlConnection();

        //Esse danado realiza os commands SQL
        //Instancia do objeto da classe Command que é responsavel
        //por executar comandos em SQL. Precisa de duas informações:
        // - O comando SQL e - A String de conexão;
        MySqlCommand CMDCLIENTE = new MySqlCommand();



        public void Inserir(ModeloClientes CLIENTE)
        {
            try
            {
                if (VerificarClienteExistente(CLIENTE) == true)
                {
                    mensagem = "O cliente já existe no cadastro";
                }
                else
                {
                    // Configuração do banco de dados;
                    CONCLIENTE.ConnectionString = Dados.strConexao;

                    // Tipo de conexão com o banco de dados;
                    CMDCLIENTE.CommandType = CommandType.StoredProcedure;

                    // Nome da Stored Procedure;
                    CMDCLIENTE.CommandText = "incluirCli";

                    // Carregando Parâmetros de Stored Procedure;
                    CMDCLIENTE.Parameters.AddWithValue("pnomeCli", CLIENTE.Nome_cliente);
                    CMDCLIENTE.Parameters.AddWithValue("ptelefone1CLi", CLIENTE.Tel);



                    // O objeto cmdFuncionario recebe a configuração do banco de dados através do conFuncionário;
                    CMDCLIENTE.Connection = CONCLIENTE;

                    // Obtendo a conexão com o banco
                    CONCLIENTE.Open();

                    // Resgata o funId gerado automaticamente pelo banco;
                    // O método ExecuteScalar() retorna apenas uma única informação
                    // numérica do banco de dados;
                    CLIENTE.Id_clientes = Convert.ToInt32(CMDCLIENTE.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CONCLIENTE.Close();
            }
        }

        public bool VerificarClienteExistente(ModeloClientes FUNCLIENTE)
        {
            string filtro = "";
            ListaClientes LISTACLI = new ListaClientes();
            bool verifica = false;
            LISTACLI = Listagem(filtro);

            // funExist é um parametro de entrada. O sinal => é a expressão lambda, que significa vá para (goes to)
            // O objeto 'f' reconhece a estrutura da lista listaFun e recebe seus dados em cada elemento da lista.
            // Assim, f.Funnome recebe o nome de cada funcionario presente em listaFun 
            // e o compara com o nome do funcionario "Funnome" presente no parametro FunExist;
            FUNCLIENTE = LISTACLI.Find(f => f.Nome_cliente == FUNCLIENTE.Nome_cliente);
            if (FUNCLIENTE != null)
            {
                verifica = true;
            }
            return verifica;
        }

        public ListaClientes Listagem(string filtro)
        {
            try
            {
                ListaClientes OBJLISTACLIENTE = new ListaClientes();
                CONCLIENTE.ConnectionString = Dados.strConexao;
                CMDCLIENTE.Connection = CONCLIENTE;
                CMDCLIENTE.CommandType = CommandType.StoredProcedure;
                CMDCLIENTE.CommandText = "selecionarCLi";
                CMDCLIENTE.Parameters.AddWithValue("pfiltro", filtro);
                CONCLIENTE.Open();
                MySqlDataReader dr = CMDCLIENTE.ExecuteReader();
                CMDCLIENTE.Parameters.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ModeloClientes CLIENTE = new ModeloClientes();
                        CLIENTE.Id_clientes = Convert.ToInt32(dr["idCli"].ToString());
                        CLIENTE.Nome_cliente = dr["nomeCli"].ToString();
                        CLIENTE.Tel = dr["telefone1CLi"].ToString();
                        
                        OBJLISTACLIENTE.Add(CLIENTE);
                    }
                }
                return OBJLISTACLIENTE;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CONCLIENTE.Close();
            }
        }

        public void Alterar(ModeloClientes CLIENTE)
        {
            try
            {
                // Configuração do banco de dados;
                CONCLIENTE.ConnectionString = Dados.strConexao;

                // Tipo de conexão com o banco de dados;
                CMDCLIENTE.CommandType = CommandType.StoredProcedure;

                // Nome da Stored Procedure;
                CMDCLIENTE.CommandText = "alterarCli";

                // Carregando Parâmetros de Stored Procedure;
                CMDCLIENTE.Parameters.AddWithValue("pidCli", CLIENTE.Id_clientes);

                CMDCLIENTE.Parameters.AddWithValue("pnomeCLi", CLIENTE.Nome_cliente);
                CMDCLIENTE.Parameters.AddWithValue("ptelefon1Cli", CLIENTE.Tel);

                CMDCLIENTE.Connection = CONCLIENTE;

                // Obtendo a conexão com o banco
                CONCLIENTE.Open();

                //O metodo ExecuteNonQuery executa comandos insert, update, delete
                CMDCLIENTE.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CONCLIENTE.Close();
            }
        }

        public bool Excluir(ModeloClientes CLIENTE)
        {
            int resultado = 0;
            bool resposta = false;
            try
            {
                CONCLIENTE.ConnectionString = Dados.strConexao;
                CMDCLIENTE.CommandType = CommandType.StoredProcedure;
                CMDCLIENTE.CommandText = "excluirCli";
                CMDCLIENTE.Parameters.AddWithValue("pidCli", CLIENTE.Id_clientes);
                CMDCLIENTE.Connection = CONCLIENTE;
                CONCLIENTE.Open();
                resultado = CMDCLIENTE.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o cliente" + CLIENTE.Nome_cliente.ToString());
                }
                else
                {
                    resposta = true;
                }
                return resposta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CONCLIENTE.Close();
            }
        }
    }
}
