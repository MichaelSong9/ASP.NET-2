using System;
using System.Collections.Generic;
using System.Text;

namespace Cap07_Lab1
{
    public class FuncionarioInfo:CadastroBase
    {
        public string Cargo;
        public decimal Salario;

        public override string NomeArquivo()
        {
            return "C:\\Funcionarios.txt";
        }
    }
}