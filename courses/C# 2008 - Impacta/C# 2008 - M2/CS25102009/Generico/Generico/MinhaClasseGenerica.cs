using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generico
{
    class MinhaClasseGenerica<T>
    {
        public string MeuMetodoGenerico(T valor)
        {
            if (valor is string)
            {
                return "Foi enviada a string " + valor;
            }
            else
            {
                if (valor is decimal)
                {
                    return "Foi enviado o número " +
                        valor.ToString() + " e o dobro é " +
                        (Convert.ToDecimal(valor) * 2).ToString(); 
                }
                else
                {
                    return "Foi enviado um outro Data Type";
                }
            }
        }
    }
}
