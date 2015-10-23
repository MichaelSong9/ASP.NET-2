using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjOficina
{
    class clsVeiculoInfo
    {
        #region ...: Construtores :...
        //método construtor: 1º metodo que acontece quando instancia a classe.
        //exemplo principal: usar para colocar a ConnectionString

        //sobrecarga do método construtor, para criar um caminho padrão para salvar os dados
        public clsVeiculoInfo()
        {
            caminho = @"C:\oficina.txt";
        }

        public clsVeiculoInfo(string CaminhoDoArquivo)
        {
            caminho = CaminhoDoArquivo;
        } 
        #endregion

        #region ...: Atributos :...
        
        private string _placa;
        private string _modelo;
        private string _cor;
        private short _ano;

        private string caminho;
        
        #endregion

        #region ...: Propriedades :...

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

        #endregion

        #region ...: Métodos :...
        
        public void Gravar()
        {
            string registro = 
                   string.Format("{0};{1};{2};{3};{4}",  
                          this.Placa,
                          this.Modelo,
                          this.Cor,
                          this.Ano.ToString(),
                          DateTime.Now);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho, true);
            sw.WriteLine(registro);
            sw.Close();
        }

        public void Abrir()
        {
            //praticamente o "dir" do shell
            if (System.IO.File.Exists(caminho))
            {
                //serve para abrir arquivos
                System.Diagnostics.Process.Start(caminho);
            }
            else
            {
                throw new Exception("Atquivo " + caminho + " não encontrado");
            }
        } 

        #endregion
    }
}