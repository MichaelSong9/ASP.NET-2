using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo07
{
    class Venda
    {
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public int CodigoCliente { get; set; }
        public decimal Valor { get; set; }

        //Construtor Padrao
        public Venda()
        { 

        }
        //Construtor SobreCarregado
        public Venda(int _codigo, DateTime _data, int _codigoCliente, decimal _valor)
        {
            this.Codigo = _codigo;
            this.Data = _data;
            this.CodigoCliente = _codigoCliente;
            this.Valor = _valor;

        }

    }
}
