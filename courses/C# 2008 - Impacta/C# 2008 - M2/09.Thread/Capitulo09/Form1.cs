using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capitulo09
{
    public partial class Form1 : Form
    {
        System.Threading.Thread Processo;
        System.Threading.ThreadStart ProcessoInicio;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = @"c:\WINDOWS\Web\Wallpaper";
            ProcessoInicio = new System.Threading.ThreadStart(Iniciar);
            
        }

        private void Iniciar()
        {
            this.Text = "Procurando....";
            listBox1.Items.Clear();
            ProcurarImagens(textBox1.Text);
            this.Text = "Procura terminada em " + DateTime.Now;
            button1.Enabled = true;
            Processo.Abort();
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Processo = new System.Threading.Thread(ProcessoInicio);
            Processo.Start();
        }

        private void ProcurarImagens(string pasta)
        {
            var imagens = System.IO.Directory.GetFiles(pasta, "*.jpg");
            foreach (var arquivo in imagens)
            {
                listBox1.Items.Add(arquivo);
                try
                {
                    pictureBox1.Load(arquivo);
                }
                catch
                {
                    pictureBox1.Image = null;
                }
                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(60);

            }

            var pastas = System.IO.Directory.GetDirectories(pasta);
            foreach (var p in pastas)
            {
                ProcurarImagens(p);
            }
        
        }

      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Load(listBox1.Text);
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }
    }
}
