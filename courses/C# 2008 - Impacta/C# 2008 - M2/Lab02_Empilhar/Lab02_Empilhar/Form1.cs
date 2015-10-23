using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace Lab02_Empilhar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack pilha = new Stack();

        private void btnEmpilhar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                pilha.Push(textBox1.Text);
                label1.Text = "nº de itens na pilha: " + pilha.Count.ToString();
                textBox1.Clear();
                textBox1.Focus();
                btnRemover.Enabled = true;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            textBox1.Text = pilha.Peek().ToString();
            pilha.Pop();
            label1.Text = "n de itens na pilha: " + pilha.Count.ToString();

            if (pilha.Count == 0)
            {
                btnRemover.Enabled = false;
            }
        }

    }
}
