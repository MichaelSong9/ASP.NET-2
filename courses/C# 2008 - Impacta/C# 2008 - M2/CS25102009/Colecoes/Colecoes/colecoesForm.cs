using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace Colecoes
{
    public partial class colecoesForm : Form
    {
        public colecoesForm()
        {
            InitializeComponent();
        }

        private void stackButton_Click(object sender, EventArgs e)
        {
            Stack pilha = new Stack();

            //Adicionando itens
            pilha.Push("banana");
            pilha.Push("laranja");
            pilha.Push("uva");

            //Exibindo os itens da coleção
            foreach (string elemento in pilha)
            {
                listBox1.Items.Add(elemento);
            }
            listBox1.Items.Add("--------------");

            //Exibindo o item do topo da pilha
            listBox1.Items.Add("topo da pilha");
            listBox1.Items.Add(pilha.Peek());
            listBox1.Items.Add("--------------");

            //Retirando um elemento da pilha (do topo)
            pilha.Pop();

            //Exibindo o item do topo da pilha
            listBox1.Items.Add("topo da pilha");
            listBox1.Items.Add(pilha.Peek());

        }

        private void queueButton_Click(object sender, EventArgs e)
        {
            Queue fila = new Queue();

            //Adicionando itens
            fila.Enqueue("Gabriela");
            fila.Enqueue("Rafael");
            fila.Enqueue("Thiago");

            //Exibindo os itens da coleção
            foreach (string elemento in fila)
            {
                listBox1.Items.Add(elemento);
            }
            listBox1.Items.Add("--------------");

            //Exibindo o item primeiro da fila
            listBox1.Items.Add("primeiro da fila");
            listBox1.Items.Add(fila.Peek());
            listBox1.Items.Add("--------------");

            //Retirando um elemento da fila (primeiro da fila)
            fila.Dequeue();

            //Exibindo o item primeiro da fila
            listBox1.Items.Add("primeiro da fila");
            listBox1.Items.Add(fila.Peek());
        }

        private void hashtableButton_Click(object sender, EventArgs e)
        {
            Hashtable candidatos = new Hashtable();

            //Adicionando os itens
            candidatos["maluf"] = 5;
            candidatos["sarney"] = 10;
            candidatos["alckimin"] = 50;
            candidatos["serra"] = 40;

            //Exibindo os itens da coleção
            foreach (DictionaryEntry cand in candidatos)
            {
                string registro = string.Format("Nome: {0} - {1} votos",
                    cand.Key.ToString(), cand.Value.ToString());
                listBox1.Items.Add(registro);
            }
            listBox1.Items.Add("--------------");
        
        }

        private void sortedListButton_Click(object sender, EventArgs e)
        {
            SortedList candidatos = new SortedList();

            //Adicionando os itens
            candidatos["maluf"] = 5;
            candidatos["sarney"] = 10;
            candidatos["alckimin"] = 50;
            candidatos["serra"] = 40;

            //Exibindo os itens da coleção
            foreach (DictionaryEntry cand in candidatos)
            {
                string registro = string.Format("Nome: {0} - {1} votos",
                    cand.Key.ToString(), cand.Value.ToString());
                listBox1.Items.Add(registro);
            }
            listBox1.Items.Add("--------------");
        

        }
    }
}
