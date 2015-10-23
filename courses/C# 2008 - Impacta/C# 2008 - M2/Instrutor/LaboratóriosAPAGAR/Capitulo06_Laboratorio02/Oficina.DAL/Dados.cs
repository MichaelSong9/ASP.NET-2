using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oficina.DAL
{
    static class Dados
    {
        public static string StringDeConexao()
        {
            return @"Integrated Security=SSPI;Persist Security Info=False;
                            Initial Catalog=Oficina;Data Source=.\sqlexpress";
        }

    }

}
