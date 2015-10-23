using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    //abstrata porque vai ser herdada
    abstract class Pessoa
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

    }
}
