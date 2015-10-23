using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsumoCombustivel
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void bemVindoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemConsumo_Click(object sender, EventArgs e)
        {
            frmConsumoCombustivel f = new frmConsumoCombustivel();
            f.MdiParent = this;
            //habilitar IsMDIContainer no form que será o menu
            f.Show();
            //não permite digitar ou selecionar o form anterior
            //f.ShowDialog();
        }

        private void filhoUnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilhoUnico unico = new frmFilhoUnico();
            unico.MdiParent = this;
            unico.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
