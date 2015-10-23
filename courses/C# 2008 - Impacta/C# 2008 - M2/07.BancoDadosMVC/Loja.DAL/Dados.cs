using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.DAL
{
    static class Dados
    {
        public static string Conexao
        {
            get
            {
                return @"server=localhost\sqlexpress;database=Loja; Integrated Security=true";
            }
        }
    }
}