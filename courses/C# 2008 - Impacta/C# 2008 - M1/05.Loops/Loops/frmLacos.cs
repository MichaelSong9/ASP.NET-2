using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loops
{
    public partial class frmLaços : Form
    {
        public frmLaços()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i <= 10)
            {
                textBox1.Text += i.ToString() + " ";
                i++;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 10;
            do
            {
                textBox1.Text += i.ToString() + " ";
            } while (i < 10);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                textBox1.Text += i.ToString() + " ";
            }
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    //controle.Text = string.Empty;
                    if (controle.Tag != "1")
                    {
                        //faz um casting para poder utilizar o metodo Clear. Poderia usar o controle.Text = "" mas não está totalmente certo
                        (controle as TextBox).Clear();
                    }
                }
            }
        }
    }
}
