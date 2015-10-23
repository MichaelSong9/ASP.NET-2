using System;
using System.Collections.Generic;
using System.Text;

namespace Cap09_Lab1
{
    class ContaCorrente
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private decimal _saldo;
        public decimal Saldo
        {
            get { return _saldo; }
        }

        public void Depositar(decimal valor)
        {
            _saldo += valor;
        }

        public void Retirar(decimal valor)
        {
            if (valor <= _saldo)
            {
                _saldo -= valor;
            }
            if (_saldo < 50)
            {
                if (SaldoBaixo != null)
                {
                    SaldoBaixo(this, new EventArgs());
                }
            }
        }
        public event System.EventHandler SaldoBaixo;

        public override string  ToString()
        {
             return this.Nome;
        }

        public ContaCorrente(string nome)
        {
            this.Nome = nome;
        }
    }
}
