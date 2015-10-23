using System;
using System.Collections.Generic;
using System.Text;

namespace Cap07_Lab1
{
    public abstract class CadastroBase
    {
        public string Nome;
        public string Email;
        public abstract string NomeArquivo();
    }
}
