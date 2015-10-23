using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo05_Lab01
{
    public abstract class PessoaInfo
    {

        #region "...: Atributos :..."
        private string _nome;
        private string _endereco;
        private string _cidade;
        private string _eCivil;
        #endregion

        #region "...: Propriedades :..."
        public string Nome
        {
            get { return _nome; }
            set { _nome = value.ToUpper(); }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value.ToUpper(); }
        }

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value.ToUpper(); }
        }


        public string EstadoCivil
        {
            get { return _eCivil; }
            set { _eCivil = value.ToUpper(); }
        }

        #endregion

        #region "...: Métodos :..."
        //metodo abstrato: obrigatoriamente deverá ser sobreposto
        public abstract void Gravar();
        #endregion
    }
}
