using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo05_Lab01
{
    class Geral
    {
        public static string RetirarAcentros(string texto)
        {
            string c_Acentos = "ÄÀÁÂÃäàáâãËÈÉÊëèéêÏÌÍÎïìíîÖÒÓÔÕöòóôõÜÙÚÛüùúûÇçÑñ";
            string s_Acentos = "AAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUUuuuuCcNn";

            for (int i = 0; i < c_Acentos.Length; i++)
            {
                texto = texto.Replace(c_Acentos[i], s_Acentos[i]);
            }
            return texto;
        }

    }
}
