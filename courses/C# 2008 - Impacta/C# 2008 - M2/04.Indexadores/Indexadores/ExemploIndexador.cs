using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexadores
{
    class ExemploIndexador
    {
        private string[] textos;
        private int nPosicoes = 0;

        //Construtor - Define o numero de posições do indexador
        public ExemploIndexador(int numPosicoes)
        {
            textos = new string[numPosicoes];
        }

        //Metodo para adcionar itens ao indexador
        public void Adicionar(string texto)
        {
            if (nPosicoes >= textos.Length)
            {
                throw new Exception("Não há mais posições disponiveis");
            }
            else
            {
                textos[nPosicoes] = texto;
                nPosicoes++;
            }
        }

        //indexador
        public string this[int indice]
        {
            get
            {
                if (indice <0 || indice >= textos.Length)
                {
                    throw new Exception("Posição não disponível");
                }
                else
                {
                    return textos[indice];
                }
            }
            set 
            {
                if (indice >= nPosicoes)
                {
                    throw new Exception("Posição não disponível");
                }
                else
                {
                    textos[indice] = value;
                }
            }
        }

        //metodo que retorna o numero de posições ocupadas

        public int NumeroDePosicoes()
        {
            return nPosicoes;
        }
    }
}
