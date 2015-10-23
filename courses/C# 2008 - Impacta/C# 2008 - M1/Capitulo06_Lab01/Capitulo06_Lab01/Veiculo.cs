using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo06_Lab01
{
    class Veiculo : VeiculoInfo, IPasseio
    {
        #region "...: Atributos :..."
        private bool _som;
        private bool _ar;
        private string _caminho;
        #endregion

        #region IPasseio Members

        public  bool Som
        {
            get { return _som; }
            set { _som = value; }
        }

        public bool Ar
        {
            get { return _ar; }
            set { _ar = value; }
        }

        public string Caminho
        {
            get { return _caminho; }
        }

        #endregion

        #region "...: Métodos :..."
        public Veiculo(string endereco)
        {
            _caminho = endereco;
        }

        public override void Gravar()
        {
            string registro = string.Format("{0};{1};{2};{3};{4};{5}", this.Placa,
                                                                       this.Modelo,
                                                                       this.Cor,
                                                                       this.Ano.ToString(),
                                                                       _som ? "Com som" : "Sem som",
                                                                       _ar ? "Com ar" : "Sem ar");

            System.IO.StreamWriter sw = new System.IO.StreamWriter(this.Caminho, true);
            sw.WriteLine(registro);
            sw.Close();
        }
        public override void Abrir()
        {
            if (System.IO.File.Exists(this.Caminho))
            {
                System.Diagnostics.Process.Start(this.Caminho);
            }
        }
        #endregion
    }
}
