using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateEvento
{
    class Eventos
    {
        //sender...: objeto que envia os dados (...)
        //EventArgs: especialização dos argumentos de eventos. "manipulador de eventos"
        
        //eventos
        public event System.EventHandler Evento1;
        public event System.EventHandler Evento2;

        //métodos
        public void TestarCondicao(bool teste)
        {
            if (teste)
            {
                //sender é ele mesmo
                Evento1(this, new EventArgs());
            }
            else
            {
                Evento2(this, new EventArgs());
            }
        }

    }
}
