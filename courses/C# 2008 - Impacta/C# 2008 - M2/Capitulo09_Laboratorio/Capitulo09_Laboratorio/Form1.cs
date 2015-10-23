using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capitulo09_Laboratorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Processar();
        }

        private void Processar()
        {
            //Executando algo demorado...
            for (int x = 1; x < 1000; x++)
            {
                listBox1.Items.Add(x);
                listBox1.SelectedItem = x;
                listBox1.Refresh();
                System.Threading.Thread.Sleep(500);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }


    }
}
