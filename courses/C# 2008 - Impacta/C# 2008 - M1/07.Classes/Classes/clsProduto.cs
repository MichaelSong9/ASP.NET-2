using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class clsProduto
    {
        #region ...: Atributos :...
        private string _nome;
        private decimal _preco; 
        #endregion

        #region ...: Propriedades :...
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public decimal Preco
        {
            get { return _preco; }
            set { _preco = value; }
        } 
        #endregion

        #region ...: Métodos :...
        public virtual string MostrarDados()
        {
            return string.Format("O produto {0} custa {1}", this.Nome.ToUpper(), this.Preco.ToString("C2"));
        } 
        #endregion
    }
}