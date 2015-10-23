using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjOficina
{
    class VeiculoInfo
    {

        public VeiculoInfo()
        {
            caminho = @"c:\oficina.txt";
        }

        public VeiculoInfo(string CaminhoDoArquivo)
        {
            caminho = CaminhoDoArquivo;
        }

        private string _placa;
        private string _modelo;
        private string _cor;
        private short _ano;

        private string caminho;

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

        public void Gravar()
        {
            string registro =
                string.Format("{0};{1};{2};{3};{4}", this.Placa,this.Modelo,
                        this.Cor,this.Ano.ToString(),DateTime.Now);

            System.IO.StreamWriter sw = 
                new System.IO.StreamWriter(caminho, true);

            sw.WriteLine(registro);
            sw.Close();
        }

        public void Abrir()
        {
            if (System.IO.File.Exists(caminho))
            {
                //Shell do Sistema Operacional
                //Serve para abrir arquivos, executáveis, URLs, etc...
                System.Diagnostics.Process.Start(caminho);
            }
            else
            {
                throw new Exception("Arquivo " + caminho + "não encontrado");
            }
        }
    }
}
