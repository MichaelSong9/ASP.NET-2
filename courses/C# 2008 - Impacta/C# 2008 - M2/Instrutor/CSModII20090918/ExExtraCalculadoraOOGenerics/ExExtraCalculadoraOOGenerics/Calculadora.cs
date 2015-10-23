using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExExtraCalculadoraOOGenerics
{
    public delegate T CalculoHandler<T>(T n1, T n2);
    public delegate T FuncaoHandler<T>(T n1, T n2);

    public interface ICalculadoraOO<T>
    {
        //Definindo os métodos que devem existir na classe que implementar essa interface
        T Somar(T n1, T n2);
        T Subtrair(T n1, T n2);
        T Multiplicar(T n1, T n2);
        T Dividir(T n1, T n2);

        CalculoHandler<T> MetodoCalculo(T n1, T n2); //Usando o Delegate
        FuncaoHandler<T> MetodoFuncao(T n1, T n2); //Usando o Delegate
    }

    public class CalculadoraInteiros : ICalculadoraOO<int>
    {
        #region ICalculadoraOO<int> Members

        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }

        public CalculoHandler<int> MetodoCalculo(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public FuncaoHandler<int> MetodoFuncao(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
