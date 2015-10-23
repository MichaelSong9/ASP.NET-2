using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    //só pode ser instanciada, não pode ser herdada;
    sealed class clsContratoCompraVenda
    {
        public string MetodoTeste()
        {
            return "Teste";
        }
    }

    abstract class clsContratoQuePodeSerHerdado
    {

    }

    class clsOutroContrato
    {
        //quem posso herdar?
        //todos, menos a classe "sealed";
    }
}