using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.Modelo
{
    public class ProdutoInfo
    {
        public int Codigo {get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        private int _estoque;

        public int Estoque
        {
            get { return _estoque; }
            set 
            {
                if (value < 0) throw new Exception("O estoque não pode ser menor que zero");
                _estoque = value; 
            }
        }
    }
}
