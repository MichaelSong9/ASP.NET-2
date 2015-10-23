using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oficina.Modelos
{
    public class VeiculoInfo
    {
        private string _placa;
        private string _modelo;
        private string _cor;
        private short _ano;

        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public string Cor
        {
            get { return _cor; }
            set { _cor = value; }
        }

        public short Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
    }

}
