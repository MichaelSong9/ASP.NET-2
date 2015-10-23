using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjGenerics
{
    public partial class genericsForm : Form
    {
        public genericsForm()
        {
            InitializeComponent();
        }

        Lista<string> listinha = new Lista<string>();

        private void carregarButton_Click(object sender, EventArgs e)
        {
            listinha.Incluir(itemTextBox.Text);
            itemTextBox.Focus();
            itemTextBox.SelectAll();
        }

        private void descarregarButton_Click(object sender, EventArgs e)
        {
            listinha.Descarregar(itensListBox);
        }
    }
}