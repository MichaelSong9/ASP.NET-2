using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vetores
{
    class Calcular
    {
        public decimal Media(decimal[] elementos)
        {
            decimal soma = 0;

            for (int i = 0; i < elementos.Length; i++)
            {
                soma += elementos[i];
            }
            return soma / elementos.Length;
        }

        //diferença é que dessa forma você passa quantos parametros quiser
        public decimal MediaElementos(params decimal[] elementos)
        {
            decimal soma = 0;

            for (int i = 0; i < elementos.Length; i++)
            {
                soma += elementos[i];
            }

            return soma / elementos.Length;
        }

        public void mostrarLista(params object[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i].ToString();
            }
        }

    }
}
