using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class clsPessoa
    {
        #region ...: Atributos :...
        private string _nome;
        private int _idade;
        private string _telefone; 
        #endregion

        #region ...: Propriedades :...
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value.Trim() != "")
                {
                    _nome = value.ToUpper();
                }
                else
                {
                    throw new Exception("Por favor, informe o nome");
                }
            }
        }

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value >= 18)
                {
                    _idade = value;
                }
                else
                {
                    throw new Exception("Idade não permitida");
                }
            }
        }

        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (value.Trim() != "")
                {
                    _telefone = value;
                }
                else
                {
                    throw new Exception("Informe o telefone");
                }
            }
        } 
        #endregion

        #region ...: Métodos :...
        //método com nome igual mas outro comportamento: sobrecarga!

        /// <summary>
        /// Retorna uma string com o nome e a idade
        /// </summary>
        /// <returns>Retorno vai ser uma string de dados</returns>
        public string MostrarDados()
        {
            string dados = string.Format("Nome: {0}\nIdade: {1}", this.Nome, this.Idade.ToString());
            return dados;
        }

        /// <summary>
        /// Retorna uma string com nome, idade e observação. P-o-r-r-a!
        /// </summary>
        /// <param name="observacao">Parametro de observação</param>
        /// <returns>Retorno vai ser uma string de dados</returns>
        public string MostrarDados(string observacao)
        {
            string dados = string.Format("Nome: {0}\nIdade: {1}\nObservacao: {2}", this.Nome, this.Idade.ToString(), observacao);
            return dados;
        }

        #endregion

        #region "...: Eventos :..."
        //faltam os eventos para terminar tudo que tem em uma classe
        #endregion
    }
}