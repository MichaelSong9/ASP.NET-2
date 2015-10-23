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
    public partial class frmIndexadores : Form
    {
        public frmIndexadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ExemploIndexador teste = new ExemploIndexador(4);
                teste.Adicionar("elemento 1");
                teste.Adicionar("elemento 2");
                teste.Adicionar("elemento 3");
                teste.Adicionar("elemento 4");
                
                MessageBox.Show(teste[2].ToString());

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