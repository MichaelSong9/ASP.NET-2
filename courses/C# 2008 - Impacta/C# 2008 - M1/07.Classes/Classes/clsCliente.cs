using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class clsCliente
    {
        public string _nome;
        public Endereco _comercial;
        public EstadoCivil ECivil;

        // pesquisar porque esse filho da puta não aceita!
        public Endereco Comercial
        {
            get { return _comercial; }
            set { _comercial = value; }
        }
    }
}