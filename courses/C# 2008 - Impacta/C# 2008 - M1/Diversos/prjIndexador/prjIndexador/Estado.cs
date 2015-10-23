using System;
using System.Collections.Generic;
using System.Text;

namespace prjIndexador
{
    class Estado
    {
        public string this[string sigla]
        {
            get 
            {
                switch (sigla.ToUpper())
                {
                    case "SP": return "São Paulo"; break;
                    case "RJ": return "Rio de Janeiro"; break;
                    case "MG": return "Minas Gerais"; break;
                    default: return ""; break;
                }
            }
        }
    }
}
