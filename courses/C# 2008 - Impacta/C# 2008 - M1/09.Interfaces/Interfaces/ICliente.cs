using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    interface ICliente
    {
        //a propriedade deve ser declarada dessa forma, quem for implementar a interface, é obrigado a usar
        string CPF { get; set; }

        void Cadastrar();
        void Cadastrar(string obs);
    }
}