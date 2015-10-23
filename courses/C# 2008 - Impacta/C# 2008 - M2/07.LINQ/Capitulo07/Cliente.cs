using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo07
{
    class Cliente
    {
        //Propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        
        //Construtores
        public Cliente()
        { 

        }

        public Cliente(int _codigo, string _nome, string _email, int _idade)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Email = _email;
            this.Idade = _idade;
        }

    }
}
