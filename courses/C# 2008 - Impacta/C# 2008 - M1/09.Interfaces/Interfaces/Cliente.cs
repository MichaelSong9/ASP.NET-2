using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    //a implementação é feita automaticamente após "herdar" a interface. Clicar na Interface após declarar ela...
    class Cliente : Pessoa,ICliente, IDados
    {
        private string _cpf;

        #region ICliente Members
        public string CPF
        {
            get
            {
                return _cpf;
                //throw new NotImplementedException();
            }
            set
            {
                _cpf = value;
                //throw new NotImplementedException();
            }
        }

        public void Cadastrar()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(string obs)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDados Members

        public byte Idade
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Endereco
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
