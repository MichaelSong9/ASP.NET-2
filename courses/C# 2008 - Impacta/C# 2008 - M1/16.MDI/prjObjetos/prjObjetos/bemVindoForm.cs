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
    public partial class bemVindoForm : Form
    {
        public bemVindoForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exibeButton_Click(object sender, EventArgs e)
        {
            //Exibe o nome digitado na caixa de texto
            MessageBox.Show("O meu nome é " + nomeTextBox.Text,
                "Nome do usuário", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

            //TODO:Melhorar a rotina de exibição

        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();   //Não utilizar este comando
            this.Close();

            //TODO: Programar o fechamento do banco de dados

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {
            label1.Text = nomeTextBox.Text;

            
            #region ... Configurando Botões ...
            exibeButton.Text = nomeTextBox.Text.ToUpper();
            sairButton.Text = nomeTextBox.Text.Trim();
            
            #endregion
 

        }

        private void nomeTextBox_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void bemVindoForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            //MessageBox.Show(e.CloseReason.ToString());

            //            if (e.CloseReason == CloseReason.UserClosing)
            //          {
            //            
            //      }

            if (MessageBox.Show("Sr. Usuário,\n\nVerifique o arquivo em c:\\novosDocs\\text.doc\nQuer sair?", "Saída", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                //Cancela o fechamento do formulário
                e.Cancel = true;
            }

        }

        private void cargaButton_Click(object sender, EventArgs e)
        {
//            minhaImagemPictureBox.ImageLocation =
//      "C:\\CarlosH\\CarlosHCSharp24072009Oficial\\Diversos\\Imagens\\ultra7.bmp";

//                minhaImagemPictureBox.ImageLocation =
//    @"C:\CarlosH\CarlosHCSharp24072009Oficial\Diversos\Imagens\ultra7.bmp";


            openFileDialog1.Filter = 
                "Arquivos do tipo Bitmap (*.bmp)|*.bmp|Imagens jpeg ou gif|*.jpg;*.gif|Todos os arquivos (*.*)|*.*";


            openFileDialog1.ShowDialog();

            minhaImagemPictureBox.ImageLocation = openFileDialog1.FileName;
//            MessageBox.Show(openFileDialog1.FileName.ToString());
        }

        private void bemVindoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
