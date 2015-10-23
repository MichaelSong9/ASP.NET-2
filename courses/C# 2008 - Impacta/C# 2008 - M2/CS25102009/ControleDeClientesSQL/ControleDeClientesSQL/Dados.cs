using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeClientesSQL
{
    public static class Dados
    {
        public static string StringDeConexao
        {
            get
            {
                return "server=.\\SQLEXPRESS;Initial Catalog=Oficina;Integrated Security=True;Pooling=False";
            }
        }
    }
}
