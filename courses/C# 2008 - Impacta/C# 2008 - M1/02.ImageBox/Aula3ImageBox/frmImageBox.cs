using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula3ImageBox
{
    public partial class frmImageBox : Form
    {
        public frmImageBox()
        {
            InitializeComponent();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            //picBox.ImageLocation = "C:\\[ CSharp-30-08-09 ]\\Thiago\\Instrutor\\CSharp30082009\\Diversos\\Imagens\\simpsons.jpg";
            //picBox.ImageLocation = @"C:\[ CSharp-30-08-09 ]\Thiago\Instrutor\CSharp30082009\Diversos\Imagens\simpsons.jpg";

            openFileDialog1.Filter = "Arquivos bmp| *.bmp |Arquivos jpg| *.jpg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picBox.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
