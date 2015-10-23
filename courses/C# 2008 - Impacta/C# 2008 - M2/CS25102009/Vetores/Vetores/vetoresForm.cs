using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace Vetores
{
    public partial class vetoresForm : Form
    {
        public vetoresForm()
        {
            InitializeComponent();
        }

        private void exemplo1Button_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[5];

            numeros[0] = 10;
            numeros[1] = 30;
            numeros[2] = 25;
            numeros[3] = 2523;
            numeros[4] = 2544;

            //int[] numeros = { 20, 30, 50, 12 };

            //MessageBox.Show(numeros[1].ToString());

            //Array.Sort(numeros); //Coloca em ordem alfabética crescente

            Array.Reverse(numeros); //Coloca em ordem alfabética decrescente

            for (int i = 0; i < numeros.Length; i++)
            {
                //numeros[i] = i * 2 + 5;
                listBox1.Items.Add(numeros[i].ToString());
            }
        }

        private void exemplo2Button_Click(object sender, EventArgs e)
        {
            string[,] alunos = new string[4, 2];

            alunos[0, 0] = "Thiago";
            alunos[0, 1] = "Solteiro";

            alunos[1, 0] = "Fabio";
            alunos[1, 1] = "Casado";

            alunos[2, 0] = "Paulo";
            alunos[2, 1] = "Solteiro";

            alunos[3, 0] = "João";
            alunos[3, 1] = "Viúvo";

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                //listBox1.Items.Add(alunos[i, 0] + " - " + alunos[i, 1]);
                for (int j = 0; j < alunos.GetLength(1); j++)
                {
                    listBox1.Items.Add(alunos[i, j]);
                }
                    listBox1.Items.Add("------------------");
            }
            listBox1.Items.Add("Nro de dimensões: " + 
                                                        alunos.Rank.ToString());
            listBox1.Items.Add("Nro de dimensões da posição 0: " + 
                                                        alunos.GetLength(0).ToString());
            listBox1.Items.Add("Nro de dimensões da posição 1: " + 
                                                        alunos.GetLength(1).ToString());
            listBox1.Items.Add("Nro de elementos: " + 
                                                        alunos.Length.ToString());
        }

        private void mediaButton_Click(object sender, EventArgs e)
        {
            decimal[] numeros = {2, 3, 5, 20, 18};
            MessageBox.Show("A média é: " + CalcularMedia(numeros));
        }

        decimal CalcularMedia(decimal[] valores)
        {
            decimal soma = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }
            return soma / valores.Length;
        }

        private void calcularSomaButton_Click(object sender, EventArgs e)
        {
            MeusCalculos mcalc = new MeusCalculos();

            decimal[] numeros = { 2, 3, 5, 20, 18 };
            MessageBox.Show("A soma é: " + mcalc.CalcularSoma(numeros));

        }

        private void media2Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A média é: " +
                             CalcularMedia2(2, 3, 5, 20, 18));


        }

        decimal CalcularMedia2(params decimal[] valores)
        {
            decimal soma = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }
            return soma / valores.Length;
        }

        void MostraLista(params object[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
			{
                listBox1.Items.Add(valores[i].ToString());
			}
        }

        private void mostraButton_Click(object sender, EventArgs e)
        {
            MostraLista(10, "oi", 5, 4.5m, "tchau");
        }

        private void copyToButton_Click(object sender, EventArgs e)
        {
            int[] valoresA = { 10, 20, 30, 40 };
            int[] valoresB = new int[valoresA.Length];

            //Copiando o vetor A para o B
            valoresA.CopyTo(valoresB, 0);

            valoresA[2] = 100;
            listBox1.Items.Add("valoresA");
            for (int i = 0; i < valoresA.Length; i++)
            {
                listBox1.Items.Add(valoresA[i].ToString());
            }
            listBox1.Items.Add("--------");

            listBox1.Items.Add("valoresB");
            for (int i = 0; i < valoresB.Length; i++)
            {
                listBox1.Items.Add(valoresB[i].ToString());
            }
            listBox1.Items.Add("--------");

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            int[] valoresA = { 10, 20, 30, 40 };
            int[] valoresB = new int[valoresA.Length];

            //Copiando o vetor A para o B
           Array.Copy(valoresA,valoresB, 2);

            valoresA[2] = 100;
            listBox1.Items.Add("valoresA");
            for (int i = 0; i < valoresA.Length; i++)
            {
                listBox1.Items.Add(valoresA[i].ToString());
            }
            listBox1.Items.Add("--------");

            listBox1.Items.Add("valoresB");
            for (int i = 0; i < valoresB.Length; i++)
            {
                listBox1.Items.Add(valoresB[i].ToString());
            }
            listBox1.Items.Add("--------");

        }

        private void cloneButton_Click(object sender, EventArgs e)
        {
            int[] valoresA = { 10, 20, 30, 40 };
            int[] valoresB = (int[]) valoresA.Clone();

            valoresA[2] = 100;
            listBox1.Items.Add("valoresA");
            for (int i = 0; i < valoresA.Length; i++)
            {
                listBox1.Items.Add(valoresA[i].ToString());
            }
            listBox1.Items.Add("--------");

            listBox1.Items.Add("valoresB");
            for (int i = 0; i < valoresB.Length; i++)
            {
                listBox1.Items.Add(valoresB[i].ToString());
            }
            listBox1.Items.Add("--------");

        }

        private void arrayListButton_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();

            lista.Add("Excel");
            lista.Add("Windows");
            lista.Add("C Sharp");
            lista.Add("Java");

            for (int i = 0; i < lista.Count; i++)
			{
			    listBox1.Items.Add(i.ToString() + "-" + lista[i].ToString());
			}
            listBox1.Items.Add("--------");

            lista.Insert(2, "Word");

            for (int i = 0; i < lista.Count; i++)
            {
                listBox1.Items.Add(i.ToString() + "-" + lista[i].ToString());
            }

        }
}



    class MeusCalculos
    {
        public decimal CalcularSoma(decimal[] valores)
        {
            decimal soma = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }
            return soma;
        }

        decimal CalcularProduto(decimal[] valores)
        {
            decimal produto = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                produto *= valores[i];
            }
            return produto;
        }

    }
}
