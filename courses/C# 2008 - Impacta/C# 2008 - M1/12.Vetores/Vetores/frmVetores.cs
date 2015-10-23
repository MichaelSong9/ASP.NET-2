using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//para usar o arraylist
using System.Collections;

namespace Vetores
{
    public partial class frmVetores : Form
    {
        public frmVetores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] produtos = new string[5];
            produtos[0] = "maçã";
            produtos[1] = "banana";
            produtos[2] = "pera";
            produtos[3] = "uva";
            produtos[4] = "goiaba";

            for (int i = 0; i < produtos.Length; i++)
            {
                listBox1.Items.Add(i.ToString() + " - " + produtos[i]);
            }
            listBox1.Items.Add("-------------------");

            //FILHO DA PUTA!!! faz ordenação! não precisa mais de bubble sort, PORRA!
            Array.Sort(produtos);

            for (int i = 0; i < produtos.Length; i++)
            {
                listBox1.Items.Add(i.ToString() + " - " + produtos[i]);
            }
            listBox1.Items.Add("-------------------");

            Array.Reverse(produtos);

            for (int i = 0; i < produtos.Length; i++)
            {
                listBox1.Items.Add(i.ToString() + " - " + produtos[i]);
            }
            listBox1.Items.Add("-------------------");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] produtos ={ "maçã",
                                 "banana",
                                 "pera",
                                 "uva",
                                 "melancia",
                                 "goiaba"};

            for (int i = 0; i < produtos.Length; i++)
            {
                listBox1.Items.Add(i.ToString() + " - " + produtos[i]);
            }
            listBox1.Items.Add("-------------------");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal[,] valores = new decimal[300, 20];
            string dados = string.Format("Nro de posições: {0}\nNro de dimensões: {1}\nNro do ultimo indice da dimensao 0: {2}\nNro do ultimo indice da dimensão 1: {3}",
                                         valores.Length,
                                         valores.Rank,
                                         valores.GetUpperBound(0),
                                         valores.GetUpperBound(1));

            MessageBox.Show(dados);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //arraylist pode ser usado como itens do carrinho de compras
            ArrayList lista = new ArrayList();
            lista.Add("maçã");
            lista.Add("banana");
            lista.Add("uva");
            lista.Add("manga");
            lista.Add(12345678910);

            //diferença: lista.COUNT e não LENGTH
            //não há limitação, e pode inserir diversos tipos de dados diferentes
            for (int i = 0; i < lista.Count; i++)
            {
                listBox1.Items.Add(i.ToString() + " - " + lista[i]);
            }
            listBox1.Items.Add("-------------------");

            //é possível inserir um elemento na posição que quiser:
            lista.Insert(2, "MORANGO");

            for (int i = 0; i < lista.Count; i++)
            {
                listBox1.Items.Add(i.ToString() + " - " + lista[i]);
            }
            listBox1.Items.Add("-------------------");


            //também é possível remover o elemento. Tanto por nome quanto pelo numero do elemento
            lista.Remove("MORANGO");

            //remove 5º elemento.
            //lista.RemoveAt(5);

            //remove 5 elementos a partir do terceiro elemento
            //lista.RemoveRange(3, 5);

            for (int i = 0; i < lista.Count; i++)
            {
                listBox1.Items.Add(i.ToString() + " - " + lista[i]);
            }
            listBox1.Items.Add("-------------------");

            if (lista.Contains("laranja"))
            {
                listBox1.Items.Add("-------------------");
                listBox1.Items.Add("Laranja existe");
                listBox1.Items.Add("-------------------");
            }
            else
            {
                listBox1.Items.Add("-------------------");
                listBox1.Items.Add("Não existe 'Laranja'");
                listBox1.Items.Add("-------------------");
            }
        }
    }
}