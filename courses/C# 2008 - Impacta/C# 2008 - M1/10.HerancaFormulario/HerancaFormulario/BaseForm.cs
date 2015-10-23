using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HerancaFormulario
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        //criar uma propriedade para que os Inherit Forms possam alterar o objeto
        //obs: ela ficará nas Propriedades do Form que herda.

        //digitar prop + tab 2 vezes
        public string Rotulo
        {
            get { return lblRotulo.Text; }
            set { lblRotulo.Text = value; }
        }

        public string BotaoSair
        {
            get { return btnSair.Text; }
            set { btnSair.Text = value; }
        }

        public Color CorFundoForm
        {
            get { return this.BackColor;}
            set { this.BackColor = value;}
        }

        public Color CorFundoLabel
        {
            get { return this.lblRotulo.BackColor; }
            set { this.lblRotulo.BackColor = value; }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
