using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exemplo01Pag12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exemploButton_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[3];

            numeros[0] = 50;
            numeros[1] = 100;
            numeros[2] = 150;

            exemploListBox.Items.Add(string.Format("numeros[0] = {0}", numeros[0].ToString()));
            exemploListBox.Items.Add(string.Format("numeros[1] = {0}", numeros[1].ToString()));
            exemploListBox.Items.Add(string.Format("numeros[2] = {0}", numeros[2].ToString()));
            
        }

        private void exemplo2Button_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[3];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 50 * (i+1);
                exemploListBox.Items.Add(string.Format("numeros[{0}] = {1}",i, numeros[i].ToString()));
            }
        }

        private void exemplo3Button_Click(object sender, EventArgs e)
        {
            string[,] pesquisa = new string[3, 2];

            pesquisa[0, 0] = "Carlos";
            pesquisa[1, 0] = "Pedro";
            pesquisa[2, 0] = "João";

            pesquisa[0, 1] = "Casado";
            pesquisa[1, 1] = "Solteiro";
            pesquisa[2, 1] = "Viúvo";

            for (int i = 0; i < pesquisa.GetLength(0); i++)
            {
                for (int j = 0; j < pesquisa.GetLength(1); j++)
                {
                    exemploListBox.Items.Add(pesquisa[i, j]);
                }
                exemploListBox.Items.Add("--------------------");
            }

            exemploListBox.Items.Add("Número de Dimensões: " + pesquisa.Rank.ToString());
            exemploListBox.Items.Add("Número de Posições Dimensão 0: " + pesquisa.GetLength(0).ToString());
            exemploListBox.Items.Add("Número de Posições Dimensão 1: " + pesquisa.GetLength(1).ToString());
            exemploListBox.Items.Add("Número Total de Posições: " + pesquisa.Length.ToString());
        }

        private void mediaButton_Click(object sender, EventArgs e)
        {
            decimal[] numeros = { 7.5m, 8.5m, 3.25m, 10 };

            for (int i = 0; i < numeros.Length; i++)
            {
                exemploListBox.Items.Add(numeros[i].ToString());
            }
            exemploListBox.Items.Add("-----------------");

            exemploListBox.Items.Add(CalcularMedia(numeros));
        }

        private decimal CalcularMedia(decimal[] valores)
        {
            decimal soma = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }

            return soma / valores.Length;
        }

        private void media2Button_Click(object sender, EventArgs e)
        {
            exemploListBox.Items.Add(CalcularMedia2(2, 3, 4, 5));
        }

        private decimal CalcularMedia2(params decimal[] valores)
        {
            decimal soma = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }

            return soma / valores.Length;
        }

        private void listaButton_Click(object sender, EventArgs e)
        {
            MostraLista("Banana", 3.45, "Maça", 2.47);
        }

        private void MostraLista(params object[] valores)
        {
            foreach (object item in valores)
            {
                exemploListBox.Items.Add(item.ToString());
            }

            exemploListBox.Items.Add("---------------");

            for (int i = 0; i < valores.Length; i++)
            {
                exemploListBox.Items.Add(valores[i].ToString());
            }
        }

        private void copyToButton_Click(object sender, EventArgs e)
        {
            int[] valoresA = { 1, 2, 3, 4, 5 };
            int[] valoresB = new int[valoresA.Length];

            valoresA.CopyTo(valoresB, 0);

            valoresA[3] = 100;

            for (int i = 0; i < valoresA.Length; i++)
            {
                exemploListBox.Items.Add("Valores A: " + valoresA[i].ToString());
            }

            exemploListBox.Items.Add("------------------------");

            for (int i = 0; i < valoresA.Length; i++)
            {
                exemploListBox.Items.Add("Valores B: " + valoresB[i].ToString());
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            int[] valoresA = { 1, 2, 3, 4, 5 };
            int[] valoresB = new int[valoresA.Length];

            Array.Copy(valoresA, valoresB,2); //Copiando 2 elementos apenas

            valoresA[3] = 100;

            for (int i = 0; i < valoresA.Length; i++)
            {
                exemploListBox.Items.Add("Valores A: " + valoresA[i].ToString());
            }

            exemploListBox.Items.Add("------------------------");

            for (int i = 0; i < valoresA.Length; i++)
            {
                exemploListBox.Items.Add("Valores B: " + valoresB[i].ToString());
            }
        }

        private void cloneButton_Click(object sender, EventArgs e)
        {
            int[] valoresA = { 1, 2, 3, 4, 5 };
            int[] valoresB = (int[]) valoresA.Clone(); //Clona o array. Já cria e copia em uma mesma ação

            valoresA[3] = 100;

            for (int i = 0; i < valoresA.Length; i++)
            {
                exemploListBox.Items.Add("Valores A: " + valoresA[i].ToString());
            }

            exemploListBox.Items.Add("------------------------");

            for (int i = 0; i < valoresA.Length; i++)
            {
                exemploListBox.Items.Add("Valores B: " + valoresB[i].ToString());
            }
        }
    }
}
