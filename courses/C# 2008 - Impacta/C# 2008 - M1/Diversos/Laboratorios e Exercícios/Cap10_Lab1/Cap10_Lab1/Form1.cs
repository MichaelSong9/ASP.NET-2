using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Cap10_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nometextBox.Clear();
            listaListBox.Items.Clear();
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            listaListBox.Items.Add(itemTextBox.Text);
            itemTextBox.Clear();
            itemTextBox.Focus();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (listaListBox.Items.Contains(itemTextBox.Text))
            {
                listaListBox.Items.Remove(itemTextBox.Text);
            }
            else
            {
                MessageBox.Show("Este item não está na lista");
            }
            itemTextBox.Focus();
            itemTextBox.SelectAll();
        }

        private void listaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaListBox.SelectedItem != null)
            {
                itemTextBox.Text = listaListBox.SelectedItem.ToString();
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Listas(*.lst)|*.lst";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string arq = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(arq);
                sw.WriteLine(nometextBox.Text);
                foreach(string item in listaListBox.Items)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
                MessageBox.Show("gravado");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fonteBold = new Font("Verdana", 10, FontStyle.Bold);
            Font fonteNormal = new Font("Verdana", 10, FontStyle.Regular);
            Brush pincel = Brushes.Black;
            int linha = 10;
            int coluna = 10;

            e.Graphics.DrawString(nometextBox.Text, fonteBold, pincel, coluna, linha);
            linha += 30;

            foreach (string item in listaListBox.Items)
            {
                e.Graphics.DrawString(item, fonteNormal, pincel, coluna, linha);
                linha += 20;
            }
            e.HasMorePages = false;

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void préviaDeImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 obj = new AboutBox1();
            obj.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            novoToolStripMenuItem.PerformClick();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            abrirToolStripMenuItem.PerformClick();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            salvarToolStripMenuItem.PerformClick();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            imprimirToolStripMenuItem.PerformClick();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            abrirToolStripMenuItem.PerformClick();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Listas(*.lst)|*lst";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string arq = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(arq);
                nometextBox.Text = sr.ReadLine();

                listaListBox.Items.Clear();
                string linha = sr.ReadLine();
                while (linha != null)
                {
                    listaListBox.Items.Add(linha);
                    linha = sr.ReadLine();
                }
                sr.Close();
            }
        }


    }
}