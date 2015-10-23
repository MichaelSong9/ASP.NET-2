using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponenteDinamico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //EVENTO do botão gerado dinamicamente
            btn.Click += new EventHandler(btn_Click);
            //digitar: btn.Click += {TAB} {TAB}
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem do botão que não existe! (fodão...)");
            //throw new NotImplementedException();
        }

        //-------------------------
        Button btn = new Button();
        //-------------------------

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCriarBotaoDinamico_Click(object sender, EventArgs e)
        {
            this.Controls.Add(btn);
            btn.Text = "Botão criado dinamicamente";
            //btn.Location = new Point(20, 51);
            btn.Left = btnCriarBotaoDinamico.Left;
            btn.Top = btnCriarBotaoDinamico.Top + 40;
            btn.Size = new Size(150, 24);
        }

    }
}
