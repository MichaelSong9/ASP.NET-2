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
    public partial class videosForm : Form
    {
        public videosForm()
        {
            InitializeComponent();
        }

        private void abrirButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                "Músicas|*.mp3|Vídeos|*.avi;*.wmv|Todos os arquivos (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = "";

                nomeArquivo = openFileDialog1.FileName;
                
                //Carrega a mídia no MediaPlayer
                axWindowsMediaPlayer1.URL = nomeArquivo;

                nomeDoArquivoLabel.Text = nomeArquivo;

//                this.Text = "Meus vídeos - " +s
//                    nomeArquivo.Substring(nomeArquivo.LastIndexOf('\\')+1);

                    this.Text = "Meus vídeos - " +
                        openFileDialog1.SafeFileName;
            }
        }
    }
}
