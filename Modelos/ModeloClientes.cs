using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Imobiliaria.Modelos
{
    public class ModeloClientes
    {
        private int id_clientes;
        private string nome_cliente;
       
        private string tel;
        


        public int Id_clientes
        {
            get {return id_clientes;}
            set {id_clientes= value;}
        }

        public string Nome_cliente
        {
            get
            {
                return nome_cliente;
            }

            set
            {
                nome_cliente = value;
            }
        }

       
        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }

       
    }
}
