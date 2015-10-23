using System;
using System.Collections.Generic;
using System.Text;


namespace Cap08_Lab1
{
    class TextoInfo
    {
        private string _texto;
        public string Texto
        {
            get { return _texto; }
            set { _texto = value; }
        }

        private string _titulo;
        public string Titulo
        {
            get { return _titulo;}
            set { _titulo = value.Replace(".", ""); }
        }

        public TextoInfo(string titulo, string texto)
        {
            this.Titulo = titulo;
            this.Texto = texto;
        }

        public TextoInfo(string titulo)
            : this(titulo, "")
        { }

        private string arquivo
        { 
            get{return _titulo+".txt";}
        }

        public void Gravar()
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(this.arquivo);
            sw.WriteLine(this.Texto);
            sw.Close();
        }

        public string Ler()
        {
            System.IO.StreamReader sr = null;
            try
            {
                sr = new System.IO.StreamReader(this.arquivo);
                string resultado = sr.ReadToEnd();
                return resultado;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
