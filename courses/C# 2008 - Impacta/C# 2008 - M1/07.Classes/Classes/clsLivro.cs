using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class clsLivro : clsProduto 
    {
        #region ...: Atributos :...
        private int _nroPaginas;
        #endregion

        #region ...: Propriedades :...
        public int NroPaginas
        {
            get { return _nroPaginas; }
            set { _nroPaginas = value; }
        }
        
        #endregion

        #region ...: Métodos :...

        //Override sobrepõe o método original (herança). A classe-mãe precisa deixar fazer isso,
        //para isso, o metodo da classe-mãe tem que ser declarado como "virtual" ou "abstract"
        //abstract => você é obrigado a utilizar o override
        //virtual => você não é obrigado.

        //só digitar public override que ele automaticamente verifica qual método pode usar
        public override string MostrarDados()
        {
            return base.MostrarDados() + "\n\nNumero de paginas: " + this.NroPaginas.ToString();
        }
        #endregion
    }
}
