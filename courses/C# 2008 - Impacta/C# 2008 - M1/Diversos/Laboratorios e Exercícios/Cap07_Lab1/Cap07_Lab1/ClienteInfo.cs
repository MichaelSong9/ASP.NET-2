using System;
using System.Collections.Generic;
using System.Text;

namespace Cap07_Lab1
{
    public class ClienteInfo:CadastroBase
    {
        public string Telefone;
        public DateTime ClienteDesde;
        public override string NomeArquivo()
        {
            return "C:\\Clientes.txt";
        }
    }
}
