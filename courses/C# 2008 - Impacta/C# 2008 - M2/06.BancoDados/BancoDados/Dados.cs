using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoDados
{
    public static class Dados
    {
        public static string StringDeConexao
        {
            get
            {
                return @"Server=.\sqlexpress;Initial Catalog=Oficina;Integrated Security=True;Pooling=False";
            }
        }
    }
}
