using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    enum EstadoCivil
    {
        Casado,
        Solteiro,
        Viuvo,
        Separado,
        Viado,
        Outro
    }

    struct Endereco
    {
        public string Rua;
        public string Bairro;
        public string Cidade;
        public string UF;
        public string CEP;
    }
}
