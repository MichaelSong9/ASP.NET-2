using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo3
{
    class ExemploIndexador
    {
        private string[] textos;
        private int nPosicoes = 0;

        //Construtor - Define o número de posições do indexador
        public ExemploIndexador(int NumPosicoes)
        {
            textos = new string[NumPosicoes];
        }

        //Método para adicionar itens ao indexador
        public void Adicionar(string texto)
        {
            if (nPosicoes >= textos.Length)
            {
                throw new Exception("Não há posições disponíveis");
            }
            else
            {
                textos[nPosicoes++] = texto;
            }
        }

        //Indexador
        public string this[int indice]
        {
            get
            {
                if (indice < 0 || indice >= textos.Length)
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

        //Método que retorna o número de posições ocupadas
        public int NumeroDePosicoes()
        {
            return nPosicoes;
        }
    }
}
