using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    interface IFuncionario
    {
        string Matricula { get; set; }

        void Admitir();
        void Demitir();
    }
}
