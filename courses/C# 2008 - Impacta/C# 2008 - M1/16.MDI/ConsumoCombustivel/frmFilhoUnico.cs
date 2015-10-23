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
    public partial class frmFilhoUnico : Form
    {
        public frmFilhoUnico()
        {
            InitializeComponent();
        }

        private void frmFilhoUnico_Load(object sender, EventArgs e)
        {

        }

        private void frmFilhoUnico_Activated(object sender, EventArgs e)
        {

        }

        private void frmFilhoUnico_Shown(object sender, EventArgs e)
        {
            //objeto já foi desenhado na tela, diferente do activated

            byte b = 0;

            //rotina para pesquisar se acha o proprio form no MDI. Se existir, não é duplicado.
            foreach (Form formulario in this.MdiParent.MdiChildren)
            {
                if (formulario.Name == this.Name)
                {
                    b++;
                    if (b > 1)
                    {
                        //MessageBox.Show("Não é permitido carregar esse form novamente");
                        this.Close();
                    }
                }
            }
        }
    }
}
