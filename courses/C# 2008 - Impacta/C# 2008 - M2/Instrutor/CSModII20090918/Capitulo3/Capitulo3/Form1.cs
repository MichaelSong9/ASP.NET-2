using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capitulo3
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
                ExemploIndexador indexador = new ExemploIndexador(5);

                indexador.Adicionar("banana");
                indexador.Adicionar("maçã");
                indexador.Adicionar("laranja");
                indexador.Adicionar("uva");
                indexador.Adicionar("limão");

                for (int i = 0; i < indexador.NumeroDePosicoes(); i++)
                {
                    exemploListBox.Items.Add(indexador[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
