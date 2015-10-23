using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genericos
{
    class ClasseGenerica<T>
    {
        public string MetodoGenerico(T valor)
        {
            if (valor is string)
            {
                return "String " + valor + " enviada";
            }
            else
            {
                if (valor is decimal)
                {
                    return "Foi enviado o numero: " + Convert.ToDecimal(valor) + 
                           " e o dobro é " + (Convert.ToDecimal(valor)*2).ToString();
                }
                else
                {
                        
                }
            }
        }
    }
}
