using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace Capitulo2
{
    public partial class capitulo2Form : Form
    {
        public capitulo2Form()
        {
            InitializeComponent();
        }

        private void stackButton_Click(object sender, EventArgs e)
        {
            Stack pilha = new Stack();

            //Adicionando itens
            pilha.Push("banana");
            pilha.Push("laranja");
            pilha.Push("maça");
            pilha.Push("uva");

            //Exibindo os itens da coleção
            foreach (string item in pilha)
            {
                exemploListBox.Items.Add(item);
            }
            exemploListBox.Items.Add("--------------------------------");

            //Exibindo o item no topo da pilha
            exemploListBox.Items.Add("Item no topo da pilha: " + pilha.Peek().ToString());

            exemploListBox.Items.Add("--------------------------------");

            //Removendo um item da pilha
            pilha.Pop();

            //Exibindo os itens da coleção
            foreach (string item in pilha)
            {
                exemploListBox.Items.Add(item);
            }
            exemploListBox.Items.Add("--------------------------------");

            //Exibindo o item no topo da pilha após o Pop
            exemploListBox.Items.Add("Item no topo da pilha após o Pop: " + pilha.Peek().ToString());

            exemploListBox.Items.Add("--------------------------------");
        }

        private void queueButton_Click(object sender, EventArgs e)
        {
            Queue fila = new Queue();

            //Adicionando itens
            fila.Enqueue("banana");
            fila.Enqueue("laranja");
            fila.Enqueue("maça");
            fila.Enqueue("uva");

            //Exibindo os itens da coleção
            foreach (string item in fila)
            {
                exemploListBox.Items.Add(item);
            }
            exemploListBox.Items.Add("--------------------------------");

            //Exibindo o primeiro item da fila
            exemploListBox.Items.Add("Primeiro item da fila: " + fila.Peek().ToString());

            exemploListBox.Items.Add("--------------------------------");

            //Removendo um item da fila
            fila.Dequeue();

            //Exibindo os itens da coleção
            foreach (string item in fila)
            {
                exemploListBox.Items.Add(item);
            }
            exemploListBox.Items.Add("--------------------------------");

            //Exibindo o primeiro item da fila após o Dequeue
            exemploListBox.Items.Add("Primeiro item da fila após o Dequeue: " + fila.Peek().ToString());

            exemploListBox.Items.Add("--------------------------------");
        }

        private void hashtableButton_Click(object sender, EventArgs e)
        {
            Hashtable candidatos = new Hashtable(); //Vai mostrar a quantidade de votos

            //Adicionando itens
            candidatos["Carlos"] = 100;
            candidatos["Pedro"] = 120;
            candidatos["Antonio"] = 130;
            candidatos["João"] = 110;
            candidatos["Paulo"] = 90;

            //Exibindo os valores
            foreach (DictionaryEntry item in candidatos)
            {
                string registro = string.Format("Nome: {0} - {1} votos", 
                                                            item.Key.ToString(), item.Value.ToString());

                exemploListBox.Items.Add(registro);
            exemploListBox.Items.Add("--------------------------------");
            }
        }

        private void sortedListButton_Click(object sender, EventArgs e)
        {
            SortedList candidatos = new SortedList(); //Vai mostrar a quantidade de votos

            //Adicionando itens
            candidatos["Carlos"] = 100;
            candidatos["Pedro"] = 120;
            candidatos["Antonio"] = 130;
            candidatos["João"] = 110;
            candidatos["Paulo"] = 90;

            //Exibindo os valores
            foreach (DictionaryEntry item in candidatos)
            {
                string registro = string.Format("Nome: {0} - {1} votos",
                                                            item.Key.ToString(), item.Value.ToString());

                exemploListBox.Items.Add(registro);
                exemploListBox.Items.Add("--------------------------------");
            }
        }
    }
}
