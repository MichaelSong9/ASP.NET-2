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
    public partial class frmColecoes : Form
    {
        public frmColecoes()
        {
            InitializeComponent();
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            Stack pilha = new Stack();

            //adicionando itens
            pilha.Push("1º elemento");
            pilha.Push("2º elemento");
            pilha.Push("3º elemento");

            //exibindo os itens da COLEÇÃO
            listBox1.Items.Add("Ultimo a entrar, primeiro a sair - LIFO ");
            foreach (string elemento in pilha)
            {
                listBox1.Items.Add(elemento);
            }

            //retirar elemento da pilha
            //pilha.Pop();

            //topo da pilha
            listBox1.Items.Add("Topo da pilha: " + pilha.Peek());
        }

        private void btnFila_Click(object sender, EventArgs e)
        {
            Queue fila = new Queue();

            //adicionando itens
            fila.Enqueue("1º elemento");
            fila.Enqueue("2º elemento");
            fila.Enqueue("3º elemento");

            //exibindo os itens da COLEÇÃO
            listBox1.Items.Add("Primeiro a entrar, primeiro a sair - FIFO ");
            foreach (string elemento in fila)
            {
                listBox1.Items.Add(elemento);
            }

            //retirar elemento da fila
            //fila.Dequeue();

            //topo da fila
            listBox1.Items.Add("Topo da pilha: " + fila.Peek());
        }

        private void btnHashtable_Click(object sender, EventArgs e)
        {
            Hashtable candidatos = new Hashtable();

            //adicionando os ítens
            candidatos["Maluf"] = 0;
            candidatos["Sarney"] = 5000;
            candidatos["Serra"] = 24;

            //exibindo os itens da coleção
            foreach (DictionaryEntry cnd in candidatos)
            {
                string registro = string.Format("Nome: {0} - {1} votos",
                                                                 cnd.Key.ToString(),
                                                                 cnd.Value.ToString());

                listBox1.Items.Add(registro);
            }
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            //diferença é que ele é exibido por ordem alfabetica
            SortedList candidatos = new SortedList();

            //adicionando os ítens
            candidatos["Maluf"] = 0;
            candidatos["Sarney"] = 5000;
            candidatos["Serra"] = 24;

            //exibindo os itens da coleção
            foreach (DictionaryEntry cnd in candidatos)
            {
                string registro = string.Format("Nome: {0} - {1} votos",
                                                                 cnd.Key.ToString(),
                                                                 cnd.Value.ToString());

                listBox1.Items.Add(registro);
            }
        }
    }
}