using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjObjetos
{
    public partial class loopsForm : Form
    {
        public loopsForm()
        {
            InitializeComponent();
        }

        private void whileButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i<=15)
            {
                textBox1.Text += i.ToString() + "\r\n";
                i++;
            }
        }

        private void doWhileButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                textBox1.Text += i.ToString() + "\r\n";
                i++;
            } while (i < 10);
        }

        private void forButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                textBox1.Text += i.ToString() + "\r\n";
            }
        }

        private void forEachButton_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                //MessageBox.Show(controle.Text);

                if (controle is TextBox)
                {
                    //MessageBox.Show(controle.Name);
                    //if (controle.Name != "textBox1")
                    //if ((string) controle.Tag != "1")
                    if (controle.Tag != "1")
                    {
                        //controle.Text = "";
                        (controle as TextBox).Clear();
                    }
                }
            }
        }
    }
}
