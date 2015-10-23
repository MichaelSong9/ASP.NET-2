using System;
using System.Collections.Generic;
using System.Text;

namespace prjCPF
{
    class Geral
    {
        //método estático
        public static string RetirarAcentos(string nome)
        {
            string comAcentos = 
                "ÄÀÁÂÃäàáâãËÈÉÊëèéêÏÌÍÎïìíîÖÒÓÔÕöòóôõÜÙÚÛüùúûÇçÑñ";
            
            string semAcentos = 
                "AAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUUuuuuCcNn";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                nome = nome.Replace(comAcentos[i], semAcentos[i]);
            }
            return nome;
        }
    }
}
