using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Imobiliaria.DAL
{
    class Dados
    {
        public static string strConexao
        {
            get
            {
                return "server = localhost; DataBase = trabalho; Uid = root; Pwd = root; Connect Timeout = 30";
            }
        }
    }
}
