using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Indexadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void indexadorButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExemploIndexador teste = new ExemploIndexador(5);

                teste.Adicionar("banana");
                teste.Adicionar("laranja");
                teste.Adicionar("uva");
                teste.Adicionar("maçã");
                teste.Adicionar("manga");

                MessageBox.Show(teste[2]);

                for (int i = 0; i < teste.NumeroDePosicoes(); i++)
                {
                    listBox1.Items.Add(teste[i]);
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
    }
}
