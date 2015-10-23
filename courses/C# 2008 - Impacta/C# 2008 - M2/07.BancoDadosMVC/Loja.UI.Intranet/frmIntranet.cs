using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loja.UI.Intranet
{
    public partial class frmIntranet : Form
    {
        public frmIntranet()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos p = new Produtos();
            p.MdiParent = this;
            p.Show();
        }
    }
}
