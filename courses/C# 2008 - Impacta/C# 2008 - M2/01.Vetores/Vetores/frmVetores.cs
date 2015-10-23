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
    public partial class frmVetores : Form
    {
        public frmVetores()
        {
            InitializeComponent();
        }

        private void btnExemplo1_Click(object sender, EventArgs e)
        {
            //usado para vetores criados dinamicamente
            int[] numeros = new int[3];
            numeros[0] = 500;
            numeros[1] = 1;
            numeros[2] = 1000;

            Array.Sort(numeros);

            //usado quando você vai fazer hard code
            int[] x = { 1, 2, 3 };

            for (int i = 0; i < numeros.Length; i++)
            {
                listBox1.Items.Add("Vetor[" + i + "] = " + numeros[i].ToString());
            }
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            string[,] alunos = new string[3, 2];
            alunos[0, 0] = "Nome 1";
            alunos[0, 1] = "Solteiro";

            alunos[1, 0] = "Nome 2";
            alunos[1, 1] = "Casado";

            alunos[2, 0] = "Nome 3";
            alunos[2, 1] = "Viuvo";

            //getLenght obtem o tamanho da dimensão especificada. 0 - primeira, 1 - segunda dimensão
            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                for (int j = 0; j < alunos.GetLength(1); j++)
                {
                    listBox1.Items.Add(alunos[i, j]);
                }
            }

            listBox1.Items.Add("Nro de dimensões....: " + alunos.Rank.ToString());
            listBox1.Items.Add("Nro elementos Pos. 1: " + alunos.GetLength(0).ToString());
            listBox1.Items.Add("Nro elementos Pos. 2: " + alunos.GetLength(1).ToString());
            listBox1.Items.Add("Nro de elementos....: " + alunos.Length.ToString());
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            Calcular calcular = new Calcular();
            decimal[] valores = new decimal[4];

            valores[0] = 1.5m;
            valores[1] = 2.5m;
            valores[2] = 3.5m;
            valores[3] = 4.5m;

            listBox1.Items.Add(calcular.MediaElementos(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17));
            listBox1.Items.Add(calcular.Media(valores).ToString());

            mostrarLista(10, "oi", 5, 4.5m, "tchau...");
        }


        void mostrarLista(params object[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                listBox1.Items.Add(valores[i].ToString());
            }
        }

        private void btnCopyTo_Click(object sender, EventArgs e)
        {
            int[] valoresA = { 10, 20, 30, 40 };
            int[] valoresB = new int[valoresA.Length];

            valoresA.CopyTo(valoresB, 0);

            listBox1.Items.Add("VALORES A");
            for (int i = 0; i < valoresA.Length; i++)
            {
                listBox1.Items.Add(valoresA[i].ToString());    
            }
            
            listBox1.Items.Add("VALORES B");
            for (int i = 0; i < valoresB.Length; i++)
            {
                listBox1.Items.Add(valoresB[i].ToString());
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            int[] valoresA = { 10, 20, 30, 40 };
            int[] valoresB = new int[valoresA.Length];

            Array.Copy(valoresA, valoresB, 2);

            listBox1.Items.Add("VALORES A");
            for (int i = 0; i < valoresA.Length; i++)
            {
                listBox1.Items.Add(valoresA[i].ToString());
            }

            listBox1.Items.Add("VALORES B");
            for (int i = 0; i < valoresB.Length; i++)
            {
                listBox1.Items.Add(valoresB[i].ToString());
            }
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            int[] valoresA = { 10, 20, 30, 40 };
            int[] valoresB = (int[])valoresA.Clone();

            valoresA[2] = 100;

            listBox1.Items.Add("VALORES A");
            for (int i = 0; i < valoresA.Length; i++)
            {
                listBox1.Items.Add(valoresA[i].ToString());
            }

            listBox1.Items.Add("VALORES B");
            for (int i = 0; i < valoresB.Length; i++)
            {
                listBox1.Items.Add(valoresB[i].ToString());
            }
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            lista.Add("C#");
            lista.Add("JAVA");
            lista.Add("VB.NET");
            lista.Add("ASP.NET");
            lista.Add("COBOL");
            lista.Add("ABAP");

            for (int i = 0; i < lista.Count; i++)
            {
                listBox1.Items.Add(i.ToString() + " - " + lista[i].ToString());
            }

            lista.Insert(2, "_______________________ INSERIDO ___________________________");


            listBox1.Items.Add("------------------------");
            for (int i = 0; i < lista.Count; i++)
            {
                listBox1.Items.Add(i.ToString() + " - " + lista[i].ToString());
            }

        }
    }
}