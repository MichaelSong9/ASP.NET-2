using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oficina.DAL
{
    public class Dados
    {
        public static string StringDeConexao()
        {
            return @"integrated security=SSPI;Persist Security Info=false; Initial Catalog=Oficina; Data Source =.\sqlexpress;";

        }
    }
}
