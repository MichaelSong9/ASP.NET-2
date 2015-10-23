using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Funcionario : Pessoa, IFuncionario, IDados
    {
        #region IFuncionario Members

        public string Matricula
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

        public void Admitir()
        {
            throw new NotImplementedException();
        }

        public void Demitir()
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
