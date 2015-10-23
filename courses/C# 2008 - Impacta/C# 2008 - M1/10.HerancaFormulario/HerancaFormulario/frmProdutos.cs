using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HerancaFormulario
{
    public partial class frmProdutos : HerancaFormulario.BaseForm
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnRecebe_Click(object sender, EventArgs e)
        {
            this.Rotulo = txtRotulo.Text;
            this.BotaoSair = txtRotulo.Text;
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
