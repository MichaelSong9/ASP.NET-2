using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo05_Lab01
{
    class Cliente : PessoaInfo
    {

        #region "...: Atributos :..."
        private string _caminho;
        #endregion

        #region "...: Propriedades :..."
        public string Caminho
        {
            get { return _caminho; }
        }

        //método construtor
        public Cliente(string Endereco)
        {
            _caminho = Endereco;
        }

        public override void Gravar()
        {
            string registro = string.Format("{0};{1};{2};{3}", this.Nome,
                                                               this.Endereco,
                                                               this.Cidade,
                                                               this.EstadoCivil);

            System.IO.StreamWriter sw = new System.IO.StreamWriter(this.Caminho, true);
            sw.WriteLine(registro);
            sw.Close();
            //throw new NotImplementedException();
        }

        #endregion
        
    }
}
