using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumerosExtensos
{
    public partial class frmNumerosExtensos : Form
    {
        public frmNumerosExtensos()
        {
            InitializeComponent();
        }

        //propriedade AcceptButton do form para fazer o <Enter> ser o padrão
        private void btnEscrever_Click(object sender, EventArgs e)
        {
            Gerar gerar = new Gerar();

            if (txtNumero.Text != string.Empty)
            {
                int numero = Convert.ToInt16(txtNumero.Text);
                label1.Text = gerar.escreverNumero(numero);

                for (int i = 1; i < 100; i++)
                {
                    listBox1.Items.Add(gerar.escreverNumero(i).ToString());
                }
            }
            else
            {
                MessageBox.Show("Insira o numero");
            }

            txtNumero.Focus();
            txtNumero.SelectAll();
        }
    }
}