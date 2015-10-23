using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerosExtensos
{
    class Gerar
    {
        public string escreverNumero(int valorQueSeraConvertido)
        {
            string extenso = "";
            string[] v_unidades =   {"um", 
                                 "dois",
                                 "três",
                                 "quatro",
                                 "cinco",
                                 "seis",
                                 "sete",
                                 "oito",
                                 "nove",
                                 "dez",
                                 "onze",
                                 "doze",
                                 "treze",
                                 "quatorze",
                                 "quinze",
                                 "dezesseis",
                                 "dezessete",
                                 "dezoito",
                                 "dezenove"};

            string[] v_dezenas = {"vinte",
                                "trinta",
                                "quarenta",
                                "cinquenta",
                                "sessenta",
                                "setenta",
                                "oitenta",
                                "noventa"};

            if (valorQueSeraConvertido < 20)
            {
                extenso = v_unidades[valorQueSeraConvertido - 1];
            }
            else
            {
                int unidade = valorQueSeraConvertido % 10;
                int dezena = valorQueSeraConvertido / 10;

                extenso = v_dezenas[dezena - 2];

                if (unidade != 0)
                {
                    extenso += " e " +  v_unidades[unidade - 1];
                }
            }
            return extenso;
        }
    }
}