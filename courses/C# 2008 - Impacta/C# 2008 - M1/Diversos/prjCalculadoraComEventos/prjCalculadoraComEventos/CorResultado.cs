using System;
using System.Collections.Generic;
using System.Text;

namespace prjCalculadoraComEventos
{
    class CorResultado
    {
        // Passo 1 - Criar o evento
        public event System.EventHandler Negativo;
        public event System.EventHandler Positivo;

        //Passo 2 - Disparar o Evento
        public void TestarResultado(decimal valor)
        {
            if (valor < 0)
            {
                Negativo(this, new EventArgs());
            }
            else
            {
                Positivo(this, new EventArgs());
            }
        }
    }
}
