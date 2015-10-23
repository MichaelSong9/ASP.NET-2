using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace Capitulo02_Laboratorio01
{
    public partial class Cap02_Lab01Form : Form
    {
        public Cap02_Lab01Form()
        {
            InitializeComponent();
        }

        Stack pilha = new Stack();

        private void empilharButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(itemTextBox.Text))
            //if (itemTextBox.Text!="")
            {
                if (!pilha.Contains(itemTextBox.Text))
                {
                    pilha.Push(itemTextBox.Text);
                    qtdeItensLabel.Text = 
                        "Nº de itens na Pilha: " + pilha.Count.ToString();
                    itemTextBox.Clear();
                    itemTextBox.Focus();
                    removerButton.Enabled = true;
                }
            }
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            itemTextBox.Text = pilha.Peek().ToString();
            pilha.Pop();
            qtdeItensLabel.Text = 
                "Nº de itens na Pilha: " + pilha.Count.ToString();
            if (pilha.Count == 0)
            {
                removerButton.Enabled = false;
            }
        }
    }
}
