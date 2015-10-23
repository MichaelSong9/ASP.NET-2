using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmVideos
{
    public partial class frmVideos : Form
    {
        public frmVideos()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Musicas|*.mp3|Vídeos|*.avi;*.wmv|Todos os arquivos|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = openFileDialog1.FileName;
                axWindowsMediaPlayer1.URL = nomeArquivo;

                //pegar o nome do arquivo: procurar pela ultima barra
                //this.Text = "Meus vídeos - " + nomeArquivo.Substring(nomeArquivo.LastIndexOf('\\') + 1);
                this.Text = "Meus vídeos - " + openFileDialog1.SafeFileName;
            }
        }
    }
}