using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo06_Lab01
{
    abstract class VeiculoInfo
    {
        #region "...: Atributos :..."
        private string _placa;
        private string _modelo;
        private string _cor;
        private string _ano;
        #endregion

        #region "...: Propriedades :..."
        public string Placa
        {
            get { return _placa; }
            set { _placa = value.ToUpper(); }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value.ToUpper(); }
        }

        public string Cor
        {
            get { return _cor; }
            set { _cor = value.ToUpper(); }
        }

        public string Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
        
        #endregion

        #region "...: Métodos :..."
        public abstract void Gravar();
        public abstract void Abrir(); 
        #endregion
    }
}
