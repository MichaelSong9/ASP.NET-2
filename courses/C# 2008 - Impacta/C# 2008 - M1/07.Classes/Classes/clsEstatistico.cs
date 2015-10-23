using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    partial class clsCalculo
    {
        public decimal Media(decimal PrimeiroNro, decimal SegundoNro)
        {
            return (PrimeiroNro + SegundoNro) / 2;
        }

        public decimal Maximo(decimal PrimeiroNro, decimal SegundoNro)
        {

            if (PrimeiroNro > SegundoNro)
            {
                return PrimeiroNro;
            }
            else
            {
                return SegundoNro;
            }
        }
    }
}