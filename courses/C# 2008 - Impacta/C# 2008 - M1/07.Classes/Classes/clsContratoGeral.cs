using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    //classe abstrata só pode ser herdada, não pode ser instanciada
    abstract class clsContratoGeral
    {
        #region ...: Atributos :...
        private string _nome; 
        #endregion

        #region ...: Propriedades :...
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        } 
        #endregion

        #region ...: Métodos :...
        //será usado pela classe filha do jeito que foi criado;
        public string MedotoComum()
        {
            return "Método Comum";
        }

        //pode ou não ser sobreposto pela classe filha
        public virtual string MetodoVirtual()
        {
            return "Método Virtual";
        }

        //obriga a sobreposição pela classe filha
        //public abstract string MetodoAbstrato()
        //{
        //    return "Método Abstrato";
        //}

        //um método abstrato tem que ser declarado dessa forma, se for declarado com código
        //ocorre erro, já que essa é uma classe abstrata, que não pode ser alterada;
        public abstract string MetodoAbstrato();

        #endregion
    }

    #region ...: Classe Contrato Locação :...
    //também é possível inserir uma classe dentro de outra classe
    //aqui, estou herdando a classe Contrato Geral. (os dois pontos)
    class clsContratoLocacao : clsContratoGeral
    {
        public override string MetodoAbstrato()
        {
            return "Metodo abstrato implementado no Contrato de Locação";
        }
    } 
    #endregion
}