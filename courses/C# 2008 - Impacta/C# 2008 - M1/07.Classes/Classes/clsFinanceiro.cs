using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    partial class clsCalculo
    {
        public decimal JurosSimples(decimal Principal, int Periodo, decimal Taxa)
        {
            return Principal*Periodo*Taxa ;
        }
    }
}
