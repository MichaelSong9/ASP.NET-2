using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Collections;


namespace Cap06_Lab1
{
    

    public partial class cadastroForm : Form
    {
        Hashtable tabela = new Hashtable();

        public cadastroForm()
        {
            InitializeComponent();
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            
            
            //ContainsKey verifica se o parâmetro existe no HashTable
            if(tabela.Contains(nomeTextBox.Text))
            {
                mensagemLabel.Text="Este registro já existe";
                mensagemLabel.BackColor = Color.Red;
                mensagemLabel.ForeColor = Color.White;
            }
            else
            {
                tabela.Add(nomeTextBox.Text, emailTextBox.Text);
                mensagemLabel.Text = "Total de itens: " + tabela.Count;
                mensagemLabel.BackColor = Color.Black;
                mensagemLabel.ForeColor = Color.White;
                
                nomeTextBox.Clear();
                emailTextBox.Clear();
                nomeTextBox.Focus();
            }
        }

        private void pesquisarButton_Click(object sender, EventArgs e)
        {
            if (tabela.Contains(nomeTextBox.Text))
            {
                emailTextBox.Text = tabela[nomeTextBox.Text].ToString();
                mensagemLabel.Text = "Registro encontrado";
                mensagemLabel.BackColor = Color.Blue;
                mensagemLabel.ForeColor = Color.Yellow;
            }
            else
            {
                mensagemLabel.Text = "Nome não localizado";
                mensagemLabel.BackColor = Color.Red;
                mensagemLabel.ForeColor = Color.White;
            }
        }

        private void cadastroForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{tab}");
            }
        }

        
    }
}