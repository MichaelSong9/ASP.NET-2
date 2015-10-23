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
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        bool JaChamouLoops = false;

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void videosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bemVindoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bemVindoToolStripMenuItem.Enabled = false;

            bemVindoForm f = new bemVindoForm();

            f.MdiParent = this;
            f.Show();
            //f.ShowDialog();     //Modal
        }

        private void loopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!JaChamouLoops)
            {
                loopsForm f = new loopsForm();

                //f.TopMost = true; //Sempre visível
                f.MdiParent = this;
                f.Show();

                JaChamouLoops = true;
            }
            
        }

        private void exceptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filhoUnicoForm f = new filhoUnicoForm();

            f.MdiParent = this;
            f.Show();
        }

        private void emCascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bemVindoToolStripMenuItem.PerformClick();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            loopsToolStripMenuItem.PerformClick();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            sairToolStripMenuItem.PerformClick();
        }

    }
}
